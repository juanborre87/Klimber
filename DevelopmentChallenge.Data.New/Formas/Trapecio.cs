using DevelopmentChallenge.Data.New.Classes;

namespace DevelopmentChallenge.Data.New.Formas
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal  baseMayor;
        private readonly decimal baseMenor;
        private readonly decimal altura;
        private readonly decimal lado1;
        private readonly decimal lado2;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal lado1, decimal lado2)
        {
            this.baseMayor = baseMayor;
            this.baseMenor = baseMenor;
            this.altura = altura;
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public override decimal CalcularArea()
        {
            return ((baseMayor + baseMenor) / 2) * altura;
        }

        public override decimal CalcularPerimetro()
        {
            return baseMayor + baseMenor + lado1 + lado2;
        }
    }
}
