# FSharp.Core for PowerShell
`FSharp.Core` redistributables from [F#](https://learn.microsoft.com/en-us/dotnet/fsharp),
for [PowerShell](https://learn.microsoft.com/en-us/powershell) modules.
	
## Quick start
Install the latest version of **FSharp.Core for PowerShell**
with [PSResourceGet](https://learn.microsoft.com/en-us/powershell/module/microsoft.powershell.psresourceget) package manager:

```powershell
Install-PSResource Belin.FSharp
```

For detailed instructions, see the [installation guide](Installation.md).

## Usage
This module is meant to be used as a dependency by other PowerShell modules written in [F#](https://learn.microsoft.com/en-us/dotnet/fsharp).  
It loads the `FSharp.Core` assembly into the PowerShell session, so that your own module does not have to ship it.

Binary modules bundling their own copy of `FSharp.Core.dll` cannot be loaded side by side
if they reference different versions of this assembly: the first imported module wins, and the others fail to load.

By depending on this module, all F#-based modules share a single copy of `FSharp.Core` assembly.

### Declaring the dependency
Add a dependency to the [manifest](https://learn.microsoft.com/en-us/powershell/module/microsoft.powershell.core/about/about_module_manifests) of your module:

```powershell
@{
  RequiredModules = @(
    @{ ModuleName = "Belin.FSharp"; ModuleVersion = "10.1.401" }
  )
}
```

The `ModuleVersion` key specifies the minimum version of `FSharp.Core` assembly required by your module.

### Checking the assembly version
The module provides a single cmdlet, `Get-FSharpVersion`, which returns the version number
of the provided `FSharp.Core` assembly as a [SemanticVersion](https://learn.microsoft.com/en-us/dotnet/api/system.management.automation.semanticversion) object:

```powershell
Import-Module Belin.FSharp
Get-FSharpVersion
# 10.1.401
```
