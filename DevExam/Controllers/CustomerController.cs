using DevExam.Service;
using FluentNHibernate.Conventions.AcceptanceCriteria;
using Microsoft.AspNetCore.Mvc;

namespace DevExam.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    public ActionResult<List<string>> GetPersonalData([FromQuery] double amount)
    {
        var data = _customerService.GetCustomerPersonalDataList(amount);

        if (data?.Count == 0)
        {
            return NotFound("No se encontraron clientes");
        }

        return Ok(data);
    }
}
