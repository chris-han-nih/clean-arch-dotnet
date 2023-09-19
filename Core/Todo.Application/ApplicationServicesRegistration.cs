using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Todo.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
    {
        // services.AddAutoMapper(typeof(MappingProfile));
        // TODO: 동영상 32분
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}