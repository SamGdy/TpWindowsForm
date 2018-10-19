namespace TpWFediteur
{
    partial class Mere
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rt_text = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ouvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_nouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_enregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.od_ouvrir = new System.Windows.Forms.OpenFileDialog();
            this.sd_enregistrer = new System.Windows.Forms.SaveFileDialog();
            this.mi_enregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_annuler = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Copier = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_couper = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_coller = new System.Windows.Forms.ToolStripMenuItem();
            this.tbRechercher = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rt_text
            // 
            this.rt_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rt_text.Location = new System.Drawing.Point(0, 24);
            this.rt_text.Name = "rt_text";
            this.rt_text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rt_text.Size = new System.Drawing.Size(557, 349);
            this.rt_text.TabIndex = 0;
            this.rt_text.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_fichier,
            this.editionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_fichier
            // 
            this.m_fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_ouvrir,
            this.mi_nouveau,
            this.mi_enregistrer,
            this.mi_enregistrerSous,
            this.toolStripSeparator1,
            this.mi_quitter});
            this.m_fichier.Name = "m_fichier";
            this.m_fichier.Size = new System.Drawing.Size(54, 20);
            this.m_fichier.Text = "Fichier";
            // 
            // mi_ouvrir
            // 
            this.mi_ouvrir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mi_ouvrir.Name = "mi_ouvrir";
            this.mi_ouvrir.Size = new System.Drawing.Size(169, 22);
            this.mi_ouvrir.Text = "Ouvrir";
            // 
            // mi_nouveau
            // 
            this.mi_nouveau.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mi_nouveau.Name = "mi_nouveau";
            this.mi_nouveau.Size = new System.Drawing.Size(169, 22);
            this.mi_nouveau.Text = "Nouveau";
            // 
            // mi_enregistrerSous
            // 
            this.mi_enregistrerSous.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mi_enregistrerSous.Name = "mi_enregistrerSous";
            this.mi_enregistrerSous.Size = new System.Drawing.Size(169, 22);
            this.mi_enregistrerSous.Text = "Enregistrer sous ...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // mi_quitter
            // 
            this.mi_quitter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mi_quitter.Name = "mi_quitter";
            this.mi_quitter.Size = new System.Drawing.Size(169, 22);
            this.mi_quitter.Text = "Quitter";
            // 
            // od_ouvrir
            // 
            this.od_ouvrir.FileName = "openFileDialog1";
            // 
            // mi_enregistrer
            // 
            this.mi_enregistrer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mi_enregistrer.Name = "mi_enregistrer";
            this.mi_enregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_enregistrer.Size = new System.Drawing.Size(170, 22);
            this.mi_enregistrer.Text = "Enregistrer";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_annuler,
            this.mi_Copier,
            this.mi_couper,
            this.mi_coller});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // mi_annuler
            // 
            this.mi_annuler.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mi_annuler.Name = "mi_annuler";
            this.mi_annuler.Size = new System.Drawing.Size(152, 22);
            this.mi_annuler.Text = "Annuler";
            // 
            // mi_Copier
            // 
            this.mi_Copier.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mi_Copier.Name = "mi_Copier";
            this.mi_Copier.Size = new System.Drawing.Size(152, 22);
            this.mi_Copier.Text = "Copier";
            // 
            // mi_couper
            // 
            this.mi_couper.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mi_couper.Name = "mi_couper";
            this.mi_couper.Size = new System.Drawing.Size(152, 22);
            this.mi_couper.Text = "Couper";
            // 
            // mi_coller
            // 
            this.mi_coller.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mi_coller.Name = "mi_coller";
            this.mi_coller.Size = new System.Drawing.Size(152, 22);
            this.mi_coller.Text = "Coller";
            // 
            // tbRechercher
            // 
            this.tbRechercher.Location = new System.Drawing.Point(457, 4);
            this.tbRechercher.Name = "tbRechercher";
            this.tbRechercher.Size = new System.Drawing.Size(100, 20);
            this.tbRechercher.TabIndex = 2;
            this.tbRechercher.Text = "Rechercher";
            // 
            // Mere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 373);
            this.Controls.Add(this.tbRechercher);
            this.Controls.Add(this.rt_text);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mere";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_text;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_fichier;
        private System.Windows.Forms.ToolStripMenuItem mi_ouvrir;
        private System.Windows.Forms.ToolStripMenuItem mi_enregistrerSous;
        private System.Windows.Forms.ToolStripMenuItem mi_quitter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog od_ouvrir;
        private System.Windows.Forms.SaveFileDialog sd_enregistrer;
        private System.Windows.Forms.ToolStripMenuItem mi_nouveau;
        private System.Windows.Forms.ToolStripMenuItem mi_enregistrer;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_annuler;
        private System.Windows.Forms.ToolStripMenuItem mi_Copier;
        private System.Windows.Forms.ToolStripMenuItem mi_couper;
        private System.Windows.Forms.ToolStripMenuItem mi_coller;
        private System.Windows.Forms.TextBox tbRechercher;
    }
}

