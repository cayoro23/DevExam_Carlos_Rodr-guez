using DevExam.Controllers;
using DevExam.Model;
using DevExam.Service;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExamTest
{
    internal class CustomerControllerTest
    {
        private Mock<ICustomerService> _mockCustomerService;
        private CustomerController _customerController;

        [SetUp]
        public void Setup()
        {
            this._mockCustomerService = new Mock<ICustomerService>();
            this._customerController = new CustomerController(this._mockCustomerService.Object);

            this._mockCustomerService
                .Setup(
                    mock => mock.GetCustomerPersonalDataList(It.Is<double>(x => x == 60))
                ).Returns(new List<string> {"Miguel Grau", "Cesar Vallejo"});
        }

        [Test]
        public void shouldReturCustomersPersonalDataForSpecificAmount()
        {
            ActionResult<List<string>> result = this._customerController.GetPersonalData(60);
            var okObjectResult = (OkObjectResult) result.Result;
            List<string> list = (List<string>)okObjectResult.Value;

            CollectionAssert.Contains(list, "Miguel Grau");
            CollectionAssert.Contains(list, "Cesar Vallejo");
        }
    }
}
