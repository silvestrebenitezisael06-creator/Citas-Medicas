using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citas_Medicas.Data;
using Citas_Medicas.Modules.Medicos.Entities;
using Citas_Medicas.Modules.Medicos.DTOS;   

namespace Citas_Medicas.Modules.Medicos.Repositories
{
    public class MedicoRepository(AppDbContext appDbContext)
    {
        private readonly AppDbContext _context = appDbContext;

        public List<Medico> ObtenerTodas()
        {
            return _context.Medicos.ToList();
        }

        public Medico? FindOne(int id) {
    Medico? medico = _context.Medicos.FirstOrDefault(m => m.Id == id);
    return medico;
    }
    public Medico Create(Medico medico) {
    _context.Medicos.Add(medico);
    _context.SaveChanges();

    return medico;
    }
    public bool Delete(int id) {
    Medico? medico = FindOne(id);

    if (medico is null) {
    return false;
    }

    _context.Medicos.Remove(medico);
    _context.SaveChanges();

    return true;
    }
    public Medico Update(Medico medico) {
    _context.Update(medico);
    _context.SaveChanges();
    return medico;
    }
        
    }
}