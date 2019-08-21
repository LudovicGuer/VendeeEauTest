using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendeeEauTest2.Models;

namespace VendeeEauTest2.Services
{
    public class SqlTechnicienRepository : IRepository<Technicien>
    {
        private VendeeeautestContext _context;

        public SqlTechnicienRepository(VendeeeautestContext context)
        {
            _context = context;
        }

        public bool Add(Technicien item)
        {
            try
            {
                _context.Add(item);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Technicien item)
        {
            try
            {
                Technicien tech = Get(item.IdTechnicien);
                if(tech != null)
                {
                    _context.Remove(item);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Edit(Technicien item)
        {
            throw new NotImplementedException();
        }

        public Technicien Get(int id)
        {
            if (_context.Technicien.Count(x=>x.IdTechnicien == id) > 0)
            {
                return _context.Technicien.FirstOrDefault(x => x.IdTechnicien == id);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Technicien> GetAll()
        {
            return _context.Technicien;
        }
    }
}
