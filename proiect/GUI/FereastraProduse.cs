using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FereastraProduse : Form
    {
        public FereastraProduse()
        {
            InitializeComponent();
        }

        private void User_ButonInapoi_Click(object sender, EventArgs e)
        {
            MeniuPrincipal meniuPrincipal = new MeniuPrincipal();
            meniuPrincipal.Show();
            this.Hide();
        }
    }
}
