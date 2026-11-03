namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200003C")]
internal static class LayerUtility
{
	[Token(Token = "0x400012C")]
	private static LayerBatch[] s_LayerBatches; //Field offset: 0x0

	[Address(RVA = "0x2D204E0", Offset = "0x2D1F8E0", Length = "0x469")]
	[Token(Token = "0x6000179")]
	public static LayerBatch[] CalculateBatches(Renderer2DData rendererData, out int batchCount) { }

	[Address(RVA = "0x2D20950", Offset = "0x2D1FD50", Length = "0x14B")]
	[Token(Token = "0x6000176")]
	private static bool CanBatchCameraSortingLayer(int startLayerIndex, SortingLayer[] sortingLayers, Renderer2DData rendererData) { }

	[Address(RVA = "0x2D20AA0", Offset = "0x2D1FEA0", Length = "0x563")]
	[Token(Token = "0x6000175")]
	private static bool CanBatchLightsInLayer(int layerIndex1, int layerIndex2, SortingLayer[] sortingLayers, ILight2DCullResult lightCullResult) { }

	[Address(RVA = "0x2D21010", Offset = "0x2D20410", Length = "0xB5")]
	[Token(Token = "0x6000177")]
	private static int FindUpperBoundInBatch(int startLayerIndex, SortingLayer[] sortingLayers, Renderer2DData rendererData) { }

	[Address(RVA = "0x2D210D0", Offset = "0x2D204D0", Length = "0xC6")]
	[Token(Token = "0x600017A")]
	public static void GetFilterSettings(Renderer2DData rendererData, ref LayerBatch layerBatch, out FilteringSettings filterSettings) { }

	[Address(RVA = "0x2D211A0", Offset = "0x2D205A0", Length = "0x100")]
	[Token(Token = "0x6000178")]
	private static void InitializeBatchInfos(SortingLayer[] cachedSortingLayers) { }

	[Address(RVA = "0x2D212B0", Offset = "0x2D206B0", Length = "0x200")]
	[Token(Token = "0x600017B")]
	private static void SetupActiveBlendStyles() { }

}

