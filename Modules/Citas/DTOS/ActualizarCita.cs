using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citas_Medicas.Modules.Citas.DTOS
{
    public class ActualizarCita
    {
        public string? NombrePaciente { get; set; }
        public int? IdPaciente { get; set; }
        public string? SeguroMedico { get; set; }
        public string? Medico { get; set; }
        public DateTime? FechaHora { get; set; }
        public string? NumeroTelefono { get; set; }
        public string? NumeroCita { get; set; }
    }
}