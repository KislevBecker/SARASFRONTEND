using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.SeguridadDTO
{
    public class UsuarioCambiarClaveDTO
    {
        public string Usuario { get; set; }
        [MaxLength(25)]
        public string ClaveActual { get; set; }
        [MaxLength(25)]
        public string ClaveNueva { get; set; }
    }
}
