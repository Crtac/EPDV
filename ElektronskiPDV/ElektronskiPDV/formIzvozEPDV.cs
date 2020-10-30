using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElektronskiPDV
{
    public partial class formIzvozEPDV : Form
    {
        public class Organizacija
        {
            public Organizacija(string pDVBroj)
            {
                PDVBroj = pDVBroj;
            }

            public string PDVBroj { get; set; }

        }
        public class Nova 
        {
            public Nova(string text, decimal broj)
            {
                Text = text;
                this.broj = broj;
            }

            public string Text { get; set; }
            public decimal broj { get; set; }
        }

        public class KUF
        {
            public KUF(string serijskiBroj, int tipDokumenta, string brojFakture, DateTime datumIVrijemeFakture, DateTime datumIVrijemePrijemaFakture, string nazivDobavljaca, string sjedisteDobavljaca, string pDVBrojDobavljaca, decimal iznosFaktureBezPDV, decimal iznosFaktureSaPDV, decimal iznosPausalneNaknade, decimal iznosUlaznogPDV, decimal ulazniPDVOdbijaSe, decimal ulazniPDVNeOdbijaSe, decimal ulazniPDVNeOdbijaSePolje32, decimal ulazniPDVNeOdbijaSePolje33, decimal ulazniPDVNeOdbijaSePolje34)
            {
                SerijskiBroj = serijskiBroj;
                TipDokumenta = tipDokumenta;
                BrojFakture = brojFakture;
                DatumIVrijemeFakture = datumIVrijemeFakture;
                DatumIVrijemePrijemaFakture = datumIVrijemePrijemaFakture;
                NazivDobavljaca = nazivDobavljaca;
                SjedisteDobavljaca = sjedisteDobavljaca;
                PDVBrojDobavljaca = pDVBrojDobavljaca;
                IznosFaktureBezPDV = iznosFaktureBezPDV;
                IznosFaktureSaPDV = iznosFaktureSaPDV;
                IznosPausalneNaknade = iznosPausalneNaknade;
                IznosUlaznogPDV = iznosUlaznogPDV;
                UlazniPDVOdbijaSe = ulazniPDVOdbijaSe;
                UlazniPDVNeOdbijaSe = ulazniPDVNeOdbijaSe;
                UlazniPDVNeOdbijaSePolje32 = ulazniPDVNeOdbijaSePolje32;
                UlazniPDVNeOdbijaSePolje33 = ulazniPDVNeOdbijaSePolje33;
                UlazniPDVNeOdbijaSePolje34 = ulazniPDVNeOdbijaSePolje34;
            }

            public string SerijskiBroj { get; set; }
            public int TipDokumenta { get; set; }
            public string BrojFakture { get; set; }
            public DateTime DatumIVrijemeFakture { get; set; }
            public DateTime DatumIVrijemePrijemaFakture { get; set; }
            public string NazivDobavljaca { get; set; }
            public string SjedisteDobavljaca { get; set; }
            public string PDVBrojDobavljaca { get; set; }
            public string JIBDobavljaca { get; set; }
            public decimal IznosFaktureBezPDV { get; set; }
            public decimal IznosFaktureSaPDV { get; set; }
            public decimal IznosPausalneNaknade { get; set; }
            public decimal IznosUlaznogPDV { get; set; }
            public decimal UlazniPDVOdbijaSe { get; set; }
            public decimal UlazniPDVNeOdbijaSe { get; set; }
            public decimal UlazniPDVNeOdbijaSePolje32 { get; set; }
            public decimal UlazniPDVNeOdbijaSePolje33 { get; set; }
            public decimal UlazniPDVNeOdbijaSePolje34 { get; set; }

        }

        private Organizacija organizacija;
        private List<KUF> listaKufova;

        public formIzvozEPDV()
        {
            InitializeComponent();
            organizacija = new Organizacija("123456789012");
            listaKufova = new List<KUF>();
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
                int BrojDatotekeKif = 1;
                int BrojDatotekeKuf = 1;
                string SlogZaglavlja = "";
                string ImeDatoteke = "";

                decimal IznosFaktureBezPDVSuma = 0;
                decimal IznosFaktureSaPDVSuma = 0;
                decimal IznosPausalneNaknadeSuma = 0;
                decimal IznosUlaznogPDVSuma = 0;
                decimal UlazniPDVOdbijaSeSuma = 0;
                decimal UlazniPDVNeOdbijaSeSuma = 0;
                decimal UlazniPDVNeOdbijaSePolje32Suma = 0;
                decimal UlazniPDVNeOdbijaSePolje33Suma = 0;
                decimal UlazniPDVNeOdbijaSePolje34Suma = 0;

                int BrojRedova = 0;
                if (true)//Kuf
                {
                    ImeDatoteke = organizacija.PDVBroj + "_" + dtpPeriod.Value.ToString("yyMM") + "_1_" + (BrojDatotekeKuf < 10 ? "0" + BrojDatotekeKuf.ToString() : BrojDatotekeKuf.ToString());
                    SlogZaglavlja = "1;" + organizacija.PDVBroj + ";" + dtpPeriod.Value.ToString("yyMM") + ";1;"
                        + (BrojDatotekeKuf < 10 ? "0" + BrojDatotekeKuf.ToString() : BrojDatotekeKuf.ToString()) + ";" + DateTime.Now.ToString("yyyy-MM-dd") + ";" + DateTime.Now.ToString("HH:mm:ss");
                    using (StreamWriter swOutputFile = new StreamWriter(new FileStream(txtLokacija.Text + "\\" + ImeDatoteke, FileMode.Create, FileAccess.Write, FileShare.Read)))
                    {
                        swOutputFile.WriteLine(SlogZaglavlja);
                        foreach (KUF item in listaKufova)
                        {
                            swOutputFile.WriteLine("2;" + dtpPeriod.Value.ToString("yyMM")
                                + ";" + item.SerijskiBroj + ";"
                                + (item.TipDokumenta < 10 ? "0" + item.TipDokumenta.ToString() : item.TipDokumenta.ToString())
                                + ";" + item.BrojFakture + ";" + item.DatumIVrijemeFakture.ToString("yyyy-MM-dd") + ";"
                                + item.DatumIVrijemePrijemaFakture.ToString("yyyy-MM-dd") + ";" + item.NazivDobavljaca + ";" + item.SjedisteDobavljaca + ";" + item.PDVBrojDobavljaca + ";"
                                + item.JIBDobavljaca + ";" + item.IznosFaktureBezPDV.ToString("F"));

                        }
                    }
                }
                else
                { //Kif

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nije uspješan upis u dokumente. Greška:> \n" + ex.Message);
            }
        }
    }
}
