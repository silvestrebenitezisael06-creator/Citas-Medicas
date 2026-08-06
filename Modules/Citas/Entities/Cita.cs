using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citas_Medicas.Modules.Medicos.Entities;

namespace Citas_Medicas.Modules.Citas.Entities
{
    public class Cita
    {
    public int Id { get; set; }
    public required string NombrePaciente { get; set; }
    public required int IdPaciente { get; set; }
    public required string SeguroMedico { get; set; }
    public int MedicoId { get; set; }
    public required DateTime FechaHora { get; set; }
    public required string NumeroTelefono { get; set; }
    public required string NumeroCita { get; set; }
    public Medico Medico { get; set; } = null!;
    }
}