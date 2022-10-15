using CarDealer.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.DataAccess.Model.Repositories
{
    public class DealerRepository : IRepository<Dealer>
    {

        private readonly CarDealerContext _context;

        public DealerRepository(CarDealerContext context)
        {
            _context = context;
        }

        public Dealer Add(Dealer item)
        {
            var result = _context.Dealers.Add(item);
            _context.SaveChanges();
            return result.Entity;
        }

        public void Delete(Dealer item)
        {
            _context.Dealers.Remove(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {

            var dealer = new Dealer { Id = id };
            _context.Dealers.Attach(dealer);
            Delete(dealer);
        }

        public ICollection<Dealer> Get()
        {
            return _context.Dealers.ToList();
        }

        public Dealer Get(int id)
        {
            var result = _context.Dealers.Where(dealer => dealer.Id == id).FirstOrDefault();
            return result ??= new Dealer();
        }

        public void Update(Dealer item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
