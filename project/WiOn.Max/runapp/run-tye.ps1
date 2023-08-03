$currentFolder = $PSScriptRoot
$devBuildFolder =  Join-Path $currentFolder "../"

Write-Host "[INFO] START TYE SERVICES RUN WATCH" -ForegroundColor Yellow
Set-Location $currentFolder
$typePort = 30001
Write-Host "[INFO] OPEN URL http://localhost:$typePort/ to view TYE DASHBOARD " -ForegroundColor Cyan
<# Run all services #>
tye run --watch --port $typePort --dashboard

