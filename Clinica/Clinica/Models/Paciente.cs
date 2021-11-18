using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Paciente : Usuario
    {
        [Required]
        public string NSS { get; set; }                         // ID del Paciente

        [Required]
        public string NumTarjeta { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Direccion { get; set; }

        public ICollection<Medico> Medicos { get; set; }        // relacion 1...* a 1...*

        public ICollection<Cita> Citas { get; set; }            // relacion 1 a 0...*

        public Paciente()
        {
            Medicos = new List<Medico>();
            Citas = new List<Cita>();
        }
    }
}
