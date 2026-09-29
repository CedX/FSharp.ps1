using module PSScriptAnalyzer
using module ./Cmdlets.psm1

"Performing the static analysis of source code..."
Invoke-ScriptAnalyzer $PSScriptRoot -ExcludeRule PSUseShouldProcessForStateChangingFunctions -Recurse
Invoke-FSharpLint FSharp.slnx -Configuration Configuration/FSharpLint.json
Test-ModuleManifest FSharp.psd1 | Out-Null
