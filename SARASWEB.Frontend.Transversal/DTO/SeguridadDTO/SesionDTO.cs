using System;

namespace SARASWEB.Frontend.Transversal.DTO.SeguridadDTO
{
    public class SesionDTO
    {
        public string token { get; set; }
        public string usuario { get; set; }
        public string cif { get; set; }
        public string correo { get; set; }
        public DateTime fechaVencimiento { get; set; }
    }
}
