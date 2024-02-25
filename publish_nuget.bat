@echo off
rem ====== projects ======

set projects=Asv.Avalonia.Toolkit

rem ====== projects ======

 rem copy version to text file, then in variable
git describe --tags --abbrev=4 >>version.txt
SET /p VERSION=<version.txt
del version.txt

rem Extracting only X.X.X from the version string
SET VERSION=%VERSION:v=%

(for %%p in (%projects%) do (
	cd src\%%p\bin\Release\
	dotnet nuget push%%p.%VERSION%.nupkg --skip-duplicate --source https://api.nuget.org/v3/index.json
	dotnet nuget %%p.%VERSION%.nupkg --skip-duplicate --source https://nuget.pkg.github.com/asv-soft/index.json
	cd ../../../../
)) 





