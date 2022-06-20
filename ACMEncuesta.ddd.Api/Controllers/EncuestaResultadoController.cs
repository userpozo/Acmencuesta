using ACMEncuesta.ddd.Api.Dtos;
using ACMEncuesta.ddd.Infraestructura.Data;
using ACMEncuesta.ddd.Infraestructura.Repositorios;
using ACMEncuesta.ddd.Infraestructura.Servicios;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACMEncuesta.ddd.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EncuestaResultadoController: ControllerBase
    {
        private readonly ServicioResultadoEncuesta _servicioResultadoEncuesta;
        private readonly IMapper _mapper;

        //private readonly ApplicationDbContext _context;

        public EncuestaResultadoController(ApplicationDbContext context, IMapper mapper)
        {
            this._servicioResultadoEncuesta = new ServicioResultadoEncuesta(new RepositorioResultadoEncuesta(context));
            this._mapper = mapper;
            //this._context = context;
        }

        [HttpGet("{codigoGuid}")]
        public async Task<List<EncuestaCamposValorDto>> Get(Guid codigoGuid)
        {
            var resultado = await this._servicioResultadoEncuesta.ObtenerPorGuid(codigoGuid);
            var map = this._mapper.Map<List<EncuestaCamposValorDto>>(resultado);
            return map;
        }

        //public Task Get(Guid codigoGuid)
        //{
        //    var prueba = (from encuesta in this._context.Encuestas.Cast<Encuesta>()
        //                  where encuesta.Guid == codigoGuid
        //                  join preguntas in this._context.EncuestaCampos on encuesta equals preguntas.Encuesta
        //                  join respuestas in this._context.EncuestaCamposValor on preguntas equals respuestas.EncuestaCampos
        //                  select new
        //                  {
        //                      Encuesta = encuesta,
        //                      Preguntas = preguntas,
        //                      Respuestas = respuestas
        //                  }).AsQueryable();
        //    return Task.FromResult(prueba);
        //}
    }
}
