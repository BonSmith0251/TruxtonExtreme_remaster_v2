namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005C3")]
internal static class RenderEvents
{
	[Token(Token = "0x4001496")]
	private static readonly ProfilerMarker k_NudgeVerticesMarker; //Field offset: 0x0
	[Token(Token = "0x4001497")]
	private static readonly float VisibilityTreshold; //Field offset: 0x8

	[Address(RVA = "0x330A7E0", Offset = "0x3309BE0", Length = "0x73")]
	[Token(Token = "0x600296A")]
	private static RenderEvents() { }

	[Address(RVA = "0x3305370", Offset = "0x3304770", Length = "0x952")]
	[Token(Token = "0x6002954")]
	internal static uint DepthFirstOnChildAdded(RenderTreeManager renderTreeManager, VisualElement parent, VisualElement ve, int index) { }

	[Address(RVA = "0x3305CD0", Offset = "0x33050D0", Length = "0x649")]
	[Token(Token = "0x600295B")]
	private static void DepthFirstOnClippingChanged(RenderTreeManager renderTreeManager, RenderData parentRenderData, RenderData renderData, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats) { }

	[Address(RVA = "0x3306320", Offset = "0x3305720", Length = "0x1A3")]
	[Token(Token = "0x6002955")]
	internal static uint DepthFirstOnElementRemoving(RenderTreeManager renderTreeManager, VisualElement ve) { }

	[Address(RVA = "0x33064D0", Offset = "0x33058D0", Length = "0x3EF")]
	[Token(Token = "0x600295C")]
	private static void DepthFirstOnOpacityChanged(RenderTreeManager renderTreeManager, float parentCompositeOpacity, RenderData renderData, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration = false) { }

	[Address(RVA = "0x33068C0", Offset = "0x3305CC0", Length = "0x4DA")]
	[Token(Token = "0x600295E")]
	private static void DepthFirstOnTransformOrSizeChanged(RenderTreeManager renderTreeManager, RenderData renderData, uint dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats) { }

	[Address(RVA = "0x3306DA0", Offset = "0x33061A0", Length = "0x179")]
	[Token(Token = "0x6002956")]
	private static void DepthFirstRemoveRenderData(RenderTreeManager renderTreeManager, RenderData renderData) { }

	[Address(RVA = "0x3306F20", Offset = "0x3306320", Length = "0x10E")]
	[Token(Token = "0x6002962")]
	private static ClipMethod DetermineSelfClipMethod(RenderTreeManager renderTreeManager, RenderData renderData) { }

	[Address(RVA = "0x3307030", Offset = "0x3306430", Length = "0x8D")]
	[Token(Token = "0x6002959")]
	private static void DisconnectRenderTreeFromParent(RenderTree parentTree, RenderTree nestedTree) { }

	[Address(RVA = "0x33070C0", Offset = "0x33064C0", Length = "0x9D")]
	[Token(Token = "0x6002958")]
	private static void DisconnectSubTree(RenderData renderData) { }

	[Address(RVA = "0x3307160", Offset = "0x3306560", Length = "0x104")]
	[Token(Token = "0x6002957")]
	private static void DoDepthFirstRemoveRenderData(RenderTreeManager renderTreeManager, RenderData renderData) { }

	[Address(RVA = "0x3307270", Offset = "0x3306670", Length = "0x25E")]
	[Token(Token = "0x6002953")]
	private static Vector4 GetClipRectIDClipInfo(RenderData renderData) { }

	[Address(RVA = "0x33074D0", Offset = "0x33068D0", Length = "0x1C3")]
	[Token(Token = "0x6002952")]
	private static Matrix4x4 GetTransformIDTransformInfo(RenderData renderData) { }

	[Address(RVA = "0x33076A0", Offset = "0x3306AA0", Length = "0x47B")]
	[Token(Token = "0x6002968")]
	private static bool InitColorIDs(RenderTreeManager renderTreeManager, VisualElement ve) { }

