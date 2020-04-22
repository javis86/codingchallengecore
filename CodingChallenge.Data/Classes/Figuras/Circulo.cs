using System;
using System.Collections.Generic;
using CodingChallengeCore.Data.Classes.Idiomas;

namespace CodingChallengeCore.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        private decimal _radio;
       

        public Circulo(decimal radio)
        {
            this._radio = radio;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * _radio * _radio;
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _radio * 2;
        }

    }
}