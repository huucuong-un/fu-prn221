using Microsoft.Extensions.DependencyInjection;


namespace DiamondPlaza.Services
{
    public static class DependencyInjectionResolver
    {
        public static void ConfigureDI(this IServiceCollection services)
        {
            //services.InitializerDI();
            /*services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ICustomerService, CustomerServices>();
            services.AddScoped<IAdminService, AdminServices>();*/
         
        }
    }
}
