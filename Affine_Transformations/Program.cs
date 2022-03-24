using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Affine_Transformations
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка");
            }
        }
    }
}
