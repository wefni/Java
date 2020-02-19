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
    }
}
