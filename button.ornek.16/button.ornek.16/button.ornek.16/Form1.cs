using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._16
{
    public partial class lblFiyat : Form
    {
        public lblFiyat()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat, taksit, taksitutar;

            fiyat = Convert.ToDouble(txtFiyat.Text);
            taksit = trackBar1.Value;

            taksitutar = fiyat / taksit;
            lblTaksitTutar.Text = taksitutar.ToString();


        }
    }
}
