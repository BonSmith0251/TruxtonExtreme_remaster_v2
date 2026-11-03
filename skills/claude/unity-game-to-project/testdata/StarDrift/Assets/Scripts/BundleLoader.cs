using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace StarDrift
{
    // Loads an obfuscated asset bundle from StreamingAssets:
    // [32-byte header "SDPK" + junk][bundle bytes XOR repeating key]
    public class BundleLoader : MonoBehaviour
    {
        public string fileName = "bonus.dat";
        public string prefabName = "BonusPickup";
        public float interval = 3f;

        const int HeaderSize = 32;
        static readonly byte[] Key = System.Text.Encoding.ASCII.GetBytes("StarDrift#Key!07");

        public static byte[] Decode(byte[] raw)
        {
            var data = new byte[raw.Length - HeaderSize];
            for (int i = 0; i < data.Length; i++) data[i] = (byte)(raw[i + HeaderSize] ^ Key[i % Key.Length]);
            return data;
        }

        IEnumerator Start()
        {
            var path = Path.Combine(Application.streamingAssetsPath, fileName);
            if (!File.Exists(path)) { Debug.LogError("Bonus bundle missing: " + path); yield break; }
            var bundle = AssetBundle.LoadFromMemory(Decode(File.ReadAllBytes(path)));
            if (bundle == null) { Debug.LogError("Bonus bundle failed to load"); yield break; }
            var prefab = bundle.LoadAsset<GameObject>(prefabName);
            if (prefab == null) { Debug.LogError("Bonus prefab missing in bundle"); yield break; }
            if (GameManager.Instance != null) GameManager.Instance.Count("bundleLoaded");
            while (true)
            {
                yield return new WaitForSeconds(interval);
                Instantiate(prefab, new Vector3(Random.Range(-5f, 5f), 6f, 0f), Quaternion.identity);
                if (GameManager.Instance != null) GameManager.Instance.Count("bonusSpawned");
            }
        }
    }
}
