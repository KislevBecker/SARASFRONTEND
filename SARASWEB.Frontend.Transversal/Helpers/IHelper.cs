using System.Net.Http;

namespace SARASWEB.Frontend.Transversal.Helpers
{
    public interface IHelper
    {
        int[] Errores { get; set; }
        StringContent JsonToStringContent<T>(T entity);
        bool ValidarModelo(object modelo);
        string FormateadorDecimales(string monto);
        string obtenerComision(string parametro);
    }
}
