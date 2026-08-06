using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Citas_Medicas.Modules.Citas.Entities;

namespace Citas_Medicas.Modules.Medicos.Entities
{
    public class Medico
    {
        public int Id { get; set; }

        public required string NombreMedico { get; set; }

        public required string Especialidad { get; set; }

        public required string NumeroTelefono { get; set; }

        public required string NumeroConsultorio { get; set; }

        public required string HorarioAtencion { get; set; }
        public ICollection<Cita> Citas= [];
    }
}