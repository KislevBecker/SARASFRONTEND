using SARASWEB.Frontend.PD;
using SARASWEB.Frontend.Transversal.DTO.ListasGeneralesDTO;
using SARASWEB.Frontend.Transversal.DTO.RespuestaDTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.TipoDocumentoAplicacion
{
    public class TipoDocumentoAplicacion : ITipoDocumentoAplicacion
    {
        private readonly IGenericaPersistenciaDatos genericaPersistenciaDatos;

        public TipoDocumentoAplicacion(IGenericaPersistenciaDatos genericaPersistenciaDatos)
        {
            this.genericaPersistenciaDatos = genericaPersistenciaDatos;
        }
        public async Task<RespuestaDTO<IEnumerable<TipoDocumentoDTO>>> ObtenerTipoDocumento()
        {
            try
            {
                return await genericaPersistenciaDatos
                    .GetAll<TipoDocumentoDTO>($"/api/ListasGenerales/obtener-tipo-documento");
            }
            catch (Exception)
            {

                return new RespuestaDTO<IEnumerable<TipoDocumentoDTO>>
                {
                    Mensaje = "Ocurrio un error interno",
                    Codigo = 500
                };
            }
        }
    }
}
