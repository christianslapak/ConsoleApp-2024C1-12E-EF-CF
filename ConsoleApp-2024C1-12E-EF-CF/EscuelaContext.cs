using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2024C1_12E_EF_CF
{
    internal class EscuelaContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder.UseSqlServer(@"Server=A-PROFH-360;Database=Escuela2024C112E;Trusted_Connection=True;Trusted_Connection=True;Trust Server Certificate=true"); }
    }
}
