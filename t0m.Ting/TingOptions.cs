namespace t0m.Ting;

/// <summary>
/// Options for configuring the Ting notification client.
/// </summary>
public sealed class TingOptions
{
    /// <summary>
    /// Base URL of the Ting notification endpoint, e.g. "https://api.tzer0m.co.uk".
    /// </summary>
    public string BaseUrl { get; set; } = string.Empty;

    /// <summary>
    /// API key used to authenticate with the Ting endpoint.
    /// </summary>
    public string ApiKey { get; set; } = string.Empty;
}