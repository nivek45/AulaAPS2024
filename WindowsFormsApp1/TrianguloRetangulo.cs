using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TrianguloRetangulo : Triangulo
    {
		private double cateto1;

        public double Cateto1
		{
			get { return cateto1; }
			set { cateto1 = value; }
		}

		private double cateto2;

		public double Cateto2
		{
			get { return cateto2; }
			set { cateto2 = value; }
		}
		public override double CalcularArea()
		{
			return CalcularArea();
		}
		public override double CalcularPerimetro()
        {
            cateto1 = System.Math.Pow(cateto1, 2);
            cateto2 = System.Math.Pow(cateto2, 2);
            double hipotenusa = cateto1 + cateto2;
			hipotenusa = System.Math.Sqrt(hipotenusa);
            cateto1 = System.Math.Sqrt(cateto1);
            cateto1 = System.Math.Sqrt(cateto2);
			return cateto1 + cateto2 + hipotenusa;

        }

    }
}
