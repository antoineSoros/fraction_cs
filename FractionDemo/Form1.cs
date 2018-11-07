using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionDemo
{
    public partial class Form1 : Form

    {
        NumBox num = new NumBox(0.00, 100.00);
        private Fraction f = new Fraction(4,2);
       
        public Form1()
        {
            
        InitializeComponent();
        }
      
        private void proc(Object sender, EventArgs e)
        {
            MessageBox.Show("la fraction a une valeur entiere.");
        }
           
        private void button1_Click_1(object sender, EventArgs e)
        {
            Fraction f = new Centieme(3, 4);
           
           
            MessageBox.Show(f.valeur.ToString());

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Fraction f = new Fraction(3,7);
           
            f.inverser();
            MessageBox.Show(f.toText());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fraction f = new Fraction(12,6);
            
            f.simplifier();
            MessageBox.Show(f.toText());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            for (int n = 1; n < 10; n++)
            {
                Fraction fraction = new Fraction(2, 3);

                str.Append(fraction.nom).Append(" || ");


            }
            ;
            MessageBox.Show(str.ToString());


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fraction f1 = new Fraction(2, 8);
            Fraction f2 = new Fraction(1, 4);
            if (f1 == f2)
            {
                MessageBox.Show(f1.toText() + " " + f2.toText() + " les deux fractions sont égales");
            }
            else
            {
                MessageBox.Show(f1.toText() + " " + f2.toText() + "  sont differentes");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fraction f = new Fraction();

            f.isInteger += proc;
            f.numerateur = 4;
            f.denominateur = 2;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
          
           
            

        

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Centieme cent = new Centieme(3, 4);
           MessageBox.Show( cent.toText());
            MessageBox.Show(cent.ToString());
        }
    }

      

        
    
}
