using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModule2
{
    public class Cercle : Forme
    {
        private int rayon;

        public int Rayon { get => rayon; set => rayon = value; }

        public override float calculateAire()
        {
            return (float)Math.PI * (rayon * rayon);
        }

        public override float calculatePerimeter()
        {
            return 2 * (float)Math.PI * rayon;
        }

        public override string ToString()
        {
            String res = "Cercle de rayon=" + rayon;
            res += "\n Aire=" + calculateAire();
            res += "\n Périmètre=" + calculatePerimeter();

            return res;
        }
    }
}