	[Address(RVA = "0x3307B20", Offset = "0x3306F20", Length = "0x1F")]
	[Token(Token = "0x6002966")]
	internal static bool NeedsColorID(VisualElement ve) { }

	[Address(RVA = "0x3307B40", Offset = "0x3306F40", Length = "0xE8")]
	[Token(Token = "0x6002967")]
	internal static bool NeedsTextCoreSettings(VisualElement ve) { }

	[Address(RVA = "0x3307C30", Offset = "0x3307030", Length = "0x38")]
	[Token(Token = "0x6002965")]
	private static bool NeedsTransformID(VisualElement ve) { }

	[Address(RVA = "0x3307C70", Offset = "0x3307070", Length = "0x633")]
	[Token(Token = "0x6002960")]
	private static bool NudgeVerticesToNewSpace(RenderData renderData, RenderTreeManager renderTreeManager, UIRenderDevice device) { }

	[Address(RVA = "0x33082B0", Offset = "0x33076B0", Length = "0x208")]
	[Token(Token = "0x600295D")]
	private static void OnColorChanged(RenderTreeManager renderTreeManager, RenderData renderData, uint dirtyID, ref ChainBuilderStats stats) { }

	[Address(RVA = "0x33084C0", Offset = "0x33078C0", Length = "0x149")]
	[Token(Token = "0x6002961")]
	private static void PrepareNudgeVertices(UIRenderDevice device, MeshHandle mesh, out IntPtr src, out IntPtr dst, out int count) { }

	[Address(RVA = "0x3308610", Offset = "0x3307A10", Length = "0x106")]
	[Token(Token = "0x600294E")]
	internal static void ProcessOnClippingChanged(RenderTreeManager renderTreeManager, RenderData renderData, uint dirtyID, ref ChainBuilderStats stats) { }

	[Address(RVA = "0x3308720", Offset = "0x3307B20", Length = "0x82")]
	[Token(Token = "0x6002950")]
	internal static void ProcessOnColorChanged(RenderTreeManager renderTreeManager, RenderData renderData, uint dirtyID, ref ChainBuilderStats stats) { }

	[Address(RVA = "0x33087B0", Offset = "0x3307BB0", Length = "0xDE")]
	[Token(Token = "0x600294F")]
	internal static void ProcessOnOpacityChanged(RenderTreeManager renderTreeManager, RenderData renderData, uint dirtyID, ref ChainBuilderStats stats) { }

	[Address(RVA = "0x3308890", Offset = "0x3307C90", Length = "0xAF")]
	[Token(Token = "0x6002951")]
	internal static void ProcessOnTransformOrSizeChanged(RenderTreeManager renderTreeManager, RenderData renderData, uint dirtyID, ref ChainBuilderStats stats) { }

	[Address(RVA = "0x3308940", Offset = "0x3307D40", Length = "0xD65")]
	[Token(Token = "0x600295A")]
	private static void ResetRenderData(RenderTreeManager renderTreeManager, RenderData renderData) { }

	[Address(RVA = "0x33096B0", Offset = "0x3308AB0", Length = "0x7FB")]
	[Token(Token = "0x6002969")]
	public static void SetColorValues(RenderTreeManager renderTreeManager, VisualElement ve) { }

	[Address(RVA = "0x3309EB0", Offset = "0x33092B0", Length = "0x10D")]
	[Token(Token = "0x6002963")]
	private static bool UpdateLocalFlipsWinding(RenderData renderData) { }

	[Address(RVA = "0x3309FC0", Offset = "0x33093C0", Length = "0x5CF")]
	[Token(Token = "0x600295F")]
	public static bool UpdateTextCoreSettings(RenderTreeManager renderTreeManager, VisualElement ve) { }

	[Address(RVA = "0x330A590", Offset = "0x3309990", Length = "0x244")]
	[Token(Token = "0x6002964")]
	private static void UpdateZeroScaling(RenderData renderData) { }

}

