
using Microsoft.EntityFrameworkCore;
using DevExam.Model;

namespace DevExam.Dao.Impl
{
    public class CustomerDaoImpl : ICustomerDao
    {
        private readonly ApplicationDbContext _context;

        public CustomerDaoImpl()
        {
        }

        public CustomerDaoImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Customer> GetCustomersThanAccountAmount(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
