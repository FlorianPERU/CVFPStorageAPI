﻿// <auto-generated />
using System;
using CVFPDataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CVFPDataAccess.Migrations
{
    [DbContext(typeof(CVContext))]
    partial class CVContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CVFPDataAccess.Models.AssociationCandidateHardSkill", b =>
                {
                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("HardSkillId")
                        .HasColumnType("int");

                    b.Property<int>("PositionHardSkill")
                        .HasColumnType("int");

                    b.Property<int>("PositionHardSkillType")
                        .HasColumnType("int");

                    b.HasKey("CandidateId", "HardSkillId");

                    b.HasIndex("HardSkillId");

                    b.ToTable("AssociationCandidatesHardSkills");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.AssociationCandidateHobbie", b =>
                {
                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("HobbieId")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("CandidateId", "HobbieId");

                    b.HasIndex("HobbieId");

                    b.ToTable("AssociationCandidateHobbies");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.AssociationCandidateLanguage", b =>
                {
                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<bool>("IsNative")
                        .HasColumnType("bit");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("Ref")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandidateId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("AssociationCandidateLanguages");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.AssociationCandidateSoftSkill", b =>
                {
                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("SoftSkillId")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<int>("SkillMasteryPercentage")
                        .HasColumnType("int");

                    b.HasKey("CandidateId", "SoftSkillId");

                    b.HasIndex("SoftSkillId");

                    b.ToTable("AssociationCandidatesSoftSkills");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("DesiredJobType")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DrivingLicenseType")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("HasOwnVehicle")
                        .HasColumnType("bit");

                    b.Property<string>("IdentityPhotoLink")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LinkedinLink")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PresentationSentence")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Certification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("LogoLink")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ObtentionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("Certifications");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.ContractType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ContractTypes");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyInfo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ContractTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("LinkedinLink")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("ParentExperienceId")
                        .HasColumnType("int");

                    b.Property<string>("WorkCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("ContractTypeId");

                    b.HasIndex("JobId");

                    b.HasIndex("ParentExperienceId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Formation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("SchoolAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("Formations");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.HardSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HardSkillTypeId")
                        .HasColumnType("int");

                    b.Property<string>("LogoLink")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("HardSkillTypeId");

                    b.ToTable("HardSkills");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.HardSkillType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("HardSkillType");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Hobbie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LogoLink")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.JobTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExperienceId")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.ToTable("JobTasks");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LogoLink")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.SoftSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LogoLink")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("SoftSkills");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.AssociationCandidateHardSkill", b =>
                {
                    b.HasOne("CVFPDataAccess.Models.Candidate", "Candidate")
                        .WithMany("AssociationCandidateHardSkills")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CVFPDataAccess.Models.HardSkill", "HardSkill")
                        .WithMany("AssociationCandidateHardSkills")
                        .HasForeignKey("HardSkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("HardSkill");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.AssociationCandidateHobbie", b =>
                {
                    b.HasOne("CVFPDataAccess.Models.Candidate", "Candidate")
                        .WithMany("AssociationCandidateHobbies")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CVFPDataAccess.Models.Hobbie", "Hobbie")
                        .WithMany("AssociationCandidateHobbies")
                        .HasForeignKey("HobbieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("Hobbie");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.AssociationCandidateLanguage", b =>
                {
                    b.HasOne("CVFPDataAccess.Models.Candidate", "Candidate")
                        .WithMany("AssociationCandidateLanguages")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CVFPDataAccess.Models.Language", "Language")
                        .WithMany("AssociationCandidateLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.AssociationCandidateSoftSkill", b =>
                {
                    b.HasOne("CVFPDataAccess.Models.Candidate", "Candidate")
                        .WithMany("AssociationCandidateSoftSkills")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CVFPDataAccess.Models.SoftSkill", "SoftSkill")
                        .WithMany("AssociationCandidateSoftSkills")
                        .HasForeignKey("SoftSkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("SoftSkill");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Certification", b =>
                {
                    b.HasOne("CVFPDataAccess.Models.Candidate", "Candidate")
                        .WithMany("Certifications")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Experience", b =>
                {
                    b.HasOne("CVFPDataAccess.Models.Candidate", "Candidate")
                        .WithMany("Experiences")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CVFPDataAccess.Models.ContractType", "ContractType")
                        .WithMany("Experiences")
                        .HasForeignKey("ContractTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CVFPDataAccess.Models.Job", "Job")
                        .WithMany("Experiences")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CVFPDataAccess.Models.Experience", "ParentExperience")
                        .WithMany("SubExperiences")
                        .HasForeignKey("ParentExperienceId");

                    b.Navigation("Candidate");

                    b.Navigation("ContractType");

                    b.Navigation("Job");

                    b.Navigation("ParentExperience");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Formation", b =>
                {
                    b.HasOne("CVFPDataAccess.Models.Candidate", "Candidate")
                        .WithMany("Formations")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.HardSkill", b =>
                {
                    b.HasOne("CVFPDataAccess.Models.HardSkillType", "HardSkillType")
                        .WithMany("HardSkills")
                        .HasForeignKey("HardSkillTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HardSkillType");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.JobTask", b =>
                {
                    b.HasOne("CVFPDataAccess.Models.Experience", "Experience")
                        .WithMany("JobTasks")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Experience");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Candidate", b =>
                {
                    b.Navigation("AssociationCandidateHardSkills");

                    b.Navigation("AssociationCandidateHobbies");

                    b.Navigation("AssociationCandidateLanguages");

                    b.Navigation("AssociationCandidateSoftSkills");

                    b.Navigation("Certifications");

                    b.Navigation("Experiences");

                    b.Navigation("Formations");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.ContractType", b =>
                {
                    b.Navigation("Experiences");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Experience", b =>
                {
                    b.Navigation("JobTasks");

                    b.Navigation("SubExperiences");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.HardSkill", b =>
                {
                    b.Navigation("AssociationCandidateHardSkills");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.HardSkillType", b =>
                {
                    b.Navigation("HardSkills");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Hobbie", b =>
                {
                    b.Navigation("AssociationCandidateHobbies");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Job", b =>
                {
                    b.Navigation("Experiences");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.Language", b =>
                {
                    b.Navigation("AssociationCandidateLanguages");
                });

            modelBuilder.Entity("CVFPDataAccess.Models.SoftSkill", b =>
                {
                    b.Navigation("AssociationCandidateSoftSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
