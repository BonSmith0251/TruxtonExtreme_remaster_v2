// Unity 2023 / Core RP 16 data-attachment compatibility shell.
// Original type was in Unity.RenderPipelines.Core.Runtime (Unity 6).
// The target assembly changes to Assembly-CSharp; remap the source MonoScript pointer explicitly.
// Preserves serialized fields only. Original rendering-layer debug interaction is unrecovered.
using System.Collections.Generic;
using UnityEngine.UI;
namespace UnityEngine.Rendering.UI
{
    public class DebugUIHandlerRenderingLayerField : DebugUIHandlerWidget
    {
        public Text nameLabel;
        public UIFoldout valueToggle;
        public List<DebugUIHandlerIndirectToggle> toggles;
    }
}
