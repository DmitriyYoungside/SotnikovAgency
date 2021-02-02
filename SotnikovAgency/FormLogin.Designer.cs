namespace SotnikovAgency
{
    partial class FormLogin
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPasswd = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.buttonBackToMain = new Zeroit.Framework.Metro.ZeroitMetroNavigationButton();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLogin.Location = new System.Drawing.Point(176, 20);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(165, 30);
            this.textBoxLogin.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.White;
            this.labelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.Gray;
            this.labelLogin.Location = new System.Drawing.Point(72, 21);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(61, 25);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Логин";
            // 
            // labelPasswd
            // 
            this.labelPasswd.AutoSize = true;
            this.labelPasswd.BackColor = System.Drawing.Color.White;
            this.labelPasswd.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.labelPasswd.ForeColor = System.Drawing.Color.Gray;
            this.labelPasswd.Location = new System.Drawing.Point(68, 65);
            this.labelPasswd.Name = "labelPasswd";
            this.labelPasswd.Size = new System.Drawing.Size(70, 23);
            this.labelPasswd.TabIndex = 4;
            this.labelPasswd.Text = "Пароль";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonLogIn.FlatAppearance.BorderSize = 3;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonLogIn.ForeColor = System.Drawing.Color.White;
            this.buttonLogIn.Location = new System.Drawing.Point(82, 279);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(247, 60);
            this.buttonLogIn.TabIndex = 3;
            this.buttonLogIn.Text = "Вход";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasswd.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPasswd.Location = new System.Drawing.Point(176, 65);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.PasswordChar = '*';
            this.textBoxPasswd.Size = new System.Drawing.Size(165, 31);
            this.textBoxPasswd.TabIndex = 5;
            this.textBoxPasswd.UseSystemPasswordChar = true;
            // 
            // buttonBackToMain
            // 
            this.buttonBackToMain.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buttonBackToMain.ArrowHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonBackToMain.ArrowPressedColor = System.Drawing.Color.White;
            this.buttonBackToMain.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackToMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBackToMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.buttonBackToMain.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonBackToMain.BorderPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonBackToMain.DefaultColor = System.Drawing.Color.White;
            this.buttonBackToMain.DisabledArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonBackToMain.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonBackToMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBackToMain.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonBackToMain.Location = new System.Drawing.Point(2, 357);
            this.buttonBackToMain.Name = "buttonBackToMain";
            this.buttonBackToMain.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonBackToMain.Size = new System.Drawing.Size(49, 50);
            this.buttonBackToMain.TabIndex = 6;
            this.buttonBackToMain.Text = "zeroitMetroNavigationButton1";
            this.buttonBackToMain.Click += new System.EventHandler(this.buttonBackToMain_Click_1);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SotnikovAgency.Properties.Resources.morealty_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(410, 408);
            this.Controls.Add(this.buttonBackToMain);
            this.Controls.Add(this.textBoxPasswd);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.labelPasswd);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPasswd;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textBoxPasswd;
        private Zeroit.Framework.Metro.ZeroitMetroNavigationButton buttonBackToMain;
    }
}