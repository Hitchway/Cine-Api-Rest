using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessData.Migrations
{
    public partial class migracion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sinopsis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.PeliculaId);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    SalaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.SalaId);
                });

            migrationBuilder.CreateTable(
                name: "Funciones",
                columns: table => new
                {
                    FuncionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeliculaId = table.Column<int>(type: "int", nullable: false),
                    SalaId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funciones", x => x.FuncionId);
                    table.ForeignKey(
                        name: "FK_Funciones_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "PeliculaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funciones_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "SalaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FuncionId = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => new { x.TicketId, x.FuncionId });
                    table.ForeignKey(
                        name: "FK_Tickets_Funciones_FuncionId",
                        column: x => x.FuncionId,
                        principalTable: "Funciones",
                        principalColumn: "FuncionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "PeliculaId", "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[,]
                {
                    { 1, "https://i.ibb.co/DbdbPTg/1-Poster.jpg", "El doctor Ben y su esposa Jo viajan con su hijo hasta Marruecos, donde conocen a un hombre de negocios y a un matrimonio británico. Un día de visita a un mercado le confieren un secreto un atentado político y luego su hijo es secuestrado.", "El hombre que sabía demasiado", "https://www.youtube.com/embed/e7edJ0OEic4" },
                    { 2, "https://i.ibb.co/G0CWRgv/2-Poster.jpg", "Melanie, una joven rica mujer, conoce en una pajarería al abogado Mitch Brenner. Tras el encuentro, Melanie persigue al hombre hasta Bodega Bay, lugar en el que es atacada por bandadas de pájaros enfurecidos.", "Los pájaros", "https://www.youtube.com/embed/EpF83rjA814" },
                    { 3, "https://i.ibb.co/55srNk1/3-Poster.jpg", "Después de haberle robado 40 000 dólares a su jefe, Marion Crane huye de la policía y se detiene a pasar la noche en un motel que se erige junto a una carretera perdida. El establecimiento lo regentan un joven tímido y extraño y su madre.", "Psicosis", "https://www.youtube.com/embed/mC2gOyWuSEY" },
                    { 4, "https://i.ibb.co/NCQc7Cz/4-Poster.jpg", "Un detective jubilado que tiene miedo a las alturas es asignado a rastrear a la esposa del rico dueño de un barco.", "Vértigo", "https://www.youtube.com/embed/Z5jvQwwHQNY" },
                    { 5, "https://i.ibb.co/FH2RvHK/5-Poster.jpg", "Una pareja de brillantes estudiantes asesinan a un compañero para demostrar que el crimen perfecto puede llevarse a cabo si el mismo es realizado por gente inteligente.", "La soga", "https://www.youtube.com/embed/wJ8EnnOib6s" },
                    { 6, "https://i.ibb.co/7nZTs39/6-Poster.jpg", "A Thornhill unos espías lo confunden con un agente llamado Kaplan. Secuestrado y llevado a una mansión en la que es interrogado, consigue huir antes de que lo maten. Pero cuando regresa a la casa acompañado de la policía, le espera una sorpresa.", "Intriga Internacional", "https://www.youtube.com/embed/hfZyZRy7Xi8" },
                    { 7, "https://i.ibb.co/7WLL48q/7-Poster.jpg", "Un fotógrafo, sentado en una silla de ruedas y con una pierna enyesada, espía a los vecinos y es testigo de un asesinato.", "La ventana indiscreta", "https://www.youtube.com/embed/dHwoVtbZdPY" },
                    { 8, "https://i.ibb.co/XzydV3d/8-Poster.jpg", "Un ex-tenista decide matar a su mujer para heredar su dinero y vengarse por haber tenido un romance con un escritor. Él chantajea a un compañero para que la estrangule y finge que el crimen fue cometido por un ladrón.", "La llamada fatal", "https://www.youtube.com/embed/y1oPtCA2PWg" },
                    { 9, "https://i.ibb.co/chs7wQT/9-Poster.jpg", "Un psicópata y una estrella del tenis acuerdan poner en marcha un siniestro juego que desembocará en una imparable cadena de asesinatos.", "Extraños en un tren", "https://www.youtube.com/embed/J1iSS5r0OVE" },
                    { 10, "https://i.ibb.co/K6znPYy/10-Poster.jpg", "Un espía estadounidense encubierto persuade a la hija de un traidor para que se infiltre en una banda nazi de América del Sur.", "Tuyo es mi corazón", "https://www.youtube.com/embed/EhMyp8ZvjWs" }
                });

            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "SalaId", "Capacidad" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 2, 15 },
                    { 3, 35 }
                });

            migrationBuilder.InsertData(
                table: "Funciones",
                columns: new[] { "FuncionId", "Fecha", "Horario", "PeliculaId", "SalaId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 30, 0, 0), 1, 1 },
                    { 8, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 21, 30, 0, 0), 3, 1 },
                    { 2, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 19, 30, 0, 0), 2, 2 },
                    { 4, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 10, 30, 0, 0), 4, 2 },
                    { 9, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 22, 0, 0, 0), 8, 2 },
                    { 3, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 21, 30, 0, 0), 3, 3 },
                    { 5, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), 2, 3 },
                    { 6, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 30, 0, 0), 3, 3 },
                    { 7, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 30, 0, 0), 3, 3 },
                    { 10, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 30, 0, 0), 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funciones_PeliculaId",
                table: "Funciones",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funciones_SalaId",
                table: "Funciones",
                column: "SalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FuncionId",
                table: "Tickets",
                column: "FuncionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Funciones");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Salas");
        }
    }
}
