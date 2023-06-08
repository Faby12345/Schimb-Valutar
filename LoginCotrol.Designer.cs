namespace mainApp
{
    partial class LoginCotrol
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
            this.WelcomeText = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.calendarLogin = new System.Windows.Forms.DateTimePicker();
            this.btnLogin = new System.Windows.Forms.Button();
            this.passwordEye = new System.Windows.Forms.PictureBox();
            this.loginError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.WelcomeText.Location = new System.Drawing.Point(212, 97);
            this.WelcomeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(212, 39);
            this.WelcomeText.TabIndex = 0;
            this.WelcomeText.Text = "Bine ati venit!";
            this.WelcomeText.Click += new System.EventHandler(this.WelcomeText_Click);
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.usernameText.Location = new System.Drawing.Point(292, 228);
            this.usernameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(83, 27);
            this.usernameText.TabIndex = 1;
            this.usernameText.Text = "Utilizator";
            this.usernameText.Click += new System.EventHandler(this.usernameText_Click);
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.passwordText.Location = new System.Drawing.Point(302, 302);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(60, 27);
            this.passwordText.TabIndex = 2;
            this.passwordText.Text = "Parola";
            // 
            // passwordInput
            // 
            this.passwordInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordInput.Location = new System.Drawing.Point(212, 332);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(250, 22);
            this.passwordInput.TabIndex = 3;
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameInput.Location = new System.Drawing.Point(212, 258);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(250, 22);
            this.usernameInput.TabIndex = 4;
            // 
            // calendarLogin
            // 
            this.calendarLogin.CustomFormat = "dd MM yyyy";
            this.calendarLogin.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calendarLogin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calendarLogin.Location = new System.Drawing.Point(272, 398);
            this.calendarLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calendarLogin.Name = "calendarLogin";
            this.calendarLogin.Size = new System.Drawing.Size(125, 25);
            this.calendarLogin.TabIndex = 5;
            this.calendarLogin.Value = new System.DateTime(2022, 11, 23, 17, 32, 29, 0);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.btnLogin.Location = new System.Drawing.Point(271, 438);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 51);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // passwordEye
            // 
            this.passwordEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordEye.ErrorImage = null;
            this.passwordEye.Image = global::mainApp.Properties.Resources.passwordEye_ErrorImage;
            this.passwordEye.InitialImage = null;
            this.passwordEye.Location = new System.Drawing.Point(438, 333);
            this.passwordEye.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordEye.Name = "passwordEye";
            this.passwordEye.Size = new System.Drawing.Size(23, 20);
            this.passwordEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.passwordEye.TabIndex = 9;
            this.passwordEye.TabStop = false;
            this.passwordEye.Click += new System.EventHandler(this.passwordEye_Click);
            // 
            // loginError
            // 
            this.loginError.AutoSize = true;
            this.loginError.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(49)))), ((int)(((byte)(36)))));
            this.loginError.Location = new System.Drawing.Point(240, 357);
            this.loginError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginError.Name = "loginError";
            this.loginError.Size = new System.Drawing.Size(184, 22);
            this.loginError.TabIndex = 10;
            this.loginError.Text = "Utilizator / Parola gresita!";
            this.loginError.Visible = false;
            // 
            // LoginCotrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.loginError);
            this.Controls.Add(this.passwordEye);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.calendarLogin);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.WelcomeText);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginCotrol";
            this.Size = new System.Drawing.Size(700, 550);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.DateTimePicker calendarLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox passwordEye;
        private System.Windows.Forms.Label loginError;
    }
}
