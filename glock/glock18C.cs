using System.Diagnostics;

public class BuildBundlesPlay : MonoBehaviour
{
    void Start()
    {
        string outputPath = "Assets/AssetBundles";

        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
        }

        BuildPipeline.BuildAssetBundles(outputPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);

        Debug.Log("AssetBundles built in " + outputPath);
    }
}