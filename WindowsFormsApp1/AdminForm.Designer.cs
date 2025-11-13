namespace WindowsFormsApp1
{
    partial class AdminForm
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
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backupBtn = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
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
            this.infoLabel.Size = new System.Drawing.Size(294, 26);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Доступные функции администратора:\n- Управление пользователями\n- Резервное копирование БД";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(250, 300);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(100, 30);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // usersGrid
            // 
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.FIO,
            this.Role});
            this.usersGrid.Location = new System.Drawing.Point(34, 130);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.ReadOnly = true;
            this.usersGrid.Size = new System.Drawing.Size(343, 150);
            this.usersGrid.TabIndex = 3;
            this.usersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Управление пользователями";
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(34, 300);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(150, 30);
            this.backupBtn.TabIndex = 5;
            this.backupBtn.Text = "Создать резервную копию";
            this.backupBtn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.Login.HeaderText = "Логин";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Width = 150;
            // 
            // Role
            // 
            this.Role.HeaderText = "Роль";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 361);
            this.Controls.Add(this.backupBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersGrid);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.HelloLbl);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма администратора";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLbl;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataGridView usersGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}