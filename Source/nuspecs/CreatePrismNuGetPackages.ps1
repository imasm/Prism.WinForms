### This is just the initial script to get the nuget packages out.  We need to refactor this script to make it easier to maintain and update
### One idea is to force a Visual Studio build using the Release-Signed build configuration before packing the nuspecs

$releaseNotesUri = 'https://github.com/PrismLibrary/Prism/wiki/Release-Notes--Dec-3-2015'

$nugetFileName = 'nuget.exe'
$nugetDownloadUrl = 'https://dist.nuget.org/win-x86-commandline/latest/nuget.exe'
if (!(Test-Path $nugetFileName))
{
    Write-Host 'Downloading Nuget.exe ...'

    (New-Object System.Net.WebClient).DownloadFile($nugetDownloadUrl, $nugetFileName)
}

$coreFileVersion = '6.1.0'


################################
######   Prism.WinForms   ######
################################
$winFromsNuspecPath = 'Prism.WinForms.nuspec'
$winFormsAssemblyPath = '../WinForms/Prism.WinForms/bin/Release/Prism.WinForms.dll'
if ((Test-Path $winFormsAssemblyPath))
{
    $fileInfo = Get-Item $winFormsAssemblyPath
    $winFormsFileVersion = $fileInfo.VersionInfo.ProductVersion
    Invoke-Expression ".\$($nugetFileName) pack $($winFromsNuspecPath) -Prop version=$($winFormsFileVersion) -Prop coreVersion=$($coreFileVersion) -Prop releaseNotes=$($releaseNotesUri)"
}
else
{
    Write-Host 'Prism.WinForms.dll not found'
}




###########################
######  Prism.Unity  ######
###########################
$unityNuspecPath = 'Prism.Unity.WinForms.nuspec'
$unityWinFormsAssemblyPath = '../WinForms/Prism.Unity.WinForms/bin/Release/Prism.Unity.WinForms.dll'
if (!(Test-Path $unityWinFormsAssemblyPath))
{
    Write-Host 'Prism.Unity.WinFroms.dll not found'
}
else
{
    ### all assemblies should be versioned the same, so we can just use the first one ###
    $unityFileInfo = Get-Item $unityWinFormsAssemblyPath
    $unityFileVersion = $unityFileInfo.VersionInfo.ProductVersion   

    Invoke-Expression ".\$($nugetFileName) pack $($unityNuspecPath) -Prop version=$($unityFileVersion) -Prop winFormsVersion=$($winFormsFileVersion) -Prop releaseNotes=$($releaseNotesUri)"
}


Read-Host 'Press Enter to continue'