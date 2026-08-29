[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.messages.msteams.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.messages.msteams/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.messages.msteams/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.messages.msteams/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.messages.msteams.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.messages.msteams/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.messages.msteams/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.messages.msteams/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.Messages.MsTeams

An AutoFaker override for the routing metadata on `MsTeamsMessage`.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.Messages.MsTeams
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.Messages.MsTeams;
using Soenneker.Messages.MsTeams;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides = [new MsTeamsMessageOverride()];

MsTeamsMessage message = autoFaker.Generate<MsTeamsMessage>();
```

The override sets `Channel` to `notifications`, `Queue` to `msteams`, and `Sender` to the current machine name. Other message properties are left to AutoFaker. The fixed channel and queue values make this override opinionated; add a later override when a test needs different routing.
