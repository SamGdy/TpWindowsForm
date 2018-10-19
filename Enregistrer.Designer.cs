namespace TpWFediteur
{
    partial class Enregistrer
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
            this.lbSave = new System.Windows.Forms.Label();
            this.btnEnregistrerOui = new System.Windows.Forms.Button();
            this.btnEnregistrerNon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSave
            // 
            this.lbSave.AutoSize = true;
            this.lbSave.Location = new System.Drawing.Point(45, 17);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(66, 13);
            this.lbSave.TabIndex = 0;
            this.lbSave.Text = "Enregistrer ?";
            this.lbSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnregistrerOui
            // 
            this.btnEnregistrerOui.Location = new System.Drawing.Point(43, 68);
            this.btnEnregistrerOui.Name = "btnEnregistrerOui";
            this.btnEnregistrerOui.Size = new System.Drawing.Size(91, 26);
            this.btnEnregistrerOui.TabIndex = 1;
            this.btnEnregistrerOui.Text = "Oui";
            this.btnEnregistrerOui.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrerNon
            // 
            this.btnEnregistrerNon.Location = new System.Drawing.Point(210, 68);
            this.btnEnregistrerNon.Name = "btnEnregistrerNon";
            this.btnEnregistrerNon.Size = new System.Drawing.Size(112, 25);
            this.btnEnregistrerNon.TabIndex = 2;
            this.btnEnregistrerNon.Text = "Non";
            this.btnEnregistrerNon.UseVisualStyleBackColor = true;
            // 
            // Enregistrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 119);
            this.Controls.Add(this.btnEnregistrerNon);
            this.Controls.Add(this.btnEnregistrerOui);
            this.Controls.Add(this.lbSave);
            this.Name = "Enregistrer";
            this.Text = "Enregistrer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSave;
        private System.Windows.Forms.Button btnEnregistrerOui;
        private System.Windows.Forms.Button btnEnregistrerNon;
    }
}