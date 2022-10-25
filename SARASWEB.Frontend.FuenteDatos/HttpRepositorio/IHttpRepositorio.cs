using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.FuenteDatos.HttpRepositorio
{
    public interface IHttpRepositorio
    {
        Task<Dictionary<string, string>> Get(string uri, string jwt = null);
        Task<Dictionary<string, string>> Post(StringContent stringContent, string uri, string jwt = null);
        Task<Dictionary<string, string>> Put(StringContent stringContent, string uri, string jwt = null);
    }
}
