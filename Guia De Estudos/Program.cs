using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temas;

namespace Guia_De_Estudos
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Tema.AlterarTema("Dark");
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PaginaMDI());
        }
    }
}
