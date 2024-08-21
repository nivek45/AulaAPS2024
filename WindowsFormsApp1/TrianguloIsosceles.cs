using System;

namespace WindowsFormsApp1
{
    public class TrianguloIsosceles
    {
        private double _lado;
        private double _base;

        public double Lado
        {
            get { return _lado; }
            set { _lado = value; }
        }

        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public double CalcularArea()
        {
            double altura = Math.Sqrt(Math.Pow(_lado, 2) - Math.Pow(_base / 2, 2));
            double area = (_base * altura) / 2;
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 2 * _lado + _base;
            return perimetro;
        }
    }
}
