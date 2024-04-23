using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCaltempo : Form
    {
        public frmCaltempo()
        {
            InitializeComponent();
        }

        // buscando o valor
        private void guna2Button14_Click(object sender, EventArgs e)
        {
         
            Control cb = (Control)sender;
            if (lbentrada.Text == "0" && cb.Text == ",")
                return;

                if (lbentrada.Text == "0")
                lbentrada.Text = "";
        
           lbentrada.Text +=  cb.Text;
            if (lbentrada.Text != "" && lbentrada.Text != "0")
            {
                lbSaida.Text = Calculos.Tempo(c1.Text, c2.Text, lbentrada.Text);
            }
        }

        private void guna2Button30_Click(object sender, EventArgs e)
        {
         
            if (lbentrada.Text != "0")
            lbentrada.Text = lbentrada.Text.Substring(0, lbentrada.Text.Length - 1);
            if (lbentrada.Text == "")
                lbentrada.Text = "0";
            if (lbentrada.Text != "" && lbentrada.Text != "0")
            {
                lbSaida.Text = Calculos.Comprimento(c1.Text, c2.Text, lbentrada.Text);
            }
            if (lbentrada.Text == "0" && lbSaida.Text != "0")
            {
                lbSaida.Text = Calculos.Comprimento(c1.Text, c2.Text, "0");
            }
        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            if (lbentrada.Text != "0")
            {
                lbentrada.Text = "0";
                lbSaida.Text = Calculos.Comprimento(c1.Text, c2.Text, "0");
            }
        }

        private void c1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void c2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSaida.Text = Calculos.Tempo(c1.Text, c2.Text, lbentrada.Text);
        }
    }
}
