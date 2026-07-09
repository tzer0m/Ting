using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace t0m.Ting;

/// <summary>
/// Extension methods for registering the Ting client with dependency injection.
/// </summary>
public static class TingServiceCollectionExtensions
{
    /// <summary>
    /// Registers <see cref="TingClient"/> and its configuration with the service collection. Expects a "Ting" section in configuration with BaseUrl and ApiKey values.
    /// </summary>
    public static IServiceCollection AddTingClient(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<TingOptions>(configuration.GetSection("Ting"));
        services.AddHttpClient<TingClient>((serviceProvider, httpClient) =>
        {
            TingOptions options = serviceProvider.GetRequiredService<IOptions<TingOptions>>().Value;
            httpClient.BaseAddress = new Uri(options.BaseUrl);
        });
        return services;
    }
}