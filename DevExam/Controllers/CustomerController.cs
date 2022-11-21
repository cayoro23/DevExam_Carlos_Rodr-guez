using DevExam.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;

namespace DevExam.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet(Name = "PersonalData")]
        public ActionResult<List<string>> GetPersonalData([FromRoute] double amount)
        {
            return Ok(this._customerService.GetCustomerPersonalDataList(amount));
        }
    }
}
