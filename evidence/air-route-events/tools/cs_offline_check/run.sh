#!/bin/sh
# Offline cross-check of Reconstructed/Assets/Truxton/Round1EventStack.cs against ../../sims/*.json WITHOUT starting Unity:
# compiles the class with Unity 2023.2's Roslyn (C# 9) against the real UnityEngine.CoreModule.dll (Vector3/Mathf are
# managed), with a stub Round1EnemyWaves (its nested data classes only), and runs it on Unity's bundled .NET 6 runtime.
# usage (Git Bash): sh run.sh [workdir]     prints PASS/FAIL per sim; exit 0 when all pass (same rule as the editor check).
set -e
U="/c/Program Files/Unity 2023.2.22f1/Editor/Data"; R="$U/NetCoreRuntime/shared/Microsoft.NETCore.App/6.0.21"
HERE=$(cd "$(dirname "$0")" && pwd); W=${1:-$HERE/build}; mkdir -p "$W"; cd "$W"
P=D:/games/TruxtonExRecon
{ echo 'using System;using UnityEngine;public class Round1EnemyWaves{'; sed -n 19,49p $P/Reconstructed/Assets/Truxton/Round1EnemyWaves.cs; echo '}'; } > stub.cs
{ echo -nologo; echo -langversion:9; echo -nowarn:CS0414,CS0169; echo -out:harness.dll
  for f in System.Runtime System.Private.CoreLib System.Collections System.Text.Json System.Linq System.Runtime.Extensions netstandard System.Console System.Memory System.IO.FileSystem System.Text.Encoding.Extensions; do echo "-r:\"$(cygpath -w "$R/$f.dll")\""; done
  echo "-r:\"$(cygpath -w "$U/Managed/UnityEngine/UnityEngine.CoreModule.dll")\""
  echo "\"$(cygpath -w $P/Reconstructed/Assets/Truxton/Round1EventStack.cs)\""; echo stub.cs; echo "\"$(cygpath -w "$HERE/harness.cs")\""; } > build.rsp
cp "$U/Managed/UnityEngine/UnityEngine.CoreModule.dll" .
echo '{"runtimeOptions":{"tfm":"net6.0","framework":{"name":"Microsoft.NETCore.App","version":"6.0.21"}}}' > harness.runtimeconfig.json
"$U/NetCoreRuntime/dotnet.exe" "$(cygpath -w "$U/DotNetSdkRoslyn/csc.dll")" @build.rsp
"$U/NetCoreRuntime/dotnet.exe" harness.dll "$(cygpath -w $P/evidence/air-route-events/sims)" "$(cygpath -w $P/Reconstructed/Assets/Resources/StageEnemies)"
