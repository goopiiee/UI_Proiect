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
using Librarie_Modele;
using proiect;
using Nivel_Stocare_Date;

namespace GUI
{
    public partial class FereastraUseri : Form
    {
        AdministrareUseriText adminUseri;

        private TextBox txtID;
        private TextBox txtNume;
        private TextBox txtPrenume;
        private TextBox txtUUID;

        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblsID;
        private Label[] lblsUUID;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 20;
        private const int DIMENSIUNE_PAS_X = 130;
        public FereastraUseri()
        {
            InitializeComponent();

            string FisierUseri = ConfigurationManager.AppSettings["NumeFisierUseri"];
            string locatieFisierUseriSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierUseri = locatieFisierUseriSolutie + "\\" + FisierUseri;
            adminUseri = new AdministrareUseriText(caleCompletaFisierUseri);
        }
        private void FereastraUseri_Load(object sender, EventArgs e)
        {
            //AfisareUseri();
            AfisareUseriGrid();
        }

        private void User_ID_Click(object sender, EventArgs e)
        {
            
        }

        private void User_ButonAfisare_Click(object sender, EventArgs e)
        {
            //AfisareUseri();
            AfisareUseriGrid();
        }
        private void AfisareUseri()
        {
            Useri[] useri = adminUseri.GetUseri(out int nrUseri);
            lblsID = new Label[nrUseri];
            lblsNume = new Label[nrUseri];
            lblsPrenume = new Label[nrUseri];
            lblsUUID = new Label[nrUseri];
            int i = 0;
            foreach(Useri user in useri)
            {
                //> Control Label tip Tabel :: Nume
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = user.Nume;
                lblsNume[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsNume[i].Top = (i + 1) * 2 * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                //> Control Label tip Tabel :: Prenume
                lblsPrenume[i] = new Label();
                lblsPrenume[i].Width = LATIME_CONTROL;
                lblsPrenume[i].Text = user.Prenume;
                lblsPrenume[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsPrenume[i].Top = (i + 1) * 2 * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPrenume[i]);

                //> Control Label tip Tabel :: UUID
                lblsUUID[i] = new Label();
                lblsUUID[i].Width= LATIME_CONTROL;
                lblsUUID[i].Text = Convert.ToString(user.UserUniqueId);
                lblsUUID[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsUUID[i].Top= (i + 1) * 2 * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsUUID[i]);
                i++;
            }
        }

        private void User_ButonInapoi_Click(object sender, EventArgs e)
        {
            MeniuPrincipal meniuPrincipal=new MeniuPrincipal();
            meniuPrincipal.Show();
            this.Hide();
        }

        private void User_ButonAdaugare_Click(object sender, EventArgs e)
        {
          FereastraUseriAdaugare window= new FereastraUseriAdaugare();
            window.Show();
        }
        private void AfisareUseriGrid()
        {
            Useri[] useri = adminUseri.GetUseri(out int nrUseri);
            //reset continut control DataGridView
            dataGridProduse.DataSource = useri;

            //!!!! Controlul de tip DataGridView are ca sursa de date lista de obiecte de tip Student !!!
            dataGridProduse.DataSource = useri;
            dataGridProduse.DataSource = useri.Select(u => new { u.Nume, u.Prenume, u.UserUniqueId}).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
