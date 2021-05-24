using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prueba_saas.Models
{
    public class asignaturas
    {

        [Key]
        public int id_cargo { get; set; }
        public string descripcion { get; set; }

    }
}