using System;
using System.Collections.Generic;

namespace ACMEncuesta.ddd.Api.Dtos
{
    public class EncuestaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Guid Guid { get; set; }
        public string Link { get; set; }
        public List<EncuestaCamposDto> ListaDeCampos { get; set; }
        public List<EncuestaCodigosDto> ListaDeCodigos { get; set; }
    }
}
