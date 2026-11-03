// Native reconstruction from SHA256 b3ee81c6bf8506e8134512e14640b7bdae6092269893ccdea40f2afe758b5ab6.
// Replacement candidate for TXEKernel.BootTXE ONLY. Do not import beside the original type DLL.
// Methods are reconstructed from native state machines; dependencies remain unrecovered.
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using KANAI.Kernel;
namespace TXEKernel
{
    public class BootTXE : MonoBehaviour
    {
        [SerializeField] private string _SceneName = string.Empty;
        // Native coroutine MoveNext RVA 0x26e9900. Static offset identities match ApplicationUtility.
        private IEnumerator Start()
        {
            yield return null;
            LocalizeUtility.SetDefaultAppLanguage();
            ApplicationUtility.Start();
            ApplicationUtility.bootRoot = this;
            ApplicationUtility.onSoftwareReboot += _softReboot;
            yield return ApplicationUtility.SetupAssetLoader();
            yield return _loadScene();
            while (!ApplicationUtility.IsReady) yield return null;
        }
        // Native coroutine MoveNext RVA 0x26ea230: edx=1 is LoadSceneMode.Additive.
        private IEnumerator _loadScene()
        {
            yield return SceneManager.LoadSceneAsync(_SceneName, LoadSceneMode.Additive);
        }
        // Native coroutine MoveNext RVA 0x26ea320; float constant at RVA0x34e0bcc is 1.0f.
        private IEnumerator _softReboot()
        {
            yield return SceneManager.UnloadSceneAsync(_SceneName);
            yield return null;
            yield return Resources.UnloadUnusedAssets();
            GC.Collect();
            yield return new WaitForSeconds(1f);
            yield return _loadScene();
        }
    }
}
