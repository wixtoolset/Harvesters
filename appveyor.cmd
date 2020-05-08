@setlocal
@pushd %~dp0

dotnet pack -c Release src\WixToolset.Harvesters

@popd
@endlocal
