@echo off

echo =======================================================================
echo Cosmos.Internationalization
echo =======================================================================

::go to parent folder
cd ..

::create nuget_packages
if not exist nuget_packages (
    md nuget_packages
    echo Created nuget_packages folder.
)

::clear nuget_packages
for /R "nuget_packages" %%s in (*) do (
    del "%%s"
)
echo Cleaned up all nuget packages.
echo.

::start to package all projects

::core
dotnet pack src/Cosmos.I18N.Abstractions/Cosmos.I18N.Abstractions._build.csproj                                     -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.I18N.Countries/Cosmos.I18N.Countries._build.csproj                                           -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.I18N/Cosmos.I18N._build.csproj                                                               -c Release -o nuget_packages --no-restore

::extensions-adapters
dotnet pack src/Cosmos.I18N.Adapters.Json/Cosmos.I18N.Adapters.Json._build.csproj                                   -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.I18N.Adapters.Xml/Cosmos.I18N.Adapters.Xml._build.csproj                                     -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.I18N.Adapters.Yaml/Cosmos.I18N.Adapters.Yaml._build.csproj                                   -c Release -o nuget_packages --no-restore

::extensions-dependency
dotnet pack src/Cosmos.I18N.Extensions.AspectCoreInjector/Cosmos.I18N.Extensions.AspectCoreInjector._build.csproj   -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.I18N.Extensions.Autofac/Cosmos.I18N.Extensions.Autofac._build.csproj                         -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.I18N.Extensions.DependencyInjection/Cosmos.I18N.Extensions.DependencyInjection._build.csproj -c Release -o nuget_packages --no-restore

::extensions-host
dotnet pack src/Cosmos.I18N.Extensions.Host/Cosmos.I18N.Extensions.Host._build.csproj                               -c Release -o nuget_packages --no-restore

::extensions-runs-on
dotnet pack src/Cosmos.I18N.Extensions.AspNetCore/Cosmos.I18N.Extensions.AspNetCore._build.csproj                   -c Release -o nuget_packages --no-restore
dotnet pack src/Cosmos.I18N.Extensions.Console/Cosmos.I18N.Extensions.Console._build.csproj                         -c Release -o nuget_packages --no-restore

::extensions-renderers
dotnet pack src/Cosmos.I18N.Extensions.Handlebars/Cosmos.I18N.Extensions.Handlebars._build.csproj                   -c Release -o nuget_packages --no-restore

::extra-bridges
REM dotnet pack src/Cosmos.Bridges.AbpBridge.I18N/Cosmos.Bridges.AbpBridge.I18N._build.csproj                           -c Release -o nuget_packages --no-restore

for /R "nuget_packages" %%s in (*symbols.nupkg) do (
    del "%%s"
)

echo.
echo.

::push nuget packages to server
for /R "nuget_packages" %%s in (*.nupkg) do ( 	
    dotnet nuget push "%%s" -s "Beta" --skip-duplicate
	echo.
)

::get back to build folder
cd build