namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x20002A3")]
public struct TextureDesc
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BC0")]
	public TextureSizeMode sizeMode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000BC1")]
	public int width; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BC2")]
	public int height; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000BC3")]
	public int slices; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BC4")]
	public Vector2 scale; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BC5")]
	public ScaleFunc func; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BC6")]
	public GraphicsFormat format; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000BC7")]
	public FilterMode filterMode; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BC8")]
	public TextureWrapMode wrapMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000BC9")]
	public TextureDimension dimension; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BCA")]
	public bool enableRandomWrite; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000BCB")]
	public bool useMipMap; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x4000BCC")]
	public bool autoGenerateMips; //Field offset: 0x32
	[FieldOffset(Offset = "0x33")]
	[Token(Token = "0x4000BCD")]
	public bool isShadowMap; //Field offset: 0x33
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000BCE")]
	public int anisoLevel; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BCF")]
	public float mipMapBias; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000BD0")]
	public MSAASamples msaaSamples; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BD1")]
	public bool bindTextureMS; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000BD2")]
	public bool useDynamicScale; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4000BD3")]
	public bool useDynamicScaleExplicit; //Field offset: 0x42
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000BD4")]
	public RenderTextureMemoryless memoryless; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BD5")]
	public VRTextureUsage vrUsage; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000BD6")]
	public bool enableShadingRate; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BD7")]
	public string name; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BD8")]
	public FastMemoryDesc fastMemoryDesc; //Field offset: 0x58
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000BD9")]
	public bool fallBackToBlackTexture; //Field offset: 0x64
	[FieldOffset(Offset = "0x65")]
	[Token(Token = "0x4000BDA")]
	public bool disableFallBackToImportedTexture; //Field offset: 0x65
	[FieldOffset(Offset = "0x66")]
	[Token(Token = "0x4000BDB")]
	public bool clearBuffer; //Field offset: 0x66
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000BDC")]
	public Color clearColor; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000BDD")]
	public bool discardBuffer; //Field offset: 0x78

	[Token(Token = "0x1700025E")]
	public GraphicsFormat colorFormat
	{
		[Address(RVA = "0x2CAB250", Offset = "0x2CAA650", Length = "0x69")]
		[Token(Token = "0x60012EA")]
		 get { } //Length: 105
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x60012EB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700025D")]
	public DepthBits depthBufferBits
	{
		[Address(RVA = "0x2CAB2C0", Offset = "0x2CAA6C0", Length = "0x4B")]
		[Token(Token = "0x60012E8")]
		 get { } //Length: 75
		[Address(RVA = "0x2CAB310", Offset = "0x2CAA710", Length = "0x8B")]
		[Token(Token = "0x60012E9")]
		 set { } //Length: 139
	}

	[Address(RVA = "0x2CAAF50", Offset = "0x2CAA350", Length = "0x45")]
	[Token(Token = "0x60012ED")]
	public TextureDesc(int width, int height, bool dynamicResolution = false, bool xrReady = false) { }

	[Address(RVA = "0x2CAB020", Offset = "0x2CAA420", Length = "0x52")]
	[Token(Token = "0x60012EE")]
	public TextureDesc(Vector2 scale, bool dynamicResolution = false, bool xrReady = false) { }

	[Address(RVA = "0x2CAAFA0", Offset = "0x2CAA3A0", Length = "0x7F")]
	[Token(Token = "0x60012EF")]
	public TextureDesc(ScaleFunc func, bool dynamicResolution = false, bool xrReady = false) { }

	[Address(RVA = "0x2CAB080", Offset = "0x2CAA480", Length = "0x49")]
	[Token(Token = "0x60012F0")]
	public TextureDesc(TextureDesc input) { }

	[Address(RVA = "0x2CAB0D0", Offset = "0x2CAA4D0", Length = "0x17A")]
	[Token(Token = "0x60012F1")]
	public TextureDesc(RenderTextureDescriptor input) { }

	[Address(RVA = "0x2CAAE60", Offset = "0x2CAA260", Length = "0xE0")]
	[Token(Token = "0x60012F2")]
	public TextureDesc(RenderTexture input) { }

	[Address(RVA = "0x2CAAAD0", Offset = "0x2CA9ED0", Length = "0xF9")]
	[Token(Token = "0x60012F4")]
	public Vector2Int CalculateFinalDimensions() { }

	[Address(RVA = "0x2CAB250", Offset = "0x2CAA650", Length = "0x69")]
	[Token(Token = "0x60012EA")]
	public GraphicsFormat get_colorFormat() { }

	[Address(RVA = "0x2CAB2C0", Offset = "0x2CAA6C0", Length = "0x4B")]
	[Token(Token = "0x60012E8")]
	public DepthBits get_depthBufferBits() { }

	[Address(RVA = "0x2CAABD0", Offset = "0x2CA9FD0", Length = "0x1BC")]
	[Token(Token = "0x60012F3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2CAAD90", Offset = "0x2CAA190", Length = "0xCC")]
	[Token(Token = "0x60012EC")]
	private void InitDefaultValues(bool dynamicResolution, bool xrReady) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x60012EB")]
	public void set_colorFormat(GraphicsFormat value) { }

	[Address(RVA = "0x2CAB310", Offset = "0x2CAA710", Length = "0x8B")]
	[Token(Token = "0x60012E9")]
	public void set_depthBufferBits(DepthBits value) { }

}

