using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CodingChallengeCore.Data.Classes.Idiomas
{
    public class Portugues : ITraducible
    {
        private Dictionary<System.Type, string> traductor = new Dictionary<Type, string>();

        public Portugues()
        {
            traductor.Add(Type.GetType("CodingChallengeCore.Data.Classes.Circulo"), "Círculo|Círculos");
            traductor.Add(Type.GetType("CodingChallengeCore.Data.Classes.Cuadrado"), "Quadrado|Quadrados");
            traductor.Add(Type.GetType("CodingChallengeCore.Data.Classes.TrianguloEquilatero"), "Triângulo|Triângulos");
            traductor.Add(Type.GetType("CodingChallengeCore.Data.Classes.Rectangulo"), "Retângulo|Retângulos");
            traductor.Add(Type.GetType("CodingChallengeCore.Data.Classes.TrapecioIsosceles"), "Trapézio|Trapézios");
        }
        
        public string ObtenerLinea(Type tipo, int cantidad, decimal area, decimal perimetro)
        {
            return $"{cantidad} {GetNombre(tipo, cantidad)} | Area {String.Format(new CultureInfo("es-AR"), "{0:#.##}", area)} | Perímetro {String.Format(new CultureInfo("es-AR"), "{0:#.##}", perimetro)} <br/>";
        }

        public string ObtenerTitulo()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public string ObtenerTotales(int cantidades, decimal areas, decimal perimetro)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("TOTAL:<br/>");
            sb.Append(cantidades + " " + "formas" + " ");
            sb.Append("Perímetro " + String.Format(new CultureInfo("es-AR"), "{0:#.##} ", perimetro));
            sb.Append("Area " + String.Format(new CultureInfo("es-AR"), "{0:#.##}", areas));

            return sb.ToString();
        }

        public string ObtenerVacio()
        {
            return "<h1>Lista vazia de formas!</h1>";
        }

        private string GetNombre(Type tipo, int cantidad)
        {
            string valor = "";
            traductor.TryGetValue(tipo, out valor);
            return cantidad == 1 ? valor.Split('|')[0] : valor.Split('|')[1];
        }
    }
}