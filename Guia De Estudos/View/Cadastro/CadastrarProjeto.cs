using Guia_De_Estudos.Config;
using Guia_De_Estudos.Model.Enums;
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
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = false;
            this.VerticalScroll.Visible = false;
            this.AutoScroll = true;

            cbPrioridade.DataSource = Global.Listar(typeof(Prioridade));
        }

    }
}
