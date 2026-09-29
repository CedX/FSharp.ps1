# Installation

## Requirements
Before installing **FSharp.Core for PowerShell**, you need to make sure
you have [PowerShell](https://learn.microsoft.com/en-us/powershell) up and running.

You can verify if you're already good to go with the following command:

```powershell
pwsh --version
# PowerShell 7.6.0
```

## Installing with PSResourceGet package manager

### 1. Install it
From a command prompt, run:

```powershell
Install-PSResource Belin.FSharp -Repository PSGallery
```

### 2. Import it
Add the `Belin.FSharp` module as a dependency
in your [module manifest](https://learn.microsoft.com/en-us/powershell/module/microsoft.powershell.core/about/about_module_manifests):

```powershell
@{
  RequiredModules = @(
    "Belin.FSharp"
  )
}
```
