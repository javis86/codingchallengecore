using System;
using System.Collections.Generic;
using CodingChallengeCore.Data.Classes;
using CodingChallengeCore.Data.Classes.Idiomas;
using NUnit.Framework;

namespace CodingChallengeCore.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), new Castellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), new Ingles()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> {new Cuadrado(5)};

            var resumen = FormaGeometrica.Imprimir(cuadrados, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioIsosceles()
        {
            var trapecio = new List<FormaGeometrica> { new TrapecioIsosceles(2, 3, 5) };

            var resumen = FormaGeometrica.Imprimir(trapecio, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 6,5 | Perimetro 15,2 <br/>TOTAL:<br/>1 formas Perimetro 15,2 Area 6,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(1.5m),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(1.375m),
                new TrianguloEquilatero(4.2m),
                new TrapecioIsosceles(2, 3, 5)
            };

            var resumen = FormaGeometrica.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>1 Trapezoid | Area 6,5 | Perimeter 15,2 <br/>TOTAL:<br/>8 shapes Perimeter 112,86 Area 98,15",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(1.5m),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(1.375m),
                new TrianguloEquilatero(4.2m),
                new Rectangulo(2, 4),
                new TrapecioIsosceles(2, 3, 5)
            };

            var resumen = FormaGeometrica.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>1 Rectángulo | Area 8 | Perimetro 12 <br/>1 Trapecio | Area 6,5 | Perimetro 15,2 <br/>TOTAL:<br/>9 formas Perimetro 124,86 Area 106,15",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnPortugues()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(1.5m),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(1.375m),
                new TrianguloEquilatero(4.2m),
                new Rectangulo(2, 4),
                new TrapecioIsosceles(2, 3, 5)
            };

            var resumen = FormaGeometrica.Imprimir(formas, new Portugues());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Quadrados | Area 29 | Perímetro 28 <br/>2 Círculos | Area 13,01 | Perímetro 18,06 <br/>3 Triângulos | Area 49,64 | Perímetro 51,6 <br/>1 Retângulo | Area 8 | Perímetro 12 <br/>1 Trapézio | Area 6,5 | Perímetro 15,2 <br/>TOTAL:<br/>9 formas Perímetro 124,86 Area 106,15",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectanguloEnCastellano()
        {
            var rectangulo = new List<FormaGeometrica> { new Rectangulo(2, 4) };

            var resumen = FormaGeometrica.Imprimir(rectangulo, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Area 8 | Perimetro 12 <br/>TOTAL:<br/>1 formas Perimetro 12 Area 8", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var rectangulo = new List<FormaGeometrica> { new Rectangulo(2, 4) };

            var resumen = FormaGeometrica.Imprimir(rectangulo, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>1 Rectangle | Area 8 | Perimeter 12 <br/>TOTAL:<br/>1 shapes Perimeter 12 Area 8", resumen);
        }
    }
}
