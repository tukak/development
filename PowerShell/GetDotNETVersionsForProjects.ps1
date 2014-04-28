# This script displays version of .NET framework used in Visual Studio projects

gci -Recurse -Filter *.csproj | sort | %{$xmlFileContent = [xml](Get-Content $_.FullName); write "$_ - $($xmlFileContent.Project.PropertyGroup.TargetFrameworkVersion)"}