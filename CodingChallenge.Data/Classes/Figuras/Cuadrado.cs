namespace CodingChallengeCore.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        private decimal _anchoLado;
        public Cuadrado(decimal ancho ) 
        {
            this._anchoLado = ancho;
        } 

        public override decimal CalcularArea()
        {
            return _anchoLado * _anchoLado;
        }

        public override decimal CalcularPerimetro()
        {
            return _anchoLado * 4;
        }
    }
}