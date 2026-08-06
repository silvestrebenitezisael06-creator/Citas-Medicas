using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citas_Medicas.Modules.Citas.Entities;
using Citas_Medicas.Modules.Citas.DTOS;
using Citas_Medicas.Modules.Citas.Repositories;
using Citas_Medicas.Modules.Medicos.DTOS;

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
        public CitaResponse Crear(CrearCita dto)
        {
            Cita nuevaCita = new Cita
            {
                NombrePaciente = dto.NombrePaciente,
                IdPaciente = dto.IdPaciente,
                SeguroMedico = dto.SeguroMedico,
                MedicoId = dto.MedicoId,
                FechaHora = DateTime.SpecifyKind(dto.FechaHora, DateTimeKind.Utc),
                NumeroTelefono = dto.NumeroTelefono,
                NumeroCita = dto.NumeroCita
            };
            nuevaCita = _citasrepository.Create(nuevaCita);
            return new CitaResponse
            {
                Id = nuevaCita.Id,
                NombrePaciente = nuevaCita.NombrePaciente,
                IdPaciente = nuevaCita.IdPaciente,
                SeguroMedico = nuevaCita.SeguroMedico,
                MedicoId = nuevaCita.MedicoId,
                FechaHora = nuevaCita.FechaHora,
                NumeroTelefono = nuevaCita.NumeroTelefono,
                NumeroCita = nuevaCita.NumeroCita,

            Medico = new MedicoResponse
            {
                Id = nuevaCita.Medico.Id,
                NombreMedico = nuevaCita.Medico.NombreMedico,
                Especialidad = nuevaCita.Medico.Especialidad,
                NumeroTelefono = nuevaCita.Medico.NumeroTelefono,
                NumeroConsultorio = nuevaCita.Medico.NumeroConsultorio,
                HorarioAtencion = nuevaCita.Medico.HorarioAtencion
            }

            };
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

        if (dto.MedicoId.HasValue)
        cita.MedicoId = dto.MedicoId.Value;

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