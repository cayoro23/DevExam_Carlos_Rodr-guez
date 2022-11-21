using DevExam.Dao;
using DevExam.Dao.Impl;
using DevExam.Model;
using Microsoft.EntityFrameworkCore;

namespace DevExamTest
{
    internal class CustomerDaoTest
    {
        ApplicationDbContext context;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "pick_or_generate_a_unique_name_here")
            .Options;
            context = new ApplicationDbContext(options);

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

                for (int j = i * 10; j < (i + 1) * 10; j++)
                {
                    Account account = new Account()
                    {
                        Number = (j + 1),
                        Amount = (j + 1) * 10
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
            var customerDao = new CustomerDaoImpl(context);
            Assert.That(customerDao.GetCustomersThanAccountAmount(60).Count, Is.EqualTo(5));
        }
    }
}