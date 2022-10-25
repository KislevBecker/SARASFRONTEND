using System;
using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.ActividadEconomicaDTO
{
    public class ActividadEconomicaSocialDTO
    {
        [Required(ErrorMessage = "Debe asignar un nivel de riesgo")]
        public string nivelRiesgo { get; set; }
        [Required(ErrorMessage = "Debe completar el campo monto con un valor mayor a 0")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0}")]
        public int codigo { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar el nombre de la nueva categoría")]
        [MaxLength(150, ErrorMessage = "La longitud máxima es de 150 caracteres")]
        public string nombreCategoria { get; set; }
    }
}
