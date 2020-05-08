@setlocal
@pushd %~dp0
@set _P=%~dp0build\Release\publish

dotnet pack -c Release src\WixToolset.Harvesters
dotnet pack -c Release src\WixToolset.Harvesters.MSBuild12
dotnet pack -c Release src\WixToolset.Harvesters.MSBuild14

dotnet build -c Release src\WixToolset.Harvesters
dotnet build -c Release src\WixToolset.Harvesters.MSBuild12
dotnet build -c Release src\WixToolset.Harvesters.MSBuild14

@popd
@endlocal
