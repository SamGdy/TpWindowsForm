using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TpWFediteur
{
    public partial class Enregistrer : Form
    {
        Mere mam;
        public Enregistrer(Mere m)
        {
            this.mam = m;
            InitializeComponent();
            btnEnregistrerNon.Click += new EventHandler(btnEnregistrerNon_Click);
            btnEnregistrerOui.Click += new EventHandler(btnEnregistrerOui_Click);
        }

        void btnEnregistrerOui_Click(object sender, EventArgs e)
        {
            mam.Enregistrer();
        }

        void btnEnregistrerNon_Click(object sender, EventArgs e)
        {
            mam.CacherEnregistrer();
        }
    }
}
