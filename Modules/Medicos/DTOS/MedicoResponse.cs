using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citas_Medicas.Modules.Medicos.DTOS
{
    public class MedicoResponse
    {
        public int Id { get; set; }
        public string NombreMedico { get; set; } = string.Empty;
        public string Especialidad { get; set; } = string.Empty;
        public string  NumeroTelefono { get; set; } = string.Empty;
        public string NumeroConsultorio { get; set; } = string.Empty;
        public string  HorarioAtencion { get; set; } = string.Empty;
    }
}