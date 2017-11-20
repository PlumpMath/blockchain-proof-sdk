#!/usr/bin/env bash
#
# Generated by: https://github.com/swagger-api/swagger-codegen.git
#

frameworkVersion=net45
netfx=${frameworkVersion#net}

echo "[INFO] Target framework: ${frameworkVersion}"

echo "[INFO] Download nuget and packages"
wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe;
mozroots --import --sync
mono nuget.exe install src/Sphereon.SDK.Blockchain.Proof/packages.config -o packages;

echo "[INFO] Copy DLLs to the 'bin' folder"
mkdir -p bin;
cp packages/Newtonsoft.Json.10.0.3/lib/net45/Newtonsoft.Json.dll bin/Newtonsoft.Json.dll;
cp packages/RestSharp.105.1.0/lib/net45/RestSharp.dll bin/RestSharp.dll;

echo "[INFO] Run 'mcs' to build bin/Sphereon.SDK.Blockchain.Proof.dll"
mcs -sdk:${netfx} -r:bin/Newtonsoft.Json.dll,\
bin/RestSharp.dll,\
System.ComponentModel.DataAnnotations.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/Sphereon.SDK.Blockchain.Proof.dll \
-recurse:'src/Sphereon.SDK.Blockchain.Proof/*.cs' \
-doc:bin/Sphereon.SDK.Blockchain.Proof.xml \
-platform:anycpu

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] bin/Sphereon.SDK.Blockchain.Proof.dll was created successfully"
fi
