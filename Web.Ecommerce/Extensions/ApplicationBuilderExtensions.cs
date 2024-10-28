using Web.DataAccess.Repository;
using Web.DataAccess.Repository.IRepository;

namespace Web.Ecommerce.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IServiceCollection AddRepositories(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            return builder.Services;
        }
    }
}
