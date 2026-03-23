using System;
using System.Windows.Forms;

namespace apollo
{
    static class Program
    {
        [STAThread] // 🔴 ESTO ES CLAVE
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string archivo = args.Length > 0 ? args[0] : null;

            Application.Run(new Form1(archivo));
        }
    }
}