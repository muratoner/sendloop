# Sendloop

A .NET client library for Sendloop v3 API endpoints.

## Why this package

Sendloop provides a single entry point (`SendloopManager`) for common email marketing operations:

- Account info
- Subscriber and list management
- Campaign operations
- Suppression list operations
- System metadata endpoints

## Installation

```powershell
Install-Package Sendloop
```

## Supported framework

- .NET Framework 4.5

## Quick start

```csharp
using Sendloop;

var manager = new SendloopManager("YOUR_SENDLOOP_API_KEY");
var account = manager.Account.GetInfo();

if (account.Success)
{
    System.Console.WriteLine(account.AccountInfo.Email);
}
```

## API modules

`SendloopManager` exposes:

- `System`
- `Account`
- `SubscriberList`
- `Subscriber`
- `Campaign`
- `SuppressionList`

## Notes

- This package targets Sendloop v3 endpoints.
- Test project in the repository is integration-oriented and requires a real API key.

## Source and issues

- Source: https://github.com/muratoner/Sendloop
- Issues: https://github.com/muratoner/Sendloop/issues
