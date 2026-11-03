namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
[Token(Token = "0x200027B")]
internal abstract class RenderGraphPass
{
	[Token(Token = "0x200027C")]
	internal struct RandomWriteResourceInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B46")]
		public ResourceHandle h; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000B47")]
		public bool preserveCounterValue; //Field offset: 0xC

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B27")]
	private string <name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B28")]
	private int <index>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000B29")]
	private RenderGraphPassType <type>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B2A")]
	private ProfilingSampler <customSampler>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B2B")]
	private bool <enableAsyncCompute>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000B2C")]
	private bool <allowPassCulling>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000B2D")]
	private bool <allowGlobalState>k__BackingField; //Field offset: 0x2A
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x4000B2E")]
	private bool <enableFoveatedRasterization>k__BackingField; //Field offset: 0x2B
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000B2F")]
	private ExtendedFeatureFlags <extendedFeatureFlags>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B30")]
	private TextureAccess <depthAccess>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B31")]
	private TextureAccess[] <colorBufferAccess>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B32")]
	private int <colorBufferMaxIndex>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000B33")]
	private bool <hasShadingRateImage>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B34")]
	private TextureAccess <shadingRateAccess>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000B35")]
	private bool <hasShadingRateStates>k__BackingField; //Field offset: 0x7C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000B36")]
	private ShadingRateFragmentSize <shadingRateFragmentSize>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000B37")]
	private ShadingRateCombiner <primitiveShadingRateCombiner>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000B38")]
	private ShadingRateCombiner <fragmentShadingRateCombiner>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000B39")]
	private TextureAccess[] <fragmentInputAccess>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000B3A")]
	private int <fragmentInputMaxIndex>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000B3B")]
	private RandomWriteResourceInfo[] <randomAccessResource>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000B3C")]
	private int <randomAccessResourceMaxIndex>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000B3D")]
	private bool <generateDebugData>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	[FieldOffset(Offset = "0xAD")]
	[Token(Token = "0x4000B3E")]
	private bool <allowRendererListCulling>k__BackingField; //Field offset: 0xAD
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000B3F")]
	public List<ResourceHandle>[] resourceReadLists; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000B40")]
	public List<ResourceHandle>[] resourceWriteLists; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000B41")]
	public List<ResourceHandle>[] transientResourceList; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000B42")]
	public List<RendererListHandle> usedRendererListList; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000B43")]
	public List<ValueTuple`2<TextureHandle, Int32>> setGlobalsList; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000B44")]
	public bool useAllGlobalTextures; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000B45")]
	public List<ResourceHandle> implicitReadsList; //Field offset: 0xE0

	[Token(Token = "0x17000241")]
	public bool allowGlobalState
	{
		[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60011BB")]
		 get { } //Length: 5
		[Address(RVA = "0x2BCDF60", Offset = "0x2BCD360", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011BC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000240")]
	public bool allowPassCulling
	{
		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60011B9")]
		 get { } //Length: 5
		[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011BA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000252")]
	public bool allowRendererListCulling
	{
		[Address(RVA = "0x1D62660", Offset = "0x1D61A60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60011DD")]
		 get { } //Length: 8
		[Address(RVA = "0x1D62680", Offset = "0x1D61A80", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60011DE")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000245")]
	public TextureAccess[] colorBufferAccess
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60011C3")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60011C4")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000246")]
	public int colorBufferMaxIndex
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011C5")]
		 get { } //Length: 4
		[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011C6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700023E")]
	public ProfilingSampler customSampler
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60011B5")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60011B6")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000244")]
	public TextureAccess depthAccess
	{
		[Address(RVA = "0x2C9FBF0", Offset = "0x2C9EFF0", Length = "0x1B")]
		[CompilerGenerated]
		[Token(Token = "0x60011C1")]
		 get { } //Length: 27
		[Address(RVA = "0x2C9FC30", Offset = "0x2C9F030", Length = "0x18")]
		[CompilerGenerated]
		[Token(Token = "0x60011C2")]
		 set { } //Length: 24
	}

	[Token(Token = "0x1700023F")]
	public bool enableAsyncCompute
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60011B7")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011B8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000242")]
	public bool enableFoveatedRasterization
	{
		[Address(RVA = "0x1CC53B0", Offset = "0x1CC47B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60011BD")]
		 get { } //Length: 5
		[Address(RVA = "0x2BCDE90", Offset = "0x2BCD290", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011BE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000243")]
	public ExtendedFeatureFlags extendedFeatureFlags
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011BF")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011C0")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700024D")]
	public TextureAccess[] fragmentInputAccess
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60011D3")]
		 get { } //Length: 8
		[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60011D4")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700024E")]
	public int fragmentInputMaxIndex
	{
		[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60011D5")]
		 get { } //Length: 7
		[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60011D6")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700024C")]
	public ShadingRateCombiner fragmentShadingRateCombiner
	{
		[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60011D1")]
		 get { } //Length: 7
		[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60011D2")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000251")]
	public bool generateDebugData
	{
		[Address(RVA = "0x1D59150", Offset = "0x1D58550", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60011DB")]
		 get { } //Length: 8
		[Address(RVA = "0x1D58AF0", Offset = "0x1D57EF0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60011DC")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000247")]
	public bool hasShadingRateImage
	{
		[Address(RVA = "0x1FEC950", Offset = "0x1FEBD50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60011C7")]
		 get { } //Length: 5
		[Address(RVA = "0x2C9FC50", Offset = "0x2C9F050", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011C8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000249")]
	public bool hasShadingRateStates
	{
		[Address(RVA = "0x243EE10", Offset = "0x243E210", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60011CB")]
		 get { } //Length: 5
		[Address(RVA = "0x248DB10", Offset = "0x248CF10", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011CC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700023C")]
	public int index
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011B1")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011B2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700023B")]
	public string name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60011AF")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60011B0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700024B")]
	public ShadingRateCombiner primitiveShadingRateCombiner
	{
		[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60011CF")]
		 get { } //Length: 7
		[Address(RVA = "0xD11B10", Offset = "0xD10F10", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60011D0")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700024F")]
	public RandomWriteResourceInfo[] randomAccessResource
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60011D7")]
		 get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60011D8")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000250")]
	public int randomAccessResourceMaxIndex
	{
		[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60011D9")]
		 get { } //Length: 7
		[Address(RVA = "0x2C9FC60", Offset = "0x2C9F060", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60011DA")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000248")]
	public TextureAccess shadingRateAccess
	{
		[Address(RVA = "0x2C9FC10", Offset = "0x2C9F010", Length = "0x1B")]
		[CompilerGenerated]
		[Token(Token = "0x60011C9")]
		 get { } //Length: 27
		[Address(RVA = "0x2C9FC70", Offset = "0x2C9F070", Length = "0x18")]
		[CompilerGenerated]
		[Token(Token = "0x60011CA")]
		 set { } //Length: 24
	}

	[Token(Token = "0x1700024A")]
	public ShadingRateFragmentSize shadingRateFragmentSize
	{
		[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60011CD")]
		 get { } //Length: 7
		[Address(RVA = "0xE26DE0", Offset = "0xE261E0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60011CE")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700023D")]
	public internal RenderGraphPassType type
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011B3")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60011B4")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x2C9F7C0", Offset = "0x2C9EBC0", Length = "0x42A")]
	[Token(Token = "0x60011DF")]
	public RenderGraphPass() { }

	[Address(RVA = "0x2C9CC90", Offset = "0x2C9C090", Length = "0x12B")]
	[Token(Token = "0x60011E7")]
	public void AddResourceRead(in ResourceHandle res) { }

	[Address(RVA = "0x2C9CDC0", Offset = "0x2C9C1C0", Length = "0x12B")]
	[Token(Token = "0x60011E6")]
	public void AddResourceWrite(in ResourceHandle res) { }

	[Address(RVA = "0x2C9CEF0", Offset = "0x2C9C2F0", Length = "0x12B")]
	[Token(Token = "0x60011E8")]
	public void AddTransientResource(in ResourceHandle res) { }

	[Address(RVA = "0x2BCDF60", Offset = "0x2BCD360", Length = "0x4")]
	[Token(Token = "0x60011EE")]
	public void AllowGlobalState(bool value) { }

	[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
	[Token(Token = "0x60011EB")]
	public void AllowPassCulling(bool value) { }

	[Address(RVA = "0x1D62680", Offset = "0x1D61A80", Length = "0x7")]
	[Token(Token = "0x60011ED")]
	public void AllowRendererListCulling(bool value) { }

	[Address(RVA = "0x2C9D020", Offset = "0x2C9C420", Length = "0x1DD")]
	[Token(Token = "0x60011E0")]
	public void Clear() { }

	[Address(RVA = "0x2C9D290", Offset = "0x2C9C690", Length = "0xBB2")]
	[Token(Token = "0x60011F8")]
	public void ComputeHash(ref HashFNV1A32 generator, RenderGraphResourceRegistry resources) { }

	[Address(RVA = "0x2C9D200", Offset = "0x2C9C600", Length = "0x87")]
	[Token(Token = "0x60011F7")]
	private static void ComputeHashForTextureAccess(ref HashFNV1A32 generator, in ResourceHandle handle, in TextureAccess textureAccess) { }

	[Address(RVA = "0x2C9DE50", Offset = "0x2C9D250", Length = "0x520")]
	[Token(Token = "0x60011F6")]
	private void ComputeTextureHash(ref HashFNV1A32 generator, in ResourceHandle handle, RenderGraphResourceRegistry resources) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x60011EA")]
	public void EnableAsyncCompute(bool value) { }

	[Address(RVA = "0x2BCDE90", Offset = "0x2BCD290", Length = "0x4")]
	[Token(Token = "0x60011EC")]
	public void EnableFoveatedRasterization(bool value) { }

	[Token(Token = "0x60011AB")]
	public abstract void Execute(InternalRenderGraphContext renderGraphContext) { }

	[Address(RVA = "0x1D58AF0", Offset = "0x1D57EF0", Length = "0x7")]
	[Token(Token = "0x60011EF")]
	public void GenerateDebugData(bool value) { }

	[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60011BB")]
	public bool get_allowGlobalState() { }

	[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60011B9")]
	public bool get_allowPassCulling() { }

	[Address(RVA = "0x1D62660", Offset = "0x1D61A60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60011DD")]
	public bool get_allowRendererListCulling() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60011C3")]
	public TextureAccess[] get_colorBufferAccess() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011C5")]
	public int get_colorBufferMaxIndex() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60011B5")]
	public ProfilingSampler get_customSampler() { }

	[Address(RVA = "0x2C9FBF0", Offset = "0x2C9EFF0", Length = "0x1B")]
	[CompilerGenerated]
	[Token(Token = "0x60011C1")]
	public TextureAccess get_depthAccess() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60011B7")]
	public bool get_enableAsyncCompute() { }

	[Address(RVA = "0x1CC53B0", Offset = "0x1CC47B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60011BD")]
	public bool get_enableFoveatedRasterization() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011BF")]
	public ExtendedFeatureFlags get_extendedFeatureFlags() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60011D3")]
	public TextureAccess[] get_fragmentInputAccess() { }

	[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60011D5")]
	public int get_fragmentInputMaxIndex() { }

	[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60011D1")]
	public ShadingRateCombiner get_fragmentShadingRateCombiner() { }

	[Address(RVA = "0x1D59150", Offset = "0x1D58550", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60011DB")]
	public bool get_generateDebugData() { }

	[Address(RVA = "0x1FEC950", Offset = "0x1FEBD50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60011C7")]
	public bool get_hasShadingRateImage() { }

	[Address(RVA = "0x243EE10", Offset = "0x243E210", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60011CB")]
	public bool get_hasShadingRateStates() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011B1")]
	public int get_index() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60011AF")]
	public string get_name() { }

	[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60011CF")]
	public ShadingRateCombiner get_primitiveShadingRateCombiner() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60011D7")]
	public RandomWriteResourceInfo[] get_randomAccessResource() { }

	[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60011D9")]
	public int get_randomAccessResourceMaxIndex() { }

	[Address(RVA = "0x2C9FC10", Offset = "0x2C9F010", Length = "0x1B")]
	[CompilerGenerated]
	[Token(Token = "0x60011C9")]
	public TextureAccess get_shadingRateAccess() { }

	[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60011CD")]
	public ShadingRateFragmentSize get_shadingRateFragmentSize() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011B3")]
	public RenderGraphPassType get_type() { }

	[Token(Token = "0x60011AE")]
	public abstract int GetRenderFuncHash() { }

	[Address(RVA = "0x2C9E380", Offset = "0x2C9D780", Length = "0x12D")]
	[Token(Token = "0x60011E1")]
	public bool HasRenderAttachments() { }

	[Token(Token = "0x60011AD")]
	public abstract bool HasRenderFunc() { }

	[Address(RVA = "0x2C9E4B0", Offset = "0x2C9D8B0", Length = "0x1FA")]
	[Token(Token = "0x60011E5")]
	public bool IsAttachment(in TextureHandle res) { }

	[Address(RVA = "0x2C9E6B0", Offset = "0x2C9DAB0", Length = "0x245")]
	[Token(Token = "0x60011E4")]
	public bool IsRead(in ResourceHandle res) { }

	[Address(RVA = "0x2C9E900", Offset = "0x2C9DD00", Length = "0x17D")]
	[Token(Token = "0x60011E2")]
	public bool IsTransient(in ResourceHandle res) { }

	[Address(RVA = "0x2C9EA80", Offset = "0x2C9DE80", Length = "0x17D")]
	[Token(Token = "0x60011E3")]
	public bool IsWritten(in ResourceHandle res) { }

	[Token(Token = "0x60011AC")]
	public abstract void Release(RenderGraphObjectPool pool) { }

	[Address(RVA = "0x2BCDF60", Offset = "0x2BCD360", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011BC")]
	protected void set_allowGlobalState(bool value) { }

	[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011BA")]
	protected void set_allowPassCulling(bool value) { }

	[Address(RVA = "0x1D62680", Offset = "0x1D61A80", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60011DE")]
	protected void set_allowRendererListCulling(bool value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60011C4")]
	protected void set_colorBufferAccess(TextureAccess[] value) { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011C6")]
	protected void set_colorBufferMaxIndex(int value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60011B6")]
	protected void set_customSampler(ProfilingSampler value) { }

	[Address(RVA = "0x2C9FC30", Offset = "0x2C9F030", Length = "0x18")]
	[CompilerGenerated]
	[Token(Token = "0x60011C2")]
	protected void set_depthAccess(TextureAccess value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011B8")]
	protected void set_enableAsyncCompute(bool value) { }

	[Address(RVA = "0x2BCDE90", Offset = "0x2BCD290", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011BE")]
	protected void set_enableFoveatedRasterization(bool value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011C0")]
	protected void set_extendedFeatureFlags(ExtendedFeatureFlags value) { }

	[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60011D4")]
	protected void set_fragmentInputAccess(TextureAccess[] value) { }

	[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60011D6")]
	protected void set_fragmentInputMaxIndex(int value) { }

	[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60011D2")]
	protected void set_fragmentShadingRateCombiner(ShadingRateCombiner value) { }

	[Address(RVA = "0x1D58AF0", Offset = "0x1D57EF0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60011DC")]
	protected void set_generateDebugData(bool value) { }

	[Address(RVA = "0x2C9FC50", Offset = "0x2C9F050", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011C8")]
	protected void set_hasShadingRateImage(bool value) { }

	[Address(RVA = "0x248DB10", Offset = "0x248CF10", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011CC")]
	protected void set_hasShadingRateStates(bool value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011B2")]
	protected void set_index(int value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60011B0")]
	protected void set_name(string value) { }

	[Address(RVA = "0xD11B10", Offset = "0xD10F10", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60011D0")]
	protected void set_primitiveShadingRateCombiner(ShadingRateCombiner value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60011D8")]
	protected void set_randomAccessResource(RandomWriteResourceInfo[] value) { }

	[Address(RVA = "0x2C9FC60", Offset = "0x2C9F060", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60011DA")]
	protected void set_randomAccessResourceMaxIndex(int value) { }

	[Address(RVA = "0x2C9FC70", Offset = "0x2C9F070", Length = "0x18")]
	[CompilerGenerated]
	[Token(Token = "0x60011CA")]
	protected void set_shadingRateAccess(TextureAccess value) { }

	[Address(RVA = "0xE26DE0", Offset = "0xE261E0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60011CE")]
	protected void set_shadingRateFragmentSize(ShadingRateFragmentSize value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60011B4")]
	internal void set_type(RenderGraphPassType value) { }

	[Address(RVA = "0x2C9EDF0", Offset = "0x2C9E1F0", Length = "0xDD")]
	[Token(Token = "0x60011F0")]
	public void SetColorBuffer(in TextureHandle resource, int index) { }

	[Address(RVA = "0x2C9EC00", Offset = "0x2C9E000", Length = "0x1E8")]
	[Token(Token = "0x60011F1")]
	public void SetColorBufferRaw(in TextureHandle resource, int index, AccessFlags accessFlags, int mipLevel, int depthSlice) { }

	[Address(RVA = "0x2C9F080", Offset = "0x2C9E480", Length = "0x67")]
	[Token(Token = "0x60011F4")]
	public void SetDepthBuffer(in TextureHandle resource, DepthAccess flags) { }

	[Address(RVA = "0x2C9EED0", Offset = "0x2C9E2D0", Length = "0x1A8")]
	[Token(Token = "0x60011F5")]
	public void SetDepthBufferRaw(in TextureHandle resource, AccessFlags accessFlags, int mipLevel, int depthSlice) { }

	[Address(RVA = "0x2C9F0F0", Offset = "0x2C9E4F0", Length = "0x4")]
	[Token(Token = "0x60011FD")]
	public void SetExtendedFeatureFlags(ExtendedFeatureFlags value) { }

	[Address(RVA = "0x2C9F100", Offset = "0x2C9E500", Length = "0x1F7")]
	[Token(Token = "0x60011F2")]
	public void SetFragmentInputRaw(in TextureHandle resource, int index, AccessFlags accessFlags, int mipLevel, int depthSlice) { }

	[Address(RVA = "0x2C9F300", Offset = "0x2C9E700", Length = "0x28F")]
	[Token(Token = "0x60011F3")]
	public void SetRandomWriteResourceRaw(in ResourceHandle resource, int index, bool preserveCounterValue, AccessFlags accessFlags) { }

	[Address(RVA = "0x2C9F590", Offset = "0x2C9E990", Length = "0x4D")]
	[Token(Token = "0x60011FC")]
	public void SetShadingRateCombiner(ShadingRateCombinerStage stage, ShadingRateCombiner combiner) { }

	[Address(RVA = "0x2C9F5E0", Offset = "0x2C9E9E0", Length = "0x2F")]
	[Token(Token = "0x60011FB")]
	public void SetShadingRateFragmentSize(ShadingRateFragmentSize shadingRateFragmentSize) { }

	[Address(RVA = "0x2C9F660", Offset = "0x2C9EA60", Length = "0x91")]
	[Token(Token = "0x60011FA")]
	public void SetShadingRateImage(in TextureHandle shadingRateImage, AccessFlags accessFlags, int mipLevel, int depthSlice) { }

	[Address(RVA = "0x2C9F610", Offset = "0x2C9EA10", Length = "0x4A")]
	[Token(Token = "0x60011F9")]
	public void SetShadingRateImageRaw(in TextureHandle shadingRateImage) { }

	[Address(RVA = "0x2C9F700", Offset = "0x2C9EB00", Length = "0xBE")]
	[Token(Token = "0x60011E9")]
	public void UseRendererList(in RendererListHandle rendererList) { }

}

