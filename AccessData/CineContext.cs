using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace AccessData
{
    public class CineContext : DbContext
    {
        public CineContext(){}

        public CineContext(DbContextOptions<CineContext> options): base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            modelBuilder.Entity<Peliculas>(entity =>
            {
                entity.HasKey(x => x.PeliculaId);

                entity.Property(x => x.Titulo)
                    .HasMaxLength(50)
                    .IsRequired();

                entity.Property(x => x.Poster)
                    .HasMaxLength(255)
                    .IsRequired();

                entity.Property(x => x.Sinopsis)
                    .HasMaxLength(255)
                    .IsRequired();

                entity.Property(x => x.Trailer)
                    .HasMaxLength(255)
                    .IsRequired();
            });
            modelBuilder.Entity<Salas>(entity =>
            {
                entity.HasKey(x => x.SalaId);

                entity.Property(x => x.SalaId)
                    .ValueGeneratedOnAdd();

                entity.Property(x => x.Capacidad)
                    .IsRequired();
            });
            modelBuilder.Entity<Funciones>(entity =>
            {
                entity.HasKey(x => x.FuncionId);

                entity.Property(e => e.FuncionId)
                    .ValueGeneratedOnAdd();

                entity.HasIndex(e => e.PeliculaId);

                entity.HasIndex(e => e.SalaId);
            });
            modelBuilder.Entity<Tickets>(entity =>
            {
                entity.HasKey(e => new { e.TicketId, e.FuncionId });

                entity.Property(e => e.TicketId)
                        .ValueGeneratedOnAdd();

                entity.Property(e => e.Usuario)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                entity.HasOne(d => d.Funcion)
                        .WithMany(p => p.Tickets)
                        .HasForeignKey(d => d.FuncionId);
            });
        }
        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<Salas> Salas { get; set; }
        public DbSet<Funciones> Funciones { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
    }
}
