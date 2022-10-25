using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.SeguridadDTO
{
    public class UsuarioCambiarClaveFrmDTO
    {
        public string Usuario { get; set; }
        [MaxLength(25)]
        [Required(ErrorMessage = "Debe ingresar su clave actual")]
        public string ClaveActual { get; set; }
        [MaxLength(25)]
        [Required(ErrorMessage = "Debe ingresar su nueva clave")]
        public string ClaveNueva { get; set; }
        [MaxLength(25)]
        [Required(ErrorMessage = "Debe confirmar su nueva clave")]
        public string ConfirmarClaveNueva { get; set; }
    }
}
