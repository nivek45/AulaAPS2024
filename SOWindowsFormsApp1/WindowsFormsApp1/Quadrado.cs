﻿namespace WindowsFormsApp1
{
    public class Quadrado : FormaGeometrica
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double CalcularArea()
        {
            //return lado * lado;
            return System.Math.Pow(lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return lado * 4;
        }
    }
}
