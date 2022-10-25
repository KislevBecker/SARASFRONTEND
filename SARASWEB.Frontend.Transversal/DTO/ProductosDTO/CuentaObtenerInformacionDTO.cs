using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.ProductosDTO
{
    public class CuentaObtenerInformacionDTO
    {
        [Required]
        public string Cuenta { get; set; }
    }
}
