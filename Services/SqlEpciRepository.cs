using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendeeEauTest2.Models;

namespace VendeeEauTest2.Services
{
    public class SqlEpciRepository : IRepository<Epci>
    {
        private VendeeeautestContext _context;

        public SqlEpciRepository(VendeeeautestContext context)
        {
            _context = context;
        }

        public bool Add(Epci item)
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
            };
        }

        public bool Delete(Epci item)
        {
            try
            {
                Epci epcis = Get(item.IdEpci);
                if (epcis != null)
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

        public bool Edit(Epci item)
        {
            throw new NotImplementedException();
        }

        public Epci Get(int id)
        {
            if (_context.Epci.Count(x => x.IdEpci == id) > 0)
            {
                return _context.Epci.FirstOrDefault(x => x.IdEpci == id);
            }
            else
            {
                return null;
            };
        }

        public IEnumerable<Epci> GetAll()
        {
           return _context.Epci;
        }
    }
}
