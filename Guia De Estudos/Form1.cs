using System;
using System.Windows.Forms;
using Temas;

namespace Guia_De_Estudos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tema.AtribuirTema(this);
        }
    }
}
