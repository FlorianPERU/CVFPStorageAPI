using CVFPDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFPDataAccess.Data
{
    public class CVContext : DbContext
    {
        public CVContext(DbContextOptions<CVContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configurez ici votre connexion à la base de données
            optionsBuilder.UseSqlServer("Server=localhost;Database=CVFP;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Candidate> Candidates { get; set; }
    }
}
