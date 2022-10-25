using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text;

namespace SARASWEB.Frontend.Transversal.Helpers
{
    public class Helper : IHelper
    {
        private int[] errores = { 400, 500, 404, 409, 401 };
        public int[] Errores { get => errores; set => errores = value; }
        private readonly IConfiguration configuration;

        public Helper(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public bool ValidarModelo(object modelo)
        {
            var context = new ValidationContext(modelo, serviceProvider: null, items: null);

            var validationResults = new List<ValidationResult>();

            return Validator.TryValidateObject(modelo, context, validationResults, true);
        }

        public StringContent JsonToStringContent<T>(T entity)
            => new StringContent(JsonConvert.SerializeObject(entity, Formatting.Indented),
                Encoding.UTF8, "application/json");

        public string FormateadorDecimales(string monto)
        {
            bool continuarCiclo = true;
            string numeroFormateado = "";
            string monedas = "";

            if (monto.Contains("."))
            {
                var dividir = monto.Split(".");
                monto = dividir[0];
                monedas = dividir[1];
            }

            if (monto.Contains(","))
            {
                string[] dividir = monto.Split(',');
                monto = dividir[0];
                monedas = dividir[1];
            }

            do
            {
                int longitud = monto.Length;

                if (longitud >= 4)
                {
                    string montoDividido = monto.Substring(longitud - 3, 3);

                    numeroFormateado = $"{numeroFormateado},{montoDividido}";

                    monto = monto.Remove(longitud - 3, 3);
                }
                else
                {
                    continuarCiclo = false;
                }
            }
            while (continuarCiclo);

            if (string.IsNullOrEmpty(monedas))
            {
                numeroFormateado = $"{monto}{numeroFormateado}.00";
            }
            else
            {
                numeroFormateado = $"{monto}{numeroFormateado}.{monedas}";
            }

            return numeroFormateado;
        }
        public string obtenerComision(string parametro)
        {
            var microservicios = configuration.GetSection("Parametros");
            switch (parametro)
            {
                case "ComisionACH":
                    return microservicios.GetSection("ComisionACH").Value;

                default: return "";
            }
        }

    }
}
