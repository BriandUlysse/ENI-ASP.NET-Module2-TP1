using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModule2
{
    public class Carre : Rectangle
    {
        public new int Longueur
        {
            get { return base.Longueur; }
            set
            {
                base.Longueur = value;
                this.Largeur = value;
            }
        }

        public override string ToString()
        {
            String res = "Carré de longueur=" + Longueur;
            res += "\n Aire=" + calculateAire();
            res += "\n Périmètre=" + calculatePerimeter();

            return res;
        }
    }
}
