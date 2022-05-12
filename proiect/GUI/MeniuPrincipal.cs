using System;
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
    public partial class MeniuPrincipal : Form
    {
        
        public string adminpassword;
        private TextBox txtboxpass;
        public MeniuPrincipal()
        {
            InitializeComponent();
            adminpassword = LoginScreen.SetValueForText1;
            LoadingErr.Hide();
        }
        FereastraUseri userWindow=new FereastraUseri();
        FereastraClienti clientWindow=new FereastraClienti();
        FereastraComenzi orderWindow=new FereastraComenzi();
        FereastraProduse productWindow=new FereastraProduse();

        private void USERI_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(adminpassword)==9866)
            {
                userWindow.Show();
                LoadingErr.Hide();
                this.Hide();
            }
            else
            {
                LoadingErr.Show();
            }
        }

        private void Produse_Click(object sender, EventArgs e)
        {
            productWindow.Show();
            this.Hide();
        }

        private void Clienti_Click(object sender, EventArgs e)
        {
            clientWindow.Show();
            this.Hide();
        }

        private void Comenzi_Click(object sender, EventArgs e)
        {
            orderWindow.Show();
            this.Hide();
        }
    }
}
