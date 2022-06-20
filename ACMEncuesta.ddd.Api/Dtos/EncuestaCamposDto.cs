using ACMEncuenta.ddd.Dominio.Enumeraciones;

namespace ACMEncuesta.ddd.Api.Dtos
{
    public class EncuestaCamposDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public char Requerido { get; set; }
        public TipoCampo TipoCampo { get; set; }
    }
}
