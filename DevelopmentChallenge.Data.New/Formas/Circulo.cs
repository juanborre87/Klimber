using DevelopmentChallenge.Data.New.Classes;
using System;

namespace DevelopmentChallenge.Data.New.Formas
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal radio;

        public Circulo(decimal radio)
        {
            this.radio = radio;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (radio / 2) * (radio / 2); ;
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * radio;
        }
    }
}
