using System;

namespace SARASWEB.Frontend.Transversal.DTO.SeguridadDTO
{
    public class SesionPELDTO
    {
        public string Usuario { get; set; }
        public string Cif { get; set; }
        public string Jwt { get; set; }
        public DateTime Expiracion { get; set; }
        public string Email { get; set; }
        public string Identificacion { get; set; }
        public Guid Identificador { get; set; }
        public bool CambioClave { get; set; }
    }
}
