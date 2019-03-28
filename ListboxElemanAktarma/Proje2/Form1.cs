using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAktar_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();

            lblSayi.Text = lbListe.Items.Count.ToString();

            foreach (string item in clbGazeteler.CheckedItems)
            {
                lbListe.Items.Add(item);
                lblSayi.Text = lbListe.Items.Count.ToString();
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
