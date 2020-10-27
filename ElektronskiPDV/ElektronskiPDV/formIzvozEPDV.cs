using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElektronskiPDV
{
    public partial class formIzvozEPDV : Form
    {
        public formIzvozEPDV()
        {
            InitializeComponent();
        }

        private void formIzvozEPDV_Load(object sender, EventArgs e)
        {
            dtpPeriod.Value = DateTime.Now;
        }

        private void btnLokacija_Click(object sender, EventArgs e)
        {
            OpenFileDialog folder = new OpenFileDialog();
            folder.ValidateNames = false;
            folder.CheckFileExists = false;
            folder.CheckPathExists = true;
            folder.FileName = "Select folder...";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folder.FileName);
                txtLokacija.Text = folderPath;
            }
        }

        private void btnIzvrsi_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
