# Sendloop [![Build status](https://ci.appveyor.com/api/projects/status/y0rl0kklfxttg05q?svg=true)](https://ci.appveyor.com/project/muratoner/sendloop) [![Gitter](https://badges.gitter.im/muratoner/Sendloop.svg)](https://gitter.im/muratoner/Sendloop?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)

Unofficial .NET client for Sendloop v3 API endpoints.

## Install

Install the [NuGet package](https://www.nuget.org/packages/Sendloop):

```powershell
Install-Package Sendloop
```

## Solution Structure

- `Sendloop`: Main class library (`.NET Framework 4.5`)
- `Sendloop.Test`: MSTest test project (`.NET Framework 4.5`)
- `Sendloop.Console`: Small console sample project

Primary facade:

```csharp
var manager = new SendloopManager("YOUR_API_KEY");
var accountInfo = manager.Account.GetInfo();
```

## Supported Modules

`SendloopManager` exposes these modules:

- `System`
- `Account`
- `SubscriberList`
- `Subscriber`
- `Campaign`
- `SuppressionList`

## Build From Source

This repository uses classic (non-SDK-style) `.csproj` files and `packages.config`.

```bash
nuget restore Sendloop.sln
msbuild Sendloop.sln /p:Configuration=Release
```

Notes:

- `dotnet test` does not discover/run these tests directly because the project is non-SDK-style MSTest.
- Preferred test execution is Visual Studio Test Explorer on Windows.

## Test Project Analysis

`Sendloop.Test` is mostly integration-oriented and requires a real Sendloop API key:

1. Set your API key in `Sendloop.Test/TestBase.cs` (`{YOUR-SENDLOOP-API-KEY}` placeholder).
2. Tests short-circuit if the placeholder key is still present.

Current coverage highlights:

- `TestAccount`
  - `GetInfo`
  - `GetApiKeyList`
  - `UpdateInfo` (updates account data and restores original value)
- `TestCampaign`
  - `GetList`
  - `GetListByStatus` test exists but is commented out
- `TestTransactionEmail`
  - Method scaffold exists, send/assert section is commented out
- `TestSubscriberList`
  - `TestCreate` method currently empty

## Packaging

Build release first, then pack:

```bash
nuget pack Sendloop/Sendloop.csproj -Properties Configuration=Release -OutputDirectory artifacts
```

Push package:

```bash
nuget push artifacts/Sendloop.<version>.nupkg -Source https://api.nuget.org/v3/index.json
```

If needed, set API key once:

```bash
nuget setapikey <NUGET_API_KEY> -Source https://api.nuget.org/v3/index.json
```

## Endpoints Progress

| Progress | Endpoint |
| ------ | ------ |
| Complete | system.timezones.get |
| Complete | system.systemdate.get |
| Complete | system.countries.get |
| Complete | system.accountdate.get |
| Complete | account.info.get |
| Complete | account.info.update |
| Uncomplete | report.list.overall |
| Complete | list.settings.get |
| Complete | list.getlist |
| Complete | list.get |
| Complete | suppression.list.getlist |
| Complete | suppression.list.get |
| Complete | list.update |
| Complete | list.settings.update |
| Complete | list.create |
| Complete | list.delete |
| Uncomplete | customfield.create |
| Uncomplete | customfield.delete |
| Uncomplete | customfield.get |
| Uncomplete | customfield.getlist |
| Uncomplete | customfield.getsizes |
| Uncomplete | customfield.update |
| Uncomplete | segment.create |
| Uncomplete | segment.delete |
| Uncomplete | segment.get |
| Uncomplete | segment.getlist |
| Uncomplete | segment.update |
| Complete | subscriber.get |
| Complete | subscriber.search |
| Complete | subscriber.browse |
| Uncomplete | export.unsubscriptions |
| Uncomplete | export.suppressionlist |
| Uncomplete | export.spamcomplaints |
| Uncomplete | export.bounces |
| Complete | subscriber.update |
| Complete | subscriber.unsubscribe |
| Complete | subscriber.subscribe |
| Complete | subscriber.import |
| Complete | suppression.list.add |
| Uncomplete | campaign.getlistbystatus |
| Complete | campaign.getlist |
| Complete | campaign.get |
| Uncomplete | report.campaign.webbrowserviews |
| Uncomplete | report.campaign.unsubscriptions |
| Uncomplete | report.campaign.spamcomplaints |
| Uncomplete | report.campaign.overall |
| Uncomplete | report.campaign.opens |
| Uncomplete | report.campaign.openlocations |
| Uncomplete | report.campaign.links |
| Uncomplete | report.campaign.forwards |
| Uncomplete | report.campaign.emailclients |
| Uncomplete | report.campaign.bounces |
| Uncomplete | data.campaign.unsubscriptions |
| Uncomplete | data.campaign.openlocations |
| Uncomplete | data.campaign.forwards |
| Uncomplete | data.campaign.emailopens |
| Uncomplete | data.campaign.linkclicks |
| Uncomplete | data.campaign.browserviews |
| Uncomplete | data.campaign.bounces |
| Complete | campaign.update |
| Complete | campaign.delete |
| Complete | campaign.create |
| Complete | campaign.send |
| Complete | campaign.cancelschedule |
| Complete | campaign.resume |
| Complete | campaign.pause |
| Complete | account.api.getlist |
