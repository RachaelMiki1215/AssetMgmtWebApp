using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models = AssetMgmtWebApp3.Models;

namespace AssetMgmtWebApp3.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Models.Environment> Environments { get; set; } = null!;
        public virtual DbSet<Models.Equipment> Equipment { get; set; } = null!;
        public virtual DbSet<Models.Lab> Labs { get; set; } = null!;
        public virtual DbSet<Models.MaintenanceRecord> MaintenanceRecords { get; set; } = null!;
        public virtual DbSet<Models.NewsArticle> NewsArticles { get; set; } = null!;
        public virtual DbSet<Models.ReservationRecord> ReservationRecords { get; set; } = null!;
        public virtual DbSet<Models.Team> Teams { get; set; } = null!;
        public virtual DbSet<Models.User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Environment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasColumnType("text");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Lab)
                    .WithMany(p => p.Environments)
                    .HasForeignKey(d => d.LabId)
                    .HasConstraintName("FK__Environme__LabId__30F848ED");
            });

            modelBuilder.Entity<Models.Equipment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Condition)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Environment)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.EnvironmentId)
                    .HasConstraintName("FK_Equipment_EnvironmentId");

                entity.HasOne(d => d.Lab)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.LabId)
                    .HasConstraintName("FK_Equipment_LabId");
            });

            modelBuilder.Entity<Models.Lab>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasColumnType("text");

                entity.HasOne(d => d.OwnerTeam)
                    .WithMany(p => p.Labs)
                    .HasForeignKey(d => d.OwnerTeamId)
                    .HasConstraintName("FK__Labs__OwnerTeamI__2E1BDC42");

                entity.HasOne(d => d.OwnerUser)
                    .WithMany(p => p.Labs)
                    .HasForeignKey(d => d.OwnerUserId)
                    .HasConstraintName("FK__Labs__OwnerUserI__2D27B809");
            });

            modelBuilder.Entity<Models.MaintenanceRecord>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Details).HasColumnType("text");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.MaintenanceRecords)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Maintenan__Equip__33D4B598");

                entity.HasOne(d => d.MaintainedUser)
                    .WithMany(p => p.MaintenanceRecords)
                    .HasForeignKey(d => d.MaintainedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Maintenan__Maint__34C8D9D1");
            });

            modelBuilder.Entity<Models.NewsArticle>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ContentHtml)
                    .HasColumnType("text")
                    .HasColumnName("ContentHTML");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.HeadLine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AuthorUser)
                    .WithMany(p => p.NewsArticles)
                    .HasForeignKey(d => d.AuthorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NewsArtic__Autho__48CFD27E");
            });

            modelBuilder.Entity<Models.ReservationRecord>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApprovalStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalStatusReason)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Note).HasColumnType("text");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurposeDetails).HasColumnType("text");

                entity.Property(e => e.RetrieveAssistReason)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.UsageStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.BorrowerUser)
                    .WithMany(p => p.ReservationRecords)
                    .HasForeignKey(d => d.BorrowerUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservati__Borro__38996AB5");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.ReservationRecords)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservati__Equip__37A5467C");
            });

            modelBuilder.Entity<Models.Team>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Organization)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Leader)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.LeaderId)
                    .HasConstraintName("FK__Teams__LeaderId__286302EC");
            });

            modelBuilder.Entity<Models.User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK__Users__TeamId__276EDEB3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
