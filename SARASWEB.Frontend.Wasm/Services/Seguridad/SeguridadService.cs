using SARASWEB.Frontend.Transversal.DTO.SeguridadDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.Wasm.Services.Seguridad
{
    public class SeguridadService : ISeguridadService
    {
        public SeguridadService()
        {

        }
        public Task CerrarSesison()
        {
            throw new NotImplementedException();
        }

        public Task IniciarSesion(IniciarSesionDTO iniciarSesionDTO)
        {
            throw new NotImplementedException();
        }

        public Task<SesionPELDTO> ObtenerSesion()
        {
            throw new NotImplementedException();
        }
    }
}
