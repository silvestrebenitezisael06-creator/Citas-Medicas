using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citas_Medicas.Modules.Citas.DTOS
{
    public class CrearCita
    {
    public int Id { get; set; }
    public required string NombrePaciente { get; set; }
    public required int IdPaciente { get; set; }
    public required string SeguroMedico { get; set; }
    public required int MedicoId { get; set; }
    public required DateTime FechaHora { get; set; }
    public required string NumeroTelefono { get; set; }
    public required string NumeroCita { get; set; }
    }
}