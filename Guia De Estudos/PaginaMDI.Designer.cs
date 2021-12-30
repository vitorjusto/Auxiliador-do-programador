
namespace Guia_De_Estudos
{
    partial class PaginaMDI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.sideMenuItem1 = new Temas.SideMenuItem();
            this.SidePanelItem = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuPanel.SuspendLayout();
            this.SidePanelItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.sideMenuItem1);
            this.MenuPanel.Controls.Add(this.SidePanelItem);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 24);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(250, 754);
            this.MenuPanel.TabIndex = 4;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // sideMenuItem1
            // 
            this.sideMenuItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sideMenuItem1.Location = new System.Drawing.Point(0, 67);
            this.sideMenuItem1.Name = "sideMenuItem1";
            this.sideMenuItem1.Size = new System.Drawing.Size(250, 65);
            this.sideMenuItem1.TabIndex = 2;
            this.sideMenuItem1.Click += new System.EventHandler(this.sideMenuItem1_Click);
            // 
            // SidePanelItem
            // 
            this.SidePanelItem.Controls.Add(this.label1);
            this.SidePanelItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidePanelItem.Location = new System.Drawing.Point(0, 0);
            this.SidePanelItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SidePanelItem.Name = "SidePanelItem";
            this.SidePanelItem.Size = new System.Drawing.Size(250, 67);
            this.SidePanelItem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1178, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PaginaMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1178, 778);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PaginaMDI";
            this.Text = "PaginaMDI";
            this.Load += new System.EventHandler(this.PaginaMDI_Load);
            this.MenuPanel.ResumeLayout(false);
            this.SidePanelItem.ResumeLayout(false);
            this.SidePanelItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private Temas.SideMenuItem sideMenuItem1;
        private System.Windows.Forms.Panel SidePanelItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}



