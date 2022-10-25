using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.SeguridadDTO
{
    public class IniciarSesionDTO
    {
        [Required (ErrorMessage ="Debe ingresar un usuario")]
        [MaxLength(50)]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Debe ingresar una contraseña")]
        public string Contraseña { get; set; }
    }
}
