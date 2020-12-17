using CSD.AppointmentApplication.Entity;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CSD.AppointmentApplication.Data
{
    public partial class AppointmentDbContext : DbContext
    {
        public AppointmentDbContext()
        {
        }

        public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;            
             
            optionsBuilder.UseSqlServer("Server=.;Database=AppointmentDb;Trusted_Connection=True;");            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__Appointme__Clien__3A81B327");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.HasIndex(e => e.Email, "UQ__Client__A9D10534C256574D")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
