﻿using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotesEncryptor
{
    public partial class Form1 : Form
    {
        private readonly string FileFullNameArg = "-f=";
        private SearchNavigator _searchNavigator;

        public Form1(string[] args)
        {
            InitializeComponent();

            this.bt_encrypt.Enabled = false;
            this.bt_decrypt.Enabled = false;

            this._searchNavigator = new SearchNavigator();

            this.ProcessCommandArgs(args);
        }

        private void ProcessCommandArgs(string[] args)
        {
            if (args?.Length == 0)
                return;

            if (args[0].StartsWith(this.FileFullNameArg))
            {
                var fileFullName = args[0]
                    .Replace(this.FileFullNameArg, string.Empty)
                    .Replace("\"", string.Empty);

                LoadFile(fileFullName);
            }
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            ExecuteActionWithCheck(() =>
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        this.tb_filePath.Text = openFileDialog.FileName;

                        this.rtb_content.Text = File.ReadAllText(this.tb_filePath.Text, Encoding.Default);
                    }
                }
            });
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            ExecuteActionWithCheck(() =>
            {
                if (string.IsNullOrWhiteSpace(this.tb_filePath.Text))
                    return;

                File.WriteAllText(this.tb_filePath.Text, this.rtb_content.Text);
            });
        }

        private void bt_encrypt_Click(object sender, EventArgs e)
        {
            ExecuteActionWithCheck(() =>
            {
                var ecrypted = AES.EncryptStringToBytes_Aes(this.rtb_content.Text, this.tb_password.Text);

                this.rtb_content.Text = Convert.ToBase64String(ecrypted);
            });
        }

        private void bt_decrypt_Click(object sender, EventArgs e)
        {
            ExecuteActionWithCheck(() =>
            {
                var ecrypted = Convert.FromBase64String(this.rtb_content.Text);
                var text = AES.DecryptStringFromBytes_Aes(ecrypted, this.tb_password.Text);

                this.rtb_content.Text = text;
            });
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            var word = this.tb_search.Text;
            if (string.IsNullOrWhiteSpace(word))
                return;

            _searchNavigator.Clear();

            int startindex = 0;
            while (startindex < rtb_content.TextLength)
            {
                int wordstartIndex = rtb_content.Find(word, startindex, RichTextBoxFinds.None);
                if (wordstartIndex != -1)
                {
                    rtb_content.SelectionStart = wordstartIndex;
                    rtb_content.SelectionLength = word.Length;
                    rtb_content.SelectionBackColor = Color.Yellow;

                    _searchNavigator.AddIndex(wordstartIndex);
                }
                else
                {
                    break;
                }

                startindex += wordstartIndex + word.Length;
            }

            rtb_content.SelectionStart = 0;
            rtb_content.SelectionLength = rtb_content.TextLength;
            rtb_content.SelectionColor = Color.Black;

            lb_searchedWordsCount.Text = _searchNavigator.Count.ToString();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            rtb_content.SelectionStart = 0;
            rtb_content.SelectAll();
            rtb_content.SelectionBackColor = Color.White;

            _searchNavigator.Clear();
            lb_searchedWordsCount.Text = _searchNavigator.Count.ToString();
        }

        private void btn_ScrollNext_Click(object sender, EventArgs e)
        {
            rtb_content.SelectionStart = _searchNavigator.GetNextIndex();
            rtb_content.ScrollToCaret();
        }

        private void btn_ScrollPrev_Click(object sender, EventArgs e)
        {
            rtb_content.SelectionStart = _searchNavigator.GetPrevIndex();
            rtb_content.ScrollToCaret();
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            var isPasswordValid = !string.IsNullOrWhiteSpace(this.tb_password.Text);

            this.bt_encrypt.Enabled = isPasswordValid;
            this.bt_decrypt.Enabled = isPasswordValid;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files != null && files.Any())
            {
                LoadFile(files.First());
            }
        }

        private void LoadFile(string fileFullName)
        {
            if (!File.Exists(fileFullName))
            {
                DisplayErrorMsg("File not exists, or you don't have required permissions.");
                return;
            }

            ExecuteActionWithCheck(() =>
            {
                this.tb_filePath.Text = fileFullName;

                this.rtb_content.Text = File.ReadAllText(this.tb_filePath.Text, Encoding.Default);
            });
        }

        private void ExecuteActionWithCheck(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                DisplayErrorMsg(e.Message);
            }
        }

        private void DisplayErrorMsg(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
