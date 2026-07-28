using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Citas_Medicas.Modules.Citas.Services;
using Citas_Medicas.Modules.Citas.DTOS;


namespace Citas_Medicas.Modules.Citas.Controllers
{
    public class CitasController
    {
    [ApiController]
    [Route("api/[controller]")]
        public class CitasControllers : ControllerBase
        {
        private readonly CitaService _citaService;

        public CitasControllers(CitaService citaService)
        {
            _citaService = citaService;
        }

        [HttpGet]
        public IActionResult ObtenerTodas()
        {
            return Ok(_citaService.ObtenerTodas());
        }

        [HttpGet("{uuid}")]
        public IActionResult ObtenerPorUuid(Guid uuid)
        {
        var cita = _citaService.ObtenerPorUuid(uuid);

        if (cita == null)
        {
        return NotFound();
        }

        return Ok(cita);
        }
        [HttpPost]
        public IActionResult Crear(CrearCita dto)
        {
        var cita = _citaService.Crear(dto);

        return Created("", cita);
        }

        [HttpPatch("{uuid}")]
        public IActionResult Actualizar(Guid uuid, ActualizarCita dto)
        {
        var cita = _citaService.Actualizar(uuid, dto);

        if (cita == null)
        {
        return NotFound();
        }

        return Ok(cita);
        }

        [HttpDelete("{uuid}")]
        public IActionResult Eliminar(Guid uuid)
            {
            bool eliminado = _citaService.Eliminar(uuid);

            if (!eliminado)
            {
            return NotFound();
            }

            return Ok();
            }
        }
    }
}