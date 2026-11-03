namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[Token(Token = "0x20002C6")]
internal struct NativePassData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CD7")]
	public FixedAttachmentArray<LoadAudit> loadAudit; //Field offset: 0x0
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000CD8")]
	public FixedAttachmentArray<StoreAudit> storeAudit; //Field offset: 0x44
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000CD9")]
	public PassBreakAudit breakAudit; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000CDA")]
	public FixedAttachmentArray<PassFragmentData> fragments; //Field offset: 0xD0
	[FieldOffset(Offset = "0x194")]
	[Token(Token = "0x4000CDB")]
	public FixedAttachmentArray<NativePassAttachment> attachments; //Field offset: 0x194
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000CDC")]
	public int firstGraphPass; //Field offset: 0x298
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x4000CDD")]
	public int lastGraphPass; //Field offset: 0x29C
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000CDE")]
	public int numGraphPasses; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A4")]
	[Token(Token = "0x4000CDF")]
	public int firstNativeSubPass; //Field offset: 0x2A4
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4000CE0")]
	public int numNativeSubPasses; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2AC")]
	[Token(Token = "0x4000CE1")]
	public int width; //Field offset: 0x2AC
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000CE2")]
	public int height; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B4")]
	[Token(Token = "0x4000CE3")]
	public int volumeDepth; //Field offset: 0x2B4
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4000CE4")]
	public int samples; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2BC")]
	[Token(Token = "0x4000CE5")]
	public int shadingRateImageIndex; //Field offset: 0x2BC
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4000CE6")]
	public bool hasDepth; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C1")]
	[Token(Token = "0x4000CE7")]
	public bool hasFoveatedRasterization; //Field offset: 0x2C1
	[FieldOffset(Offset = "0x2C2")]
	[Token(Token = "0x4000CE8")]
	public bool hasShadingRateStates; //Field offset: 0x2C2
	[FieldOffset(Offset = "0x2C4")]
	[Token(Token = "0x4000CE9")]
	public ExtendedFeatureFlags extendedFeatureFlags; //Field offset: 0x2C4
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000CEA")]
	public ShadingRateFragmentSize shadingRateFragmentSize; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2CC")]
	[Token(Token = "0x4000CEB")]
	public ShadingRateCombiner primitiveShadingRateCombiner; //Field offset: 0x2CC
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000CEC")]
	public ShadingRateCombiner fragmentShadingRateCombiner; //Field offset: 0x2D0

	[Token(Token = "0x17000268")]
	public bool hasShadingRateImage
	{
		[Address(RVA = "0x2CBC600", Offset = "0x2CBBA00", Length = "0xC")]
		[Token(Token = "0x600139F")]
		 get { } //Length: 12
	}

	[Address(RVA = "0x2CBC1D0", Offset = "0x2CBB5D0", Length = "0x427")]
	[Token(Token = "0x60013A0")]
	public NativePassData(ref PassData pass, CompilerContextData ctx) { }

	[Address(RVA = "0x2CB96A0", Offset = "0x2CB8AA0", Length = "0x344")]
	[Token(Token = "0x60013AC")]
	private void AddDepthAttachmentFirstDuringMerge(CompilerContextData contextData, in PassFragmentData depthAttachment) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60013A7")]
	private static bool AreExtendedFeatureFlagsCompatible(ExtendedFeatureFlags flags0, ExtendedFeatureFlags flags1) { }

	[Address(RVA = "0x2CBA090", Offset = "0x2CB9490", Length = "0xB3F")]
	[Token(Token = "0x60013A8")]
	public static PassBreakAudit CanMerge(CompilerContextData contextData, int activeNativePassId, int passIdToMerge) { }

	[Address(RVA = "0x2CB99F0", Offset = "0x2CB8DF0", Length = "0x1F")]
	[Token(Token = "0x60013A6")]
	private static bool CanMergeMSAASamples(ref NativePassData nativePass, ref PassData passToMerge) { }

	[Address(RVA = "0x2CB9A10", Offset = "0x2CB8E10", Length = "0x674")]
	[Token(Token = "0x60013AA")]
	private static bool CanMergeNativeSubPass(CompilerContextData contextData, ref NativePassData nativePass, ref PassData passToMerge) { }

	[Address(RVA = "0x2CBABD0", Offset = "0x2CB9FD0", Length = "0x124")]
	[Token(Token = "0x60013A2")]
	public void Clear() { }

	[Address(RVA = "0x2CBC600", Offset = "0x2CBBA00", Length = "0xC")]
	[Token(Token = "0x600139F")]
	public bool get_hasShadingRateImage() { }

	[Address(RVA = "0x2CBAD00", Offset = "0x2CBA100", Length = "0x168")]
	[IsReadOnly]
	[Token(Token = "0x60013A5")]
	public void GetGraphPassNames(CompilerContextData ctx, DynamicArray<Name> dest) { }

	[Address(RVA = "0x2CBAE70", Offset = "0x2CBA270", Length = "0x69")]
	[Token(Token = "0x60013A1")]
	public SubPassFlags GetSubPassFlagForMerging() { }

	[Address(RVA = "0x2CBAEE0", Offset = "0x2CBA2E0", Length = "0x2A4")]
	[IsReadOnly]
	[Token(Token = "0x60013A4")]
	public ReadOnlySpan<PassData> GraphPasses(CompilerContextData ctx, out NativeArray<PassData>& actualPasses) { }

	[Address(RVA = "0x2CBB190", Offset = "0x2CBA590", Length = "0xB")]
	[IsReadOnly]
	[Token(Token = "0x60013A3")]
	public bool IsValid() { }

	[Address(RVA = "0x2CBB1A0", Offset = "0x2CBA5A0", Length = "0x15A")]
	[Token(Token = "0x60013AE")]
	public static void SetPassStatesForNativePass(CompilerContextData contextData, int nativePassId) { }

	[Address(RVA = "0x2CBB300", Offset = "0x2CBA700", Length = "0x32E")]
	[Token(Token = "0x60013A9")]
	private static bool TotalAttachmentsSizeExceedPixelStorageLimit(CompilerContextData contextData, ref NativePassData nativePass, ref FixedAttachmentArray<PassFragmentData>& attachmentsToTryAdding) { }

	[Address(RVA = "0x2CBBB80", Offset = "0x2CBAF80", Length = "0x64A")]
	[Token(Token = "0x60013AD")]
	public static PassBreakAudit TryMerge(CompilerContextData contextData, int activeNativePassId, int passIdToMerge) { }

	[Address(RVA = "0x2CBB630", Offset = "0x2CBAA30", Length = "0x548")]
	[Token(Token = "0x60013AB")]
	public static void TryMergeNativeSubPass(CompilerContextData contextData, ref NativePassData nativePass, ref PassData passToMerge) { }

}

