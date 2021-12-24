
using Temas;

namespace Guia_De_Estudos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.sideMenuItem1 = new Temas.SideMenuItem();
            this.SidePanelItem = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.SidePanelItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.sideMenuItem1);
            this.MenuPanel.Controls.Add(this.SidePanelItem);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(214, 953);
            this.MenuPanel.TabIndex = 1;
            // 
            // sideMenuItem1
            // 
            this.sideMenuItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideMenuItem1.Location = new System.Drawing.Point(0, 67);
            this.sideMenuItem1.Name = "sideMenuItem1";
            this.sideMenuItem1.Size = new System.Drawing.Size(214, 65);
            this.sideMenuItem1.TabIndex = 2;
            // 
            // SidePanelItem
            // 
            this.SidePanelItem.Controls.Add(this.label1);
            this.SidePanelItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidePanelItem.Location = new System.Drawing.Point(0, 0);
            this.SidePanelItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SidePanelItem.Name = "SidePanelItem";
            this.SidePanelItem.Size = new System.Drawing.Size(214, 67);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.MenuPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.SidePanelItem.ResumeLayout(false);
            this.SidePanelItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel SidePanelItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SideMenuItem sideMenuItem1;
    }
}

