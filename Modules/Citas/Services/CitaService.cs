using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citas_Medicas.Modules.Citas.Entities;
using Citas_Medicas.Modules.Citas.DTOS;
using Citas_Medicas.Modules.Citas.Repositories;

namespace Citas_Medicas.Modules.Citas.Services
{
    public class CitaService(CitasRepository citasrepository)
    {
    private readonly CitasRepository _citasrepository = citasrepository;
    public List<Cita> FindAll()
        {
            return _citasrepository.FindAll();
        }
        public Cita? FindById(int id)
        {
            Cita? cita= _citasrepository.FindOne(id);
            return cita;
        }
        public Cita Crear(CrearCita dto)
        {
            Cita cita = new()
            {
                NombrePaciente = dto.NombrePaciente,
                IdPaciente = dto.IdPaciente,
                SeguroMedico = dto.SeguroMedico,
                Medico = dto.Medico,
                FechaHora = DateTime.SpecifyKind(dto.FechaHora, DateTimeKind.Utc),
                NumeroTelefono = dto.NumeroTelefono,
                NumeroCita = dto.NumeroCita
            };

            return _citasrepository.Create(cita);
        }

        public Cita? Update(int id, ActualizarCita dto)
        {
            Cita? cita = _citasrepository.FindOne(id);

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
        cita.FechaHora = DateTime.SpecifyKind(dto.FechaHora.Value, DateTimeKind.Utc);

        if (dto.NumeroTelefono != null)
        cita.NumeroTelefono = dto.NumeroTelefono;

        if (dto.NumeroCita != null)
        cita.NumeroCita = dto.NumeroCita;

            return _citasrepository.Update(cita);
        }

        public bool Delete(int id)
        {
            Cita? cita = FindById(id);
            if (cita == null)
                return false;

            _citasrepository.Delete(cita.Id);
            return true;
        }
    }
}