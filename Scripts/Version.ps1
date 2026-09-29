"Updating the version number in the sources..."
$version = (Import-PowerShellDataFile FSharp.psd1).ModuleVersion
Get-ChildItem -File -Filter *.fsproj -Recurse | ForEach-Object {
	$content = (Get-Content $_ -Raw) -replace "<Version>\d+(\.\d+){2}</Version>", "<Version>$version</Version>"
	$content = $content -replace "<PackageReference Update=""FSharp.Core"" Version=""\d+(\.\d+){2}"" />", "<PackageReference Update=""FSharp.Core"" Version=""$version"" />"
	$content | Set-Content $_ -NoNewLine
}
