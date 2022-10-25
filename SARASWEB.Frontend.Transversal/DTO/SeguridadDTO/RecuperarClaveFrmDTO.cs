using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.DTO.SeguridadDTO
{
    public class RecuperarClaveFrmDTO
    {
        [MaxLength(25)]
        [Required(ErrorMessage = "Debe ingresar su usuario")]
        public string Usuario { get; set; }
        [MaxLength(8)]
        [Required(ErrorMessage = "Debe ingresar el token de seguridad")]
        public string Token { get; set; }
    }
}
