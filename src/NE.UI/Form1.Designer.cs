namespace NotesEncryptor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtb_content = new System.Windows.Forms.RichTextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_open = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_encrypt = new System.Windows.Forms.Button();
            this.bt_decrypt = new System.Windows.Forms.Button();
            this.tb_filePath = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.btn_ScrollNext = new System.Windows.Forms.Button();
            this.btn_ScrollPrev = new System.Windows.Forms.Button();
            this.lb_searchedWordsCount = new System.Windows.Forms.Label();
            this.lb_searchedWords = new System.Windows.Forms.Label();
            this.cb_encoding = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rtb_content
            // 
            this.rtb_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_content.Location = new System.Drawing.Point(17, 116);
            this.rtb_content.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_content.Name = "rtb_content";
            this.rtb_content.Size = new System.Drawing.Size(949, 422);
            this.rtb_content.TabIndex = 0;
            this.rtb_content.Text = "";
            // 
            // bt_save
            // 
            this.bt_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_save.Location = new System.Drawing.Point(1036, 475);
            this.bt_save.Margin = new System.Windows.Forms.Padding(4);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(153, 64);
            this.bt_save.TabIndex = 1;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(17, 12);
            this.bt_open.Margin = new System.Windows.Forms.Padding(4);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(113, 28);
            this.bt_open.TabIndex = 2;
            this.bt_open.Text = "Open";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.Location = new System.Drawing.Point(139, 59);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_password.MaxLength = 15;
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(707, 41);
            this.tb_password.TabIndex = 3;
            this.tb_password.WordWrap = false;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
            // 
            // bt_encrypt
            // 
            this.bt_encrypt.Location = new System.Drawing.Point(855, 47);
            this.bt_encrypt.Margin = new System.Windows.Forms.Padding(4);
            this.bt_encrypt.Name = "bt_encrypt";
            this.bt_encrypt.Size = new System.Drawing.Size(113, 28);
            this.bt_encrypt.TabIndex = 5;
            this.bt_encrypt.Text = "Encrypt";
            this.bt_encrypt.UseVisualStyleBackColor = true;
            this.bt_encrypt.Click += new System.EventHandler(this.bt_encrypt_Click);
            // 
            // bt_decrypt
            // 
            this.bt_decrypt.Location = new System.Drawing.Point(855, 82);
            this.bt_decrypt.Margin = new System.Windows.Forms.Padding(4);
            this.bt_decrypt.Name = "bt_decrypt";
            this.bt_decrypt.Size = new System.Drawing.Size(113, 28);
            this.bt_decrypt.TabIndex = 6;
            this.bt_decrypt.Text = "Decrypt";
            this.bt_decrypt.UseVisualStyleBackColor = true;
            this.bt_decrypt.Click += new System.EventHandler(this.bt_decrypt_Click);
            // 
            // tb_filePath
            // 
            this.tb_filePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_filePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_filePath.Location = new System.Drawing.Point(139, 15);
            this.tb_filePath.Margin = new System.Windows.Forms.Padding(4);
            this.tb_filePath.Name = "tb_filePath";
            this.tb_filePath.ReadOnly = true;
            this.tb_filePath.Size = new System.Drawing.Size(1049, 23);
            this.tb_filePath.TabIndex = 7;
            this.tb_filePath.WordWrap = false;
            // 
            // bt_search
            // 
            this.bt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_search.Location = new System.Drawing.Point(1088, 167);
            this.bt_search.Margin = new System.Windows.Forms.Padding(4);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(113, 28);
            this.bt_search.TabIndex = 8;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Location = new System.Drawing.Point(976, 116);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_search.MaxLength = 10;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(224, 22);
            this.tb_search.TabIndex = 9;
            this.tb_search.WordWrap = false;
            // 
            // bt_clear
            // 
            this.bt_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_clear.Location = new System.Drawing.Point(1088, 203);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(4);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(113, 28);
            this.bt_clear.TabIndex = 10;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // btn_ScrollNext
            // 
            this.btn_ScrollNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ScrollNext.Location = new System.Drawing.Point(1023, 167);
            this.btn_ScrollNext.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ScrollNext.Name = "btn_ScrollNext";
            this.btn_ScrollNext.Size = new System.Drawing.Size(35, 28);
            this.btn_ScrollNext.TabIndex = 11;
            this.btn_ScrollNext.Text = ">";
            this.btn_ScrollNext.UseVisualStyleBackColor = true;
            this.btn_ScrollNext.Click += new System.EventHandler(this.btn_ScrollNext_Click);
            // 
            // btn_ScrollPrev
            // 
            this.btn_ScrollPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ScrollPrev.Location = new System.Drawing.Point(980, 167);
            this.btn_ScrollPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ScrollPrev.Name = "btn_ScrollPrev";
            this.btn_ScrollPrev.Size = new System.Drawing.Size(35, 28);
            this.btn_ScrollPrev.TabIndex = 12;
            this.btn_ScrollPrev.Text = "<";
            this.btn_ScrollPrev.UseVisualStyleBackColor = true;
            this.btn_ScrollPrev.Click += new System.EventHandler(this.btn_ScrollPrev_Click);
            // 
            // lb_searchedWordsCount
            // 
            this.lb_searchedWordsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_searchedWordsCount.AutoSize = true;
            this.lb_searchedWordsCount.Location = new System.Drawing.Point(1152, 144);
            this.lb_searchedWordsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_searchedWordsCount.Name = "lb_searchedWordsCount";
            this.lb_searchedWordsCount.Size = new System.Drawing.Size(16, 17);
            this.lb_searchedWordsCount.TabIndex = 13;
            this.lb_searchedWordsCount.Text = "0";
            // 
            // lb_searchedWords
            // 
            this.lb_searchedWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_searchedWords.AutoSize = true;
            this.lb_searchedWords.Location = new System.Drawing.Point(976, 144);
            this.lb_searchedWords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_searchedWords.Name = "lb_searchedWords";
            this.lb_searchedWords.Size = new System.Drawing.Size(153, 17);
            this.lb_searchedWords.TabIndex = 14;
            this.lb_searchedWords.Text = "Searched words count:";
            // 
            // cb_encoding
            // 
            this.cb_encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_encoding.FormattingEnabled = true;
            this.cb_encoding.Location = new System.Drawing.Point(975, 47);
            this.cb_encoding.Name = "cb_encoding";
            this.cb_encoding.Size = new System.Drawing.Size(213, 24);
            this.cb_encoding.TabIndex = 15;
            this.cb_encoding.SelectedValueChanged += new System.EventHandler(this.cb_encoding_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 554);
            this.Controls.Add(this.cb_encoding);
            this.Controls.Add(this.lb_searchedWords);
            this.Controls.Add(this.lb_searchedWordsCount);
            this.Controls.Add(this.btn_ScrollPrev);
            this.Controls.Add(this.btn_ScrollNext);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_filePath);
            this.Controls.Add(this.bt_decrypt);
            this.Controls.Add(this.bt_encrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.rtb_content);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Notes Encryptor";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_content;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_encrypt;
        private System.Windows.Forms.Button bt_decrypt;
        private System.Windows.Forms.TextBox tb_filePath;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button btn_ScrollNext;
        private System.Windows.Forms.Button btn_ScrollPrev;
        private System.Windows.Forms.Label lb_searchedWordsCount;
        private System.Windows.Forms.Label lb_searchedWords;
        private System.Windows.Forms.ComboBox cb_encoding;
    }
}

