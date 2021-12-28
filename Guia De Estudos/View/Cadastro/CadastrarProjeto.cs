using System;
using System.Windows.Forms;
using Temas;

namespace Guia_De_Estudos.View.Cadastro
{
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();
        }

        private void cadastrar_Load(object sender, EventArgs e)
        {
            Tema.AtribuirTema(this);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
