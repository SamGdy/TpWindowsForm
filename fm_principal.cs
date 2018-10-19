using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TpWFediteur
{
    public partial class Mere : Form
    {
        private bool save=false;
        private bool sauvegarder = false;
        Enregistrer enregistrer;
        public Mere()
        {
            InitializeComponent();
            this.Text = "Mon petit éditeur";
            this.enregistrer = new Enregistrer(this);
            sd_enregistrer.DefaultExt = "txt";
            sd_enregistrer.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 
            mi_quitter.Click += new EventHandler(mi_quitter_Click);
            mi_ouvrir.Click += new EventHandler(mi_ouvrir_Click);
            //od_ouvrir.FileOk += new CancelEventHandler(od_ouvrir_FileOk);
            mi_enregistrerSous.Click += new EventHandler(mi_enregistrerSous_Click);
            mi_nouveau.Click += new EventHandler(mi_nouveau_Click);
            mi_enregistrer.Click += new EventHandler(mi_enregistrer_Click);
            mi_annuler.Click += new EventHandler(mi_annuler_Click);
            mi_coller.Click += new EventHandler(mi_coller_Click);
            mi_Copier.Click += new EventHandler(mi_Copier_Click);
            mi_couper.Click += new EventHandler(mi_couper_Click);
            tbRechercher.Click += new EventHandler(tbRechercher_Click);
            tbRechercher.TextChanged += new EventHandler(tbRechercher_TextChanged);
            rt_text.TextChanged += new EventHandler(rt_text_TextChanged);

        }

        void rt_text_TextChanged(object sender, EventArgs e)
        {
            this.sauvegarder = false;
        }

        void tbRechercher_TextChanged(object sender, EventArgs e)
        {
            string nimportekoi = tbRechercher.Text;
            int index = 0;
            if (rt_text.Text.Contains(nimportekoi) == true)
            {
                rt_text.Find(nimportekoi,index ,RichTextBoxFinds.None);
                rt_text.SelectionColor=Color.OrangeRed;
            }
            
        }

        void tbRechercher_Click(object sender, EventArgs e)
        {
            tbRechercher.Text = "";

        }

        void mi_couper_Click(object sender, EventArgs e)
        {
            rt_text.Cut();
        }

        void mi_Copier_Click(object sender, EventArgs e)
        {
            rt_text.Copy();
        }

        void mi_coller_Click(object sender, EventArgs e)
        {
            rt_text.Paste();    
        }

        void mi_annuler_Click(object sender, EventArgs e)
        {
            rt_text.Undo();
        }

        void mi_enregistrer_Click(object sender, EventArgs e)
        {
            Enregistrer(); 
            this.enregistrer.Hide();
        }
        public void Enregistrer()
        {
            if (this.save == false)
            {
                if (sd_enregistrer.ShowDialog() == DialogResult.OK)
                {
                    rt_text.SaveFile(sd_enregistrer.FileName, RichTextBoxStreamType.PlainText);
                }
                this.save = true;
            }
            else
            {
                rt_text.SaveFile(sd_enregistrer.FileName, RichTextBoxStreamType.PlainText);
                this.sauvegarder = true;
            }
        }
        void mi_nouveau_Click(object sender, EventArgs e)
        {
            if (this.sauvegarder == false && rt_text.Text != "")
            {
                
                this.enregistrer.ShowDialog();
            }
            else
            {
                rt_text.Clear();
                this.save = false;
            }
        }

        public void mi_enregistrerSous_Click(object sender, EventArgs e)
        {
            if (sd_enregistrer.ShowDialog() == DialogResult.OK && save != true)
            {
                rt_text.SaveFile(sd_enregistrer.FileName, RichTextBoxStreamType.PlainText);
            }
           
        }
        public void CacherEnregistrer()
        {
            this.enregistrer.Hide();
            rt_text.Clear();
        }
        void od_ouvrir_FileOk(object sender, CancelEventArgs e)
        {
            rt_text.LoadFile(od_ouvrir.FileName, RichTextBoxStreamType.PlainText);
            this.save = true;
        }

        void mi_ouvrir_Click(object sender, EventArgs e)
        {
            if (od_ouvrir.ShowDialog() == DialogResult.OK)
            {
                rt_text.LoadFile(od_ouvrir.FileName, RichTextBoxStreamType.PlainText);
                this.sauvegarder = true;
            }
        }

        void mi_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        
}
