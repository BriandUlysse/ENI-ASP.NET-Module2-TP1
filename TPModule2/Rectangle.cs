using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModule2
{
    public class Rectangle : Forme
    {
        private int longueur;
        private int largeur;

        public int Longueur { get => longueur; set => longueur = value; }
        public int Largeur { get => largeur; set => largeur = value; }

        public override float calculateAire()
        {
            return longueur * largeur;
        }

        public override float calculatePerimeter()
        {
            return (longueur * 2) + (largeur * 2);
        }

        public override string ToString()
        {
            String res =  "Rectangle de longueur=" + longueur + " et largeur=" + largeur;
            res += "\n Aire=" + calculateAire();
            res += "\n Périmètre=" + calculatePerimeter();

            return res;
        }
    }
}
