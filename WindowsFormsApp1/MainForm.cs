using System;
using System.Windows.Forms;
using System.Linq;
using WindowsFormsApp1.ModelEF;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public Form prevFORM = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTxt.Text) || string.IsNullOrEmpty(PswTxt.Text))
            {
                MessageBox.Show("Нужно задать логин и пароль!");
                return;
            }

            using (var db = Program.GetNewDbContext())
            {
                try
                {
                    Users usr = db.Users.FirstOrDefault(u => u.login == LoginTxt.Text);

                    if (usr != null && usr.password == PswTxt.Text)
                    {
                        Program.USER = usr;

                        if (usr.roleId == 1)
                        {
                            DirectorForm frm = new DirectorForm();
                            frm.prevFORM = this;
                            frm.Show();
                            this.Hide();
                        }
                        else if (usr.roleId == 2)
                        {
                            ManagerForm frm = new ManagerForm();
                            frm.prevFORM = this;
                            frm.Show();
                            this.Hide();
                        }
                        else if (usr.roleId == 3)
                        {
                            AdminForm frm = new AdminForm();
                            frm.prevFORM = this;
                            frm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователя с таким логином и паролем нет!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка доступа к БД: {ex.Message}");
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}