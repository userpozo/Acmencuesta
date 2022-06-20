using System.Collections.Generic;

namespace ACMEncuesta.ddd.Api.Dtos
{
    public class EncuestaActualizarDto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<EncuestaCamposActualizarDto> ListaDeCampos { get; set; }
    }
}
