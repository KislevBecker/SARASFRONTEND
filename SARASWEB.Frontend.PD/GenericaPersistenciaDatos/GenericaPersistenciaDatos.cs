using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SARASWEB.Frontend.FuenteDatos.HttpRepositorio;
using SARASWEB.Frontend.Transversal.DTO.RespuestaDTO;
using SARASWEB.Frontend.Transversal.DTO.SeguridadDTO;
using SARASWEB.Frontend.Transversal.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.PD.GenericaPersistenciaDatos
{
    public class GenericaPersistenciaDatos : IGenericaPersistenciaDatos
    {
        private readonly IHttpRepositorio httpRepositorio;
        private readonly IHelper helper;
        private string[] errores = { "NotFound", "BadRequest" };
        public GenericaPersistenciaDatos(IHttpRepositorio httpRepositorio,
                                         IHelper helper)
        {
            this.httpRepositorio = httpRepositorio;
            this.helper = helper;
        }
        public async Task<RespuestaDTO<T>> Get<T>(string uri, string jwt = null) where T : class
        {
            var _request = new RespuestaDTO<T>();
            var post = await httpRepositorio.Get(uri, jwt);

            var status = post.GetValueOrDefault("status");

            if (errores.Contains(status))
            {
                _request.Excepcion = (status == "NotFound") ? "" : post.GetValueOrDefault("json");
                _request.Codigo = (status == "NotFound") ? 404 : 400;
                _request.Mensaje = (status == "NotFound") ? "No se encontro el recurso"
                                    : "Hay un error de comunicación, validar datos";
                return _request;
            }

            var json = JObject.Parse(post.GetValueOrDefault("json"));

            _request.Entidad = JsonConvert.DeserializeObject<T>(json.SelectToken("entidad").ToString());
            _request.Codigo = (int)(json.SelectToken("codigo"));
            _request.Mensaje = json.SelectToken("mensaje").ToString();
            _request.Excepcion = json.SelectToken("excepcion").ToString();

            return _request;
        }

        public async Task<RespuestaDTO<IEnumerable<T>>> GetAll<T>(string uri, string jwt = null) where T : class
        {
            var _request = new RespuestaDTO<IEnumerable<T>>();
            var post = await httpRepositorio.Get(uri, jwt);

            var status = post.GetValueOrDefault("status");
            if (errores.Contains(status))
            {
                _request.Excepcion = (status == "NotFound") ? "" : post.GetValueOrDefault("json");
                _request.Codigo = (status == "NotFound") ? 404 : 400;
                _request.Mensaje = (status == "NotFound") ? "No se encontro el recurso"
                                    : "Hay un error de comunicación, validar datos";
                return _request;
            }

            var json = JObject.Parse(post.GetValueOrDefault("json"));

            _request.Entidad = JsonConvert.DeserializeObject<IEnumerable<T>>(json.SelectToken("entidad").ToString());
            _request.Codigo = (int)(json.SelectToken("codigo"));
            _request.Mensaje = json.SelectToken("mensaje").ToString();
            _request.Excepcion = json.SelectToken("excepcion").ToString();

            return _request;
        }

        public async Task<RespuestaDTO<bool>> GetBool(string uri, string jwt = null)
        {
            var _request = new RespuestaDTO<bool>();
            var post = await httpRepositorio.Get(uri, jwt);

            var status = post.GetValueOrDefault("status");
            if (errores.Contains(status))
            {
                _request.Excepcion = (status == "NotFound") ? "" : post.GetValueOrDefault("json");
                _request.Codigo = (status == "NotFound") ? 404 : 400;
                _request.Mensaje = (status == "NotFound") ? "No se encontro el recurso"
                                    : "Hay un error de comunicación, validar datos";
                return _request;
            }


            var json = JObject.Parse(post.GetValueOrDefault("json"));

            _request.Entidad = Convert.ToBoolean(json.SelectToken("entidad"));
            _request.Codigo = (int)(json.SelectToken("codigo"));
            _request.Mensaje = json.SelectToken("mensaje").ToString();
            _request.Excepcion = json.SelectToken("excepcion").ToString();

            return _request;
        }

        public async Task<RespuestaDTO<bool>> Ping(string uri)
        {
            var _request = new RespuestaDTO<bool>();
            var post = await httpRepositorio.Get(uri);

            var status = post.GetValueOrDefault("status");
            if (errores.Contains(status))
            {
                _request.Excepcion = (status == "NotFound") ? "" : post.GetValueOrDefault("json");
                _request.Codigo = (status == "NotFound") ? 404 : 400;
                _request.Mensaje = (status == "NotFound") ? "No se encontro el recurso"
                                    : "Hay un error de comunicación, validar datos";
                return _request;
            }

            var json = JObject.Parse(post.GetValueOrDefault("json"));

            _request.Entidad = Convert.ToBoolean(json.SelectToken("entidad"));
            _request.Codigo = (int)(json.SelectToken("codigo"));
            _request.Mensaje = json.SelectToken("mensaje").ToString();
            _request.Excepcion = json.SelectToken("excepcion").ToString();

            return _request;
        }

        public async Task<RespuestaDTO<bool>> Post<T>(T entity, string Uri, string jwt = null) where T : class
        {
            var _request = new RespuestaDTO<bool>();
            var stringContent = helper.JsonToStringContent(entity);
            var post = await httpRepositorio.Post(stringContent, Uri, jwt);

            var status = post.GetValueOrDefault("status");
            if (errores.Contains(status))
            {
                _request.Excepcion = (status == "NotFound") ? "" : post.GetValueOrDefault("json");
                _request.Codigo = (status == "NotFound") ? 404 : 400;
                _request.Mensaje = (status == "NotFound") ? "No se encontro el recurso"
                                    : "Hay un error de comunicación, validar datos";
                return _request;
            }


            var json = JObject.Parse(post.GetValueOrDefault("json"));

            _request.Entidad = Convert.ToBoolean(json.SelectToken("entidad"));
            _request.Codigo = (int)(json.SelectToken("codigo"));
            _request.Mensaje = json.SelectToken("mensaje").ToString();
            _request.Excepcion = json.SelectToken("excepcion").ToString();

            return _request;
        }

        public async Task<RespuestaDTO<T>> Post<T, Y>(Y entity, string Uri, string jwt = null) where T : class
        {
            var _request = new RespuestaDTO<T>();
            var stringContent = helper.JsonToStringContent(entity);
            var post = await httpRepositorio.Post(stringContent, Uri, jwt);

            var status = post.GetValueOrDefault("status");
            if (errores.Contains(status))
            {
                _request.Excepcion = (status == "NotFound") ? "" : post.GetValueOrDefault("json");
                _request.Codigo = (status == "NotFound") ? 404 : 400;
                _request.Mensaje = (status == "NotFound") ? "No se encontro el recurso"
                                    : "Hay un error de comunicación, validar datos";
                return _request;
            }

            var json = JObject.Parse(post.GetValueOrDefault("json"));

            _request.Entidad = JsonConvert.DeserializeObject<T>(json.SelectToken("entidad").ToString());
            _request.Codigo = (int)(json.SelectToken("codigo"));
            _request.Mensaje = json.SelectToken("mensaje").ToString();
            _request.Excepcion = json.SelectToken("excepcion").ToString();

            return _request;
        }

        public async Task<RespuestaDTO<bool>> Put<T>(T entity, string Uri, string jwt = null) where T : class
        {
            var _request = new RespuestaDTO<Boolean>();
            var post = await httpRepositorio.Put(helper.JsonToStringContent(entity), Uri, jwt);

            var status = post.GetValueOrDefault("status");
            if (errores.Contains(status))
            {
                _request.Excepcion = (status == "NotFound") ? "" : post.GetValueOrDefault("json");
                _request.Codigo = (status == "NotFound") ? 404 : 400;
                _request.Mensaje = (status == "NotFound") ? "No se encontro el recurso"
                                    : "Hay un error de comunicación, validar datos";
                return _request;
            }


            var json = JObject.Parse(post.GetValueOrDefault("json"));

            _request.Entidad = Convert.ToBoolean(json.SelectToken("entidad"));
            _request.Codigo = (int)(json.SelectToken("codigo"));
            _request.Mensaje = json.SelectToken("mensaje").ToString();
            _request.Excepcion = json.SelectToken("excepcion").ToString();

            return _request;
        }
        public async Task<RespuestaDTO<IEnumerable<T>>> Post<T, Y>(string Uri, Y entity, string jwt = null) where T : class
        {
            var _request = new RespuestaDTO<IEnumerable<T>>();
            var stringContent = helper.JsonToStringContent(entity);
            var post = await httpRepositorio.Post(stringContent, Uri, jwt);

            var status = post.GetValueOrDefault("status");
            if (errores.Contains(status))
            {
                _request.Excepcion = (status == "NotFound") ? "" : post.GetValueOrDefault("json");
                _request.Codigo = (status == "NotFound") ? 404 : 400;
                _request.Mensaje = (status == "NotFound") ? "No se encontro el recurso"
                                    : "Hay un error de comunicación, validar datos";
                return _request;
            }

            var json = JObject.Parse(post.GetValueOrDefault("json"));

            _request.Entidad = JsonConvert.DeserializeObject<IEnumerable<T>>(json.SelectToken("entidad").ToString());
            _request.Codigo = (int)(json.SelectToken("codigo"));
            _request.Mensaje = json.SelectToken("mensaje").ToString();
            _request.Excepcion = json.SelectToken("excepcion").ToString();

            return _request;
        }

        public async Task<RespuestaDTO<SesionPELDTO>> Login<T>(T entity, string Uri) where T : class
        {
            var _request = new RespuestaDTO<SesionPELDTO>();
            var stringContent = helper.JsonToStringContent(entity);
            var post = await httpRepositorio.Post(stringContent, Uri);
            var json = JObject.Parse(post.GetValueOrDefault("json"));

            _request.Entidad = JsonConvert.DeserializeObject<SesionPELDTO>(json.SelectToken("entidad").ToString());
            _request.Codigo = (int)(json.SelectToken("codigo"));
            _request.Mensaje = json.SelectToken("mensaje").ToString();
            _request.Excepcion = json.SelectToken("excepcion").ToString();

            return _request;
        }
    }
}
