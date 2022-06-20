using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACMEncuenta.ddd.Dominio.Entidades
{
    [Table(name: "Encuesta", Schema = "dbo")]
    public class Encuesta
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe introducir el nombre de la encuesta")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe introducir la descripcion de la encuesta")]
        public string Descripcion { get; set; }
        public Guid Guid { get; set; }
        public int CantidadCodigos { get; set; }
        public string Link { get; set; }
        public List<EncuestaCampos> ListaDeCampos { get; set; }
        public List<EncuestaCodigos> ListaDeCodigos { get; set; }
    }
}
