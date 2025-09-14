using gimnasioApi.Models;
using Microsoft.EntityFrameworkCore;

namespace gimnasioApi.Data
{
    public class ApplicationDbContext : DbContext // Heredar de DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) // Constructor
            : base(options) { }

        // Mapeo de entidades con los nombres correctos según la base de datos
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Imagen> Imagen { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Asistencia> Asistencia { get; set; }
        public DbSet<Atleta> Atleta { get; set; }
        public DbSet<AtletaEntrenador> AtletaEntrenador { get; set; }
        public DbSet<AtletaGimnasio> AtletaGimnasio { get; set; }
        public DbSet<Ejercicio> Ejercicio { get; set; }
        public DbSet<Entrenador> Entrenador { get; set; }
        public DbSet<EntrenadorGimnasio> EntrenadorGimnasio { get; set; }
        public DbSet<FormaPago> FormaPago { get; set; }
        public DbSet<Frase> Frase { get; set; }
        public DbSet<Gimnasio> Gimnasio { get; set; }
        public DbSet<GrupoMuscular> GrupoMuscular { get; set; }
        public DbSet<Logro> Logro { get; set; }
        public DbSet<Medida> Medida { get; set; }
        public DbSet<Membresia> Membresia { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuPerfil> MenuPerfil { get; set; }
        public DbSet<Meta> Meta { get; set; }
        public DbSet<NivelDificultad> NivelDificultad { get; set; }
        public DbSet<Objetivo> Objetivo { get; set; }
        public DbSet<Pago> Pago { get; set; }
        public DbSet<PagoMp> PagoMp { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Repeticion> Repeticion { get; set; }
        public DbSet<Rutina> Rutina { get; set; }
        public DbSet<RutinaAtleta> RutinaAtleta { get; set; }
        public DbSet<RutinaEjercicio> RutinaEjercicio { get; set; }
        public DbSet<RutinaFavorita> RutinaFavorita { get; set; }
        public DbSet<SuscripcionMp> SuscripcionMp { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de tablas con nombres sin prefijo tb_
            modelBuilder.Entity<Usuario>().ToTable("usuario");
            modelBuilder.Entity<Asistencia>().ToTable("asistencia");
            modelBuilder.Entity<Atleta>().ToTable("atleta");
            modelBuilder.Entity<AtletaEntrenador>().ToTable("atleta_entrenador");
            modelBuilder.Entity<AtletaGimnasio>().ToTable("atleta_gimnasio");
            modelBuilder.Entity<Ejercicio>().ToTable("ejercicios");
            modelBuilder.Entity<Entrenador>().ToTable("entrenador");
            modelBuilder.Entity<EntrenadorGimnasio>().ToTable("entrenador_gimnasio");
            modelBuilder.Entity<FormaPago>().ToTable("forma_pago");
            modelBuilder.Entity<Frase>().ToTable("frases");
            modelBuilder.Entity<Gimnasio>().ToTable("gimnasio");
            modelBuilder.Entity<GrupoMuscular>().ToTable("grupos_musculares");
            modelBuilder.Entity<Logro>().ToTable("logros");
            modelBuilder.Entity<Medida>().ToTable("medidas");
            modelBuilder.Entity<Membresia>().ToTable("membresia");
            modelBuilder.Entity<Menu>().ToTable("menu");
            modelBuilder.Entity<MenuPerfil>().ToTable("menu_perfil");
            modelBuilder.Entity<Meta>().ToTable("metas");
            modelBuilder.Entity<NivelDificultad>().ToTable("nivel_dificultad");
            modelBuilder.Entity<Objetivo>().ToTable("objetivo");
            modelBuilder.Entity<Pago>().ToTable("pago");
            modelBuilder.Entity<PagoMp>().ToTable("pagos_mp");
            modelBuilder.Entity<Perfil>().ToTable("perfil");
            modelBuilder.Entity<Repeticion>().ToTable("repeticion");
            modelBuilder.Entity<Rutina>().ToTable("rutina");
            modelBuilder.Entity<RutinaAtleta>().ToTable("rutina_atleta");
            modelBuilder.Entity<RutinaEjercicio>().ToTable("rutina_ejercicios");
            modelBuilder.Entity<RutinaFavorita>().ToTable("rutina_favorita");
            modelBuilder.Entity<SuscripcionMp>().ToTable("suscripciones_mp");

            // Configuración de claves compuestas
            modelBuilder.Entity<RutinaFavorita>()
                .HasKey(rf => new { rf.IdAtleta, rf.IdRutina });
        }
    }
}
