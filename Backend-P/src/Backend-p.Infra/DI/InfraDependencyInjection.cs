using Backend_p.Infra.POKECLIENT;
using Backend_p.Infra.POKECLIENT.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Backend_p.Infra.DI;

public static class InfraDependencyInjection
{
    public static void RegisterInfraClient(this IServiceCollection services)
    {
        services.AddHttpClient<IPokeClient, PokeClient>();
    }
}
