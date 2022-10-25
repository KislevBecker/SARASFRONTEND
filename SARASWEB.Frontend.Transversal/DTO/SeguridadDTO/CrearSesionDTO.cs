using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.Transversal.DTO.SeguridadDTO
{
    public class CrearSesionDTO
    {
        public Guid Guid { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Dispositivo { get; set; }
    }
}
