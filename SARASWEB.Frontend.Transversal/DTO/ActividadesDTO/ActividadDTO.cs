using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.ActividadesDTO
{
    public class ActividadDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string DescripcionActividad { get; set; }

        [Required]
        public int IdPuntaje { get; set; }
    }
}
