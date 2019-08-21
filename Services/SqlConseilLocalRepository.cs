using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendeeEauTest2.Models;

namespace VendeeEauTest2.Services
{
    public class SqlConseilLocalRepository : IRepository<ConseilLocal>
    {
        private VendeeeautestContext _context;

        public SqlConseilLocalRepository(VendeeeautestContext context)
        {
            _context = context;
        }

        public bool Add(ConseilLocal item)
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

        public bool Delete(ConseilLocal item)
        {
            try
            {
                ConseilLocal cl = Get(item.IdConseilLocal);
                if(cl != null)
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

        public bool Edit(ConseilLocal item)
        {
            throw new NotImplementedException();
        }

        public ConseilLocal Get(int id)
        {
            if(_context.ConseilLocal.Count(x=>x.IdConseilLocal == id)>0){
                return _context.ConseilLocal.FirstOrDefault(x => x.IdConseilLocal == id);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<ConseilLocal> GetAll()
        {
            return _context.ConseilLocal;
        }
    }
}
