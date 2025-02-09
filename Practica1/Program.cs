using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Practica1 // Asegúrate de que el namespace sea el mismo que el de tu proyecto
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTemporizador()); // 🔹 Cambia "Form1" si tu formulario se llama diferente
        }
    }
}