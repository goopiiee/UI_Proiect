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
    
    public partial class LoginScreen : Form
    {
        public static string SetValueForText1="";
        AdministrareUseriText adminUseri;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;

        public LoginScreen()
        {
            string FisierUseri = ConfigurationManager.AppSettings["NumeFisierUseri"];
            string locatieFisierUseriSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierUseri = locatieFisierUseriSolutie + "\\" + FisierUseri;
            adminUseri = new AdministrareUseriText(caleCompletaFisierUseri);
            InitializeComponent();
            label1.Hide();
            LoginButton.Click += LoginButtonClicked;

        }
        private void LoginButtonClicked(object sender,EventArgs e)
        {
            SetValueForText1 = textBoxLogin.Text;
            if (textBoxLogin.Text == String.Empty)
            {
                label1.Show();
                label1.Text = "Introduceti UUID!";
            }
            else
            {
                UUIDLabel.Hide();
                LoginButton.Hide();
                textBoxLogin.Hide();
                this.Hide();
                MeniuPrincipal meniuPrincipal = new MeniuPrincipal();
                meniuPrincipal.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void UUIDTextBox_TextChanged(object sender, EventArgs e)
        { 
        }
    }
}
