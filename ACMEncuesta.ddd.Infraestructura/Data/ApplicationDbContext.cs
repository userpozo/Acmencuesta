using ACMEncuenta.ddd.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ACMEncuesta.ddd.Infraestructura.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EncuestaCodigos>(x => x.HasKey(pk => new { pk.EncuestaId, pk.CodigoPK }));
            modelBuilder.Entity<EncuestaCamposValor>(x => x.HasKey(y => new
            {
                y.EncuestaCodigosEncuestaId,
                y.EncuestaCodigosCodigoPK,
                y.EncuestaCamposId
            }));

            modelBuilder.Entity<EncuestaCampos>()
                .HasOne(x => x.Encuesta)
                .WithMany(x => x.ListaDeCampos)
                .OnDelete(DeleteBehavior.Restrict);

        }

        public DbSet<Encuesta> Encuestas { get; set; }
        public DbSet<EncuestaCodigos> EncuestaCodigos { get; set; }
        public DbSet<EncuestaCampos> EncuestaCampos { get; set; }
        public DbSet<EncuestaCamposValor> EncuestaCamposValor { get; set; }
    }
}
