using ACMEncuenta.ddd.Dominio.Entidades;
using ACMEncuenta.ddd.Dominio.Enumeraciones;
using System.ComponentModel.DataAnnotations;

namespace ACMEncuesta.ddd.Api.Dtos
{
    public class EncuestaCamposAlmacenarDto
    {
        [Required(ErrorMessage = "Debe introducir el Titulo del campo")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Debe indicar si el campo es requerido")]
        public char Requerido { get; set; }
        [Required(ErrorMessage = "Debe especificar si el tipo de respuesta es texto, numero, fecha, etc.")]
        public TipoCampo TipoCampo { get; set; }
        //public int IdEncuesta { get; set; }
    }
}
