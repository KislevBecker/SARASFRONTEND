using SARASWEB.Frontend.Transversal.DTO.ListasGeneralesDTO;
using SARASWEB.Frontend.Transversal.DTO.RespuestaDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.MonedasAplicacion
{
    public interface IMonedasAplicacion
    {
        Task<RespuestaDTO<IEnumerable<MonedasDTO>>> ObtenerMonedas();
    }
}
