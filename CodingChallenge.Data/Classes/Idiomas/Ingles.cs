using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CodingChallengeCore.Data.Classes.Idiomas
{
    public class Ingles : ITraducible
    {
        private Dictionary<System.Type, string> traductor = new Dictionary<Type, string>();

        public Ingles()
        {
            traductor.Add(Type.GetType("CodingChallengeCore.Data.Classes.Circulo"), "Circle|Circles");
            traductor.Add(Type.GetType("CodingChallengeCore.Data.Classes.Cuadrado"), "Square|Squares");
            traductor.Add(Type.GetType("CodingChallengeCore.Data.Classes.TrianguloEquilatero"), "Triangle|Triangles");
        }

        public string ObtenerLinea(Type tipo, int cantidad, decimal area, decimal perimetro)
        {
            return $"{cantidad} {GetNombre(tipo, cantidad)} | Area {String.Format(new CultureInfo("es-AR"), "{0:#.##}", area)} | Perimeter {String.Format(new CultureInfo("es-AR"), "{0:#.##}", perimetro)} <br/>";
        }

        private string GetNombre(Type tipo, int cantidad)
        {
            string valor = "";
            traductor.TryGetValue(tipo, out valor);
            return cantidad == 1 ? valor.Split('|')[0] : valor.Split('|')[1];
        }

        public string ObtenerTitulo()
        {
            return "<h1>Shapes report</h1>";
        }

        public string ObtenerTotales(int cantidades, decimal areas, decimal perimetro)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("TOTAL:<br/>");
            sb.Append(cantidades + " " + "shapes" + " ");
            sb.Append("Perimeter " + String.Format(new CultureInfo("es-AR"), "{0:#.##} ", perimetro));
            sb.Append("Area " + String.Format(new CultureInfo("es-AR"), "{0:#.##}", areas));

            return sb.ToString();
        }

        public string ObtenerVacio()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

    }
}