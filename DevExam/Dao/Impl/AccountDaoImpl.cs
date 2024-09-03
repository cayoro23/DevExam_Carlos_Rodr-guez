using DevExam.Model;

namespace DevExam.Dao.Impl;

public class AccountDaoImpl : IAccountDao
{
    private readonly ApplicationDbContext _context;

    public AccountDaoImpl(ApplicationDbContext dbContext)
    {
        _context = dbContext;
    }

    public List<Customer> GetCustomers()
    {
        return _context.Customers.ToList();
    }
}
