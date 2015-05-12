namespace phodson_aes_math148
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
            this.aesKey = new MetroFramework.Controls.MetroTextBox();
            this.aesMessage = new MetroFramework.Controls.MetroTextBox();
            this.aesResult = new MetroFramework.Controls.MetroTextBox();
            this.aesEncrypt = new MetroFramework.Controls.MetroButton();
            this.aesDecrypt = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // aesKey
            // 
            this.aesKey.Lines = new string[0];
            this.aesKey.Location = new System.Drawing.Point(24, 64);
            this.aesKey.MaxLength = 32;
            this.aesKey.Name = "aesKey";
            this.aesKey.PasswordChar = '\0';
            this.aesKey.PromptText = "AES Key";
            this.aesKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aesKey.SelectedText = "";
            this.aesKey.Size = new System.Drawing.Size(237, 23);
            this.aesKey.TabIndex = 0;
            this.aesKey.UseSelectable = true;
            this.aesKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aesKey_KeyDown);
            // 
            // aesMessage
            // 
            this.aesMessage.IconRight = true;
            this.aesMessage.Lines = new string[0];
            this.aesMessage.Location = new System.Drawing.Point(24, 94);
            this.aesMessage.MaxLength = 32;
            this.aesMessage.Name = "aesMessage";
            this.aesMessage.PasswordChar = '\0';
            this.aesMessage.PromptText = "AES Message";
            this.aesMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aesMessage.SelectedText = "";
            this.aesMessage.Size = new System.Drawing.Size(237, 23);
            this.aesMessage.TabIndex = 1;
            this.aesMessage.UseSelectable = true;
            this.aesMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aesMessage_KeyDown);
            // 
            // aesResult
            // 
            this.aesResult.Lines = new string[0];
            this.aesResult.Location = new System.Drawing.Point(23, 182);
            this.aesResult.MaxLength = 32767;
            this.aesResult.Name = "aesResult";
            this.aesResult.PasswordChar = '\0';
            this.aesResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aesResult.SelectedText = "";
            this.aesResult.Size = new System.Drawing.Size(237, 23);
            this.aesResult.TabIndex = 2;
            this.aesResult.UseSelectable = true;
            this.aesResult.Visible = false;
            // 
            // aesEncrypt
            // 
            this.aesEncrypt.Location = new System.Drawing.Point(24, 123);
            this.aesEncrypt.Name = "aesEncrypt";
            this.aesEncrypt.Size = new System.Drawing.Size(237, 23);
            this.aesEncrypt.TabIndex = 3;
            this.aesEncrypt.Text = "Encrypt";
            this.aesEncrypt.UseSelectable = true;
            this.aesEncrypt.Click += new System.EventHandler(this.aesEncrypt_Click);
            // 
            // aesDecrypt
            // 
            this.aesDecrypt.Location = new System.Drawing.Point(24, 153);
            this.aesDecrypt.Name = "aesDecrypt";
            this.aesDecrypt.Size = new System.Drawing.Size(237, 23);
            this.aesDecrypt.TabIndex = 4;
            this.aesDecrypt.Text = "Decrypt";
            this.aesDecrypt.UseSelectable = true;
            this.aesDecrypt.Click += new System.EventHandler(this.aesDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.aesDecrypt);
            this.Controls.Add(this.aesEncrypt);
            this.Controls.Add(this.aesResult);
            this.Controls.Add(this.aesMessage);
            this.Controls.Add(this.aesKey);
            this.Name = "Form1";
            this.Text = "128-bit AES ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox aesKey;
        private MetroFramework.Controls.MetroTextBox aesMessage;
        private MetroFramework.Controls.MetroTextBox aesResult;
        private MetroFramework.Controls.MetroButton aesEncrypt;
        private MetroFramework.Controls.MetroButton aesDecrypt;
    }
}

