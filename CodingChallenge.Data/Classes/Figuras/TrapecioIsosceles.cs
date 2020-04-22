using System;

namespace CodingChallengeCore.Data.Classes
{
    public class TrapecioIsosceles : FormaGeometrica
    {
        private decimal _baseMenor;
        private decimal _baseMayor;
        private decimal _altura;

        public TrapecioIsosceles(decimal baseMenor, decimal baseMayor, decimal altura)
        {
            this._altura = altura;
            this._baseMenor = baseMenor;
            this._baseMayor  = baseMayor;
        }

        public override decimal CalcularArea()
        {
            return (_baseMayor + _baseMenor * _altura)/2;
        }

        public override decimal CalcularPerimetro()
        {
            return _baseMenor + _baseMayor + 2 * CalcularLado();
        }

        private decimal CalcularLado(){
            decimal baseTrianguloRecto = Math.Abs(_baseMayor - _baseMenor);

            // pitagoras
            return Convert.ToDecimal(Math.Sqrt( Math.Pow(Convert.ToDouble(baseTrianguloRecto), 2) + Math.Pow(Convert.ToDouble(_altura), 2)));
        }
    }
}