using DevelopmentChallenge.Data.New.Classes;
using System;

namespace DevelopmentChallenge.Data.New.Formas
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal lado;

        public TrianguloEquilatero(decimal lado)
        {
            this.lado = lado;
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * lado * lado;
        }

        public override decimal CalcularPerimetro()
        {
            return 3 * lado;
        }
    }
}
