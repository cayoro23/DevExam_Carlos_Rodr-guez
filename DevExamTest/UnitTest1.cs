using DevExam.Dao;
using DevExam.Model;

namespace DevExamTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

            var context = new ApplicationDbContext();
            List<Customer> customers = new List<Customer>(); ;

            for (int i = 0; i < 10; i++)
            {
                Customer customer = new Customer()
                {
                    Id = i + 1,
                    Name = "CN" + (i + i),
                    Lastname = "CL" + (i + i)
                };

                Random rnd = new Random();
                List<Account> accounts = new List<Account>();

                for (int j = 0; j < 10; j++)
                {
                    Account account = new Account()
                    {
                        Number = (i + 1),
                        Amount = rnd.Next(100)
                    };
                    accounts.Add(account);
                }

                customer.Accounts = accounts;
                customers.Add(customer);
            }

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}