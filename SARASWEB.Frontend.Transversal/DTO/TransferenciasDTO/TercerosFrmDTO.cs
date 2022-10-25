using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SARASWEB.Frontend.Transversal.DTO.TransferenciasDTO
{
    public class TercerosFrmDTO
    {
        [Required(ErrorMessage = "Debe seleccionar cuenta a debitar")]
        public string cuentaOrigen { get; set; }
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(ErrorMessage = "Debe seleccionar cuenta a acreditar")]
        [MinLength(12, ErrorMessage = "La cuenta digitada es incorrecta")]
        public string cuentaDestino { get; set; }
        [Required(ErrorMessage = "Debe completar el campo monto con un valor mayor a 0")]
        [Range(1, Double.PositiveInfinity, ErrorMessage = "El valor debe ser mayor a 0")]
        public decimal monto { get; set; }
        [Required(ErrorMessage = "Debe ingresar el motivo de su transacción")]
        [MaxLength(200, ErrorMessage = "La longitud máxima es de 200 caracteres")]
        public string motivo { get; set; }

        [MaxLength(50, ErrorMessage = "La longitud máxima es de 50 caracteres")]
        public string CorreoDestinatario { get; set; }

        public string CorreoConfirmacion { get; set; }
        public string moneda { get; set; }

        [MinLength(2, ErrorMessage = "Debe validar la cuenta del destino")]
        public string descripcionCuentaDestino { get; set; }

        public bool agregarFavorito { get; set; }
        public bool nombreBeneficiario { get; set; }
        public string cuentaDestinoEnviar { get; set; }
    }
}
