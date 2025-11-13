using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class DirectorForm : Form
    {
        public Form prevFORM = null;

        public DirectorForm()
        {
            InitializeComponent();
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            HelloLbl.Text = "Добрый день, " + Program.USER.fullName + " !";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            if (prevFORM != null) prevFORM.Show();
        }
    }
}