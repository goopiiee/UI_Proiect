using System;
using System.Configuration;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proiect;
using Librarie_Modele;
using Nivel_Stocare_Date;

namespace GUI
{
    public partial class FereastraComenzi : Form
    {
        AdministrareComenziText adminComenzi;
        public FereastraComenzi()
        {
            string FisierComenzi = ConfigurationManager.AppSettings["NumeFisierComenzi"];
            string locatieFisierComenziSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierComenzi = locatieFisierComenziSolutie + "\\" + FisierComenzi;
            adminComenzi = new AdministrareComenziText(caleCompletaFisierComenzi);
            InitializeComponent();
            AfisareComenziGrid();
        }
        private void User_ButonInapoi_Click(object sender, EventArgs e)
        {
            MeniuPrincipal meniuPrincipal = new MeniuPrincipal();
            meniuPrincipal.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AfisareComenziGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FereastraComenziAdaugare window = new FereastraComenziAdaugare();
            window.Show();
        }
        private void AfisareComenziGrid()
        {
            Comenzi[] comenzi = adminComenzi.GetComenzi (out int nrComenzi);
            dataGridComenzi.DataSource = comenzi.Select(c => new { c.IdComanda, c.Metoda_Plata}).ToList();
        }

        private void dataGridComenzi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
