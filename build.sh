#!/bin/bash

version="0.0.0"
if [ -n "$1" ]; then version="$1"
fi

if [ "$2" == "true" ]; then dotnet build src/core/core.csproj
else dotnet pack src/core/core.csproj -o ../../dist -p:Version="$version" -p:PackageVersion="$version" -c Release
fi