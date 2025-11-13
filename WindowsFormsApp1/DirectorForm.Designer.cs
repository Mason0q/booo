namespace WindowsFormsApp1
{
    partial class DirectorForm
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
            this.HelloLbl = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloLbl
            // 
            this.HelloLbl.AutoSize = true;
            this.HelloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelloLbl.Location = new System.Drawing.Point(50, 30);
            this.HelloLbl.Name = "HelloLbl";
            this.HelloLbl.Size = new System.Drawing.Size(51, 20);
            this.HelloLbl.TabIndex = 0;
            this.HelloLbl.Text = "label1";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(50, 80);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(292, 39);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Доступные функции директора:\n- Просмотр отчетов\n- Управление персоналом\n- Финансовый анализ";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(200, 150);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(100, 30);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.HelloLbl);
            this.Name = "DirectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма директора";
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLbl;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button ExitBtn;
    }
}