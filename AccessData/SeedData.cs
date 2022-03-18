using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace AccessData
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Peliculas>().HasData(
                new Peliculas() { 
                    PeliculaId = 1, 
                    Titulo = "El hombre que sabía demasiado", 
                    Sinopsis = "El doctor Ben y su esposa Jo viajan con su hijo hasta Marruecos, donde conocen a un hombre de negocios y a un matrimonio británico. Un día de visita a un mercado le confieren un secreto un atentado político y luego su hijo es secuestrado.", 
                    Poster = "https://i.ibb.co/DbdbPTg/1-Poster.jpg", 
                    Trailer = "https://www.youtube.com/embed/e7edJ0OEic4"
                },
                new Peliculas() { 
                    PeliculaId = 2, 
                    Titulo = "Los pájaros", 
                    Sinopsis = "Melanie, una joven rica mujer, conoce en una pajarería al abogado Mitch Brenner. Tras el encuentro, Melanie persigue al hombre hasta Bodega Bay, lugar en el que es atacada por bandadas de pájaros enfurecidos.", 
                    Poster = "https://i.ibb.co/G0CWRgv/2-Poster.jpg", 
                    Trailer = "https://www.youtube.com/embed/EpF83rjA814"
                },
                new Peliculas() { 
                    PeliculaId = 3, 
                    Titulo = "Psicosis", 
                    Sinopsis = "Después de haberle robado 40 000 dólares a su jefe, Marion Crane huye de la policía y se detiene a pasar la noche en un motel que se erige junto a una carretera perdida. El establecimiento lo regentan un joven tímido y extraño y su madre.", 
                    Poster = "https://i.ibb.co/55srNk1/3-Poster.jpg", 
                    Trailer = "https://www.youtube.com/embed/mC2gOyWuSEY"
                },
                new Peliculas() { 
                    PeliculaId = 4, 
                    Titulo = "Vértigo", 
                    Sinopsis = "Un detective jubilado que tiene miedo a las alturas es asignado a rastrear a la esposa del rico dueño de un barco.", 
                    Poster = "https://i.ibb.co/NCQc7Cz/4-Poster.jpg", 
                    Trailer = "https://www.youtube.com/embed/Z5jvQwwHQNY"
                },
                new Peliculas() { 
                    PeliculaId = 5, 
                    Titulo = "La soga", 
                    Sinopsis = "Una pareja de brillantes estudiantes asesinan a un compañero para demostrar que el crimen perfecto puede llevarse a cabo si el mismo es realizado por gente inteligente.", 
                    Poster = "https://i.ibb.co/FH2RvHK/5-Poster.jpg", 
                    Trailer = "https://www.youtube.com/embed/wJ8EnnOib6s"
                },
                new Peliculas() { 
                    PeliculaId = 6, 
                    Titulo = "Intriga Internacional", 
                    Sinopsis = "A Thornhill unos espías lo confunden con un agente llamado Kaplan. Secuestrado y llevado a una mansión en la que es interrogado, consigue huir antes de que lo maten. Pero cuando regresa a la casa acompañado de la policía, le espera una sorpresa.", 
                    Poster = "https://i.ibb.co/7nZTs39/6-Poster.jpg", 
                    Trailer = "https://www.youtube.com/embed/hfZyZRy7Xi8"
                },
                new Peliculas() { 
                    PeliculaId = 7, 
                    Titulo = "La ventana indiscreta", 
                    Sinopsis = "Un fotógrafo, sentado en una silla de ruedas y con una pierna enyesada, espía a los vecinos y es testigo de un asesinato.", 
                    Poster = "https://i.ibb.co/7WLL48q/7-Poster.jpg", 
                    Trailer = "https://www.youtube.com/embed/dHwoVtbZdPY"
                },
                new Peliculas() { 
                    PeliculaId = 8, 
                    Titulo = "La llamada fatal", 
                    Sinopsis = "Un ex-tenista decide matar a su mujer para heredar su dinero y vengarse por haber tenido un romance con un escritor. Él chantajea a un compañero para que la estrangule y finge que el crimen fue cometido por un ladrón.", 
                    Poster = "https://i.ibb.co/XzydV3d/8-Poster.jpg", 
                    Trailer = "https://www.youtube.com/embed/y1oPtCA2PWg"
                },
                new Peliculas() { 
                    PeliculaId = 9, 
                    Titulo = "Extraños en un tren", 
                    Sinopsis = "Un psicópata y una estrella del tenis acuerdan poner en marcha un siniestro juego que desembocará en una imparable cadena de asesinatos.", 
                    Poster = "https://i.ibb.co/chs7wQT/9-Poster.jpg", 
                    Trailer = "https://www.youtube.com/embed/J1iSS5r0OVE"
                },
                new Peliculas() { 
                    PeliculaId = 10, 
                    Titulo = "Tuyo es mi corazón", 
                    Sinopsis = "Un espía estadounidense encubierto persuade a la hija de un traidor para que se infiltre en una banda nazi de América del Sur.", 
                    Poster = "https://i.ibb.co/K6znPYy/10-Poster.jpg", 
                    Trailer = "https://www.youtube.com/embed/EhMyp8ZvjWs"
                }
            );
            builder.Entity<Salas>().HasData(
                new Salas { SalaId = 1, Capacidad = 5 },
                new Salas { SalaId = 2, Capacidad = 15 },
                new Salas { SalaId = 3, Capacidad = 35 }
            );
            builder.Entity<Funciones>().HasData(
                new Funciones { 
                    FuncionId=1,
                    PeliculaId = 1,
                    SalaId = 1,
                    Fecha = System.DateTime.Today,
                    Horario = new System.TimeSpan(17,30,0)
                },
                new Funciones
                {
                    FuncionId = 2,
                    PeliculaId = 2,
                    SalaId = 2,
                    Fecha = System.DateTime.Today,
                    Horario = new System.TimeSpan(19, 30, 0)
                },
                new Funciones
                {
                    FuncionId = 3,
                    PeliculaId = 3,
                    SalaId = 3,
                    Fecha = System.DateTime.Today,
                    Horario = new System.TimeSpan(21, 30, 0)
                },
                new Funciones
                {
                    FuncionId = 4,
                    PeliculaId = 4,
                    SalaId = 2,
                    Fecha = System.DateTime.Today.AddDays(1),
                    Horario = new System.TimeSpan(10, 30, 0)
                },
                new Funciones
                {
                    FuncionId = 5,
                    PeliculaId = 2,
                    SalaId = 3,
                    Fecha = System.DateTime.Today.AddDays(1),
                    Horario = new System.TimeSpan(15, 0, 0)
                },
                new Funciones
                {
                    FuncionId = 6,
                    PeliculaId = 3,
                    SalaId = 3,
                    Fecha = System.DateTime.Today.AddDays(1),
                    Horario = new System.TimeSpan(18, 30, 0)
                },
                new Funciones
                {
                    FuncionId = 7,
                    PeliculaId = 3,
                    SalaId = 3,
                    Fecha = System.DateTime.Today.AddDays(2),
                    Horario = new System.TimeSpan(18, 30, 0)
                },
                new Funciones
                {
                    FuncionId = 8,
                    PeliculaId = 3,
                    SalaId = 1,
                    Fecha = System.DateTime.Today.AddDays(2),
                    Horario = new System.TimeSpan(21, 30, 0)
                },
                new Funciones
                {
                    FuncionId = 9,
                    PeliculaId = 8,
                    SalaId = 2,
                    Fecha = System.DateTime.Today.AddDays(2),
                    Horario = new System.TimeSpan(22, 0, 0)
                },
                new Funciones
                {
                    FuncionId = 10,
                    PeliculaId = 3,
                    SalaId = 3,
                    Fecha = System.DateTime.Today.AddDays(3),
                    Horario = new System.TimeSpan(17, 30, 0)
                }
            );
        }
    }
}
