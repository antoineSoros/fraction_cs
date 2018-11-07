using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionDemo
{
    class ButtonLoupe : Button
    {


        public Boolean Loupe{ get; set; }

        public ButtonLoupe(bool loupe)
        {
            Loupe = loupe;

            this.MouseEnter += grossir;
        }

        public ButtonLoupe() : base()
        {
            this.MouseEnter += grossir;
        }

        public void grossir(Object sender , EventArgs e)
        {
            int Heigthdef = this.Height;
            int WidthDef = this.Width;
            
            if (Loupe)
            {
                this.Height =Heigthdef*2;
                this.Width = Width *2;
                this.Top -= Heigthdef/2;
                this.Left -= WidthDef / 2;

                
            }

        }


         public void retablir(Object sender, EventArgs e)
        {

        }




    }
}
