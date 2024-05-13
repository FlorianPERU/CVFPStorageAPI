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
            optionsBuilder.UseSqlServer("Server=localhost;Database=CVFP;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration de la relation entre Candidate et Certification
            modelBuilder.Entity<Candidate>()
                .HasMany(u => u.Certifications)
                .WithOne(c => c.Candidate)
                .HasForeignKey(f => f.CandidateId);

            // Configuration de la relation entre Candidate et Formation
            modelBuilder.Entity<Candidate>()
                .HasMany(u => u.Formations)
                .WithOne(c => c.Candidate)
                .HasForeignKey(f => f.CandidateId);

            // Clé composite pour la table AssociationCandidateSoftSkill
            modelBuilder.Entity<AssociationCandidateSoftSkill>()
                .HasKey(a => new { a.CandidateId, a.SoftSkillId });

            // Configuration de la relation entre AssociationCandidateSoftSkill et Candidate
            modelBuilder.Entity<AssociationCandidateSoftSkill>()
                .HasOne(u => u.Candidate)
                .WithMany(c => c.AssociationCandidateSoftSkills)
                .HasForeignKey(f => f.CandidateId);

            // Configuration de la relation entre AssociationCandidateSoftSkill et SoftSkill
            modelBuilder.Entity<AssociationCandidateSoftSkill>()
                .HasOne(u => u.SoftSkill)
                .WithMany(c => c.AssociationCandidateSoftSkills)
                .HasForeignKey(f => f.SoftSkillId);
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<AssociationCandidateSoftSkill> AssociationCandidatesSoftSkills { get; set; }
        public DbSet<SoftSkill> SoftSkills { get; set; }
    }
}
