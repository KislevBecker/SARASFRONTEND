using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.TransferenciasDTO
{
    public class TokenFrmDTO
    {
        [Required(ErrorMessage = "Ingrese el token de seguridad")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [MaxLength(12, ErrorMessage = "La longitud máxima del pin es de 8 dígitos")]
        public string popularToken { get; set; }
    }
}
