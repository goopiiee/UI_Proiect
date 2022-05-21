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
        public static string[] SetValueFotText2;
        public int CounterForUUID;

        AdministrareUseriText adminUseri;
        bool UUIDCorect = false;

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
            LoginRetry.Hide();
            LoginButton.Click += LoginButtonClicked;
            LoginRetry.Click+=LoginRetryButtonClicked;

        }
        private void LoginRetryButtonClicked(object sender, EventArgs e)
        {
            textBoxLogin.Text = String.Empty;
            LoginButton.Show();
            label1.Hide();
            LoginRetry.Hide();
        }
        private void LoginButtonClicked(object sender,EventArgs e)
        {
            SetValueForText1 = textBoxLogin.Text;
            if (textBoxLogin.Text == String.Empty)
            {
                label1.Show();
                label1.Text = "Introduceti UUID!";
            }
            else if (textBoxLogin.Text.Length != 4)
            {
                LoginRetry.Show();
                LoginButton.Hide();
                label1.Show();
                label1.Text = "UUID trebuie sa aiba 4 cifre!";
            }
            else
            {
                string FisierUseri = ConfigurationManager.AppSettings["NumeFisierUseri"];
                string locatieFisierUseriSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                string caleCompletaFisierUseri = locatieFisierUseriSolutie + "\\" + FisierUseri;
                adminUseri = new AdministrareUseriText(caleCompletaFisierUseri);
                Useri[] useri = adminUseri.GetUseri(out int nrUseri);
                foreach(Useri user in useri)
                {
                    if (textBoxLogin.Text == Convert.ToString(user.UserUniqueId))
                        UUIDCorect = true;
                }
                if (UUIDCorect == false)
                {
                    LoginRetry.Show();
                    LoginButton.Hide();
                    label1.Show();
                    label1.Text = "UUID Necunoscut!";
                }
                else if (UUIDCorect == true)
                {
                    UUIDLabel.Hide();
                    LoginButton.Hide();
                    textBoxLogin.Hide();
                    this.Hide();
                    MeniuPrincipal meniuPrincipal = new MeniuPrincipal();
                    meniuPrincipal.Show();
                }
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

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
