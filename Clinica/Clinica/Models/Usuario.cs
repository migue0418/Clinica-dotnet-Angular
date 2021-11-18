using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Models
{
    public class Usuario
    {
        [ScaffoldColumn(false)]
        public int IdUsuario { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        public string User { get; set; }        // No puede llamarse igual que la clase Usuario -> User

        [Required]
        public string Clave { get; set; }
    }
}
