using CodingChallengeCore.Data.Classes.Idiomas;

namespace CodingChallengeCore.Data
{
    public interface ITraducible
    {
        string ObtenerTitulo();

        string ObtenerVacio();

        string ObtenerLinea(System.Type tipo, int cantidad, decimal area, decimal perimetro);

        string ObtenerTotales(int cantidades, decimal areas, decimal perimetro);
    }
}