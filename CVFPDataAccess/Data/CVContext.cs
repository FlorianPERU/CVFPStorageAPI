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

            #region Candidate
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

            #endregion
            #region AssociationCandidateSoftSkill
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
            #endregion
            #region AssociationCandidateHardSkill 
            // Clé composite pour la table AssociationCandidateHardSkill
            modelBuilder.Entity<AssociationCandidateHardSkill>()
                .HasKey(a => new { a.CandidateId, a.HardSkillId });

            // Configuration de la relation entre AssociationCandidateHardSkill et Candidate
            modelBuilder.Entity<AssociationCandidateHardSkill>()
                .HasOne(u => u.Candidate)
                .WithMany(c => c.AssociationCandidateHardSkills)
                .HasForeignKey(f => f.CandidateId);

            // Configuration de la relation entre AssociationCandidateHardSkill et HardSkill
            modelBuilder.Entity<AssociationCandidateHardSkill>()
                .HasOne(u => u.HardSkill)
                .WithMany(c => c.AssociationCandidateHardSkills)
                .HasForeignKey(f => f.HardSkillId);
            #endregion
            #region HardSkillType
            // Configuration de la relation entre HardSkillType et HardSkills
            modelBuilder.Entity<HardSkillType>()
                .HasMany(u => u.HardSkills)
                .WithOne(c => c.HardSkillType)
                .HasForeignKey(f => f.HardSkillTypeId);
            #endregion
            #region AssociationCandidateHardSkill 
            // Clé composite pour la table AssociationCandidateHobbie
            modelBuilder.Entity<AssociationCandidateHobbie>()
                .HasKey(a => new { a.CandidateId, a.HobbieId });

            // Configuration de la relation entre AssociationCandidateHobbie et Candidate
            modelBuilder.Entity<AssociationCandidateHobbie>()
                .HasOne(u => u.Candidate)
                .WithMany(c => c.AssociationCandidateHobbies)
                .HasForeignKey(f => f.CandidateId);

            // Configuration de la relation entre AssociationCandidateHobbie et Hobbie
            modelBuilder.Entity<AssociationCandidateHobbie>()
                .HasOne(u => u.Hobbie)
                .WithMany(c => c.AssociationCandidateHobbies)
                .HasForeignKey(f => f.HobbieId);
            #endregion
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<AssociationCandidateSoftSkill> AssociationCandidatesSoftSkills { get; set; }
        public DbSet<SoftSkill> SoftSkills { get; set; }
        public DbSet<AssociationCandidateHardSkill> AssociationCandidatesHardSkills { get; set; }
        public DbSet<HardSkill> HardSkills { get; set; }
        public DbSet<AssociationCandidateHobbie> AssociationCandidateHobbies { get; set; }
        public DbSet<Hobbie> Hobbies { get; set; }
    }
}
