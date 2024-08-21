using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Circunferencia : FormaGeometrica
    {
            private double largura;

            public double Largura
            {
                get { return largura; }
                set { largura = value; }
            }

            private double altura;

            public double Altura
            {
                get { return altura; }
                set { altura = value; }
            }


            public override double CalcularArea()
            {
                double area = largura * altura;
                return area;
            }

            public override double CalcularPerimetro()
            {
                double perimetro = 2 * (largura + altura);
                return perimetro;
            }


    }
}
