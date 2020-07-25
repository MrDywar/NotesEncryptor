using NE.Core;
using NE.Core.Encryption;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotesEncryptor
{
    public partial class Form1 : Form
    {
        private readonly IEncryptor _encryptor;
        private readonly IFileOperator _fileOperator;

        private readonly string FileFullNameArg = "-f=";
        private SearchNavigator _searchNavigator;
        private Encoding _currentEncoding = Encoding.Default;

        public Form1(IEncryptor encryptor, IFileOperator fileOperator)
        {
            InitializeComponent();

            this._encryptor = encryptor;
            this._fileOperator = fileOperator;

            this.cb_encoding.DataSource = new List<Encoding>()
            {
                Encoding.Default,
                Encoding.UTF8,
                Encoding.ASCII,
                Encoding.Unicode,
                Encoding.BigEndianUnicode
            };
            this.cb_encoding.DisplayMember = nameof(Encoding.EncodingName);

            this.bt_encrypt.Enabled = false;
            this.bt_decrypt.Enabled = false;

            this._searchNavigator = new SearchNavigator();

            this.ProcessCommandArgs(Environment.GetCommandLineArgs());
        }

        private void ProcessCommandArgs(string[] args)
        {
            var fileToOpenArg = args.FirstOrDefault(x => x.StartsWith(this.FileFullNameArg));
            if (!string.IsNullOrWhiteSpace(fileToOpenArg))
            {
                var fileFullName = fileToOpenArg
                    .Replace(this.FileFullNameArg, string.Empty)
                    .Replace("\"", string.Empty);

                LoadFile(fileFullName);
            }
        }

        private void cb_encoding_SelectedValueChanged(object sender, EventArgs e)
        {
            var cmb = (ComboBox)sender;
            this._currentEncoding = (Encoding)cmb.SelectedItem;
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

                        this.rtb_content.Text = this._fileOperator.Read(this.tb_filePath.Text, this._currentEncoding);
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

                this._fileOperator.Write(this.tb_filePath.Text, this.rtb_content.Text, this._currentEncoding);
            });
        }

        private void bt_encrypt_Click(object sender, EventArgs e)
        {
            ExecuteActionWithCheck(() =>
            {
                var ecrypted = this._encryptor.Encrypt(this.rtb_content.Text, this.tb_password.Text);

                this.rtb_content.Text = Convert.ToBase64String(ecrypted);
            });
        }

        private void bt_decrypt_Click(object sender, EventArgs e)
        {
            ExecuteActionWithCheck(() =>
            {
                var ecrypted = Convert.FromBase64String(this.rtb_content.Text);
                var text = this._encryptor.Decrypt(ecrypted, this.tb_password.Text);

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

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            this.tb_password.UseSystemPasswordChar = !((sender as CheckBox).Checked);
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
            if (!this._fileOperator.Exists(fileFullName))
            {
                DisplayErrorMsg("File not exists, or you don't have required permissions.");
                return;
            }

            ExecuteActionWithCheck(() =>
            {
                this.tb_filePath.Text = fileFullName;

                this.rtb_content.Text = this._fileOperator.Read(this.tb_filePath.Text, this._currentEncoding);
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
