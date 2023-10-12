set -uvx
set -e
#pushd ~/cmd/
#deno compile --allow-all my7z.js
#popd
#my7z.exe x -aos -otmp https://cdn.azul.com/zulu/bin/zulu17.44.53-ca-jdk17.0.8.1-win_x64.zip
7z.exe x -aos -otmp zulu17.44.53-ca-jdk17.0.8.1-win_x64-stripped.zip
