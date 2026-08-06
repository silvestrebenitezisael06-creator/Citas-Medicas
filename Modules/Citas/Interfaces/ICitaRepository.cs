using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citas_Medicas.Modules.Citas.Entities;
using Citas_Medicas.Modules.Citas.DTOS;

namespace Citas_Medicas.Modules.Citas.Interfaces
{
    public interface ICitaRepository
    {
        public List<Cita> FindAll();
        public Cita? FindOne(int id);
        public Cita Create(Cita cita);
        public bool Delete(int id);
        public Cita Update (Cita cita);
    }
}