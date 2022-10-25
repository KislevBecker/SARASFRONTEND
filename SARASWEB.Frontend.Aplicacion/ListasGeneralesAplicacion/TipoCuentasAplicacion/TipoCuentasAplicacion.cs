using SARASWEB.Frontend.PD;
using SARASWEB.Frontend.Transversal.DTO.ListasGeneralesDTO;
using SARASWEB.Frontend.Transversal.DTO.RespuestaDTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.TipoCuentasAplicacion
{
    public class TipoCuentasAplicacion : ITipoCuentasAplicacion
    {
        private readonly IGenericaPersistenciaDatos genericaPersistenciaDatos;

        public TipoCuentasAplicacion(IGenericaPersistenciaDatos genericaPersistenciaDatos)
        {
            this.genericaPersistenciaDatos = genericaPersistenciaDatos;
        }
        public async Task<RespuestaDTO<IEnumerable<TipoCuentasDTO>>> ObtenerTipoCuentas()
        {
            try
            {
                return await genericaPersistenciaDatos
                    .GetAll<TipoCuentasDTO>($"/api/ListasGenerales/obtener-tipo-cuenta");
            }
            catch (Exception)
            {

                return new RespuestaDTO<IEnumerable<TipoCuentasDTO>>
                {
                    Mensaje = "Ocurrio un error interno",
                    Codigo = 500
                };
            }
        }
    }
}
