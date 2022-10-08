using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double SB, Fgts, pfgts, inss, pinss, irrf, pirrf, SL;
            SB = double.Parse(txtSB.Text);
            pfgts = 8;
            Fgts = SB * (pfgts / 100);
            txtFgts.Text = Fgts.ToString();
            if (SB <= 1212)
            {
                pinss = 7.5;
                inss = SB * (pinss / 100);
                txtInss.Text = inss.ToString();
            }
            else if (SB <= 2427.35)
            {
                pinss = 9;
                inss = SB * (pinss / 100);
                txtInss.Text = inss.ToString();
            }
            else if (SB <= 3641.03)
            {
                pinss = 12;
                inss = SB * (pinss / 100);
                txtInss.Text = inss.ToString();
            }
            else if (SB <= 7087.22)
            {
                pinss = 14;
                inss = SB * (pinss / 100);
                txtInss.Text = inss.ToString();
            }
            else
            {
                inss = 828.38;
                txtInss.Text = inss.ToString();
            }
            if(SB <= 1903.38)
            {
                irrf = 0;
                txtIrrf.Text = irrf.ToString();
            }
        else if(SB <= 2826.65)
            {
                pirrf = 7.5;
                irrf = (SB * (pirrf / 100)) - 142.8;
                txtIrrf.Text = irrf.ToString();
            }
        else if(SB <= 3751.05)
            {
                pirrf = 15;
                irrf = (SB * (pirrf / 100)) - 354.80;
                txtIrrf.Text = irrf.ToString();
            }
        else if(SB <= 4664.08)
            {
                pirrf = 22.5;
                irrf = (SB * (pirrf / 100)) - 636.13;
                txtIrrf.Text = irrf.ToString();
            }
            else
            {
                pirrf = 27.5;
                irrf = (SB * (pirrf / 100)) - 869.36;
                txtIrrf.Text = irrf.ToString();
            }
            SL = SB - inss - irrf;
            txtSL.Text = SL.ToString();
        }


    }
}
