using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prueba_saas.Models
{
    public class profesores
    {
        [Key]
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
    }
}