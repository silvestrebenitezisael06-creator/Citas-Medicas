using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citas_Medicas.Modules.Medicos.DTOS;

namespace Citas_Medicas.Modules.Citas.DTOS
{
    public class CitaResponse
    {
        public int Id { get; set; }
        public  string? NombrePaciente { get; set; } = string.Empty;
        public  int IdPaciente { get; set; }
        public  int MedicoId { get; set; }
        public  string SeguroMedico { get; set; } = string.Empty;
        public required DateTime FechaHora { get; set; }
        public  string? NumeroTelefono { get; set; } = string.Empty;
        public  string? NumeroCita { get; set; } = string.Empty;
        public MedicoResponse? Medico { get; set; }
    }
}