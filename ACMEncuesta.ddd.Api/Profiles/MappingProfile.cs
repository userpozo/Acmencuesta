using ACMEncuenta.ddd.Dominio.Entidades;
using ACMEncuesta.ddd.Api.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace ACMEncuesta.ddd.Api.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Crear encuesta + preguntas
            CreateMap<Encuesta, EncuestaDto>();
            CreateMap<EncuestaAlmacenarDto, Encuesta>()
                .ForMember(x => x.ListaDeCampos, opcion => opcion.MapFrom(MapListadoDeCamposInsertar));

            // Editar encuesta + preguntas
            CreateMap<EncuestaActualizarDto, Encuesta>()
                .ForMember(x => x.ListaDeCampos, opcion => opcion.MapFrom(MapListadoDeCamposActualizar))
                .ReverseMap();

            // Crear campos de encuesta
            CreateMap<EncuestaCampos, EncuestaCamposDto>()
                .ReverseMap();
            CreateMap<EncuestaCamposAlmacenarDto, EncuestaCampos>();

            // Generar codigos para la encuesta
            CreateMap<EncuestaGenerarCodigosDto, Encuesta>()
                .ForMember(x => x.ListaDeCodigos, opcion => opcion.MapFrom(MapListadoDeCodigosInsertar));
            CreateMap<EncuestaCodigos, EncuestaCodigosDto>();

            // Almacenar/Mostrar respuesta de la encuesta
            CreateMap<EncuestaCamposValor, EncuestaCamposValorDto>()
                .ForMember(x => x.EncuestaCamposDto, opcion => opcion.MapFrom(y => y.EncuestaCampos));
            CreateMap<EncuestaCamposValorAlmacenarDto, EncuestaCamposValor>();
        }

        private List<EncuestaCodigos> MapListadoDeCodigosInsertar(EncuestaGenerarCodigosDto encuestaGenerarCodigosDto, Encuesta encuesta)
        {
            var resultado = new List<EncuestaCodigos>();
            for(int contador = 1; contador <=  encuestaGenerarCodigosDto.CantidadCodigos; contador++)
            {
                resultado.Add(new EncuestaCodigos()
                {
                    EncuestaId = encuesta.Id,
                    CodigoPK = Guid.NewGuid()
                });
            }
            return resultado;
        }

        private List<EncuestaCampos> MapListadoDeCamposInsertar(EncuestaAlmacenarDto encuestaAlmacenarDto, Encuesta encuesta)
        {
            var resultado = new List<EncuestaCampos>();
            if (encuestaAlmacenarDto.ListaDeCampos == null) return resultado;
            foreach(var item in encuestaAlmacenarDto.ListaDeCampos)
            {
                resultado.Add(new EncuestaCampos()
                {
                    EncuestaId = encuesta.Id,
                    Requerido = item.Requerido,
                    Titulo = item.Titulo,
                    TipoCampo = item.TipoCampo
                });
            }
            return resultado;
        }

        private List<EncuestaCampos> MapListadoDeCamposActualizar(EncuestaActualizarDto encuestaActualizarDto, Encuesta encuesta)
        {
            var resultado = new List<EncuestaCampos>();
            if (encuestaActualizarDto.ListaDeCampos == null) return resultado;
            foreach(var item in encuestaActualizarDto.ListaDeCampos)
            {
                resultado.Add(new EncuestaCampos()
                {
                    Id = item.Id,
                    EncuestaId = encuesta.Id,
                    Requerido = item.Requerido,
                    Titulo = item.Titulo,
                    TipoCampo = item.TipoCampo
                });
            }
            return resultado;
        }
    }
}
