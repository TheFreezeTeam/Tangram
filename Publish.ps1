# TODO build for other environments
dotnet publish .\Source\Tangram.csproj --configuration Release --runtime win10-x64


$CommandDir = $PSScriptRoot + "\bin\netcoreapp3.0\win10-x64"
if (!$env:Path.Contains($CommandDir)) { 
  $env:Path += ";" + $CommandDir
}
