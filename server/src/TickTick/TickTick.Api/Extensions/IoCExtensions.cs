using TickTick.Api.Services;

namespace TickTick.Api
{
    public static class IoCExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IPersonsService, PersonsService>();
        }
    }
}
