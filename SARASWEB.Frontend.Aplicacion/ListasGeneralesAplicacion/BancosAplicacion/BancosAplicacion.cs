using SARASWEB.Frontend.PD;
using SARASWEB.Frontend.Transversal.DTO.ListasGeneralesDTO;
using SARASWEB.Frontend.Transversal.DTO.RespuestaDTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.BancosAplicacion
{
    public class BancosAplicacion : IBancosAplicacion
    {
        private readonly IGenericaPersistenciaDatos genericaPersistenciaDatos;

        public BancosAplicacion(IGenericaPersistenciaDatos genericaPersistenciaDatos)
        {
            this.genericaPersistenciaDatos = genericaPersistenciaDatos;
        }
        public async Task<RespuestaDTO<IEnumerable<BancosDTO>>> ObtenerBancos()
        {
            try
            {
                return await genericaPersistenciaDatos
                    .GetAll<BancosDTO>($"/api/ListasGenerales/obtener-bancos");
            }
            catch (Exception)
            {

                return new RespuestaDTO<IEnumerable<BancosDTO>>
                {
                    Mensaje = "Ocurrio un error interno",
                    Codigo = 500
                };
            }
        }
    }
}
