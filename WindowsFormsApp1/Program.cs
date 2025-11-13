using System;
using System.Windows.Forms;
using WindowsFormsApp1.ModelEF;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        public static Users USER = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static Entities1 GetNewDbContext()
        {
            return new Entities1();
        }
    }
}