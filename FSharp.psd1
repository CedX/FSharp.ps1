@{
	DefaultCommandPrefix = "FSharp"
	ModuleVersion = "10.1.401"
	PowerShellVersion = "7.6"
	RootModule = "Binaries/Belin.FSharp.dll"

	Author = "Cédric Belin <cedx@outlook.com>"
	CompanyName = "Cedric-Belin.fr"
	Copyright = "© Cédric Belin"
	Description = "FSharp.Core redistributables from F#, for PowerShell modules."
	GUID = "54f3eb63-42f2-42f7-8685-840dc06affc6"

	AliasesToExport = @()
	CmdletsToExport = , "Get-Version"
	FunctionsToExport = @()
	RequiredAssemblies = , "Binaries/FSharp.Core.dll"
	VariablesToExport = @()

	PrivateData = @{
		PSData = @{
			LicenseUri = "https://github.com/CedX/FSharp.ps1/blob/main/License.md"
			ProjectUri = "https://github.com/CedX/FSharp.ps1"
			ReleaseNotes = "https://github.com/CedX/FSharp.ps1/releases"
			Tags = "assembly", "dotnet", "fsharp", "module", "powershell"
		}
	}
}
