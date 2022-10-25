using System;
using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.TransferenciasDTO
{
    public class PropiaFrmDTO
    {
        [Required(ErrorMessage = "Debe seleccionar cuenta a debitar")]
        public string cuentaOrigen { get; set; }
        [Required(ErrorMessage = "Debe seleccionar cuenta a acreditar")]
        public string cuentaDestino { get; set; }
        [Required(ErrorMessage = "Debe completar el campo monto con un valor mayor a 0")]
        [Range(1, Double.PositiveInfinity, ErrorMessage = "El valor debe ser mayor a 0")]
        public decimal? monto { get; set; }
        [Required(ErrorMessage = "Debe ingresar el motivo de su transacción")]
        [MaxLength(200, ErrorMessage = "La longitud máxima es de 200 caracteres")]
        public string motivo { get; set; }
        public string moneda { get; set; }
    }
}
