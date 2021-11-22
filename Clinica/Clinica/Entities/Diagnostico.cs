using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Entities
{
    public class Diagnostico
    {
        [ScaffoldColumn(false)]
        public int DiagnosticoID { get; set; }

        [Required]
        public string ValoracionEspecialista { get; set; }

        [Required]
        public string Enfermedad { get; set; }

        public int CitaID { get; set; }
        public Cita Cita { get; set; }          // relacion 1 a 1

    }
}
