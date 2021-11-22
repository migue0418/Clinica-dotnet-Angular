using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Entities
{
	public class Cita
	{
		[ScaffoldColumn(false)]                         // No hay que pedirle el Id al usuario en el formulario.
		public int CitaID { get; set; }

		[Required]
		public DateTime FechaHora { get; set; }

		[Required]
		public string MotivoCita { get; set; }

		/*[Required]
		public int attribute11 { get; set; }            // ?????
		*/
		[Required]
		public Paciente Paciente { get; set; }         // relacion 0..* a 1 (una cita pertenece a 1 paciente)

		[Required]
		public Medico Medico { get; set; }              // relacion 0..* a 1 (una cita pertenece a 1 medico)

		public Diagnostico Diagnostico { get; set; }    // relacion 1 a 1 (en una cita se da un diagnostico)
	}
}
