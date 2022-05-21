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
    public partial class FereastraClienti : Form
    {
       
        int nrClienti = 0;
        private Label[] lblsID;
        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblsAdresa;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 20;
        private const int DIMENSIUNE_PAS_X = 130;

        AdministrareClientiText adminClienti;

        public FereastraClienti()
        {
            string FisierClienti = ConfigurationManager.AppSettings["NumeFisierClienti"];
            string locatieFisierClientiSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierClienti = locatieFisierClientiSolutie + "\\" + FisierClienti;
            adminClienti = new AdministrareClientiText(caleCompletaFisierClienti);
            InitializeComponent();
            //AfisareClenti();
            AfisareClientiGrid();
        }

        private void User_ButonInapoi_Click(object sender, EventArgs e)
        {
            MeniuPrincipal meniuPrincipal = new MeniuPrincipal();
            meniuPrincipal.Show();
            this.Hide();
        }

        private void User_ButonAdaugare_Click(object sender, EventArgs e)
        {
            FereastraClientiAdaugare window = new FereastraClientiAdaugare();
            window.Show();
        }
        private void AfisareClenti()
        {
            Clienti[] clienti = adminClienti.GetClienti(out int nrClienti);
            lblsID = new Label[nrClienti];
            lblsNume = new Label[nrClienti];
            lblsPrenume = new Label[nrClienti];
            lblsAdresa = new Label[nrClienti];
            int i = 0;
            foreach(Clienti client in clienti)
            {
                //> Control Label tip Tabel :: Nume
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = client.Nume;
                lblsNume[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsNume[i].Top = (i + 1) * 2 * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                //> Control Label tip Tabel :: Prenume
                lblsPrenume[i] = new Label();
                lblsPrenume[i].Width = LATIME_CONTROL;
                lblsPrenume[i].Text = client.Prenume;
                lblsPrenume[i].Left = 3 * DIMENSIUNE_PAS_X + 50;
                lblsPrenume[i].Top = (i + 1) * 2 * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPrenume[i]);

                //> Control Label tip Tabel :: Adresa
                lblsAdresa[i] = new Label();
                lblsAdresa[i].Width = LATIME_CONTROL;
                lblsAdresa[i].Text = Convert.ToString(client.Adresa);
                lblsAdresa[i].Left = 4 * DIMENSIUNE_PAS_X + 95;
                lblsAdresa[i].Top = (i + 1) * 2 * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsAdresa[i]);
                i++;
            }
        }
        private void User_ButonAfisare_Click(object sender, EventArgs e)
        {
            //AfisareClenti();
            AfisareClientiGrid();
        }
        private void AfisareClientiGrid()
        {
            Clienti[] clienti = adminClienti.GetClienti(out int nrClienti);
            //reset continut control DataGridView
            dataGridClienti.DataSource = clienti;
            dataGridClienti.DataSource = clienti.Select(c => new { c.Nume, c.Prenume, c.Adresa }).ToList();

            // personalizare sursa de date
            // dataGridStudenti.DataSource = studenti.Select(s => new { s.Id, s.Nume, s.Prenume, 
            // s.Specializare, Discipline = string.Join(",", s.Discipline), 
            // Note = string.Join(",", s.GetNote()) } ).ToList();
        }

    }
}
