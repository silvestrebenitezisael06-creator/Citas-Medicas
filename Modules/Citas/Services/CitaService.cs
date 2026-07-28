using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citas_Medicas.Modules.Citas.Entities;
using Citas_Medicas.Modules.Citas.DTOS;

namespace Citas_Medicas.Modules.Citas.Services
{
    public class CitaService
    {
    private readonly List<Cita> _citas = new();
    public List<Cita> ObtenerTodas()
        {
            return _citas;
        }
        public Cita? ObtenerPorUuid(Guid uuid)
        {
            return _citas.FirstOrDefault(c => c.Uuid == uuid);
        }
        public Cita Crear(CrearCita dto)
        {
            Cita nuevaCita = new Cita
            {
                Uuid = Guid.NewGuid(),
                NombrePaciente = dto.NombrePaciente,
                IdPaciente = dto.IdPaciente,
                SeguroMedico = dto.SeguroMedico,
                Medico = dto.Medico,
                FechaHora = dto.FechaHora,
                NumeroTelefono = dto.NumeroTelefono,
                NumeroCita = dto.NumeroCita
            };

            _citas.Add(nuevaCita);

            return nuevaCita;
        }
        public bool Eliminar(Guid uuid)
        {
            Cita? cita = ObtenerPorUuid(uuid);
            if (cita == null)
                return false;

            _citas.Remove(cita);
            return true;
        }
        public Cita? Actualizar(Guid uuid, ActualizarCita dto)
        {
            Cita? cita = ObtenerPorUuid(uuid);

            if (cita == null)
            {
                return null;
            }

        if (dto.NombrePaciente != null)
        cita.NombrePaciente = dto.NombrePaciente;

        if (dto.IdPaciente.HasValue)
        cita.IdPaciente = dto.IdPaciente.Value;

        if (dto.SeguroMedico != null)
        cita.SeguroMedico = dto.SeguroMedico;

        if (dto.Medico != null)
        cita.Medico = dto.Medico;

        if (dto.FechaHora.HasValue)
        cita.FechaHora = dto.FechaHora.Value;

        if (dto.NumeroTelefono != null)
        cita.NumeroTelefono = dto.NumeroTelefono;

        if (dto.NumeroCita != null)
        cita.NumeroCita = dto.NumeroCita;

            return cita;
        }
    }

        
}