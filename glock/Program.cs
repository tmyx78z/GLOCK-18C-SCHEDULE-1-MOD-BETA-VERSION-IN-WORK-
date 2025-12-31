using System.Diagnostics;
using System.IO;
using UnityEditor;
using UnityEngine;

public class BuildBundlesEditor
{
using UnityEngine;
using UnityEditor;
using System.IO;

public class BuildBundlesEditor
{
    [MenuItem("Assets/Build All AssetBundles")]
    static void BuildAllBundles()
    {
        string outputPath = "Assets/AssetBundles";

        // Crée le dossier si il n'existe pas
        if (!Directory.Exists(outputPath))
            Directory.CreateDirectory(outputPath);

        // Construire tous les AssetBundles
        BuildPipeline.BuildAssetBundles(outputPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);

        Debug.Log("AssetBundles built in " + outputPath);
    }
}