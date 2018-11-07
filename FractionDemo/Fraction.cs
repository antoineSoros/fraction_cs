using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionDemo
{
    class Fraction
    {
        public event EventHandler isInteger;
        #region//propriete et constructeur
        private Int32 _denominateur;
        private Int32 _numerateur;//convention de nommage on place un _ avnt le nom quand celle-ci est privee.
        public Int32 numerateur  //on cree la variable en public pour creer les getter setter.

        {
            set
            {
                _numerateur = value;
                if (isInteger != null)
                {
                    if (denominateur != 0 && numerateur % denominateur == 0)
                    {
                        isInteger(this, new EventArgs());
                    }
                   
                    
                }

            }

            get { return _numerateur; }
        }

        public Int32 denominateur
        {
            get { return _denominateur; }

            set
            {
              
                _denominateur = value;

                if (denominateur == 0)
                {
                    throw new FractionException();
                }

                if (isInteger != null)
                {
                    if (numerateur % denominateur == 0)
                    {
                        isInteger(this, new EventArgs());
                    }
                  
                }
            }
        }
        static int i = 0;
        public String nom { get; set; }

        public Fraction(int numerateur, int denominateur, string nom) : this(numerateur, denominateur)
        {


            this.nom = nom;
            i++;

            nom = "Fraction" + i.ToString();





        }

        public Fraction()
        {
            i++;

            nom = "Fraction" + i.ToString();
        }

        public Fraction(int numerateur, int denominateur)
        {
            this.numerateur = numerateur;
            this.denominateur = denominateur;
            this.nom = nom;
            i++;

            nom = "Fraction" + i.ToString();
        }
        #endregion

        //// ~Fraction()
        // {
        ////     MessageBox.Show("badaoum");
        // }

        //Attention utilisation de ces proprietes
        //  Fraction f = new Fraction(); creation de l'objet.
        //f.numerateur=5; pour activer le setters
        //int n =f.numerateur; pour activer getters
        /// <summary>
        /// Propiete en lecture seule.
        /// </summary>
        /// 


        #region//methodes
        public double valeur { get { return (Double)numerateur / (Double)denominateur; } }

        public string Nom { get => nom; set => nom = value; }

        public void inverser()
        {

            Int32 buffer = numerateur;
            numerateur = denominateur;

            denominateur = buffer;



        }

        public String toText()
        {


            if (denominateur == 1)
            {
                String str = numerateur.ToString();
                return str;
            }
            else
            {
                String str = numerateur.ToString() + "/" + denominateur.ToString();
                return str;
            }

        }
        private int PGCD()
        {
            Int32 num = numerateur;
            Int32 denum = denominateur;

            while (true)
            {
                int temp = num % denum;
                if (temp == 0)
                {
                    break;
                }

                num = denum;
                denum = temp;

            }
            return denum;

        }

        public void simplifier()

        {
            Int32 p = PGCD();
            numerateur = numerateur / p;
            denominateur = denominateur / p;





        }


        static Fraction parse(String s)
        {
            char separator = '/';
            String[] tabNumDenum = s.Split(separator);


            Int32 num = Int32.Parse(tabNumDenum[0]);
            Int32 denum = Int32.Parse(tabNumDenum[1]);
            Fraction f = new Fraction(num, denum);

            return f;
        }


        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Int32 numResult = (f1.numerateur * f2.denominateur) + (f2.numerateur * f1.denominateur);
            Int32 denumResult = f2.denominateur * f1.denominateur;
            Fraction result = new Fraction(numResult, denumResult);
            result.simplifier();
            return result;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Int32 numResult = (f1.numerateur * f2.denominateur) - (f2.numerateur * f1.denominateur);
            Int32 denumResult = f2.denominateur * f1.denominateur;
            Fraction result = new Fraction(numResult, denumResult);
            result.simplifier();
            return result;

        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Int32 numResult = f1.numerateur * f2.numerateur;
            Int32 denumResult = f1.denominateur * f2.denominateur;

            Fraction result = new Fraction(numResult, denumResult);
            result.simplifier();
            return result;
        }

        public static Fraction operator *(Fraction f1, Int32 n)
        {
            Int32 numResult = f1.numerateur * n;
            Fraction result = new Fraction(numResult, f1.denominateur);

            return result;
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Int32 numResult = f1.numerateur * f2.denominateur;
            Int32 denumResult = f1.denominateur * f2.numerateur;
            Fraction result = new Fraction(numResult, denumResult);
            result.simplifier();
            return result;

        }

        public static Fraction operator /(Fraction f1, Int32 n)
        {
            Int32 numResult = f1.numerateur;
            Int32 denumResult = f1.denominateur * n;
            Fraction result = new Fraction(numResult, denumResult);
            result.simplifier();
            return result;

        }

        public static Boolean operator ==(Fraction f1, Fraction f2)
        {
            Fraction f1bis = new Fraction(f1.numerateur, f1.denominateur);
            Fraction f2bis = new Fraction(f2.numerateur, f2.denominateur);
            f1bis.simplifier();
            f2bis.simplifier();




            return (f1bis.numerateur == f2bis.numerateur && f2bis.denominateur == f1bis.denominateur);
        }

        public static Boolean operator !=(Fraction f1, Fraction f2)
        {
            Fraction f1bis = new Fraction(f1.numerateur, f1.denominateur);
            Fraction f2bis = new Fraction(f2.numerateur, f2.denominateur);
            f1bis.simplifier();
            f2bis.simplifier();


            return (f1bis.numerateur != f2bis.numerateur || f1bis.denominateur != f2bis.denominateur);
        }

        #endregion
    }

}
