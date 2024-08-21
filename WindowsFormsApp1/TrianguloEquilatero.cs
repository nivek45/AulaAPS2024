using System;

namespace WindowsFormsApp1
{
    internal class TrianguloEquilatero
    {
        private double _lado;

        public double Lado
        {
            get { return _lado; }
            set { _lado = value; }
        }

        public double CalcularArea()
        {
            double area = (Math.Sqrt(3) / 4) * Math.Pow(_lado, 2);
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 3 * _lado;
            return perimetro;
        }
    }
}
