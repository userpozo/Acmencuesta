using System.Collections.Generic;

namespace ACMEncuesta.ddd.Api.Dtos
{
    public class EncuestaAlmacenarDto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<EncuestaCamposAlmacenarDto> ListaDeCampos { get; set; }
    }
}
