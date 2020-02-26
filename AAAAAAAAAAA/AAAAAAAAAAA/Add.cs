using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAAAAAAAAAA
{
    public partial class Add : Form
    {
        List<string> tipusok = new List<string>();

        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            foreach (Termek t in frmMain.termekek)
            {
                

            }
            cmbTipus.DataSource = tipusok;
        }

        private void btnFelvetel_Click(object sender, EventArgs e)
        {
            Termek t = new Termek();
            t.Tipus = cbmTipus.SelectedValue;
            t.Nev = txtName.Text;
            string s = mtAr.Text.Substring(0,mtAr.Text.Length-2).Trim();
            int ar = 0;
            Int32.TryParse(s,out ar);
            if (ar==0 && mtAr.Text.Length<1)
            {
                MessageBox.Show("Hibás érték az ár-nál!");
            }

            t.Ar = ar;

            s = mtRaktar.Text.Substring(0, mtRaktar.Text.Length - 2).Trim();
            int raktar = 0;
            Int32.TryParse(s, out raktar);

            if (raktar == 0)
            {

            }
            t.Raktar = raktar;
            t.Beszerzes = mtBeszerzes.Text;

        }
    }
}
