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
    public partial class frmCalcCientifi : Form
    {
        bool checkpri = false;
        bool clear = false;
        bool raiz = false;
        string sinais= null;
        public static Panel pm;
        public static Panel pmtitulo;
        string sinaiscal = "÷×-+";
        List<char> sinaisencontrados = new List<char>();
        public frmCalcCientifi()
        {
            InitializeComponent();
        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
       
            pm.Visible = false;
            pmtitulo.Visible = true;
            Control cb = (Control)sender;
            if (clear == true)
            {
                sinais = null;
                clear = false;
                lbparcela1.Text = "";
                lbparcela.Text = "";

            }
            if (lbparcela.Text == "0")
            {
                lbparcela.Text = "";
            }
            if (checkpri == true)
            {
                checkpri = false;
                lbparcela.Text = "";
                lbparcela.Text += cb.Text;
            }
            else
            {
                lbparcela.Text += cb.Text;
            }
          
        }

        private void guna2Button30_Click(object sender, EventArgs e)
        {
            if (clear == true)
            {
                sinais = null;
                checkpri = true;
                lbparcela1.Text = "";
                return;
            }
            lbparcela.Text = lbparcela.Text.Substring(0, lbparcela.Text.Length-1);
            if (lbparcela.Text == "")
            {
                lbparcela.Text = "0";
            }
        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            if (lbparcela.Text != "" && lbparcela.Text != "0")
            {
                lbparcela.Text = "0";
                return;
            }
            if (lbparcela1.Text != "")
            {
                lbparcela1.Text = "";
            }
        }

        // buscando o final exato
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (raiz == true)
            {
                return;
            }


            Control cb = (Control)sender;
            if (lbparcela1.Text.Contains("="))
            {
                lbparcela1.Text= lbparcela.Text + " " + cb.Text;
                sinais = cb.Text;
                checkpri = true;
                clear = false;

                return;
            }
            if (lbparcela.Text != "" && lbparcela.Text != "0")
            {
        
                lbparcela1.Text += lbparcela.Text +" "+ cb.Text + " ";
                sinais += cb.Text;
                checkpri = true;
            }
           
        }


        //calculando resultado
        private void guna2Button25_Click(object sender, EventArgs e)
        {
            string valoracalcular = lbparcela1.Text + lbparcela.Text;
            int cont=0;
            sinaisencontrados.Clear();
            foreach (char item in sinaiscal)
            {

                foreach (char item2 in valoracalcular)
                {
                    if (item == item2)
                    {
                        if (!sinaisencontrados.Contains(item))
                        {
                            sinaisencontrados.Add(item);
                            cont++;
                    }

                }
                }
            }

            if (cont >= 2)
            {
                Calculos.multiOperacao(valoracalcular);
            }
            else
            {


            if (raiz == true)
            {
                raiz = false;
                string par = lbparcela.Text + " =";
                lbparcela.Text = Calculos.Raiz(lbparcela.Text);
                lbparcela1.Text += par;
                clear = true;
            }



            #region realizando soma

            if (sinais == "+")
            {
                string par = lbparcela.Text + " =";
                lbparcela.Text = Calculos.Soma(lbparcela1.Text, lbparcela.Text);
                lbparcela1.Text += par;
                clear = true;
            }

            #endregion
            #region realizando subtração

          
            if (sinais == "-")
            {
                string par = lbparcela.Text + " =";
                lbparcela.Text = Calculos.subtracao(lbparcela1.Text, lbparcela.Text);
                lbparcela1.Text += par;
                clear = true;
            }
            #endregion
            #region realizando multiplicação

     
            if (sinais == "×")
            {
                string par = lbparcela.Text + " =";
                lbparcela.Text = Calculos.multiplicacao(lbparcela1.Text, lbparcela.Text);
                lbparcela1.Text += par;
                clear = true;
            }
            #endregion
            #region realizando divisão
            if (sinais == "÷")
            {
                string par = lbparcela.Text + " =";
                lbparcela.Text = Calculos.divisao(lbparcela1.Text, lbparcela.Text);
                lbparcela1.Text += par;
                clear = true;
            }
            #endregion
            #region realizando Potência
            if (sinais == "^")
            {
                string par = lbparcela.Text + " =";
                lbparcela.Text = Calculos.Pontencia(lbparcela1.Text, lbparcela.Text);
                lbparcela1.Text += par;
                clear = true;
            }
            }
            #endregion
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            //*********** ////Positivo //// Negativo //// ********
            if (lbparcela.Text != "" && lbparcela.Text != "0") {
                if (lbparcela.Text.Contains("-"))
            {
                lbparcela.Text = lbparcela.Text.Replace("-", "");
            }
            else
            {
                string nega = "-" + lbparcela.Text;
                lbparcela.Text= nega;
            }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            raiz = true;
            lbparcela1.Text = guna2Button1.Text;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            clear = true;
            lbparcela.Text = "3,14159265358979";
        }
    }
}
