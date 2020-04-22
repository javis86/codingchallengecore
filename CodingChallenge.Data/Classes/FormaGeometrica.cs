/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallengeCore.Data
{
    public abstract class FormaGeometrica
    {
       
        public static string Imprimir(List<FormaGeometrica> formas, ITraducible idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(idioma.ObtenerVacio());                
            }
            else
            {
                // HEADER
                sb.Append(idioma.ObtenerTitulo());

                Dictionary<System.Type, int> cantidades = new Dictionary<System.Type, int>();
                Dictionary<System.Type, decimal> areas = new Dictionary<System.Type, decimal>();
                Dictionary<System.Type, decimal> perimetros = new Dictionary<System.Type, decimal>();

                var areasTotales = 0m;
                var perimetrosTotales = 0m;
                var cantidadesTotales = 0;
                
                // Sumatorias parciales
                for (var i = 0; i < formas.Count; i++)
                {
                    cantidadesTotales++;
                    
                    int entero;

                    //Console.WriteLine("formas[i].GetType()" + formas[i].GetType().ToString());

                    if(!cantidades.TryGetValue(formas[i].GetType(), out entero)){
                        cantidades.Add(formas[i].GetType(), 1);
                    
                        decimal areaParcial = formas[i].CalcularArea();
                        areas.Add(formas[i].GetType(), areaParcial);
                        areasTotales += areaParcial;

                        decimal perimetroParcial = formas[i].CalcularPerimetro();
                        perimetros.Add(formas[i].GetType(), perimetroParcial);
                        perimetrosTotales += perimetroParcial;

                        Console.WriteLine($"{formas[i].GetType().ToString()} - Area : {areaParcial.ToString()} - Perimetro {perimetroParcial} ");
                    }
                    else
                    {
                        cantidades[formas[i].GetType()]++;

                        decimal areaParcial = formas[i].CalcularArea();
                        areas[formas[i].GetType()] += areaParcial;
                        areasTotales += areaParcial;

                        decimal perimetroParcial = formas[i].CalcularPerimetro();
                        perimetros[formas[i].GetType()] += perimetroParcial;
                        perimetrosTotales += perimetroParcial;

                        //areas[formas[i].GetType()] += areasTotales += formas[i].CalcularArea();
                        //perimetros[formas[i].GetType()] += perimetrosTotales += formas[i].CalcularPerimetro();
                        Console.WriteLine($"{formas[i].GetType().ToString()} - Area : {areaParcial.ToString()} - Perimetro {perimetroParcial} ");
                    }
                    

                    
                    
                }

                // Impresiones
                int idx = 0;
                for(idx = 0; idx < cantidades.Keys.Count; idx++){                    
                    Type key = cantidades.Keys.ElementAt(idx);
                    Console.WriteLine("Type " + key.ToString());
                    sb.Append(idioma.ObtenerLinea(key, cantidades[key], areas[key], perimetros[key]));
                    
                }

                // FOOTER
                sb.Append(idioma.ObtenerTotales(cantidadesTotales, areasTotales, perimetrosTotales));
            }

            return sb.ToString();
        }

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
     
    }
}
