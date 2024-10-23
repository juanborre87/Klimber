using DevelopmentChallenge.Data.New.Classes;

namespace DevelopmentChallenge.Data.New.Formas
{
    public class Rectangulo : FormaGeometrica
    {
        private readonly decimal ancho;
        private readonly decimal alto;

        public Rectangulo(decimal ancho, decimal alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public override decimal CalcularArea()
        {
            return alto * ancho;
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * (ancho + alto);
        }
    }
}
