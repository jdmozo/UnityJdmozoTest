using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    AssetBundle[] bundle;
    [TextArea]
    [SerializeField] string[] path;
    [SerializeField] string[] bundle_1;
    [SerializeField] string[] bundle_2;

    private void Start()
    {
        bundle = new AssetBundle[2];
        LoadBundle(path);
        InstantiateFromBundle(bundle_1, bundle_2);

        Debug.Log(Application.dataPath);
    }

    private void LoadBundle(string[] assetPath)
    {
        for (int i = 0; i < assetPath.Length; i++)
        {
            bundle[i] = AssetBundle.LoadFromFile(assetPath[i]);
        }
    }
    // Asset Bundle for the material to not repeat assets.
    // Acoid duplicated data

    private void InstantiateFromBundle(string[] bundle_1, string[] bundle_2)
    {
        for (int i = 0; i < bundle_1.Length; i++)
        {
            var prefab = bundle[0].LoadAllAssets<GameObject>();
            for (int j = 0; j < prefab.Length; j++)
            {
                Instantiate(prefab[i]);
            }
        }

        for (int i = 0; i < bundle_2.Length; i++)
        {
            var prefab = bundle[1].LoadAsset<GameObject>(bundle_2[i]);
            Instantiate(prefab);
        }
    }
}
