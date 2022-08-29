using CrmProject.DataAccess.Abstract;
using CrmProject.DataAccess.Context;
using CrmProject.Entities;

namespace CrmProject.DataAccess
{
    public interface ICustomerRepository: IRepository<Customer>
        
    {
        
    }

    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly DatabaseContext _context;
        public CustomerRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }
        //insert customer data
       

    }

}