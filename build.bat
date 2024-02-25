@echo off
rem ====== projects ======

set projects=Asv.Avalonia.Toolkit

rem ====== projects ======

rem build all projects
(for %%p in (%projects%) do (
  	echo %%p
	dotnet restore ./src/%%p/%%p.csproj
	dotnet build ./src/%%p/%%p.csproj -c Release
	dotnet pack ./src/%%p/%%p.csproj -c Release
)) 




