using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.ProductosDTO
{
    public class MovimientosFrmDTO
    {
        [Required(ErrorMessage = "Debe seleccionar una cuenta.")]
        public string Cuenta { get; set; }
        public string Moneda { get; set; }
    }
}
