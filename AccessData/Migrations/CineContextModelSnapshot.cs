// <auto-generated />
using System;
using AccessData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccessData.Migrations
{
    [DbContext(typeof(CineContext))]
    partial class CineContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Funciones", b =>
                {
                    b.Property<int>("FuncionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Horario")
                        .HasColumnType("time");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("FuncionId");

                    b.HasIndex("PeliculaId");

                    b.HasIndex("SalaId");

                    b.ToTable("Funciones");

                    b.HasData(
                        new
                        {
                            FuncionId = 1,
                            Fecha = new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Horario = new TimeSpan(0, 17, 30, 0, 0),
                            PeliculaId = 1,
                            SalaId = 1
                        },
                        new
                        {
                            FuncionId = 2,
                            Fecha = new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Horario = new TimeSpan(0, 19, 30, 0, 0),
                            PeliculaId = 2,
                            SalaId = 2
                        },
                        new
                        {
                            FuncionId = 3,
                            Fecha = new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Horario = new TimeSpan(0, 21, 30, 0, 0),
                            PeliculaId = 3,
                            SalaId = 3
                        },
                        new
                        {
                            FuncionId = 4,
                            Fecha = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Horario = new TimeSpan(0, 10, 30, 0, 0),
                            PeliculaId = 4,
                            SalaId = 2
                        },
                        new
                        {
                            FuncionId = 5,
                            Fecha = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Horario = new TimeSpan(0, 15, 0, 0, 0),
                            PeliculaId = 2,
                            SalaId = 3
                        },
                        new
                        {
                            FuncionId = 6,
                            Fecha = new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Horario = new TimeSpan(0, 18, 30, 0, 0),
                            PeliculaId = 3,
                            SalaId = 3
                        },
                        new
                        {
                            FuncionId = 7,
                            Fecha = new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Horario = new TimeSpan(0, 18, 30, 0, 0),
                            PeliculaId = 3,
                            SalaId = 3
                        },
                        new
                        {
                            FuncionId = 8,
                            Fecha = new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Horario = new TimeSpan(0, 21, 30, 0, 0),
                            PeliculaId = 3,
                            SalaId = 1
                        },
                        new
                        {
                            FuncionId = 9,
                            Fecha = new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Horario = new TimeSpan(0, 22, 0, 0, 0),
                            PeliculaId = 8,
                            SalaId = 2
                        },
                        new
                        {
                            FuncionId = 10,
                            Fecha = new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Horario = new TimeSpan(0, 17, 30, 0, 0),
                            PeliculaId = 3,
                            SalaId = 3
                        });
                });

            modelBuilder.Entity("Domain.Entities.Peliculas", b =>
                {
                    b.Property<int>("PeliculaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Sinopsis")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("PeliculaId");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            PeliculaId = 1,
                            Poster = "https://i.ibb.co/DbdbPTg/1-Poster.jpg",
                            Sinopsis = "El doctor Ben y su esposa Jo viajan con su hijo hasta Marruecos, donde conocen a un hombre de negocios y a un matrimonio británico. Un día de visita a un mercado le confieren un secreto un atentado político y luego su hijo es secuestrado.",
                            Titulo = "El hombre que sabía demasiado",
                            Trailer = "https://www.youtube.com/embed/e7edJ0OEic4"
                        },
                        new
                        {
                            PeliculaId = 2,
                            Poster = "https://i.ibb.co/G0CWRgv/2-Poster.jpg",
                            Sinopsis = "Melanie, una joven rica mujer, conoce en una pajarería al abogado Mitch Brenner. Tras el encuentro, Melanie persigue al hombre hasta Bodega Bay, lugar en el que es atacada por bandadas de pájaros enfurecidos.",
                            Titulo = "Los pájaros",
                            Trailer = "https://www.youtube.com/embed/EpF83rjA814"
                        },
                        new
                        {
                            PeliculaId = 3,
                            Poster = "https://i.ibb.co/55srNk1/3-Poster.jpg",
                            Sinopsis = "Después de haberle robado 40 000 dólares a su jefe, Marion Crane huye de la policía y se detiene a pasar la noche en un motel que se erige junto a una carretera perdida. El establecimiento lo regentan un joven tímido y extraño y su madre.",
                            Titulo = "Psicosis",
                            Trailer = "https://www.youtube.com/embed/mC2gOyWuSEY"
                        },
                        new
                        {
                            PeliculaId = 4,
                            Poster = "https://i.ibb.co/NCQc7Cz/4-Poster.jpg",
                            Sinopsis = "Un detective jubilado que tiene miedo a las alturas es asignado a rastrear a la esposa del rico dueño de un barco.",
                            Titulo = "Vértigo",
                            Trailer = "https://www.youtube.com/embed/Z5jvQwwHQNY"
                        },
                        new
                        {
                            PeliculaId = 5,
                            Poster = "https://i.ibb.co/FH2RvHK/5-Poster.jpg",
                            Sinopsis = "Una pareja de brillantes estudiantes asesinan a un compañero para demostrar que el crimen perfecto puede llevarse a cabo si el mismo es realizado por gente inteligente.",
                            Titulo = "La soga",
                            Trailer = "https://www.youtube.com/embed/wJ8EnnOib6s"
                        },
                        new
                        {
                            PeliculaId = 6,
                            Poster = "https://i.ibb.co/7nZTs39/6-Poster.jpg",
                            Sinopsis = "A Thornhill unos espías lo confunden con un agente llamado Kaplan. Secuestrado y llevado a una mansión en la que es interrogado, consigue huir antes de que lo maten. Pero cuando regresa a la casa acompañado de la policía, le espera una sorpresa.",
                            Titulo = "Intriga Internacional",
                            Trailer = "https://www.youtube.com/embed/hfZyZRy7Xi8"
                        },
                        new
                        {
                            PeliculaId = 7,
                            Poster = "https://i.ibb.co/7WLL48q/7-Poster.jpg",
                            Sinopsis = "Un fotógrafo, sentado en una silla de ruedas y con una pierna enyesada, espía a los vecinos y es testigo de un asesinato.",
                            Titulo = "La ventana indiscreta",
                            Trailer = "https://www.youtube.com/embed/dHwoVtbZdPY"
                        },
                        new
                        {
                            PeliculaId = 8,
                            Poster = "https://i.ibb.co/XzydV3d/8-Poster.jpg",
                            Sinopsis = "Un ex-tenista decide matar a su mujer para heredar su dinero y vengarse por haber tenido un romance con un escritor. Él chantajea a un compañero para que la estrangule y finge que el crimen fue cometido por un ladrón.",
                            Titulo = "La llamada fatal",
                            Trailer = "https://www.youtube.com/embed/y1oPtCA2PWg"
                        },
                        new
                        {
                            PeliculaId = 9,
                            Poster = "https://i.ibb.co/chs7wQT/9-Poster.jpg",
                            Sinopsis = "Un psicópata y una estrella del tenis acuerdan poner en marcha un siniestro juego que desembocará en una imparable cadena de asesinatos.",
                            Titulo = "Extraños en un tren",
                            Trailer = "https://www.youtube.com/embed/J1iSS5r0OVE"
                        },
                        new
                        {
                            PeliculaId = 10,
                            Poster = "https://i.ibb.co/K6znPYy/10-Poster.jpg",
                            Sinopsis = "Un espía estadounidense encubierto persuade a la hija de un traidor para que se infiltre en una banda nazi de América del Sur.",
                            Titulo = "Tuyo es mi corazón",
                            Trailer = "https://www.youtube.com/embed/EhMyp8ZvjWs"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Salas", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.HasKey("SalaId");

                    b.ToTable("Salas");

                    b.HasData(
                        new
                        {
                            SalaId = 1,
                            Capacidad = 5
                        },
                        new
                        {
                            SalaId = 2,
                            Capacidad = 15
                        },
                        new
                        {
                            SalaId = 3,
                            Capacidad = 35
                        });
                });

            modelBuilder.Entity("Domain.Entities.Tickets", b =>
                {
                    b.Property<Guid>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FuncionId")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("TicketId", "FuncionId");

                    b.HasIndex("FuncionId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Domain.Entities.Funciones", b =>
                {
                    b.HasOne("Domain.Entities.Peliculas", "Pelicula")
                        .WithMany("Funciones")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Salas", "Sala")
                        .WithMany("Funciones")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("Domain.Entities.Tickets", b =>
                {
                    b.HasOne("Domain.Entities.Funciones", "Funcion")
                        .WithMany("Tickets")
                        .HasForeignKey("FuncionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcion");
                });

            modelBuilder.Entity("Domain.Entities.Funciones", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Domain.Entities.Peliculas", b =>
                {
                    b.Navigation("Funciones");
                });

            modelBuilder.Entity("Domain.Entities.Salas", b =>
                {
                    b.Navigation("Funciones");
                });
#pragma warning restore 612, 618
        }
    }
}
