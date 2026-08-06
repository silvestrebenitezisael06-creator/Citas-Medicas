using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citas_Medicas.Modules.Medicos.Repositories;
using Citas_Medicas.Modules.Medicos.Entities;
using Citas_Medicas.Modules.Medicos.DTOS;

namespace Citas_Medicas.Modules.Medicos.Services
{
    public class MedicoService
    {
        private readonly MedicoRepository _medicosRepository;

        public MedicoService(MedicoRepository medicosRepository)
        {
            _medicosRepository = medicosRepository;
        }

        public List<Medico> ObtenerTodas()
        {
            return _medicosRepository.ObtenerTodas();
        }
        public Medico? ObtenerPorId(int id)
        {
            return _medicosRepository.FindOne(id);
        }
        public Medico Crear(CreateMedico dto)
        {
            Medico nuevoMedico = new Medico
            {
                NombreMedico = dto.NombreMedico,
                Especialidad = dto.Especialidad,
                NumeroTelefono = dto.NumeroTelefono,
                NumeroConsultorio = dto.NumeroConsultorio,
                HorarioAtencion = dto.HorarioAtencion
            };

            return _medicosRepository.Create(nuevoMedico);
        }
        public bool Eliminar(int id)
        {
            return _medicosRepository.Delete(id);
        }
        public Medico? Actualizar(int id, UpdateMedico dto)
        {
            Medico? medico = _medicosRepository.FindOne(id);

            if (medico == null)
            {
                return null;
            }

            if (dto.NombreMedico != null)
                medico.NombreMedico = dto.NombreMedico;

            if (dto.Especialidad != null)
                medico.Especialidad = dto.Especialidad;

            if (dto.NumeroTelefono != null)
                medico.NumeroTelefono = dto.NumeroTelefono;

            if (dto.NumeroConsultorio != null)
                medico.NumeroConsultorio = dto.NumeroConsultorio;

            if (dto.HorarioAtencion != null)
                medico.HorarioAtencion = dto.HorarioAtencion;

            if (dto.NumeroTelefono != null)
                medico.NumeroTelefono = dto.NumeroTelefono;

            if (dto.NumeroConsultorio != null)
                medico.NumeroConsultorio = dto.NumeroConsultorio;

            return _medicosRepository.Update(medico);
        }
    }
}