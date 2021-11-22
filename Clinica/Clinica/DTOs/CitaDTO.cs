using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.DTOs
{
    public class CitaDTO
    {
        public int CitaID { get; set; }
        public DateTime FechaHora { get; set; }
        public string MotivoCita { get; set; }
        public string PacienteNSS { get; set; }
        public int MedicoNumColegiado { get; set; }
    }
}
