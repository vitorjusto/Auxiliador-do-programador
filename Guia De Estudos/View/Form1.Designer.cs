
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
            this.panelSubItem1 = new Temas.PanelSubItem();
            this.label2 = new System.Windows.Forms.Label();
            this.SidePanelItem = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.panelSubItem1.SuspendLayout();
            this.SidePanelItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.panelSubItem1);
            this.MenuPanel.Controls.Add(this.SidePanelItem);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(187, 560);
            this.MenuPanel.TabIndex = 1;
            // 
            // panelSubItem1
            // 
            this.panelSubItem1.Controls.Add(this.label2);
            this.panelSubItem1.Location = new System.Drawing.Point(0, 49);
            this.panelSubItem1.Name = "panelSubItem1";
            this.panelSubItem1.Size = new System.Drawing.Size(187, 39);
            this.panelSubItem1.TabIndex = 2;
            this.panelSubItem1.Click += new System.EventHandler(this.panelSubItem1_DoubleClick);
            this.panelSubItem1.DoubleClick += new System.EventHandler(this.panelSubItem1_DoubleClick);
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
            // SidePanelItem
            // 
            this.SidePanelItem.Controls.Add(this.label1);
            this.SidePanelItem.Location = new System.Drawing.Point(0, 0);
            this.SidePanelItem.Name = "SidePanelItem";
            this.SidePanelItem.Size = new System.Drawing.Size(187, 50);
            this.SidePanelItem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.MenuPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.panelSubItem1.ResumeLayout(false);
            this.panelSubItem1.PerformLayout();
            this.SidePanelItem.ResumeLayout(false);
            this.SidePanelItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel SidePanelItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Temas.PanelSubItem panelSubItem1;
    }
}

