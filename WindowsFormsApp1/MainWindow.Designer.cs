namespace GestionPretForm
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesPrêtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesPrêtsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesAdherentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesPrêtsToolStripMenuItem,
            this.outilsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesPrêtsToolStripMenuItem
            // 
            this.gestionDesPrêtsToolStripMenuItem.Name = "gestionDesPrêtsToolStripMenuItem";
            this.gestionDesPrêtsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.gestionDesPrêtsToolStripMenuItem.Text = "Fichier";
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesPrêtsToolStripMenuItem1,
            this.gestionDesAdherentsToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // gestionDesPrêtsToolStripMenuItem1
            // 
            this.gestionDesPrêtsToolStripMenuItem1.Name = "gestionDesPrêtsToolStripMenuItem1";
            this.gestionDesPrêtsToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.gestionDesPrêtsToolStripMenuItem1.Text = "Gestion des prêts";
            this.gestionDesPrêtsToolStripMenuItem1.Click += new System.EventHandler(this.GestionDesPrêts_Click);
            // 
            // gestionDesAdherentsToolStripMenuItem
            // 
            this.gestionDesAdherentsToolStripMenuItem.Name = "gestionDesAdherentsToolStripMenuItem";
            this.gestionDesAdherentsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.gestionDesAdherentsToolStripMenuItem.Text = "Gestion des adherents";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesPrêtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesPrêtsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesAdherentsToolStripMenuItem;
    }
}