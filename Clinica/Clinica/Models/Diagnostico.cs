using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Diagnostico
    {
        [ScaffoldColumn(false)]
        public int IdDiagnostico { get; set; }

        [Required]
        public string ValoracionEspecialista { get; set; }

        [Required]
        public string Enfermedad { get; set; }

        [Required]
        public Cita Cita { get; set; }          // relacion 1 a 1
    }
}
