namespace WindowsFormsApp1
{
    partial class ManagerForm
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
            this.clientsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelloLbl
            // 
            this.HelloLbl.AutoSize = true;
            this.HelloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelloLbl.Location = new System.Drawing.Point(30, 20);
            this.HelloLbl.Name = "HelloLbl";
            this.HelloLbl.Size = new System.Drawing.Size(51, 20);
            this.HelloLbl.TabIndex = 0;
            this.HelloLbl.Text = "label1";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(30, 60);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(174, 52);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Доступные функции менеджера:\n- Работа с клиентами\n- Формирование заказов\n- Отслеж" +
    "ивание продаж";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(250, 250);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(100, 30);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // clientsList
            // 
            this.clientsList.FormattingEnabled = true;
            this.clientsList.Items.AddRange(new object[] {
            "Иванов А.С. - ООО \"Ромашка\"",
            "Петрова М.И. - ИП \"Весна\"",
            "Сидоров В.П. - ЗАО \"Техно\"",
            "Козлова Е.Д. - ООО \"Стройсервис\""});
            this.clientsList.Location = new System.Drawing.Point(34, 130);
            this.clientsList.Name = "clientsList";
            this.clientsList.Size = new System.Drawing.Size(200, 95);
            this.clientsList.TabIndex = 3;
            this.clientsList.SelectedIndexChanged += new System.EventHandler(this.clientsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список клиентов";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientsList);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.HelloLbl);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма менеджера";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLbl;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ListBox clientsList;
        private System.Windows.Forms.Label label1;
    }
}