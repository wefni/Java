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

namespace AAAAAAAAAAA
{
    public partial class frmMain : Form
    {
        public float font_size = 20;    
        public static List<Termek> termekek = new List<Termek>();
        List<string> adatok = new List<string>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void adatokBetoltese() {

            try
            {
                foreach (string sor in File.ReadAllLines("Termekek.csv", Encoding.UTF8))
                {
                    termekek.Add(new Termek(sor));

                }
                

            }
            catch (Exception e)
            {

                MessageBox.Show($"Hiba: {e.Message}");
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adatokBetoltese();
        }

        /*-GOMBOK-*/

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registry reg = new Registry();
            reg.termekek = termekek;
            reg.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            float w = Width;
            float h = Height;

            font_size = ((h + w) / 650.0f) * 20.0f;

            foreach (Control c in this.Controls)
            {
                if (c is TableLayoutPanel)
                {
                    foreach (Control panel in c.Controls)
                    {
                        if (panel is Button)
                        {
                            (panel as Button).Font = new Font("Microsof Sans Serif",font_size);
                        }
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }
    }
}
