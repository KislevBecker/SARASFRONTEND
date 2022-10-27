using System.ComponentModel.DataAnnotations;

namespace SARASWEB.Frontend.Transversal.DTO.PuntajeDTO
{
    public class PuntajeFrmDTO
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar una descripcion para el puntaje")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Debe ingresar la categoria de riesgo")]
        [MaxLength(200, ErrorMessage = "La longitud máxima es de 3 caracteres")]
        public int IdCategoria { get; set; }
    }
}
