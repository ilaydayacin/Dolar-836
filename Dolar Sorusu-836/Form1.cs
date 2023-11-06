using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolar_Sorusu_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            double adet, birim, sonuc; 
            adet = Convert.ToDouble(txtAdet.Text);
            birim = Convert.ToDouble(txtBirim.Text);

            sonuc = birim * adet;

            lblSonuc.Text = sonuc.ToString(); 
        }
    }
}
