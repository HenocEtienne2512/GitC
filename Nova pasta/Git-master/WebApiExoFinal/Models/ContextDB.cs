using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiExoFinal.Models {
    public class ContextDB: DbContext {
        public DbSet<Usuario> usuarios { get; set; }
    }
}