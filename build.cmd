@echo off

SET VERSION=0.0.0
IF NOT [%1]==[] (set VERSION=%1)

IF [%2]==[true] (dotnet build src/core/core.csproj) ELSE (dotnet pack src/core/core.csproj -o ../../dist -p:Version="%VERSION%" -p:PackageVersion="%VERSION%" -c Release)