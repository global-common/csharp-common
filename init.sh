set -uvx
set -e
git lfs install
git lfs track "*.zip"
git lfs track "*.7z"
git lfs track "*.001"
git lfs track "*.002"
git lfs track "*.003"
git lfs track "*.004"
git lfs track "*.005"
git lfs track "*.006"
git lfs track "*.007"
git lfs track "*.008"
git lfs track "*.009"
git lfs track "*.010"
git lfs track "*.exe"
git lfs track "*.pdb"
git lfs track "*.dll"
git lfs track "*.jar"
git lfs track "*.msi"
git add .gitattributes
