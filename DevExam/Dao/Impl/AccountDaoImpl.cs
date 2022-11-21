using DevExam.Model;

namespace DevExam.Dao.Impl
{
    public class AccountDaoImpl : IAccountDao
    {
        private readonly ApplicationDbContext applicationDbContext;

        public AccountDaoImpl(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
    }
}
