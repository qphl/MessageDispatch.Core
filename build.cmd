@echo off

SET VERSION=0.0.0
IF NOT [%1]==[] (set VERSION=%1)

SET SEMVERSION=0.0.0
IF NOT [%2]==[] (set SEMVERSION=%2)

dotnet pack src/core/core.csproj -o ../../dist -p:Version="%VERSION%" -p:PackageVersion="%SEMVERSION%" -c Release