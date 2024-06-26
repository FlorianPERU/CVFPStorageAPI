﻿using CVFPDataAccess.Models;
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
            #region AssociationCandidateHardSkill 
            // Clé composite pour la table AssociationCandidateLanguage
            modelBuilder.Entity<AssociationCandidateLanguage>()
                .HasKey(a => new { a.CandidateId, a.LanguageId });

            // Configuration de la relation entre AssociationCandidateLanguage et Candidate
            modelBuilder.Entity<AssociationCandidateLanguage>()
                .HasOne(u => u.Candidate)
                .WithMany(c => c.AssociationCandidateLanguages)
                .HasForeignKey(f => f.CandidateId);

            // Configuration de la relation entre AssociationCandidateLanguage et Language
            modelBuilder.Entity<AssociationCandidateLanguage>()
                .HasOne(u => u.Language)
                .WithMany(c => c.AssociationCandidateLanguages)
                .HasForeignKey(f => f.LanguageId);
            #endregion
            #region Experience 
            // Configuration de la relation entre Experience et Candidate
            modelBuilder.Entity<Experience>()
                .HasOne(e => e.Candidate)
                .WithMany(c => c.Experiences)
                .HasForeignKey(e => e.CandidateId);

            // Configuration de la relation auto-référentielle entre Experience et SubExperiences
            modelBuilder.Entity<Experience>()
                .HasMany(e => e.SubExperiences)
                .WithOne(e => e.ParentExperience)
                .HasForeignKey(e => e.ParentExperienceId);

            // Configuration de la relation auto-référentielle entre Experience et JobTasks
            modelBuilder.Entity<Experience>()
                .HasMany(e => e.JobTasks)
                .WithOne(e => e.Experience)
                .HasForeignKey(e => e.ExperienceId);
            #endregion
            #region Job 
            // Configuration de la relation entre Job et Experiences
            modelBuilder.Entity<Job>()
                .HasMany(u => u.Experiences)
                .WithOne(c => c.Job)
                .HasForeignKey(f => f.JobId);
            #endregion
            #region ContractType 
            // Configuration de la relation entre ContractType et Experiences
            modelBuilder.Entity<ContractType>()
                .HasMany(u => u.Experiences)
                .WithOne(c => c.ContractType)
                .HasForeignKey(f => f.ContractTypeId);
            #endregion
            #region ExperienceSkill 
            // Clé composite pour la table ExperienceSkill
            modelBuilder.Entity<ExperienceSkill>()
                .HasKey(a => new { a.ExperienceId, a.Position });

            // Configuration de la relation entre ExperienceSkill et Experience
            modelBuilder.Entity<ExperienceSkill>()
                .HasOne(u => u.Experience)
                .WithMany(c => c.ExperienceSkills)
                .HasForeignKey(f => f.ExperienceId);

            // Configuration de la relation entre ExperienceSkill et SoftSkill
            modelBuilder.Entity<ExperienceSkill>()
                .HasOne(u => u.SoftSkill)
                .WithMany(c => c.ExperienceSkills)
                .HasForeignKey(f => f.SoftSkillId);

            // Configuration de la relation entre ExperienceSkill et HardSkill
            modelBuilder.Entity<ExperienceSkill>()
                .HasOne(u => u.HardSkill)
                .WithMany(c => c.ExperienceSkills)
                .HasForeignKey(f => f.HardSkillId);
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
        public DbSet<AssociationCandidateLanguage> AssociationCandidateLanguages { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }
        public DbSet<JobTask> JobTasks { get; set; }
        public DbSet<ExperienceSkill> ExperienceSkills { get; set; }
    }
}
