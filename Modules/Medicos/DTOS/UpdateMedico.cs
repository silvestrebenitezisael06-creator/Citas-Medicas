using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citas_Medicas.Modules.Medicos.DTOS
{
    public class UpdateMedico
    {
        public string? NombreMedico { get; set; }
        public string? Especialidad { get; set; }
        public string? NumeroTelefono { get; set; }
        public string? NumeroConsultorio { get; set; }
        public string? HorarioAtencion { get; set; }
    }
}