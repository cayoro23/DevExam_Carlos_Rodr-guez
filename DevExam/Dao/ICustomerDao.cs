using DevExam.Model;

namespace DevExam.Dao;

public interface ICustomerDao
{
    List<Customer> GetCustomersThanAccountAmount(double amount);
}
