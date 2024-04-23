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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            abrirForm(new frmCalcCientifi());
            frmCalcCientifi.pm = plmenucalcs;
            frmCalcCientifi.pmtitulo = plmenucalmostr;
            guna2ShadowForm1.SetShadowForm(this);
        }

  
        private void hideMenu()
        {
            plmenucalcs.Visible = false;
            plmenucalmostr.Visible = true;
        }
        private void guna2Button4_Click_1(object sender, EventArgs e)
        {


            plmenucalcs.Visible = false;
            plmenucalmostr.Visible = true;


        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            plmenucalmostr.Visible = false;
            //plmenucalcs.Visible = true;
            guna2Transition1.Show(plmenucalcs);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            hideMenu();
            lbtitulo.Text = "Comprimento";
            abrirForm(new frmCalComprimem());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            hideMenu();
            lbtitulo.Text = "Científica";
            abrirForm(new frmCalcCientifi());

        }
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            hideMenu();
            lbtitulo.Text = "Tempo";
            abrirForm(new frmCaltempo());
        }

        private void abrirForm(object form)
        {
           
               Form fh = (Form)form;
            if (plprincipal.Controls.Count > 0)
                plprincipal.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;
            plprincipal.Controls.Add(fh);
            fh.Show();
            
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

            frmSobre sb = new frmSobre(this.Location);
            sb.ShowDialog();
        }

    
    }
}
