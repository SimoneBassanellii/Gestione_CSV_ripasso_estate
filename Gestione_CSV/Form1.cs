using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;

namespace Gestione_CSV
{
    public partial class Form1 : Form
    {
        FunzioniCSV f;
        
        public Form1()
        {
0           VisualizzaCSV();
            InitializeComponent();
            f = new FunzioniCSV();
        }

        public string FileName = @"../../bassanelli.csv";
        public string Filename2 = @"../../bassanelli2.csv";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();

        #region visulizzare il file CSV in una listview
        
        #endregion

        #region Funzione 1 aggiunta mio valore
        private void Aggiunta_mio_valore_Click(object sender, EventArgs e)
        {
            Aggiunta_valore();
            
        }
        #endregion

        #region Funzione 2 conta campi
        private void BNCam_Click(object sender, EventArgs e)
        {
            ContaCampi();
        }
        #endregion

        #region Funzione 3 calcolare la lunghezza massima dei record presenti 
       
        private void Lunghezzacampi_Click(object sender, EventArgs e)
        {
           int a = Lunghezzamassimacampi();
        }
        #endregion

        #region Funzione 4 dimensione fissa 
        
        private void Dimfissa_Click(object sender, EventArgs e)
        {
            DimFissa();
        }
        #endregion

        #region Funzione 5 Aggiungere un record in coda
       
        private void recordcoda_Click(object sender, EventArgs e)
        {
            Recordcoda(comunetextBox1.Text, provinciatextBox2.Text, regionetextBox3.Text, nometextBox4.Text, annotextBox5.Text, datatextBox6.Text, identificatoretextBox7.Text, longitudinetextBox8.Text, latitutinetextBox9.Text);
        }
        #endregion

        #region Funzione 6 campi signifiacativi
       
        private void Significativi_Click(object sender, EventArgs e)
        {
            VisualizzaDatiSignificativi();
        }
        #endregion

        #region Funzione 7 Ricerca per campo a scelta 
       
        private void ricerca_Click(object sender, EventArgs e)
        {
            RicercaPerCampo();
        }
        #endregion

        #region Funzione 8 modificare un record
        public void ModificaRecord()
        {

        }
        #endregion

        #region Funzione 9 Cancellazione logica di un record a scelta                

        private void canclogica_Click(object sender, EventArgs e)
        {
            CancLogica();
        }
        #endregion

        #region Funzioni extra
        private void Reload_Click(object sender, EventArgs e)
        {
            VisualizzaCSV();
        }
        #endregion

        private void latidutinetextBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
