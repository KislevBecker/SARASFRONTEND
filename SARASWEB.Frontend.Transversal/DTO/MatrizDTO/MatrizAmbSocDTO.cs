using System;

namespace SARASWEB.Frontend.Transversal.DTO.MatrizDTO
{
    public class MatrizAmbSocDTO
    {
        public decimal NoCredito { get; set; }
        public DateTime FechaOtorgado { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Clasificacion { get; set; }
        public string Segmento { get; set; }
        public decimal CIF { get; set; }
        public string NombreCliente { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public int NivelEducativo { get; set; }
        public int RangoIngresos { get; set; }
        public string SectorEconomico { get; set; }
        public int Destino { get; set; }
        public string NombreDestino { get; set; }
        public string ActividadEconomica { get; set; }
        public int Agencia { get; set; }
        public string NombreAgencia { get; set; }
        public string Departamento { get; set; }
        public int CategoriaAmbiental { get; set; }
        public int NivelRiesgo { get; set; }
        public int CodGarantia { get; set; }
        public int TipoGarantia { get; set; }
        public int MaterialVivienda { get; set; }
        public int ServiciosPublicos { get; set; }
        public decimal MontOtorgado { get; set; }
        public decimal Capital { get; set; }
        public string Estatus { get; set; }
        public int Zona { get; set; }
        public int Region { get; set; }
        public decimal Saldo { get; set; }
        public string TipoCliente { get; set; }
        public int NumCiclos { get; set; }
        public string Nuevos { get; set; }
        public string Refinanciado { get; set; }
        public string Readecuado { get; set; }
    }
}
