namespace SotnikovAgency
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonInfoObjects = new System.Windows.Forms.Button();
            this.ButtonInfoAgency = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonInfoRielts = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.zeroitLollipopLabel1 = new Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ButtonLogin.FlatAppearance.BorderSize = 3;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(110, 410);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(386, 60);
            this.ButtonLogin.TabIndex = 1;
            this.ButtonLogin.Text = "Вход в систему";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonInfoObjects
            // 
            this.ButtonInfoObjects.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonInfoObjects.FlatAppearance.BorderSize = 2;
            this.ButtonInfoObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInfoObjects.Font = new System.Drawing.Font("Calibri", 12F);
            this.ButtonInfoObjects.Location = new System.Drawing.Point(414, 110);
            this.ButtonInfoObjects.Name = "ButtonInfoObjects";
            this.ButtonInfoObjects.Size = new System.Drawing.Size(179, 49);
            this.ButtonInfoObjects.TabIndex = 4;
            this.ButtonInfoObjects.Text = "Об объектах";
            this.ButtonInfoObjects.UseVisualStyleBackColor = true;
            // 
            // ButtonInfoAgency
            // 
            this.ButtonInfoAgency.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonInfoAgency.FlatAppearance.BorderSize = 2;
            this.ButtonInfoAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInfoAgency.Font = new System.Drawing.Font("Calibri", 12F);
            this.ButtonInfoAgency.Location = new System.Drawing.Point(214, 110);
            this.ButtonInfoAgency.Name = "ButtonInfoAgency";
            this.ButtonInfoAgency.Size = new System.Drawing.Size(179, 49);
            this.ButtonInfoAgency.TabIndex = 3;
            this.ButtonInfoAgency.Text = "Об агенстве";
            this.ButtonInfoAgency.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.Silver;
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonCancel.FlatAppearance.BorderSize = 2;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(237, 476);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(133, 49);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Выход";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonInfoRielts
            // 
            this.ButtonInfoRielts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonInfoRielts.FlatAppearance.BorderSize = 2;
            this.ButtonInfoRielts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInfoRielts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInfoRielts.Location = new System.Drawing.Point(12, 110);
            this.ButtonInfoRielts.Name = "ButtonInfoRielts";
            this.ButtonInfoRielts.Size = new System.Drawing.Size(179, 49);
            this.ButtonInfoRielts.TabIndex = 2;
            this.ButtonInfoRielts.Text = "Об агентах-риелтерах";
            this.ButtonInfoRielts.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.zeroitLollipopLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 30);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(574, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zeroitLollipopLabel1
            // 
            this.zeroitLollipopLabel1.AllowTransparency = true;
            this.zeroitLollipopLabel1.AutoSize = true;
            this.zeroitLollipopLabel1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.zeroitLollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.zeroitLollipopLabel1.Location = new System.Drawing.Point(3, 4);
            this.zeroitLollipopLabel1.Name = "zeroitLollipopLabel1";
            this.zeroitLollipopLabel1.Size = new System.Drawing.Size(191, 19);
            this.zeroitLollipopLabel1.TabIndex = 1;
            this.zeroitLollipopLabel1.Text = "Жилой комплекс Мореалти";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SotnikovAgency.Properties.Resources.morealty_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(606, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonInfoRielts);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonInfoAgency);
            this.Controls.Add(this.ButtonInfoObjects);
            this.Controls.Add(this.ButtonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Жилой комплекс Мореалти";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonInfoObjects;
        private System.Windows.Forms.Button ButtonInfoAgency;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonInfoRielts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Zeroit.Framework.LollipopControls.Controls.ZeroitLollipopLabel zeroitLollipopLabel1;
    }
}

