using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.ProductosDTO
{
    public class RequestProductosDTO
    {
        [Required]
        public string cif { get; set; }
    }
}
