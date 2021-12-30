
namespace Guia_De_Estudos.View.Cadastro
{
    partial class cadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataDeEntrega = new System.Windows.Forms.DateTimePicker();
            this.GroupPanelDificuldade = new System.Windows.Forms.Panel();
            this.rbFacil = new System.Windows.Forms.RadioButton();
            this.rbDificil = new System.Windows.Forms.RadioButton();
            this.rbMedio = new System.Windows.Forms.RadioButton();
            this.txtNomeProjeto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.GroupPanelDificuldade.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Projeto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dados Gerais";
            // 
            // MenuPanel
            // 
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(905, 107);
            this.MenuPanel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome Do Projeto: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(511, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nivel De Dificuldade";
            // 
            // dtpDataDeEntrega
            // 
            this.dtpDataDeEntrega.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataDeEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeEntrega.Location = new System.Drawing.Point(64, 369);
            this.dtpDataDeEntrega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDataDeEntrega.Name = "dtpDataDeEntrega";
            this.dtpDataDeEntrega.Size = new System.Drawing.Size(243, 27);
            this.dtpDataDeEntrega.TabIndex = 20;
            // 
            // GroupPanelDificuldade
            // 
            this.GroupPanelDificuldade.Controls.Add(this.rbFacil);
            this.GroupPanelDificuldade.Controls.Add(this.rbDificil);
            this.GroupPanelDificuldade.Controls.Add(this.rbMedio);
            this.GroupPanelDificuldade.Location = new System.Drawing.Point(511, 243);
            this.GroupPanelDificuldade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupPanelDificuldade.Name = "GroupPanelDificuldade";
            this.GroupPanelDificuldade.Size = new System.Drawing.Size(213, 153);
            this.GroupPanelDificuldade.TabIndex = 22;
            // 
            // rbFacil
            // 
            this.rbFacil.AutoSize = true;
            this.rbFacil.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbFacil.Location = new System.Drawing.Point(17, 17);
            this.rbFacil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFacil.Name = "rbFacil";
            this.rbFacil.Size = new System.Drawing.Size(70, 29);
            this.rbFacil.TabIndex = 2;
            this.rbFacil.TabStop = true;
            this.rbFacil.Text = "Fácil";
            this.rbFacil.UseVisualStyleBackColor = true;
            // 
            // rbDificil
            // 
            this.rbDificil.AutoSize = true;
            this.rbDificil.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDificil.Location = new System.Drawing.Point(17, 97);
            this.rbDificil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDificil.Name = "rbDificil";
            this.rbDificil.Size = new System.Drawing.Size(81, 29);
            this.rbDificil.TabIndex = 4;
            this.rbDificil.TabStop = true;
            this.rbDificil.Text = "Difícil";
            this.rbDificil.UseVisualStyleBackColor = true;
            // 
            // rbMedio
            // 
            this.rbMedio.AutoSize = true;
            this.rbMedio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMedio.Location = new System.Drawing.Point(17, 57);
            this.rbMedio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMedio.Name = "rbMedio";
            this.rbMedio.Size = new System.Drawing.Size(87, 29);
            this.rbMedio.TabIndex = 3;
            this.rbMedio.TabStop = true;
            this.rbMedio.Text = "Médio";
            this.rbMedio.UseVisualStyleBackColor = true;
            // 
            // txtNomeProjeto
            // 
            this.txtNomeProjeto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeProjeto.Location = new System.Drawing.Point(64, 243);
            this.txtNomeProjeto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeProjeto.Name = "txtNomeProjeto";
            this.txtNomeProjeto.Size = new System.Drawing.Size(243, 32);
            this.txtNomeProjeto.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(64, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Estimativa de Entrega:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Prioridade";
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Location = new System.Drawing.Point(64, 518);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(243, 28);
            this.cbPrioridade.TabIndex = 24;
            // 
            // cadastrar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(905, 944);
            this.ControlBox = false;
            this.Controls.Add(this.cbPrioridade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeProjeto);
            this.Controls.Add(this.GroupPanelDificuldade);
            this.Controls.Add(this.dtpDataDeEntrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadastrar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastrar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cadastrar_Load);
            this.GroupPanelDificuldade.ResumeLayout(false);
            this.GroupPanelDificuldade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataDeEntrega;
        private System.Windows.Forms.Panel GroupPanelDificuldade;
        private System.Windows.Forms.RadioButton rbFacil;
        private System.Windows.Forms.RadioButton rbDificil;
        private System.Windows.Forms.RadioButton rbMedio;
        private System.Windows.Forms.TextBox txtNomeProjeto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPrioridade;
    }
}