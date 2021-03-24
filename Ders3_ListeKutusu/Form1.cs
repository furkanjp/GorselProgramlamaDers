using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders3_ListeKutusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMetin.Text = lbListe.Text;//seçili texti eşliyor
        }

        private void Liste(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete) 
            {
                lbListe.Items.RemoveAt(lbListe.SelectedIndex);
            }
        }
    }
}
