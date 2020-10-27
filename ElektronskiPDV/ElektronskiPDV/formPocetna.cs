using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElektronskiPDV
{
    public partial class formPocetna : Form
    {
        public formPocetna()
        {
            InitializeComponent();
        }

        private void btnKreirajEPDV_Click(object sender, EventArgs e)
        {
            formIzvozEPDV izvozEPDV = new formIzvozEPDV();
            this.Hide();
            izvozEPDV.ShowDialog();
            this.Show();
        }

        private void btnPregledKIF_Click(object sender, EventArgs e)
        {

        }

        private void btnPregledKUF_Click(object sender, EventArgs e)
        {

        }
    }
}
