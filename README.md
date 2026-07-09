# Ting

A .NET client library for sending push notifications via a Ting notification endpoint.

Published to NuGet as [`t0m.Ting`](https://www.nuget.org/packages/t0m.Ting).

## Installation

```bash
dotnet add package t0m.Ting
```

## Usage

```csharp
builder.Services.AddTingClient(builder.Configuration);
```

```json
{
  "Ting": {
    "BaseUrl": "https://your-ting-endpoint.example.com",
    "ApiKey": "your-api-key"
  }
}
```

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
