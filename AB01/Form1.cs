using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB01
{
    public partial class frmTaschenrechner : Form
    {
        double zahl1;
        double zahl2;
        double ergebnis;

        public frmTaschenrechner()
        {
            InitializeComponent();
        }

        private void frmTaschenrechner_Load(object sender, EventArgs e)
        {

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(txtOperand1.Text);
            zahl2 = Convert.ToDouble(txtOperand2.Text);
            ergebnis = zahl1 + zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);

            lblOperator.Text = "+";
        }

        private void btnSubtraktion_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(txtOperand1.Text);
            zahl2 = Convert.ToDouble(txtOperand2.Text);
            ergebnis = zahl1 - zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);

            lblOperator.Text = "-";
        }

        private void btnMultiplikation_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(txtOperand1.Text);
            zahl2 = Convert.ToDouble(txtOperand2.Text);
            ergebnis = zahl1 * zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);

            lblOperator.Text = "*";
        }

        private void btnMittelwert_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(txtOperand1.Text);
            zahl2 = Convert.ToDouble(txtOperand2.Text);
            ergebnis = (zahl1 + zahl2) / 2;
            lblErgebnis.Text = Convert.ToString(ergebnis);

            lblOperator.Text = "|";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(txtOperand1.Text);
            zahl2 = Convert.ToDouble(txtOperand2.Text);
            ergebnis = zahl1 / zahl2;
            lblErgebnis.Text = Convert.ToString(ergebnis);

            lblOperator.Text = "/";
        }

        private void btnPotenz_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(txtOperand1.Text);
            zahl2 = Convert.ToDouble(txtOperand2.Text);
            ergebnis = Math.Pow(zahl1, zahl2);
            lblErgebnis.Text = Convert.ToString(ergebnis);

            lblOperator.Text = "/";
        }

        private void Max_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(txtOperand1.Text);
            zahl2 = Convert.ToDouble(txtOperand2.Text);
            if (zahl1 > zahl2)
            {
                ergebnis = zahl1;
            }
            else
            {
                ergebnis = zahl2; 
            }
            lblErgebnis.Text = Convert.ToString(ergebnis);
        }

        private void Min_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(txtOperand1.Text);
            zahl2 = Convert.ToDouble(txtOperand2.Text);
            if (zahl1 < zahl2)
            {
                ergebnis = zahl1;
            }
            else
            {
                ergebnis = zahl2;
            }
            lblErgebnis.Text = Convert.ToString(ergebnis);
        }
    }
}
