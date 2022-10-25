using SARASWEB.Frontend.Transversal.DTO.ListasGeneralesDTO;
using SARASWEB.Frontend.Transversal.DTO.RespuestaDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.TipoDocumentoAplicacion
{
    public interface ITipoDocumentoAplicacion
    {
        Task<RespuestaDTO<IEnumerable<TipoDocumentoDTO>>> ObtenerTipoDocumento();
    }
}
