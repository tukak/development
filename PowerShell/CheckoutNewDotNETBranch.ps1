#Checkouts new .NET branch from SVN and updates HCILibrary for it

PARAM
(
    [Parameter(Mandatory=$true)]
    [string]$BranchName
)

$targetDirectory = "c:\_svn\dotnet\CS\branches\$BranchName"
$sourceSVNBranch = "https://subversion.homecredit.net/repos/dotnet/dotnetclient/cs/branches/$BranchName"

Write-Host "Checkouting branch $sourceSVNBranch to directory $targetDirectory" -ForegroundColor Magenta

svn checkout $sourceSVNBranch $targetDirectory

Write-Host "Checkout complete!" -ForegroundColor Green

Write-Host "Copying HCILibrary" -ForegroundColor Magenta

Set-Location "$targetDirectory\BuildScript"
.\CopyHCILib.bat

Write-Host "DONE!!!"  -ForegroundColor Green