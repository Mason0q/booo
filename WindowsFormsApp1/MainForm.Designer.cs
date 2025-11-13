namespace WindowsFormsApp1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.pswLabel = new System.Windows.Forms.Label();
            this.PswTxt = new System.Windows.Forms.TextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(80, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(270, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Информационная система";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(50, 80);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Логин:";
            // 
            // LoginTxt
            // 
            this.LoginTxt.Location = new System.Drawing.Point(150, 77);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(150, 20);
            this.LoginTxt.TabIndex = 2;
            // 
            // pswLabel
            // 
            this.pswLabel.AutoSize = true;
            this.pswLabel.Location = new System.Drawing.Point(50, 120);
            this.pswLabel.Name = "pswLabel";
            this.pswLabel.Size = new System.Drawing.Size(48, 13);
            this.pswLabel.TabIndex = 3;
            this.pswLabel.Text = "Пароль:";
            // 
            // PswTxt
            // 
            this.PswTxt.Location = new System.Drawing.Point(150, 117);
            this.PswTxt.Name = "PswTxt";
            this.PswTxt.PasswordChar = '*';
            this.PswTxt.Size = new System.Drawing.Size(150, 20);
            this.PswTxt.TabIndex = 4;
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(100, 170);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(80, 30);
            this.EnterBtn.TabIndex = 5;
            this.EnterBtn.Text = "Войти";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(200, 170);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(120, 30);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Закончить работу";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.PswTxt);
            this.Controls.Add(this.pswLabel);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в информационную систему";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.Label pswLabel;
        private System.Windows.Forms.TextBox PswTxt;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}