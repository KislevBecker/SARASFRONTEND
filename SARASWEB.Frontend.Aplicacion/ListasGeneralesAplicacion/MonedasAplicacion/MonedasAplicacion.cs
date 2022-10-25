using SARASWEB.Frontend.PD;
using SARASWEB.Frontend.Transversal.DTO.ListasGeneralesDTO;
using SARASWEB.Frontend.Transversal.DTO.RespuestaDTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.Aplicacion.ListasGeneralesAplicacion.MonedasAplicacion
{
    public class MonedasAplicacion : IMonedasAplicacion
    {
        private readonly IGenericaPersistenciaDatos genericaPersistenciaDatos;

        public MonedasAplicacion(IGenericaPersistenciaDatos genericaPersistenciaDatos)
        {
            this.genericaPersistenciaDatos = genericaPersistenciaDatos;
        }
        public async Task<RespuestaDTO<IEnumerable<MonedasDTO>>> ObtenerMonedas()
        {
            try
            {
                return await genericaPersistenciaDatos
                    .GetAll<MonedasDTO>($"/api/ListasGenerales/obtener-monedas");
            }
            catch (Exception)
            {

                return new RespuestaDTO<IEnumerable<MonedasDTO>>
                {
                    Mensaje = "Ocurrio un error interno",
                    Codigo = 500
                };
            }
        }
    }
}
