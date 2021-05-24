using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using prueba_saas.Models;

namespace prueba_saas.Models.Context
{
    public class PruebaContext: DbContext
    {
        public DbSet<profesores> profesores { get; set; }
        public DbSet<asignaturas> asignaturas { get; set; }
    }
}