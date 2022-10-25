using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.TransferenciasDTO
{
    public class PropiaDTO
    {
        [Required]
        public string numeroDocumento { get; set; }
        [Required]
        public string usuario { get; set; }
        [Required]
        public string cuentaOrigen { get; set; }
        [Required]
        public string cuentaDestino { get; set; }
        [Required]
        public decimal? monto { get; set; }
        [Required]
        [MaxLength(200)]
        public string motivo { get; set; }
        [Required]
        [MaxLength(50)]
        public string correo { get; set; }
    }
}
