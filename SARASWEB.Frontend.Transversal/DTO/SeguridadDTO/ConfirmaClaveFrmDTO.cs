using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.SeguridadDTO
{
    public class ConfirmaClaveFrmDTO
    {
        [Required(ErrorMessage = "Ingrese su contraseña")]
        public string confirmaClave { get; set; }
    }
}
