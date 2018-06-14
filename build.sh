#!/bin/bash

version="0.0.0"
if [ -n "$1" ]; then version="$1"
fi

semVersion="0.0.0"
if [ -n "$2" ]; then semVersion="$2"
fi

dotnet pack src/core/core.csproj -o ../../dist -p:Version="$version" -p:PackageVersion="$semVersion" -c Release