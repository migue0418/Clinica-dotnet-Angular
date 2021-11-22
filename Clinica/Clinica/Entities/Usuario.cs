using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinica.Entities
{
    public class Usuario
    {
        [ScaffoldColumn(false)]
        public int UsuarioID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        public string Username { get; set; }        // No puede llamarse igual que la clase Usuario -> Username

        [Required]
        public string Clave { get; set; }
    }
}
