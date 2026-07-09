using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace t0m.Ting;

/// <summary>
/// Sends push notifications via a Ting notification endpoint.
/// </summary>
public sealed class TingClient(HttpClient HttpClient, IOptions<TingOptions> Options, ILogger<TingClient> Logger)
{
    /// <summary>
    /// Sends a Ting notification with the given title and body.
    /// </summary>
    /// <param name="title">The notification title.</param>
    /// <param name="body">The notification body.</param>
    public async Task SendAsync(string title, string body)
    {
        try
        {
            string url = $"/Ting?title={Uri.EscapeDataString(title)}&body={Uri.EscapeDataString(body)}";
            using HttpRequestMessage request = new(HttpMethod.Get, url);
            request.Headers.Add("X-Api-Key", Options.Value.ApiKey);
            HttpResponseMessage response = await HttpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                Logger.LogWarning("Ting notification failed with status {StatusCode}", (int)response.StatusCode);
            }
        }
        catch (Exception ex)
        {
            Logger.LogWarning("Ting notification failed: {Message}", ex.Message);
        }
    }
}