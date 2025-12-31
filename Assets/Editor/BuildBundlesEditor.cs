using UnityEditor;
using UnityEngine;
using System.IO;

public class BuildAssetBundle
{
    [MenuItem("Assets/Build AssetBundle")]
    static void Build()
    {
        string outputPath = "AssetBundles";

        // 🔧 Crée le dossier s'il n'existe pas
        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
        }

        BuildPipeline.BuildAssetBundles(
            outputPath,
            BuildAssetBundleOptions.None,
            BuildTarget.StandaloneWindows64
        );

        Debug.Log("AssetBundle build avec succès !");
    }
}
