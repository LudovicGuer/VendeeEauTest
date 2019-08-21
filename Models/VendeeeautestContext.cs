using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VendeeEauTest2.Models
{
    public partial class VendeeeautestContext : DbContext
    {
        public VendeeeautestContext()
        {
        }

        public VendeeeautestContext(DbContextOptions<VendeeeautestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ConseilLocal> ConseilLocal { get; set; }
        public virtual DbSet<Epci> Epci { get; set; }
        public virtual DbSet<Technicien> Technicien { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<ConseilLocal>(entity =>
            {
                entity.Property(e => e.IdConseilLocal).ValueGeneratedNever();

                entity.Property(e => e.NomConseilLocal).IsUnicode(false);
            });

            modelBuilder.Entity<Epci>(entity =>
            {
                entity.Property(e => e.IdEpci).ValueGeneratedNever();

                entity.Property(e => e.Epci1).IsUnicode(false);

                entity.Property(e => e.NomSecteur).IsUnicode(false);

                entity.HasOne(d => d.FkIdTechnicienNavigation)
                    .WithMany(p => p.Epci)
                    .HasForeignKey(d => d.FkIdTechnicien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPCI_Technicien");
            });

            modelBuilder.Entity<Technicien>(entity =>
            {
                entity.Property(e => e.IdTechnicien).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}