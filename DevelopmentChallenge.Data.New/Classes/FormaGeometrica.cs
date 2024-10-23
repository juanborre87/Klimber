using DevelopmentChallenge.Data.New.Idiomas;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.New.Classes
{
    public abstract class FormaGeometrica
    {
        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();

        public static string Imprimir(List<FormaGeometrica> formas, Idioma idioma)
        {
            Traduccion.Traduction(idioma);

            var sb = new StringBuilder();
            if (!formas.Any())
            {
                sb.Append(Language.EmptyList);
            }
            else 
            {
                sb.Append(Language.ShapesReport);

                var resumen = formas.GroupBy(f => f.GetType().Name)
                    .Select(g => new
                    {
                        Tipo = g.Key,
                        Cantidad = g.Count(),
                        Area = g.Sum(f => f.CalcularArea()),
                        Perimetro = g.Sum(f => f.CalcularPerimetro())
                    }).ToList();

                foreach (var item in resumen)
                {
                    sb.Append($"{item.Cantidad} {SingularOrPlural(item.Tipo, item.Cantidad)} | {Language.Area} {item.Area:#.##} | {Language.Perimeter} {item.Perimetro:#.##} <br/>");
                }

                var totalCantidad = resumen.Sum(r => r.Cantidad);
                var totalArea = resumen.Sum(r => r.Area);
                var totalPerimetro = resumen.Sum(r => r.Perimetro);

                sb.Append("TOTAL:<br/>");
                sb.Append($"{totalCantidad} {Language.shapes} ");
                sb.Append($"{Language.Perimeter} {totalPerimetro:#.##} ");
                sb.Append($"Area {totalArea:#.##}");
            }

            return sb.ToString();
        }

        private static string SingularOrPlural(string name, int cantidad)
        {
            switch (name)
            {
                case "Circulo":
                    return cantidad == 1 ? Language.Circle : Language.Circles;
                case "Cuadrado":
                    return cantidad == 1 ? Language.Square : Language.Squares;
                case "Rectangulo":
                    return cantidad == 1 ? Language.Rectangle : Language.Rectangles;
                case "Trapecio":
                    return cantidad == 1 ? Language.Trapeze : Language.Trapezes;
                case "TrianguloEquilatero":
                    return cantidad == 1 ? Language.Triangle : Language.Triangles;
            }

            return string.Empty;
        }

    }


}
