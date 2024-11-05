using Backend_p.Application.Services;
using Backend_p.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Backend_p.Application.DI;

public static class DependencyInjectionApp
{
    public static void RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IRequestPokemon, RequestPokemon>();
    }
}
