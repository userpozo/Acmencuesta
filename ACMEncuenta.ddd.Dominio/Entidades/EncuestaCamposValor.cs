using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACMEncuenta.ddd.Dominio.Entidades
{
    [Table(name: "EncuestaCamposValor", Schema = "dbo")]
    public class EncuestaCamposValor
    {
        public int EncuestaCodigosEncuestaId { get; set; }
        public Guid EncuestaCodigosCodigoPK { get; set; }
        public int EncuestaCamposId { get; set; }
        public string Valor { get; set; }
        public EncuestaCodigos EncuestaCodigos { get; set; }
        public EncuestaCampos EncuestaCampos { get; set; }

    }
}
