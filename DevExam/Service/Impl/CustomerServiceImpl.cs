using DevExam.Dao;

namespace DevExam.Service.Impl
{
    public class CustomerServiceImpl : ICustomerService
    {
        private readonly ICustomerDao customerDao;

        public CustomerServiceImpl(ICustomerDao customerDao)
        {
            this.customerDao = customerDao;
        }

        List<string> ICustomerService.GetCustomerPersonalDataList(double amount)
        {
            return this.customerDao.GetCustomersThanAccountAmount(amount)
                .Select(x => x.Name + " " + x.Lastname)
                .ToList();
        }
    }
}
