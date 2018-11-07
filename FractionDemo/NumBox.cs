using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionDemo
{
    class NumBox : TextBox
    {

        public Double Mini { get; set; }
        public Double Maxi { get; set; }

        public NumBox()
        {
            this.Validating += isConform;
        }

        public NumBox(double mini, double maxi) : base()
        {

            Mini = mini;
            Maxi = maxi;
            this.Validating += isConform;
        }
        private void isConform(object sender, CancelEventArgs e)
        {
            double saisie;
            bool ok = Double.TryParse(this.Text, out saisie);
            if (ok)
            {
                if (!this.estDansIntervalle(saisie))
                {
                    this.BackColor = Color.Red;
                    e.Cancel = true;

                }
                else
                {
                    this.BackColor = Color.LightGreen;
                }
            }
            else
            {
                MessageBox.Show("entree invalide");
            }

        }
        public Boolean estDansIntervalle(Double n)
        {
            if (n >= Mini && n <= Maxi)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }  
}
