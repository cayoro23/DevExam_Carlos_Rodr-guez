using DevExam.Dao;

namespace DevExam.Service.Impl;

public class CustomerServiceImpl : ICustomerService
{
    private readonly ICustomerDao _customerDao;

    public CustomerServiceImpl(ICustomerDao customerDao)
    {
        _customerDao = customerDao;
    }

    public List<string> GetCustomerPersonalDataList(double amount)
    {
        return _customerDao
            .GetCustomersThanAccountAmount(amount)
            .Select(x => $"{x.Name} {x.Lastname}")
            .ToList();
    }
}
