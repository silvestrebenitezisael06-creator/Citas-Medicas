using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Citas_Medicas.Modules.Citas.DTOS;
using Citas_Medicas.Modules.Citas.Entities;
using Citas_Medicas.Modules.Citas.Services;



namespace Citas_Medicas.Modules.Citas.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
        public class CitasController(CitaService citaService) : ControllerBase
        {
        private readonly CitaService _citaService = citaService;

        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(_citaService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var cita = _citaService.FindById(id);

        if (cita == null)
        {
            return NotFound();
        }

            return Ok(cita);
        }
        
        [HttpPost]
        public IActionResult Create(CrearCita dto)
        {
        var cita = _citaService.Crear(dto);

        return Created("", cita);
        }

        [HttpPatch("{id}")]
        public IActionResult Update(int id, ActualizarCita dto)
        {
        var cita = _citaService.Update(id, dto);

        if (cita == null)
        {
        return NotFound();
        }

        return Ok(cita);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
        bool eliminado = _citaService.Delete(id);

        if (!eliminado)
        {
        return NotFound();
        }
        return Ok();
        }

    }
}
