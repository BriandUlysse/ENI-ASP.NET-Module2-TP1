using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModule2
{
    public class Triangle : Forme
    {
        private int a;
        private int b;
        private int c;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public override float calculateAire()
        {
            float halfPerimeter = calculatePerimeter()/2;

            return (float)Math.Sqrt(halfPerimeter*(halfPerimeter-a)*(halfPerimeter-b)*(halfPerimeter-c));
        }

        public override float calculatePerimeter()
        {
            return a + b + c;
        }

        public override string ToString()
        {
            String res = "Triangle de côté A=" + a + " B=" + b + " C=" + c;
            res += "\n Aire=" + calculateAire();
            res += "\n Périmètre=" + calculatePerimeter();

            return res;
        }
    }
}
