using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionDemo
{
    class Centieme : Fraction
    {
       

      
        new public int denominateur { get;  }

        public Centieme(int n,int d) : base(n,d)
        {
            this.numerateur = n*100/d;
            base.denominateur = 100;
           
        }

        public new String toText()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(numerateur.ToString()).Append("\n___\n").Append("100");
            
        return stringBuilder.ToString();
        }

        public new  string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(numerateur.ToString()).Append("/").Append("100");

            return stringBuilder.ToString();
        }
    }
}
