using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Citas_Medicas.Modules.Citas.Entities;

namespace Citas_Medicas.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Cita> Citas { get; set; }
        
    }
}