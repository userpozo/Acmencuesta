using ACMEncuenta.ddd.Dominio.Entidades;
using ACMEncuesta.ddd.Api.Dtos;
using ACMEncuesta.ddd.Infraestructura.Data;
using ACMEncuesta.ddd.Infraestructura.Repositorios;
using ACMEncuesta.ddd.Infraestructura.Servicios;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMEncuesta.ddd.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EncuestaController : ControllerBase
    {
        private readonly ServicioEncuesta _service;
        private readonly IMapper _mapper;

        public EncuestaController(ApplicationDbContext context, IMapper mapper)
        {
            this._service = new ServicioEncuesta(new RepositorioEncuesta(context));
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<List<EncuestaDto>> Get()
        {
            var resultado = await this._service.ObtenerTodos();
            return this._mapper.Map<List<EncuestaDto>>(resultado);
        }

        [HttpGet("{id:int}")]
        public async Task<EncuestaDto> Get([FromRoute] int id)
        {
            var resultado = await this._service.ObtenerPorIdConCampos(id);
            return this._mapper.Map<EncuestaDto>(resultado);
        }

        [HttpPost]
        public async Task Post([FromBody] EncuestaAlmacenarDto encuesta)
        {
            var resultadoDto = this._mapper.Map<Encuesta>(encuesta);
            resultadoDto.Guid = Guid.NewGuid();
            resultadoDto.Link = string.Format("https://localhost:44301/api/LlenarEncuesta/{0}", resultadoDto.Guid.ToString());
            await this._service.Agregar(resultadoDto);
        }

        [HttpPut("generarCodigos/{id:int}")]
        public async Task GenerarCodigos([FromRoute] int id, [FromBody] EncuestaGenerarCodigosDto encuestaGenerarCodigosDto)
        {
            var resultadoEntidad = await this._service.ObtenerPorIdConCodigos(id);
            resultadoEntidad = this._mapper.Map(encuestaGenerarCodigosDto, resultadoEntidad);
            await this._service.Actualizar(resultadoEntidad, id);
        }

        [HttpPut("{id:int}")]
        public async Task Put([FromRoute] int id, [FromBody] EncuestaActualizarDto encuesta)
        {
            var ids = encuesta.ListaDeCampos.Where(xx => xx.Id != 0).Select(x => x.Id).ToList();
            var resultadoEntidad = this._service.ObtenerPadreConHijosPorId(id, ids);

            resultadoEntidad = this._mapper.Map(encuesta, resultadoEntidad);
            await this._service.Actualizar(resultadoEntidad, id);
        }

        [HttpDelete("{id:int}")]
        public async Task Delete([FromRoute] int id)
        {
            await this._service.Eliminar(id);
        }
    }
}
