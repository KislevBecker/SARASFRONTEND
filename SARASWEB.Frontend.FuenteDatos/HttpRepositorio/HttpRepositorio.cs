using Blazored.SessionStorage;
using SARASWEB.Frontend.Transversal.DTO.SeguridadDTO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.FuenteDatos.HttpRepositorio
{
    public class HttpRepositorio : IHttpRepositorio
    {
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService sessionStorageService;

        public HttpRepositorio(HttpClient httpClient, ISessionStorageService sessionStorageService)
        {
            this.httpClient = httpClient;
            this.sessionStorageService = sessionStorageService;
        }
        public async Task<Dictionary<string, string>> Get(string uri, string jwt = null)
        {
            await ValidarJwt();
            var get = await httpClient.GetAsync($"{uri}");
            var json = (await get.Content.ReadAsStringAsync() == null) ? ""
                : await get.Content.ReadAsStringAsync();

            return new Dictionary<string, string>
            {
                { "status", get.StatusCode.ToString() },
                { "json", json }
            };
        }


        public async Task<Dictionary<string, string>> Post(StringContent stringContent, string uri, string jwt = null)
        {
            await ValidarJwt();

            var post = await httpClient.PostAsync($"{uri}", stringContent);
            var json = (await post.Content.ReadAsStringAsync() == null) ? ""
                : await post.Content.ReadAsStringAsync();

            return new Dictionary<string, string>
            {
                { "status", post.StatusCode.ToString() },
                { "json", json }
            };
        }

        public async Task<Dictionary<string, string>> Put(StringContent stringContent, string uri, string jwt = null)
        {
            await ValidarJwt();

            var put = await httpClient.PutAsync($"{uri}", stringContent);
            var json = (await put.Content.ReadAsStringAsync() == null) ? "" : await put.Content.ReadAsStringAsync();

            return new Dictionary<string, string>
                {
                    { "status", put.StatusCode.ToString() },
                    { "json", json }
                };
        }
        public async Task<SesionPELDTO> ObtenerSesion()
           => await sessionStorageService.GetItemAsync<SesionPELDTO>("sesion");
        private async Task ValidarJwt()
        {
            var sesion = await ObtenerSesion();
            if (sesion != null)
            {
                var validarExistencia = httpClient.DefaultRequestHeaders.FirstOrDefault(x => x.Key == "Authorization");
                if (validarExistencia.Value == null)
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {sesion.Jwt}");
                }
                else
                {
                    httpClient.DefaultRequestHeaders.Remove("Authorization");
                    httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {sesion.Jwt}");
                }
            }

        }
    }
}
