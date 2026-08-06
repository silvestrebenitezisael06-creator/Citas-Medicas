using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Citas_Medicas.Modules.Medicos.DTOS;
using Citas_Medicas.Modules.Medicos.Services;
using Citas_Medicas.Modules.Medicos.Entities;

namespace Citas_Medicas.Modules.Medicos.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MedicoController(MedicoService medicoService) : ControllerBase
    {
        private readonly MedicoService _medicoService = medicoService;

        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(_medicoService.ObtenerTodas());
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var medico = _medicoService.ObtenerPorId(id);

            if (medico == null)
            {
                return NotFound();
            }

            return Ok(medico);
        }
        
        [HttpPost]
        public IActionResult Crear(CreateMedico dto)
        {
        var medico = _medicoService.Crear(dto);

        return Created("", medico);
        }

        [HttpPatch("{id}")]
        public IActionResult Actualizar(int id, UpdateMedico dto)
        {
        var medico = _medicoService.Actualizar(id, dto);

        if (medico == null)
        {
        return NotFound();
        }

        return Ok(medico);
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
        bool eliminado = _medicoService.Eliminar(id);

        if (!eliminado)
        {
        return NotFound();
        }

        return Ok();
        }
    }
}