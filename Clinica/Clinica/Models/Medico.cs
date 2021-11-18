﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Medico : Usuario
    {
        [Required]
        public string NumColegiado { get; set; }                  // ID del médico

        public ICollection<Paciente> Pacientes { get; set; }     // relacion 1..* a 1..*

        public ICollection<Cita> Citas { get; set; }             // relacion 1 a 0..*

        public Medico()
        {
            Pacientes = new List<Paciente>();
            Citas = new List<Cita>();
        }

    }
}
