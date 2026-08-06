using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citas_Medicas.Modules.Medicos.DTOS
{
    public class CreateMedico
    {
        public int Id { get; set; }
        public required string NombreMedico { get; set; }
        public required string Especialidad { get; set; }
        public required string NumeroTelefono { get; set; }
        public required string NumeroConsultorio { get; set; }
        public required string HorarioAtencion { get; set; }
    }
}