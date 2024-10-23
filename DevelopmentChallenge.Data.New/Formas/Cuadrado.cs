using DevelopmentChallenge.Data.New.Classes;
using System;

namespace DevelopmentChallenge.Data.New.Formas
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal lado;

        public Cuadrado(decimal lado)
        {
            this.lado = lado;
        }

        public override decimal CalcularArea()
        {
            return lado * lado;
        }

        public override decimal CalcularPerimetro()
        {
            return lado * 4;
        }
    }
}
