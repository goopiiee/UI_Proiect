using System;
using System.IO;
using System.Configuration;
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
    public partial class FereastraProduse : Form
    {
        AdministrareProduseText adminProduse;
        public FereastraProduse()
        {
            string FisierProduse = ConfigurationManager.AppSettings["NumeFisierProduse"];
            string locatieFisierProduseSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierProduse = locatieFisierProduseSolutie + "\\" + FisierProduse;
            adminProduse = new AdministrareProduseText(caleCompletaFisierProduse);
            InitializeComponent();
            AfisareProduseGrid();
        }

        private void User_ButonInapoi_Click(object sender, EventArgs e)
        {
            MeniuPrincipal meniuPrincipal = new MeniuPrincipal();
            meniuPrincipal.Show();
            this.Hide();
        }

        private void User_ButonAdaugare_Click(object sender, EventArgs e)
        {
            FereastraProduseAdaugare window = new FereastraProduseAdaugare();
            window.Show();
        }

        private void User_ButonAfisare_Click(object sender, EventArgs e)
        {
            AfisareProduseGrid();
        }
        private void AfisareProduseGrid()
        {
            Produse[] produse = adminProduse.GetProduse(out int nrProduse);
            dataGridProduse.DataSource = produse;
            dataGridProduse.DataSource = produse.Select(p => new { p.Denumire, p.Categorie, p.Pret, p.Cantitate }).ToList();
        }
    }
}
