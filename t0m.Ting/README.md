# t0m.Ting

A .NET client for sending push notifications via a Ting notification endpoint.

## Installation

```bash
dotnet add package t0m.Ting
```

## Usage

Register the client in `Program.cs`:

```csharp
builder.Services.AddTingClient(builder.Configuration);
```

Add configuration to `appsettings.json`:

```json
{
  "Ting": {
    "BaseUrl": "https://your-ting-endpoint.example.com",
    "ApiKey": "your-api-key"
  }
}
```

Inject and use `TingClient` wherever needed:

```csharp
public sealed class MyService(TingClient tingClient)
{
    public async Task DoSomethingAsync()
    {
        await tingClient.SendAsync("Alert", "Something happened.");
    }
}
```

## License

MIT