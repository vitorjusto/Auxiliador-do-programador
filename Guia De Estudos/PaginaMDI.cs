using Guia_De_Estudos.View.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temas;

namespace Guia_De_Estudos
{
    public partial class PaginaMDI : Form
    {

       public Form TelaAtual { get; set; }
        public PaginaMDI()
        {
            InitializeComponent();
        }

        private void PaginaMDI_Load(object sender, EventArgs e)
        {
            Tema.AtribuirTema(this);
            menuStrip1.Visible = false;

        }

        private void sideMenuItem1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(TelaAtual is null))
                TelaAtual.Close();

            TelaAtual = new cadastrar();
            TelaAtual.MdiParent = this;
            TelaAtual.Show();
        }
    }
    }

