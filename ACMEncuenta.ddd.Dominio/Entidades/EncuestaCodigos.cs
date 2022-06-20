using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACMEncuenta.ddd.Dominio.Entidades
{
    [Table(name: "EncuestaCodigos", Schema = "dbo")]
    public class EncuestaCodigos
    {
        public int EncuestaId { get; set; }
        public Guid CodigoPK { get; set; }
        public Encuesta Encuesta { get; set; }
    }
}
