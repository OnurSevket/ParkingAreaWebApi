using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        public bool Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(Customer entity, out int? insertedId)
        {
            throw new NotImplementedException();
        }

        public int InsertorUpdate(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
