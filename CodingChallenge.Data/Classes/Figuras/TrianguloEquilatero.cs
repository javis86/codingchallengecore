using System;

namespace CodingChallengeCore.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private decimal _lado;
        public TrianguloEquilatero(decimal lado)
        {
            this._lado = lado;
        }
        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
    }
}