using DevExam.Model;

namespace DevExam.Dao.Impl;

public class CustomerDaoImpl : ICustomerDao
{
    private readonly ApplicationDbContext _context;

    public CustomerDaoImpl(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Customer> GetCustomersThanAccountAmount(double amount)
    {
        return _context
            .Customers.Where(customer => customer.Accounts.Sum(account => account.Amount) > amount)
            .Take(5)
            .ToList();
    }
}
