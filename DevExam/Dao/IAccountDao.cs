using DevExam.Model;

namespace DevExam.Dao
{
    public interface IAccountDao
    {
        List<Customer> GetCustomers();
    }
}
