using DevExam.Dao;
using DevExam.Dao.Impl;
using DevExam.Service;
using DevExam.Service.Impl;
using Microsoft.EntityFrameworkCore;

namespace DevExam;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseInMemoryDatabase(databaseName: "CustomersDb")
        );
        services.AddScoped<ICustomerService, CustomerServiceImpl>();
        services.AddScoped<IAccountDao, AccountDaoImpl>();
        services.AddScoped<ICustomerDao, CustomerDaoImpl>();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
}
