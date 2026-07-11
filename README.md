# Ting

[![Publish](https://github.com/tzer0m/Ting/actions/workflows/publish.yml/badge.svg)](https://github.com/tzer0m/Ting/actions/workflows/publish.yml)
[![NuGet](https://img.shields.io/nuget/v/t0m.Ting.svg)](https://www.nuget.org/packages/t0m.Ting)
[![NuGet Downloads](https://img.shields.io/nuget/dt/t0m.Ting.svg)](https://www.nuget.org/packages/t0m.Ting)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

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
