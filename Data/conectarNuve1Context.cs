using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using conectarNuve1.dato;

namespace conectarNuve1.Data
{
    public class conectarNuve1Context : DbContext
    {
        public conectarNuve1Context (DbContextOptions<conectarNuve1Context> options)
            : base(options)
        {
        }

        public DbSet<conectarNuve1.dato.Class> Class { get; set; } = default!;
    }
}
