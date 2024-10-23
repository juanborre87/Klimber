using DevelopmentChallenge.Data.New.Formas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.New.Classes
{
    public enum Idioma
    {
        Castellano = 1,
        Ingles = 2,
        Italiano = 3
    }

    public class Traduccion
    {
        public static void Traduction(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Ingles:
                    break;
                case Idioma.Castellano:
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
                    break;
                case Idioma.Italiano:
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("it");
                    break;
            }

        } 
    }
}
