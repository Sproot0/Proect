using System;
using System.Windows.Forms;

namespace Proect
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += (sender, args) =>
            {
                MessageBox.Show($"Произошла ошибка: {args.Exception.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            using (var mainForm = new Form1())
            {
                Application.Run(mainForm);
            }

            Application.Exit();
        }
    }
}
