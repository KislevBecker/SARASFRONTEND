using SARASWEB.Frontend.Transversal.DTO.SeguridadDTO;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.Wasm.Services.Seguridad
{
    public interface ISeguridadService
    {
        Task CerrarSesison();
        Task IniciarSesion(IniciarSesionDTO iniciarSesionDTO);
        Task<SesionPELDTO> ObtenerSesion();
    }
}
