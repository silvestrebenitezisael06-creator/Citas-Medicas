using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citas_Medicas.Modules.Citas.DTOS;

namespace Citas_Medicas.Modules.Citas.Interfaces
{
    public interface ICitaService
    {
        public List<CitaResponse> FindAll();
        public CitaResponse? FindById(int id);
        public CitaResponse Create(CrearCita dto);
        public CitaResponse? Update(int id, ActualizarCita dto);
        public bool Delete(int id);
    }
}