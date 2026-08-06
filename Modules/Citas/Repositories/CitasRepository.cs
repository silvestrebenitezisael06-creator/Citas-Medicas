using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citas_Medicas.Data;
using Microsoft.EntityFrameworkCore;
using Citas_Medicas.Modules.Citas.DTOS;
using Citas_Medicas.Modules.Citas.Entities;


namespace Citas_Medicas.Modules.Citas.Repositories
{   
    public class CitasRepository(AppDbContext appDBContext){
    private readonly AppDbContext _context = appDBContext;
    public List<Cita> FindAll()
        {
            return _context.Citas
            .Include(c => c.Medico)
            .ToList();
        }
    
    public Cita? FindOne(int id)
        {
            Cita? cita = _context.Citas
            .Include(c => c.Medico)
            .FirstOrDefault(c => c.Id == id);
            return cita;
        }
        public Cita Create(Cita cita) {
        _context.Citas.Add(cita);
        _context.SaveChanges();

        return _context.Citas
        .Include(c => c.Medico)
        .First(c => c.Id == cita.Id);
        }
        public bool Delete(int id) {
        Cita? cita = FindOne(id);

        if (cita is null) {
        return false;
        }

        _context.Citas.Remove(cita);
        _context.SaveChanges();

        return true;
        }
        public Cita Update(Cita cita) {
        _context.Update(cita);
        _context.SaveChanges();
        return cita;
        }
    }    
}