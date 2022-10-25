using SARASWEB.Frontend.Transversal.DTO.RespuestaDTO;
using SARASWEB.Frontend.Transversal.DTO.SeguridadDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.PD
{
    public interface IGenericaPersistenciaDatos
    {
        Task<RespuestaDTO<bool>> Post<T>(T entity, string Uri, string jwt = null) where T : class;
        Task<RespuestaDTO<T>> Get<T>(string uri, string jwt = null) where T : class;
        Task<RespuestaDTO<IEnumerable<T>>> GetAll<T>(string uri, string jwt = null) where T : class;
        Task<RespuestaDTO<bool>> GetBool(string uri, string jwt = null);
        Task<RespuestaDTO<bool>> Ping(string uri);
        Task<RespuestaDTO<bool>> Put<T>(T entity, string Uri, string jwt = null) where T : class;
        Task<RespuestaDTO<SesionPELDTO>> Login<T>(T entity, string Uri) where T : class;
        Task<RespuestaDTO<T>> Post<T, Y>(Y entity, string Uri, string jwt = null) where T : class;
        Task<RespuestaDTO<IEnumerable<T>>> Post<T, Y>(string Uri, Y entity, string jwt = null) where T : class;
    }
}
