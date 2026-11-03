namespace UnityEngine;

[Token(Token = "0x200013D")]
public struct RenderTextureDescriptor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000401")]
	private int <width>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000402")]
	private int <height>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000403")]
	private int <msaaSamples>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000404")]
	private int <volumeDepth>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000405")]
	private int <mipCount>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000406")]
	private GraphicsFormat _graphicsFormat; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000407")]
	private GraphicsFormat <stencilFormat>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000408")]
	private GraphicsFormat <depthStencilFormat>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000409")]
	private TextureDimension <dimension>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400040A")]
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400040B")]
	private VRTextureUsage <vrUsage>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400040C")]
	private RenderTextureCreationFlags _flags; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400040D")]
	private RenderTextureMemoryless <memoryless>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x17000264")]
	public bool autoGenerateMips
	{
		[Address(RVA = "0x304F120", Offset = "0x304E520", Length = "0xA")]
		[Token(Token = "0x6000F86")]
		 get { } //Length: 10
		[Address(RVA = "0x304F2A0", Offset = "0x304E6A0", Length = "0x19")]
		[Token(Token = "0x6000F87")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000266")]
	public bool bindMS
	{
		[Address(RVA = "0x304F130", Offset = "0x304E530", Length = "0xD")]
		[Token(Token = "0x6000F8A")]
		 get { } //Length: 13
		[Address(RVA = "0x304F2C0", Offset = "0x304E6C0", Length = "0x1B")]
		[Token(Token = "0x6000F8B")]
		 set { } //Length: 27
	}

	[Token(Token = "0x1700025C")]
	public RenderTextureFormat colorFormat
	{
		[Address(RVA = "0x304F140", Offset = "0x304E540", Length = "0x69")]
		[Token(Token = "0x6000F6C")]
		 get { } //Length: 105
		[Address(RVA = "0x304F2E0", Offset = "0x304E6E0", Length = "0x162")]
		[Token(Token = "0x6000F6D")]
		 set { } //Length: 354
	}

	[Token(Token = "0x17000267")]
	internal bool createdFromScript
	{
		[Address(RVA = "0x304F450", Offset = "0x304E850", Length = "0x19")]
		[Token(Token = "0x6000F8C")]
		internal set { } //Length: 25
	}

	[Token(Token = "0x1700025E")]
	public int depthBufferBits
	{
		[Address(RVA = "0x304F1B0", Offset = "0x304E5B0", Length = "0x4B")]
		[Token(Token = "0x6000F70")]
		 get { } //Length: 75
		[Address(RVA = "0x304F470", Offset = "0x304E870", Length = "0x21")]
		[Token(Token = "0x6000F71")]
		 set { } //Length: 33
	}

	[Token(Token = "0x1700025B")]
	public GraphicsFormat depthStencilFormat
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F6A")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000F6B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700025F")]
	public TextureDimension dimension
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F72")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000F73")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000265")]
	public bool enableRandomWrite
	{
		[Address(RVA = "0x304F200", Offset = "0x304E600", Length = "0xA")]
		[Token(Token = "0x6000F88")]
		 get { } //Length: 10
		[Address(RVA = "0x304F4A0", Offset = "0x304E8A0", Length = "0x19")]
		[Token(Token = "0x6000F89")]
		 set { } //Length: 25
	}

	[Token(Token = "0x1700026A")]
	public bool enableShadingRate
	{
		[Address(RVA = "0x304F210", Offset = "0x304E610", Length = "0xD")]
		[Token(Token = "0x6000F91")]
		 get { } //Length: 13
		[Address(RVA = "0x304F4C0", Offset = "0x304E8C0", Length = "0x1B")]
		[Token(Token = "0x6000F92")]
		 set { } //Length: 27
	}

	[Token(Token = "0x17000259")]
	public GraphicsFormat graphicsFormat
	{
		[Address(RVA = "0x1963AC0", Offset = "0x1962EC0", Length = "0x6")]
		[Token(Token = "0x6000F67")]
		 get { } //Length: 6
		[Address(RVA = "0x304F4E0", Offset = "0x304E8E0", Length = "0x6A")]
		[Token(Token = "0x6000F68")]
		 set { } //Length: 106
	}

	[Token(Token = "0x17000255")]
	public int height
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F5F")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000F60")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000262")]
	public RenderTextureMemoryless memoryless
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F78")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000F79")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000258")]
	public int mipCount
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F65")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000F66")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000256")]
	public int msaaSamples
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F61")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000F62")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000260")]
	public ShadowSamplingMode shadowSamplingMode
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F74")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000F75")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700025D")]
	public bool sRGB
	{
		[Address(RVA = "0x304F220", Offset = "0x304E620", Length = "0x4B")]
		[Token(Token = "0x6000F6E")]
		 get { } //Length: 75
		[Address(RVA = "0x304F550", Offset = "0x304E950", Length = "0xDE")]
		[Token(Token = "0x6000F6F")]
		 set { } //Length: 222
	}

	[Token(Token = "0x1700025A")]
	public GraphicsFormat stencilFormat
	{
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000F69")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000268")]
	public bool useDynamicScale
	{
		[Address(RVA = "0x304F280", Offset = "0x304E680", Length = "0xD")]
		[Token(Token = "0x6000F8D")]
		 get { } //Length: 13
		[Address(RVA = "0x304F650", Offset = "0x304EA50", Length = "0x1B")]
		[Token(Token = "0x6000F8E")]
		 set { } //Length: 27
	}

	[Token(Token = "0x17000269")]
	public bool useDynamicScaleExplicit
	{
		[Address(RVA = "0x304F270", Offset = "0x304E670", Length = "0xD")]
		[Token(Token = "0x6000F8F")]
		 get { } //Length: 13
		[Address(RVA = "0x304F630", Offset = "0x304EA30", Length = "0x1B")]
		[Token(Token = "0x6000F90")]
		 set { } //Length: 27
	}

	[Token(Token = "0x17000263")]
	public bool useMipMap
	{
		[Address(RVA = "0x304F290", Offset = "0x304E690", Length = "0xA")]
		[Token(Token = "0x6000F84")]
		 get { } //Length: 10
		[Address(RVA = "0x304F670", Offset = "0x304EA70", Length = "0x19")]
		[Token(Token = "0x6000F85")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000257")]
	public int volumeDepth
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F63")]
		 get { } //Length: 4
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000F64")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000261")]
	public VRTextureUsage vrUsage
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F76")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000F77")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000254")]
	public int width
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000F5D")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6000F5E")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x304ED80", Offset = "0x304E180", Length = "0xC1")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F82")]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	[Address(RVA = "0x304EBF0", Offset = "0x304DFF0", Length = "0x1F")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F7A")]
	public RenderTextureDescriptor(int width, int height) { }

	[Address(RVA = "0x304EE50", Offset = "0x304E250", Length = "0x19")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F7B")]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat) { }

	[Address(RVA = "0x304ECB0", Offset = "0x304E0B0", Length = "0x9D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F81")]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[Address(RVA = "0x304F070", Offset = "0x304E470", Length = "0xA5")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F7C")]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits) { }

	[Address(RVA = "0x304ED50", Offset = "0x304E150", Length = "0x2F")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F7E")]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount) { }

	[Address(RVA = "0x304EF40", Offset = "0x304E340", Length = "0x12A")]
	[Token(Token = "0x6000F7F")]
	public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount, RenderTextureReadWrite readWrite) { }

	[Address(RVA = "0x304EC10", Offset = "0x304E010", Length = "0x9D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F7D")]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits) { }

	[Address(RVA = "0x304EE70", Offset = "0x304E270", Length = "0xCB")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F80")]
	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) { }

	[Address(RVA = "0x304F120", Offset = "0x304E520", Length = "0xA")]
	[Token(Token = "0x6000F86")]
	public bool get_autoGenerateMips() { }

	[Address(RVA = "0x304F130", Offset = "0x304E530", Length = "0xD")]
	[Token(Token = "0x6000F8A")]
	public bool get_bindMS() { }

	[Address(RVA = "0x304F140", Offset = "0x304E540", Length = "0x69")]
	[Token(Token = "0x6000F6C")]
	public RenderTextureFormat get_colorFormat() { }

	[Address(RVA = "0x304F1B0", Offset = "0x304E5B0", Length = "0x4B")]
	[Token(Token = "0x6000F70")]
	public int get_depthBufferBits() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F6A")]
	public GraphicsFormat get_depthStencilFormat() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F72")]
	public TextureDimension get_dimension() { }

	[Address(RVA = "0x304F200", Offset = "0x304E600", Length = "0xA")]
	[Token(Token = "0x6000F88")]
	public bool get_enableRandomWrite() { }

	[Address(RVA = "0x304F210", Offset = "0x304E610", Length = "0xD")]
	[Token(Token = "0x6000F91")]
	public bool get_enableShadingRate() { }

	[Address(RVA = "0x1963AC0", Offset = "0x1962EC0", Length = "0x6")]
	[Token(Token = "0x6000F67")]
	public GraphicsFormat get_graphicsFormat() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F5F")]
	public int get_height() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F78")]
	public RenderTextureMemoryless get_memoryless() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F65")]
	public int get_mipCount() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F61")]
	public int get_msaaSamples() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F74")]
	public ShadowSamplingMode get_shadowSamplingMode() { }

	[Address(RVA = "0x304F220", Offset = "0x304E620", Length = "0x4B")]
	[Token(Token = "0x6000F6E")]
	public bool get_sRGB() { }

	[Address(RVA = "0x304F280", Offset = "0x304E680", Length = "0xD")]
	[Token(Token = "0x6000F8D")]
	public bool get_useDynamicScale() { }

	[Address(RVA = "0x304F270", Offset = "0x304E670", Length = "0xD")]
	[Token(Token = "0x6000F8F")]
	public bool get_useDynamicScaleExplicit() { }

	[Address(RVA = "0x304F290", Offset = "0x304E690", Length = "0xA")]
	[Token(Token = "0x6000F84")]
	public bool get_useMipMap() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F63")]
	public int get_volumeDepth() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F76")]
	public VRTextureUsage get_vrUsage() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000F5D")]
	public int get_width() { }

	[Address(RVA = "0x304F2A0", Offset = "0x304E6A0", Length = "0x19")]
	[Token(Token = "0x6000F87")]
	public void set_autoGenerateMips(bool value) { }

	[Address(RVA = "0x304F2C0", Offset = "0x304E6C0", Length = "0x1B")]
	[Token(Token = "0x6000F8B")]
	public void set_bindMS(bool value) { }

	[Address(RVA = "0x304F2E0", Offset = "0x304E6E0", Length = "0x162")]
	[Token(Token = "0x6000F6D")]
	public void set_colorFormat(RenderTextureFormat value) { }

	[Address(RVA = "0x304F450", Offset = "0x304E850", Length = "0x19")]
	[Token(Token = "0x6000F8C")]
	internal void set_createdFromScript(bool value) { }

	[Address(RVA = "0x304F470", Offset = "0x304E870", Length = "0x21")]
	[Token(Token = "0x6000F71")]
	public void set_depthBufferBits(int value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000F6B")]
	public void set_depthStencilFormat(GraphicsFormat value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000F73")]
	public void set_dimension(TextureDimension value) { }

	[Address(RVA = "0x304F4A0", Offset = "0x304E8A0", Length = "0x19")]
	[Token(Token = "0x6000F89")]
	public void set_enableRandomWrite(bool value) { }

	[Address(RVA = "0x304F4C0", Offset = "0x304E8C0", Length = "0x1B")]
	[Token(Token = "0x6000F92")]
	public void set_enableShadingRate(bool value) { }

	[Address(RVA = "0x304F4E0", Offset = "0x304E8E0", Length = "0x6A")]
	[Token(Token = "0x6000F68")]
	public void set_graphicsFormat(GraphicsFormat value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000F60")]
	public void set_height(int value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000F79")]
	public void set_memoryless(RenderTextureMemoryless value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000F66")]
	public void set_mipCount(int value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000F62")]
	public void set_msaaSamples(int value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000F75")]
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	[Address(RVA = "0x304F550", Offset = "0x304E950", Length = "0xDE")]
	[Token(Token = "0x6000F6F")]
	public void set_sRGB(bool value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000F69")]
	public void set_stencilFormat(GraphicsFormat value) { }

	[Address(RVA = "0x304F650", Offset = "0x304EA50", Length = "0x1B")]
	[Token(Token = "0x6000F8E")]
	public void set_useDynamicScale(bool value) { }

	[Address(RVA = "0x304F630", Offset = "0x304EA30", Length = "0x1B")]
	[Token(Token = "0x6000F90")]
	public void set_useDynamicScaleExplicit(bool value) { }

	[Address(RVA = "0x304F670", Offset = "0x304EA70", Length = "0x19")]
	[Token(Token = "0x6000F85")]
	public void set_useMipMap(bool value) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000F64")]
	public void set_volumeDepth(int value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000F77")]
	public void set_vrUsage(VRTextureUsage value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x6000F5E")]
	public void set_width(int value) { }

	[Address(RVA = "0x304EBD0", Offset = "0x304DFD0", Length = "0x19")]
	[Token(Token = "0x6000F83")]
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

}

