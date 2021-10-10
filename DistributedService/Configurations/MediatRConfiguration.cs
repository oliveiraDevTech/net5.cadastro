using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Configurations
{
    public static class MediatRConfiguration
    {
        public static void AddMeditRConfiguration(this IServiceCollection services)
        {
            services.AddMediatR(typeof(Startup).Assembly);//,
                                                          //typeof(IApplicationMapper).Assembly);
        }
    }
}