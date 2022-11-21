using DevExam.Dao;
using DevExam.Model;
using DevExam.Service;
using DevExam.Service.Impl;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExamTest
{
    internal class CustomerServiceTest
    {
        private Mock<ICustomerDao> _mockCustomerDao;
        private ICustomerService _customerService;

        [SetUp]
        public void Setup()
        {
            this._mockCustomerDao = new Mock<ICustomerDao>();
            this._customerService = new CustomerServiceImpl(this._mockCustomerDao.Object);

            this._mockCustomerDao
                .Setup(
                    mock => mock.GetCustomersThanAccountAmount(It.Is<double>(x => x == 60))
                ).Returns(new List<Customer>
                    {
                        new Customer {Id = 1, Name = "Miguel", Lastname = "Grau"},
                        new Customer {Id = 2, Name = "Cesar", Lastname = "Vallejo"},
                    }
                );
        }

        [Test]
        public void shouldReturCustomersPersonalDataForSpecificAmount()
        {
            List<string> customers = this._customerService.GetCustomerPersonalDataList(60);

            Assert.That(customers.Count, Is.EqualTo(2));
            CollectionAssert.Contains(customers, "Miguel Grau");
            CollectionAssert.Contains(customers, "Cesar Vallejo");
        }
    }
}
