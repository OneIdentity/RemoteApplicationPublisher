[CmdletBinding()]
Param(
    [Parameter(Mandatory=$true, Position=0)]
    [string]$SourceDir,
    [Parameter(Mandatory=$true, Position=1)]
    [string]$SemanticVersion,
    [Parameter(Mandatory=$true, Position=2)]
    [string]$BuildId,
    [Parameter(Mandatory=$true, Position=3)]
    [bool]$IsPrerelease
)

Write-Host "SemanticVersion = $SemanticVersion"
Write-Host "BuildId = $BuildId"

$local:BuildNumber = ($BuildId % 65535) # max value for version part on Windows is 65534
Write-Host "BuildNumber = $($local:BuildNumber)"

$local:PackageCodeMarker = "255.255.65534"
$local:AssemblyCodeMarker = "255.255.65534.65534"
$local:AssemblyVersion = "${SemanticVersion}.$($local:BuildNumber)"
$local:PwShellVersion = "${SemanticVersion}.$($BuildId)"
if ($IsPrerelease)
{
    $local:PackageVersion = "${SemanticVersion}-dev-$($local:BuildNumber)"
}
else
{
    $local:PackageVersion = $SemanticVersion
}
Write-Host "PackageCodeMarker = $($local:PackageCodeMarker)"
Write-Host "AssemblyCodeMarker = $($local:AssemblyCodeMarker)"
Write-Host "PackageVersion = $($local:PackageVersion)"
Write-Host "AssemblyVersion = $($local:AssemblyVersion)"
Write-Host "PwShellVersion = $($local:PwShellVersion)"

Write-Host "Replacing version information in RemoteApplicationPublisher assembly info"
$local:ProjectFile = (Join-Path $PSScriptRoot "RemoteApplicationPublisher\Properties\AssemblyInfo.cs")
(Get-Content $local:ProjectFile -Raw).replace($local:AssemblyCodeMarker, $local:AssemblyVersion) | Set-Content -Encoding UTF8 $local:ProjectFile
(Get-Content $local:ProjectFile -Raw).replace($local:PackageCodeMarker, $local:PackageVersion) | Set-Content -Encoding UTF8 $local:ProjectFile
Write-Output "*****"
Get-Content $local:ProjectFile
Write-Output "*****"

Write-Output "##vso[task.setvariable variable=VersionString;]$($local:AssemblyVersion)"
Write-Output "##vso[task.setvariable variable=PwShellVersionString;]$($local:PwShellVersion)"
