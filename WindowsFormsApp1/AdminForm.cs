using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class AdminForm : Form
    {
        public Form prevFORM = null;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            HelloLbl.Text = "Добрый день, " + Program.USER.fullName + " !";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            if (prevFORM != null) prevFORM.Show();
        }

        private void usersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обработка клика по таблице пользователей
            MessageBox.Show("Редактирование пользователя");
        }
    }
}