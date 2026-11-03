namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[Token(Token = "0x20002BE")]
internal struct PassData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C79")]
	public int passId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000C7A")]
	public RenderGraphPassType type; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C7B")]
	public bool hasFoveatedRasterization; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000C7C")]
	public ExtendedFeatureFlags extendedFeatureFlags; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C7D")]
	public int tag; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C7E")]
	public ShadingRateFragmentSize shadingRateFragmentSize; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C7F")]
	public ShadingRateCombiner primitiveShadingRateCombiner; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000C80")]
	public ShadingRateCombiner fragmentShadingRateCombiner; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C81")]
	public PassMergeState mergeState; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000C82")]
	public int nativePassIndex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C83")]
	public int nativeSubPassIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000C84")]
	public int firstInput; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C85")]
	public int numInputs; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000C86")]
	public int firstOutput; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C87")]
	public int numOutputs; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000C88")]
	public int firstFragment; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C89")]
	public int numFragments; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000C8A")]
	public int firstFragmentInput; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C8B")]
	public int numFragmentInputs; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000C8C")]
	public int firstSampledOnlyRaster; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000C8D")]
	public int numSampledOnlyRaster; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000C8E")]
	public int firstRandomAccessResource; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000C8F")]
	public int numRandomAccessResources; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000C90")]
	public int firstCreate; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C91")]
	public int numCreated; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000C92")]
	public int firstDestroy; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C93")]
	public int numDestroyed; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000C94")]
	public int shadingRateImageIndex; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000C95")]
	public int fragmentInfoWidth; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000C96")]
	public int fragmentInfoHeight; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000C97")]
	public int fragmentInfoVolumeDepth; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000C98")]
	public int fragmentInfoSamples; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000C99")]
	public int waitOnGraphicsFencePassId; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000C9A")]
	public int awaitingMyGraphicsFencePassId; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000C9B")]
	public bool asyncCompute; //Field offset: 0x88
	[FieldOffset(Offset = "0x89")]
	[Token(Token = "0x4000C9C")]
	public bool hasSideEffects; //Field offset: 0x89
	[FieldOffset(Offset = "0x8A")]
	[Token(Token = "0x4000C9D")]
	public bool culled; //Field offset: 0x8A
	[FieldOffset(Offset = "0x8B")]
	[Token(Token = "0x4000C9E")]
	public bool beginNativeSubpass; //Field offset: 0x8B
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000C9F")]
	public bool fragmentInfoValid; //Field offset: 0x8C
	[FieldOffset(Offset = "0x8D")]
	[Token(Token = "0x4000CA0")]
	public bool fragmentInfoHasDepth; //Field offset: 0x8D
	[FieldOffset(Offset = "0x8E")]
	[Token(Token = "0x4000CA1")]
	public bool insertGraphicsFence; //Field offset: 0x8E
	[FieldOffset(Offset = "0x8F")]
	[Token(Token = "0x4000CA2")]
	public bool hasShadingRateStates; //Field offset: 0x8F

	[Token(Token = "0x17000267")]
	public bool fragmentInfoHasShadingRateImage
	{
		[Address(RVA = "0x2CBDD60", Offset = "0x2CBD160", Length = "0x8")]
		[Token(Token = "0x6001383")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2CBDC40", Offset = "0x2CBD040", Length = "0x11A")]
	[Token(Token = "0x6001385")]
	public PassData(in RenderGraphPass pass, int passIndex) { }

	[Address(RVA = "0x2CBC9A0", Offset = "0x2CBBDA0", Length = "0x19C")]
	[Token(Token = "0x6001394")]
	internal void AddFirstUse(in ResourceHandle h, CompilerContextData ctx) { }

	[Address(RVA = "0x2CBCB40", Offset = "0x2CBBF40", Length = "0x19C")]
	[Token(Token = "0x6001395")]
	internal void AddLastUse(in ResourceHandle h, CompilerContextData ctx) { }

	[Address(RVA = "0x2CBCCE0", Offset = "0x2CBC0E0", Length = "0x4")]
	[Token(Token = "0x6001393")]
	internal void AddRandomAccessResource() { }

	[Address(RVA = "0x2CBCCF0", Offset = "0x2CBC0F0", Length = "0x341")]
	[Token(Token = "0x6001397")]
	internal void DisconnectFromResources(CompilerContextData ctx, Stack<ResourceHandle> unusedVersionedResourceIdCullingStack = null, int type = 0) { }

	[Address(RVA = "0x2CBD040", Offset = "0x2CBC440", Length = "0xC3")]
	[IsReadOnly]
	[Token(Token = "0x600138D")]
	public ReadOnlySpan<ResourceHandle> FirstUsedResources(CompilerContextData ctx) { }

	[Address(RVA = "0x2CBD110", Offset = "0x2CBC510", Length = "0xC3")]
	[IsReadOnly]
	[Token(Token = "0x600138C")]
	public ReadOnlySpan<PassFragmentData> FragmentInputs(CompilerContextData ctx) { }

	[Address(RVA = "0x2CBD1E0", Offset = "0x2CBC5E0", Length = "0xC3")]
	[IsReadOnly]
	[Token(Token = "0x6001389")]
	public ReadOnlySpan<PassFragmentData> Fragments(CompilerContextData ctx) { }

	[Address(RVA = "0x2CBDD60", Offset = "0x2CBD160", Length = "0x8")]
	[Token(Token = "0x6001383")]
	public bool get_fragmentInfoHasShadingRateImage() { }

	[Address(RVA = "0x2CBD2B0", Offset = "0x2CBC6B0", Length = "0x6D")]
	[Token(Token = "0x6001384")]
	public Name GetName(CompilerContextData ctx) { }

	[Address(RVA = "0x2CBD320", Offset = "0x2CBC720", Length = "0xC3")]
	[IsReadOnly]
	[Token(Token = "0x6001388")]
	public ReadOnlySpan<PassInputData> Inputs(CompilerContextData ctx) { }

	[Address(RVA = "0x2CBD3F0", Offset = "0x2CBC7F0", Length = "0x1EF")]
	[IsReadOnly]
	[Token(Token = "0x6001396")]
	internal bool IsUsedAsFragment(in ResourceHandle h, CompilerContextData ctx) { }

	[Address(RVA = "0x2CBD5E0", Offset = "0x2CBC9E0", Length = "0xC3")]
	[IsReadOnly]
	[Token(Token = "0x600138F")]
	public ReadOnlySpan<ResourceHandle> LastUsedResources(CompilerContextData ctx) { }

	[Address(RVA = "0x2CBD6B0", Offset = "0x2CBCAB0", Length = "0xC3")]
	[IsReadOnly]
	[Token(Token = "0x6001387")]
	public ReadOnlySpan<PassOutputData> Outputs(CompilerContextData ctx) { }

	[Address(RVA = "0x2CBD780", Offset = "0x2CBCB80", Length = "0xC3")]
	[Token(Token = "0x600138E")]
	public ReadOnlySpan<PassRandomWriteData> RandomWriteTextures(CompilerContextData ctx) { }

	[Address(RVA = "0x2CBD850", Offset = "0x2CBCC50", Length = "0x11A")]
	[Token(Token = "0x6001386")]
	public void ResetAndInitialize(in RenderGraphPass pass, int passIndex) { }

	[Address(RVA = "0x2CBD970", Offset = "0x2CBCD70", Length = "0xC3")]
	[IsReadOnly]
	[Token(Token = "0x600138A")]
	public ReadOnlySpan<ResourceHandle> SampledTexturesIfRaster(CompilerContextData ctx) { }

	[Address(RVA = "0x2CBDA40", Offset = "0x2CBCE40", Length = "0x8B")]
	[IsReadOnly]
	[Token(Token = "0x600138B")]
	public PassFragmentData ShadingRateImage(CompilerContextData ctx) { }

	[Address(RVA = "0x2CBDB00", Offset = "0x2CBCF00", Length = "0x24")]
	[Token(Token = "0x6001391")]
	internal void TryAddFragment(in ResourceHandle h, CompilerContextData ctx, out string errorMessage) { }

	[Address(RVA = "0x2CBDAD0", Offset = "0x2CBCED0", Length = "0x24")]
	[Token(Token = "0x6001392")]
	internal void TryAddFragmentInput(in ResourceHandle h, CompilerContextData ctx, out string errorMessage) { }

	[Address(RVA = "0x2CBDB30", Offset = "0x2CBCF30", Length = "0x105")]
	[Token(Token = "0x6001390")]
	private bool TrySetupAndValidateFragmentInfo(in ResourceHandle h, CompilerContextData ctx, out string errorMessage) { }

}

