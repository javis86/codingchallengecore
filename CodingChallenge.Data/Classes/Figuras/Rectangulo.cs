namespace CodingChallengeCore.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        private decimal _base;
        private decimal _altura;

        public Rectangulo(decimal baase, decimal altura)
        {
            this._altura = altura;
            this._base = baase;
        }

        public override decimal CalcularArea()
        {
            return _base * _altura;
        }

        public override decimal CalcularPerimetro()
        {
            return _base * 2 + _altura * 2;
        }
    }
}