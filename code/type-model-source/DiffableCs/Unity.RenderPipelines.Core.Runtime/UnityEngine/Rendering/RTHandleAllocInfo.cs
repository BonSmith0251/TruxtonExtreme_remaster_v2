namespace UnityEngine.Rendering;

[Token(Token = "0x200019F")]
public struct RTHandleAllocInfo
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007F2")]
	private int <slices>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40007F3")]
	private GraphicsFormat <format>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007F4")]
	private FilterMode <filterMode>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40007F5")]
	private TextureWrapMode <wrapModeU>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007F6")]
	private TextureWrapMode <wrapModeV>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40007F7")]
	private TextureWrapMode <wrapModeW>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007F8")]
	private TextureDimension <dimension>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40007F9")]
	private bool <enableRandomWrite>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x40007FA")]
	private bool <useMipMap>k__BackingField; //Field offset: 0x1D
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E")]
	[Token(Token = "0x40007FB")]
	private bool <autoGenerateMips>k__BackingField; //Field offset: 0x1E
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F")]
	[Token(Token = "0x40007FC")]
	private bool <isShadowMap>k__BackingField; //Field offset: 0x1F
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007FD")]
	private int <anisoLevel>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40007FE")]
	private float <mipMapBias>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007FF")]
	private MSAASamples <msaaSamples>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000800")]
	private bool <bindTextureMS>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x4000801")]
	private bool <useDynamicScale>k__BackingField; //Field offset: 0x2D
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2E")]
	[Token(Token = "0x4000802")]
	private bool <useDynamicScaleExplicit>k__BackingField; //Field offset: 0x2E
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000803")]
	private RenderTextureMemoryless <memoryless>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000804")]
	private VRTextureUsage <vrUsage>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000805")]
	private bool <enableShadingRate>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000806")]
	private string <name>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x17000189")]
	public int anisoLevel
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C32")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C33")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000187")]
	public bool autoGenerateMips
	{
		[Address(RVA = "0x2B69C10", Offset = "0x2B69010", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C2E")]
		 get { } //Length: 5
		[Address(RVA = "0x2B81780", Offset = "0x2B80B80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C2F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700018C")]
	public bool bindTextureMS
	{
		[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C38")]
		 get { } //Length: 5
		[Address(RVA = "0x25D7F90", Offset = "0x25D7390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C39")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000184")]
	public TextureDimension dimension
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C28")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C29")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000185")]
	public bool enableRandomWrite
	{
		[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C2A")]
		 get { } //Length: 5
		[Address(RVA = "0x2B81770", Offset = "0x2B80B70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C2B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000191")]
	public bool enableShadingRate
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C42")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C43")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000180")]
	public FilterMode filterMode
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C20")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C21")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700017F")]
	public GraphicsFormat format
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C1E")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C1F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000188")]
	public bool isShadowMap
	{
		[Address(RVA = "0x2B69C00", Offset = "0x2B69000", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C30")]
		 get { } //Length: 5
		[Address(RVA = "0x2B81790", Offset = "0x2B80B90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C31")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700018F")]
	public RenderTextureMemoryless memoryless
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C3E")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C3F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700018A")]
	public float mipMapBias
	{
		[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C34")]
		 get { } //Length: 6
		[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000C35")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700018B")]
	public MSAASamples msaaSamples
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C36")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C37")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000192")]
	public string name
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C44")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000C45")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700017E")]
	public int slices
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C1C")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6000C1D")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700018D")]
	public bool useDynamicScale
	{
		[Address(RVA = "0x25D7F70", Offset = "0x25D7370", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C3A")]
		 get { } //Length: 5
		[Address(RVA = "0x25D7F80", Offset = "0x25D7380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C3B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700018E")]
	public bool useDynamicScaleExplicit
	{
		[Address(RVA = "0x29E11E0", Offset = "0x29E05E0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C3C")]
		 get { } //Length: 5
		[Address(RVA = "0x29E1220", Offset = "0x29E0620", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C3D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000186")]
	public bool useMipMap
	{
		[Address(RVA = "0x23ED910", Offset = "0x23ECD10", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C2C")]
		 get { } //Length: 5
		[Address(RVA = "0x2B81760", Offset = "0x2B80B60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C2D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000190")]
	public VRTextureUsage vrUsage
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C40")]
		 get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C41")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000181")]
	public TextureWrapMode wrapModeU
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C22")]
		 get { } //Length: 4
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C23")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000182")]
	public TextureWrapMode wrapModeV
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C24")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C25")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000183")]
	public TextureWrapMode wrapModeW
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C26")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C27")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2C47FA0", Offset = "0x2C473A0", Length = "0x4F")]
	[Token(Token = "0x6000C46")]
	public RTHandleAllocInfo(string name = "") { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C32")]
	public int get_anisoLevel() { }

	[Address(RVA = "0x2B69C10", Offset = "0x2B69010", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C2E")]
	public bool get_autoGenerateMips() { }

	[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C38")]
	public bool get_bindTextureMS() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C28")]
	public TextureDimension get_dimension() { }

	[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C2A")]
	public bool get_enableRandomWrite() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C42")]
	public bool get_enableShadingRate() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C20")]
	public FilterMode get_filterMode() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C1E")]
	public GraphicsFormat get_format() { }

	[Address(RVA = "0x2B69C00", Offset = "0x2B69000", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C30")]
	public bool get_isShadowMap() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C3E")]
	public RenderTextureMemoryless get_memoryless() { }

	[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C34")]
	public float get_mipMapBias() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C36")]
	public MSAASamples get_msaaSamples() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C44")]
	public string get_name() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C1C")]
	public int get_slices() { }

	[Address(RVA = "0x25D7F70", Offset = "0x25D7370", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C3A")]
	public bool get_useDynamicScale() { }

	[Address(RVA = "0x29E11E0", Offset = "0x29E05E0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C3C")]
	public bool get_useDynamicScaleExplicit() { }

	[Address(RVA = "0x23ED910", Offset = "0x23ECD10", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C2C")]
	public bool get_useMipMap() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C40")]
	public VRTextureUsage get_vrUsage() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C22")]
	public TextureWrapMode get_wrapModeU() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C24")]
	public TextureWrapMode get_wrapModeV() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C26")]
	public TextureWrapMode get_wrapModeW() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C33")]
	public void set_anisoLevel(int value) { }

	[Address(RVA = "0x2B81780", Offset = "0x2B80B80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C2F")]
	public void set_autoGenerateMips(bool value) { }

	[Address(RVA = "0x25D7F90", Offset = "0x25D7390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C39")]
	public void set_bindTextureMS(bool value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C29")]
	public void set_dimension(TextureDimension value) { }

	[Address(RVA = "0x2B81770", Offset = "0x2B80B70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C2B")]
	public void set_enableRandomWrite(bool value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C43")]
	public void set_enableShadingRate(bool value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C21")]
	public void set_filterMode(FilterMode value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C1F")]
	public void set_format(GraphicsFormat value) { }

	[Address(RVA = "0x2B81790", Offset = "0x2B80B90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C31")]
	public void set_isShadowMap(bool value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C3F")]
	public void set_memoryless(RenderTextureMemoryless value) { }

	[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000C35")]
	public void set_mipMapBias(float value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C37")]
	public void set_msaaSamples(MSAASamples value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000C45")]
	public void set_name(string value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x6000C1D")]
	public void set_slices(int value) { }

	[Address(RVA = "0x25D7F80", Offset = "0x25D7380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C3B")]
	public void set_useDynamicScale(bool value) { }

	[Address(RVA = "0x29E1220", Offset = "0x29E0620", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C3D")]
	public void set_useDynamicScaleExplicit(bool value) { }

	[Address(RVA = "0x2B81760", Offset = "0x2B80B60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C2D")]
	public void set_useMipMap(bool value) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C41")]
	public void set_vrUsage(VRTextureUsage value) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C23")]
	public void set_wrapModeU(TextureWrapMode value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C25")]
	public void set_wrapModeV(TextureWrapMode value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C27")]
	public void set_wrapModeW(TextureWrapMode value) { }

}

