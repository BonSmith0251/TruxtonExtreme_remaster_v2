// Data-only reconstruction from original Unity.Microsoft.GDK metadata and GDKEdition.asset.
// Original platform API implementation is not present in this assembly.
using UnityEngine;
namespace Unity.XGamingRuntime
{
    public class GdkEditionAsset : ScriptableObject
    {
        [SerializeField]
        [Tooltip("The GDK Edition number used for API compatibility checks")]
        private int m_EditionNumber;
    }
}
