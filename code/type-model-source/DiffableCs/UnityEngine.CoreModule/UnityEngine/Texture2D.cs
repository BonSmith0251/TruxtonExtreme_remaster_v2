namespace UnityEngine;

[ExcludeFromPreset]
[HelpURL("texture-type-default")]
[NativeHeader("Runtime/Graphics/Texture2D.h")]
[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
[Token(Token = "0x2000136")]
[UsedByNativeCode]
public sealed class Texture2D : Texture
{
	[Token(Token = "0x40003FF")]
	internal const int streamingMipmapsPriorityMin = -128; //Field offset: 0x0
	[Token(Token = "0x4000400")]
	internal const int streamingMipmapsPriorityMax = 127; //Field offset: 0x0

	[Token(Token = "0x1700021E")]
	public int activeMipmapLimit
	{
		[Address(RVA = "0x3042040", Offset = "0x3041440", Length = "0x76")]
		[NativeName("GetMipmapLimit")]
		[Token(Token = "0x6000DA4")]
		 get { } //Length: 118
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x17000220")]
	public static Texture2D blackTexture
	{
		[Address(RVA = "0x30420F0", Offset = "0x30414F0", Length = "0x54")]
		[Token(Token = "0x6000DA6")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700022D")]
	public int calculatedMipmapLevel
	{
		[Address(RVA = "0x3042190", Offset = "0x3041590", Length = "0x76")]
		[FreeFunction(Name = "GetTextureStreamingManager().GetCalculatedMipmapLevel", HasExplicitThis = True)]
		[Token(Token = "0x6000DCA")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700022E")]
	public int desiredMipmapLevel
	{
		[Address(RVA = "0x3042250", Offset = "0x3041650", Length = "0x76")]
		[FreeFunction(Name = "GetTextureStreamingManager().GetDesiredMipmapLevel", HasExplicitThis = True)]
		[Token(Token = "0x6000DCB")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700021C")]
	public TextureFormat format
	{
		[Address(RVA = "0x3042310", Offset = "0x3041710", Length = "0x76")]
		[NativeName("GetTextureFormat")]
		[Token(Token = "0x6000DA0")]
		 get { } //Length: 118
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x17000222")]
	public static Texture2D grayTexture
	{
		[Address(RVA = "0x30423C0", Offset = "0x30417C0", Length = "0x54")]
		[Token(Token = "0x6000DA8")]
		 get { } //Length: 84
	}

	[Token(Token = "0x17000231")]
	public bool ignoreMipmapLimit
	{
		[Address(RVA = "0x303E8A0", Offset = "0x303DCA0", Length = "0x76")]
		[Token(Token = "0x6000E1A")]
		 get { } //Length: 118
		[Address(RVA = "0x3042F40", Offset = "0x3042340", Length = "0xBB")]
		[Token(Token = "0x6000E1B")]
		 set { } //Length: 187
	}

	[Token(Token = "0x17000227")]
	internal bool isPreProcessed
	{
		[Address(RVA = "0x3042460", Offset = "0x3041860", Length = "0x76")]
		[Token(Token = "0x6000DC1")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x17000225")]
	public virtual bool isReadable
	{
		[Address(RVA = "0x3042520", Offset = "0x3041920", Length = "0x76")]
		[Token(Token = "0x6000DAF")]
		 get { } //Length: 118
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x17000223")]
	public static Texture2D linearGrayTexture
	{
		[Address(RVA = "0x30425D0", Offset = "0x30419D0", Length = "0x54")]
		[Token(Token = "0x6000DA9")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700022C")]
	internal bool loadAllMips
	{
		[Address(RVA = "0x3042670", Offset = "0x3041A70", Length = "0x76")]
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadAllMips", HasExplicitThis = True)]
		[Token(Token = "0x6000DC8")]
		internal get { } //Length: 118
		[Address(RVA = "0x3043050", Offset = "0x3042450", Length = "0x86")]
		[FreeFunction(Name = "GetTextureStreamingManager().SetLoadAllMips", HasExplicitThis = True)]
		[Token(Token = "0x6000DC9")]
		internal set { } //Length: 134
	}

	[Token(Token = "0x17000230")]
	public int loadedMipmapLevel
	{
		[Address(RVA = "0x3042730", Offset = "0x3041B30", Length = "0x76")]
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadedMipmapLevel", HasExplicitThis = True)]
		[Token(Token = "0x6000DCD")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700022F")]
	public int loadingMipmapLevel
	{
		[Address(RVA = "0x30427F0", Offset = "0x3041BF0", Length = "0x76")]
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadingMipmapLevel", HasExplicitThis = True)]
		[Token(Token = "0x6000DCC")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700022B")]
	public int minimumMipmapLevel
	{
		[Address(RVA = "0x30428B0", Offset = "0x3041CB0", Length = "0x76")]
		[FreeFunction(Name = "GetTextureStreamingManager().GetMinimumMipmapLevel", HasExplicitThis = True)]
		[Token(Token = "0x6000DC6")]
		 get { } //Length: 118
		[Address(RVA = "0x3043120", Offset = "0x3042520", Length = "0x83")]
		[FreeFunction(Name = "GetTextureStreamingManager().SetMinimumMipmapLevel", HasExplicitThis = True)]
		[Token(Token = "0x6000DC7")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700021D")]
	public string mipmapLimitGroup
	{
		[Address(RVA = "0x3042980", Offset = "0x3041D80", Length = "0x106")]
		[NativeName("GetMipmapLimitGroupName")]
		[Token(Token = "0x6000DA3")]
		 get { } //Length: 262
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x17000224")]
	public static Texture2D normalTexture
	{
		[Address(RVA = "0x3042AC0", Offset = "0x3041EC0", Length = "0x54")]
		[Token(Token = "0x6000DAA")]
		 get { } //Length: 84
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x17000221")]
	public static Texture2D redTexture
	{
		[Address(RVA = "0x3042B50", Offset = "0x3041F50", Length = "0x54")]
		[Token(Token = "0x6000DA7")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700022A")]
	public int requestedMipmapLevel
	{
		[Address(RVA = "0x3042BF0", Offset = "0x3041FF0", Length = "0x76")]
		[FreeFunction(Name = "GetTextureStreamingManager().GetRequestedMipmapLevel", HasExplicitThis = True)]
		[Token(Token = "0x6000DC4")]
		 get { } //Length: 118
		[Address(RVA = "0x30431F0", Offset = "0x30425F0", Length = "0x83")]
		[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = True)]
		[Token(Token = "0x6000DC5")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000228")]
	public bool streamingMipmaps
	{
		[Address(RVA = "0x3042D70", Offset = "0x3042170", Length = "0x76")]
		[Token(Token = "0x6000DC2")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000229")]
	public int streamingMipmapsPriority
	{
		[Address(RVA = "0x3042CB0", Offset = "0x30420B0", Length = "0x76")]
		[Token(Token = "0x6000DC3")]
		 get { } //Length: 118
	}

	[NativeConditional("ENABLE_VIRTUALTEXTURING && UNITY_EDITOR")]
	[NativeName("VTOnly")]
	[Token(Token = "0x17000226")]
	public bool vtOnly
	{
		[Address(RVA = "0x3042E30", Offset = "0x3042230", Length = "0x76")]
		[Token(Token = "0x6000DB0")]
		 get { } //Length: 118
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x1700021F")]
	public static Texture2D whiteTexture
	{
		[Address(RVA = "0x3042EE0", Offset = "0x30422E0", Length = "0x54")]
		[Token(Token = "0x6000DA5")]
		 get { } //Length: 84
	}

	[Address(RVA = "0x3041330", Offset = "0x3040730", Length = "0x19A")]
	[Token(Token = "0x6000DF2")]
	public Texture2D(int width, int height) { }

	[Address(RVA = "0x3041140", Offset = "0x3040540", Length = "0x58")]
	[Token(Token = "0x6000DED")]
	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[Address(RVA = "0x3041F40", Offset = "0x3041340", Length = "0xB1")]
	[Obsolete("Please provide mipmap limit information using a MipmapLimitDescriptor argument", False)]
	[Token(Token = "0x6000DEE")]
	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[Address(RVA = "0x3041BB0", Offset = "0x3040FB0", Length = "0xCF")]
	[Token(Token = "0x6000DEF")]
	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[Address(RVA = "0x3041E60", Offset = "0x3041260", Length = "0xD7")]
	[Token(Token = "0x6000DF0")]
	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	[Address(RVA = "0x3041CE0", Offset = "0x30410E0", Length = "0xC7")]
	[Token(Token = "0x6000DF1")]
	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	[Address(RVA = "0x30417F0", Offset = "0x3040BF0", Length = "0x1CC")]
	[Token(Token = "0x6000DEA")]
	internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[Address(RVA = "0x30419C0", Offset = "0x3040DC0", Length = "0x4B")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000DE9")]
	public Texture2D(int width, int height, GraphicsFormat format, int mipCount, TextureCreationFlags flags, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[Address(RVA = "0x3041750", Offset = "0x3040B50", Length = "0x9B")]
	[ExcludeFromDocs]
	[Obsolete("Please provide mipmap limit information using a MipmapLimitDescriptor argument", False)]
	[Token(Token = "0x6000DE8")]
	public Texture2D(int width, int height, GraphicsFormat format, int mipCount, string mipmapLimitGroupName, TextureCreationFlags flags) { }

	[Address(RVA = "0x3041C80", Offset = "0x3041080", Length = "0x51")]
	[Token(Token = "0x6000DEC")]
	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	[Address(RVA = "0x3041220", Offset = "0x3040620", Length = "0x44")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000DE7")]
	public Texture2D(int width, int height, GraphicsFormat format, int mipCount, TextureCreationFlags flags) { }

	[Address(RVA = "0x3041270", Offset = "0x3040670", Length = "0xB9")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000DE6")]
	public Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x3041A10", Offset = "0x3040E10", Length = "0x4A")]
	[Token(Token = "0x6000DEB")]
	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	[Address(RVA = "0x3041DB0", Offset = "0x30411B0", Length = "0xA4")]
	[ExcludeFromDocs]
	[Obsolete("Please provide mipmap limit information using a MipmapLimitDescriptor argument", False)]
	[Token(Token = "0x6000DE4")]
	public Texture2D(int width, int height, DefaultFormat format, int mipCount, string mipmapLimitGroupName, TextureCreationFlags flags) { }

	[Address(RVA = "0x30411A0", Offset = "0x30405A0", Length = "0x7E")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000DE5")]
	public Texture2D(int width, int height, DefaultFormat format, int mipCount, TextureCreationFlags flags, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[Address(RVA = "0x3041A60", Offset = "0x3040E60", Length = "0x76")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000DE3")]
	public Texture2D(int width, int height, DefaultFormat format, int mipCount, TextureCreationFlags flags) { }

	[Address(RVA = "0x3041AE0", Offset = "0x3040EE0", Length = "0xC2")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000DE2")]
	public Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x30414D0", Offset = "0x30408D0", Length = "0x275")]
	[Token(Token = "0x6000DE1")]
	internal Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[Address(RVA = "0x303CAF0", Offset = "0x303BEF0", Length = "0xD")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000E07")]
	public void Apply() { }

	[Address(RVA = "0x303CB00", Offset = "0x303BF00", Length = "0xB")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000E06")]
	public void Apply(bool updateMipmaps) { }

	[Address(RVA = "0x303CA20", Offset = "0x303BE20", Length = "0xCD")]
	[Token(Token = "0x6000E05")]
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x303C980", Offset = "0x303BD80", Length = "0x98")]
	[NativeName("Apply")]
	[Token(Token = "0x6000DB1")]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x303C920", Offset = "0x303BD20", Length = "0x55")]
	[Token(Token = "0x6000E2B")]
	private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x303CB50", Offset = "0x303BF50", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().ClearMinimumMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000DD0")]
	public void ClearMinimumMipmapLevel() { }

	[Address(RVA = "0x303CB10", Offset = "0x303BF10", Length = "0x33")]
	[Token(Token = "0x6000E4A")]
	private static void ClearMinimumMipmapLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303CC10", Offset = "0x303C010", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().ClearRequestedMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000DCE")]
	public void ClearRequestedMipmapLevel() { }

	[Address(RVA = "0x303CBD0", Offset = "0x303BFD0", Length = "0x33")]
	[Token(Token = "0x6000E48")]
	private static void ClearRequestedMipmapLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303CCE0", Offset = "0x303C0E0", Length = "0x86")]
	[Token(Token = "0x6000DAB")]
	public void Compress(bool highQuality) { }

	[Address(RVA = "0x303CC90", Offset = "0x303C090", Length = "0x42")]
	[Token(Token = "0x6000E27")]
	private static void Compress_Injected(IntPtr _unity_self, bool highQuality) { }

	[Address(RVA = "0x303D270", Offset = "0x303C670", Length = "0x15D")]
	[Token(Token = "0x6000E19")]
	public void CopyPixels(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY) { }

	[Address(RVA = "0x303D130", Offset = "0x303C530", Length = "0x137")]
	[Token(Token = "0x6000E17")]
	public void CopyPixels(Texture src) { }

	[Address(RVA = "0x303D3D0", Offset = "0x303C7D0", Length = "0x159")]
	[Token(Token = "0x6000E18")]
	public void CopyPixels(Texture src, int srcElement, int srcMip, int dstMip) { }

	[Address(RVA = "0x303CDC0", Offset = "0x303C1C0", Length = "0xBA")]
	[FreeFunction(Name = "Texture2DScripting::CopyPixels", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000DDC")]
	private void CopyPixels_Full(Texture src) { }

	[Address(RVA = "0x303CD70", Offset = "0x303C170", Length = "0x42")]
	[Token(Token = "0x6000E52")]
	private static void CopyPixels_Full_Injected(IntPtr _unity_self, IntPtr src) { }

	[Address(RVA = "0x303CEF0", Offset = "0x303C2F0", Length = "0xE4")]
	[FreeFunction(Name = "Texture2DScripting::CopyPixels", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000DDE")]
	private void CopyPixels_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY) { }

	[Address(RVA = "0x303CE80", Offset = "0x303C280", Length = "0x68")]
	[Token(Token = "0x6000E54")]
	private static void CopyPixels_Region_Injected(IntPtr _unity_self, IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY) { }

	[Address(RVA = "0x303D050", Offset = "0x303C450", Length = "0xD2")]
	[FreeFunction(Name = "Texture2DScripting::CopyPixels", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000DDD")]
	private void CopyPixels_Slice(Texture src, int srcElement, int srcMip, int dstMip) { }

	[Address(RVA = "0x303CFE0", Offset = "0x303C3E0", Length = "0x62")]
	[Token(Token = "0x6000E53")]
	private static void CopyPixels_Slice_Injected(IntPtr _unity_self, IntPtr src, int srcElement, int srcMip, int dstMip) { }

	[Address(RVA = "0x303D530", Offset = "0x303C930", Length = "0x128")]
	[Token(Token = "0x6000DF3")]
	public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex) { }

	[Address(RVA = "0x303D860", Offset = "0x303CC60", Length = "0x248")]
	[Token(Token = "0x6000E10")]
	public static bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results) { }

	[Address(RVA = "0x303D6C0", Offset = "0x303CAC0", Length = "0x198")]
	[FreeFunction("Texture2DScripting::GenerateAtlas")]
	[Token(Token = "0x6000DC0")]
	private static void GenerateAtlasImpl(Vector2[] sizes, int padding, int atlasSize, out Rect[] rect) { }

	[Address(RVA = "0x303D660", Offset = "0x303CA60", Length = "0x60")]
	[Token(Token = "0x6000E3A")]
	private static void GenerateAtlasImpl_Injected(ref ManagedSpanWrapper sizes, int padding, int atlasSize, out BlittableArrayWrapper rect) { }

	[Address(RVA = "0x3042040", Offset = "0x3041440", Length = "0x76")]
	[NativeName("GetMipmapLimit")]
	[Token(Token = "0x6000DA4")]
	public int get_activeMipmapLimit() { }

	[Address(RVA = "0x3042000", Offset = "0x3041400", Length = "0x33")]
	[Token(Token = "0x6000E20")]
	private static int get_activeMipmapLimit_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30420F0", Offset = "0x30414F0", Length = "0x54")]
	[Token(Token = "0x6000DA6")]
	public static Texture2D get_blackTexture() { }

	[Address(RVA = "0x30420C0", Offset = "0x30414C0", Length = "0x2A")]
	[Token(Token = "0x6000E22")]
	private static IntPtr get_blackTexture_Injected() { }

	[Address(RVA = "0x3042190", Offset = "0x3041590", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().GetCalculatedMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000DCA")]
	public int get_calculatedMipmapLevel() { }

	[Address(RVA = "0x3042150", Offset = "0x3041550", Length = "0x33")]
	[Token(Token = "0x6000E44")]
	private static int get_calculatedMipmapLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3042250", Offset = "0x3041650", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().GetDesiredMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000DCB")]
	public int get_desiredMipmapLevel() { }

	[Address(RVA = "0x3042210", Offset = "0x3041610", Length = "0x33")]
	[Token(Token = "0x6000E45")]
	private static int get_desiredMipmapLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3042310", Offset = "0x3041710", Length = "0x76")]
	[NativeName("GetTextureFormat")]
	[Token(Token = "0x6000DA0")]
	public TextureFormat get_format() { }

	[Address(RVA = "0x30422D0", Offset = "0x30416D0", Length = "0x33")]
	[Token(Token = "0x6000E1C")]
	private static TextureFormat get_format_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30423C0", Offset = "0x30417C0", Length = "0x54")]
	[Token(Token = "0x6000DA8")]
	public static Texture2D get_grayTexture() { }

	[Address(RVA = "0x3042390", Offset = "0x3041790", Length = "0x2A")]
	[Token(Token = "0x6000E24")]
	private static IntPtr get_grayTexture_Injected() { }

	[Address(RVA = "0x303E8A0", Offset = "0x303DCA0", Length = "0x76")]
	[Token(Token = "0x6000E1A")]
	public bool get_ignoreMipmapLimit() { }

	[Address(RVA = "0x3042460", Offset = "0x3041860", Length = "0x76")]
	[Token(Token = "0x6000DC1")]
	internal bool get_isPreProcessed() { }

	[Address(RVA = "0x3042420", Offset = "0x3041820", Length = "0x33")]
	[Token(Token = "0x6000E3B")]
	private static bool get_isPreProcessed_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3042520", Offset = "0x3041920", Length = "0x76")]
	[Token(Token = "0x6000DAF")]
	public virtual bool get_isReadable() { }

	[Address(RVA = "0x30424E0", Offset = "0x30418E0", Length = "0x33")]
	[Token(Token = "0x6000E29")]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30425D0", Offset = "0x30419D0", Length = "0x54")]
	[Token(Token = "0x6000DA9")]
	public static Texture2D get_linearGrayTexture() { }

	[Address(RVA = "0x30425A0", Offset = "0x30419A0", Length = "0x2A")]
	[Token(Token = "0x6000E25")]
	private static IntPtr get_linearGrayTexture_Injected() { }

	[Address(RVA = "0x3042670", Offset = "0x3041A70", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadAllMips", HasExplicitThis = True)]
	[Token(Token = "0x6000DC8")]
	internal bool get_loadAllMips() { }

	[Address(RVA = "0x3042630", Offset = "0x3041A30", Length = "0x33")]
	[Token(Token = "0x6000E42")]
	private static bool get_loadAllMips_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3042730", Offset = "0x3041B30", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadedMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000DCD")]
	public int get_loadedMipmapLevel() { }

	[Address(RVA = "0x30426F0", Offset = "0x3041AF0", Length = "0x33")]
	[Token(Token = "0x6000E47")]
	private static int get_loadedMipmapLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30427F0", Offset = "0x3041BF0", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadingMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000DCC")]
	public int get_loadingMipmapLevel() { }

	[Address(RVA = "0x30427B0", Offset = "0x3041BB0", Length = "0x33")]
	[Token(Token = "0x6000E46")]
	private static int get_loadingMipmapLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30428B0", Offset = "0x3041CB0", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().GetMinimumMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000DC6")]
	public int get_minimumMipmapLevel() { }

	[Address(RVA = "0x3042870", Offset = "0x3041C70", Length = "0x33")]
	[Token(Token = "0x6000E40")]
	private static int get_minimumMipmapLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3042980", Offset = "0x3041D80", Length = "0x106")]
	[NativeName("GetMipmapLimitGroupName")]
	[Token(Token = "0x6000DA3")]
	public string get_mipmapLimitGroup() { }

	[Address(RVA = "0x3042930", Offset = "0x3041D30", Length = "0x42")]
	[Token(Token = "0x6000E1F")]
	private static void get_mipmapLimitGroup_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3042AC0", Offset = "0x3041EC0", Length = "0x54")]
	[Token(Token = "0x6000DAA")]
	public static Texture2D get_normalTexture() { }

	[Address(RVA = "0x3042A90", Offset = "0x3041E90", Length = "0x2A")]
	[Token(Token = "0x6000E26")]
	private static IntPtr get_normalTexture_Injected() { }

	[Address(RVA = "0x3042B50", Offset = "0x3041F50", Length = "0x54")]
	[Token(Token = "0x6000DA7")]
	public static Texture2D get_redTexture() { }

	[Address(RVA = "0x3042B20", Offset = "0x3041F20", Length = "0x2A")]
	[Token(Token = "0x6000E23")]
	private static IntPtr get_redTexture_Injected() { }

	[Address(RVA = "0x3042BF0", Offset = "0x3041FF0", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().GetRequestedMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000DC4")]
	public int get_requestedMipmapLevel() { }

	[Address(RVA = "0x3042BB0", Offset = "0x3041FB0", Length = "0x33")]
	[Token(Token = "0x6000E3E")]
	private static int get_requestedMipmapLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3042D70", Offset = "0x3042170", Length = "0x76")]
	[Token(Token = "0x6000DC2")]
	public bool get_streamingMipmaps() { }

	[Address(RVA = "0x3042D30", Offset = "0x3042130", Length = "0x33")]
	[Token(Token = "0x6000E3C")]
	private static bool get_streamingMipmaps_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3042CB0", Offset = "0x30420B0", Length = "0x76")]
	[Token(Token = "0x6000DC3")]
	public int get_streamingMipmapsPriority() { }

	[Address(RVA = "0x3042C70", Offset = "0x3042070", Length = "0x33")]
	[Token(Token = "0x6000E3D")]
	private static int get_streamingMipmapsPriority_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3042E30", Offset = "0x3042230", Length = "0x76")]
	[Token(Token = "0x6000DB0")]
	public bool get_vtOnly() { }

	[Address(RVA = "0x3042DF0", Offset = "0x30421F0", Length = "0x33")]
	[Token(Token = "0x6000E2A")]
	private static bool get_vtOnly_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3042EE0", Offset = "0x30422E0", Length = "0x54")]
	[Token(Token = "0x6000DA5")]
	public static Texture2D get_whiteTexture() { }

	[Address(RVA = "0x3042EB0", Offset = "0x30422B0", Length = "0x2A")]
	[Token(Token = "0x6000E21")]
	private static IntPtr get_whiteTexture_Injected() { }

	[Address(RVA = "0x303DAF0", Offset = "0x303CEF0", Length = "0x76")]
	[Token(Token = "0x6000DBF")]
	private ulong GetImageDataSize() { }

	[Address(RVA = "0x303DAB0", Offset = "0x303CEB0", Length = "0x33")]
	[Token(Token = "0x6000E39")]
	private static ulong GetImageDataSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303DFE0", Offset = "0x303D3E0", Length = "0x109")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000DFA")]
	public Color GetPixel(int x, int y) { }

	[Address(RVA = "0x303E0F0", Offset = "0x303D4F0", Length = "0x10B")]
	[Token(Token = "0x6000DFB")]
	public Color GetPixel(int x, int y, int mipLevel) { }

	[Address(RVA = "0x303DDB0", Offset = "0x303D1B0", Length = "0x109")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000DFC")]
	public Color GetPixelBilinear(float u, float v) { }

	[Address(RVA = "0x303DCA0", Offset = "0x303D0A0", Length = "0x10E")]
	[Token(Token = "0x6000DFD")]
	public Color GetPixelBilinear(float u, float v, int mipLevel) { }

	[Address(RVA = "0x303DBD0", Offset = "0x303CFD0", Length = "0xC4")]
	[NativeName("GetPixelBilinear")]
	[Token(Token = "0x6000DB5")]
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	[Address(RVA = "0x303DB70", Offset = "0x303CF70", Length = "0x60")]
	[Token(Token = "0x6000E2F")]
	private static void GetPixelBilinearImpl_Injected(IntPtr _unity_self, int image, int mip, float u, float v, out Color ret) { }

	[Address(RVA = "0x943620", Offset = "0x942A20", Length = "0x2DC")]
	[Token(Token = "0x6000E03")]
	public NativeArray<T> GetPixelData(int mipLevel) { }

	[Address(RVA = "0x303DF20", Offset = "0x303D320", Length = "0xBF")]
	[NativeName("GetPixel")]
	[Token(Token = "0x6000DB4")]
	private Color GetPixelImpl(int image, int mip, int x, int y) { }

	[Address(RVA = "0x303DEC0", Offset = "0x303D2C0", Length = "0x60")]
	[Token(Token = "0x6000E2E")]
	private static void GetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, out Color ret) { }

	[Address(RVA = "0x303E620", Offset = "0x303DA20", Length = "0xA7")]
	[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000DD5")]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[Address(RVA = "0x303E3B0", Offset = "0x303D7B0", Length = "0xAF")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000DD6")]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) { }

	[Address(RVA = "0x303E550", Offset = "0x303D950", Length = "0xCE")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000E16")]
	public Color[] GetPixels() { }

	[Address(RVA = "0x303E460", Offset = "0x303D860", Length = "0xE4")]
	[Token(Token = "0x6000E15")]
	public Color[] GetPixels(int miplevel) { }

	[Address(RVA = "0x303E350", Offset = "0x303D750", Length = "0x60")]
	[Token(Token = "0x6000E4F")]
	private static Color[] GetPixels_Injected(IntPtr _unity_self, int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[Address(RVA = "0x303E240", Offset = "0x303D640", Length = "0x83")]
	[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000DD7")]
	public Color32[] GetPixels32(int miplevel) { }

	[Address(RVA = "0x303E2D0", Offset = "0x303D6D0", Length = "0x78")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000DD8")]
	public Color32[] GetPixels32() { }

	[Address(RVA = "0x303E200", Offset = "0x303D600", Length = "0x40")]
	[Token(Token = "0x6000E50")]
	private static Color32[] GetPixels32_Injected(IntPtr _unity_self, int miplevel) { }

	[Address(RVA = "0x303E710", Offset = "0x303DB10", Length = "0x76")]
	[FreeFunction("Texture2DScripting::GetRawTextureData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000DD4")]
	public Byte[] GetRawTextureData() { }

	[Address(RVA = "0x943A10", Offset = "0x942E10", Length = "0x10E")]
	[Token(Token = "0x6000E04")]
	public NativeArray<T> GetRawTextureData() { }

	[Address(RVA = "0x303E6D0", Offset = "0x303DAD0", Length = "0x33")]
	[Token(Token = "0x6000E4E")]
	private static Byte[] GetRawTextureData_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303E7D0", Offset = "0x303DBD0", Length = "0x83")]
	[Token(Token = "0x6000DBE")]
	private IntPtr GetWritableImageData(int frame) { }

	[Address(RVA = "0x303E790", Offset = "0x303DB90", Length = "0x40")]
	[Token(Token = "0x6000E38")]
	private static IntPtr GetWritableImageData_Injected(IntPtr _unity_self, int frame) { }

	[Address(RVA = "0x303E8A0", Offset = "0x303DCA0", Length = "0x76")]
	[Token(Token = "0x6000DA1")]
	private bool IgnoreMipmapLimit() { }

	[Address(RVA = "0x303E860", Offset = "0x303DC60", Length = "0x33")]
	[Token(Token = "0x6000E1D")]
	private static bool IgnoreMipmapLimit_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303EC00", Offset = "0x303E000", Length = "0xB4")]
	[Token(Token = "0x6000DAE")]
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[Address(RVA = "0x303E920", Offset = "0x303DD20", Length = "0x33")]
	[FreeFunction("Texture2DScripting::CreateEmpty")]
	[Token(Token = "0x6000DAC")]
	private static bool Internal_CreateEmptyImpl(Texture2D mono) { }

	[Address(RVA = "0x303E9E0", Offset = "0x303DDE0", Length = "0x213")]
	[FreeFunction("Texture2DScripting::Create")]
	[Token(Token = "0x6000DAD")]
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[Address(RVA = "0x303E960", Offset = "0x303DD60", Length = "0x72")]
	[Token(Token = "0x6000E28")]
	private static bool Internal_CreateImpl_Injected(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, ref ManagedSpanWrapper mipmapLimitGroupName) { }

	[Address(RVA = "0x303ED00", Offset = "0x303E100", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().IsRequestedMipmapLevelLoaded", HasExplicitThis = True)]
	[Token(Token = "0x6000DCF")]
	public bool IsRequestedMipmapLevelLoaded() { }

	[Address(RVA = "0x303ECC0", Offset = "0x303E0C0", Length = "0x33")]
	[Token(Token = "0x6000E49")]
	private static bool IsRequestedMipmapLevelLoaded_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x943C50", Offset = "0x943050", Length = "0x1AB")]
	[Token(Token = "0x6000E00")]
	public void LoadRawTextureData(NativeArray<T> data) { }

	[Address(RVA = "0x303EFE0", Offset = "0x303E3E0", Length = "0x1DE")]
	[Token(Token = "0x6000DFF")]
	public void LoadRawTextureData(Byte[] data) { }

	[Address(RVA = "0x303F1C0", Offset = "0x303E5C0", Length = "0x178")]
	[Token(Token = "0x6000DFE")]
	public void LoadRawTextureData(IntPtr data, int size) { }

	[Address(RVA = "0x303EF40", Offset = "0x303E340", Length = "0x95")]
	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	[Token(Token = "0x6000DBA")]
	private bool LoadRawTextureDataImpl(IntPtr data, ulong size) { }

	[Address(RVA = "0x303EEE0", Offset = "0x303E2E0", Length = "0x52")]
	[Token(Token = "0x6000E34")]
	private static bool LoadRawTextureDataImpl_Injected(IntPtr _unity_self, IntPtr data, ulong size) { }

	[Address(RVA = "0x303EDD0", Offset = "0x303E1D0", Length = "0x104")]
	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	[Token(Token = "0x6000DBB")]
	private bool LoadRawTextureDataImplArray(Byte[] data) { }

	[Address(RVA = "0x303ED80", Offset = "0x303E180", Length = "0x42")]
	[Token(Token = "0x6000E35")]
	private static bool LoadRawTextureDataImplArray_Injected(IntPtr _unity_self, ref ManagedSpanWrapper data) { }

	[Address(RVA = "0x303F510", Offset = "0x303E910", Length = "0xB0")]
	[FreeFunction("Texture2DScripting::PackTextures", HasExplicitThis = True)]
	[Token(Token = "0x6000DD9")]
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { }

	[Address(RVA = "0x303F3B0", Offset = "0x303E7B0", Length = "0xAC")]
	[Token(Token = "0x6000DDA")]
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize) { }

	[Address(RVA = "0x303F460", Offset = "0x303E860", Length = "0xA0")]
	[Token(Token = "0x6000DDB")]
	public Rect[] PackTextures(Texture2D[] textures, int padding) { }

	[Address(RVA = "0x303F340", Offset = "0x303E740", Length = "0x6D")]
	[Token(Token = "0x6000E51")]
	private static Rect[] PackTextures_Injected(IntPtr _unity_self, Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { }

	[Address(RVA = "0x303F700", Offset = "0x303EB00", Length = "0xE3")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000E0F")]
	public void ReadPixels(Rect source, int destX, int destY) { }

	[Address(RVA = "0x303F7F0", Offset = "0x303EBF0", Length = "0xE7")]
	[Token(Token = "0x6000E0E")]
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[Address(RVA = "0x303F640", Offset = "0x303EA40", Length = "0xB0")]
	[FreeFunction(Name = "Texture2DScripting::ReadPixels", HasExplicitThis = True)]
	[Token(Token = "0x6000DB8")]
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[Address(RVA = "0x303F5D0", Offset = "0x303E9D0", Length = "0x6D")]
	[Token(Token = "0x6000E32")]
	private static void ReadPixelsImpl_Injected(IntPtr _unity_self, in Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[Address(RVA = "0x303FC30", Offset = "0x303F030", Length = "0xC8")]
	[Token(Token = "0x6000E08")]
	public bool Reinitialize(int width, int height) { }

	[Address(RVA = "0x303FB70", Offset = "0x303EF70", Length = "0xB0")]
	[Token(Token = "0x6000E09")]
	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	[Address(RVA = "0x303FD00", Offset = "0x303F100", Length = "0xE9")]
	[Token(Token = "0x6000E0A")]
	public bool Reinitialize(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	[Address(RVA = "0x303F930", Offset = "0x303ED30", Length = "0x93")]
	[NativeName("Reinitialize")]
	[Token(Token = "0x6000DB2")]
	private bool ReinitializeImpl(int width, int height) { }

	[Address(RVA = "0x303F8E0", Offset = "0x303ECE0", Length = "0x50")]
	[Token(Token = "0x6000E2C")]
	private static bool ReinitializeImpl_Injected(IntPtr _unity_self, int width, int height) { }

	[Address(RVA = "0x303FA40", Offset = "0x303EE40", Length = "0xB0")]
	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithFormat", HasExplicitThis = True)]
	[Token(Token = "0x6000DB6")]
	private bool ReinitializeWithFormatImpl(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	[Address(RVA = "0x303F9D0", Offset = "0x303EDD0", Length = "0x6B")]
	[Token(Token = "0x6000E30")]
	private static bool ReinitializeWithFormatImpl_Injected(IntPtr _unity_self, int width, int height, GraphicsFormat format, bool hasMipMap) { }

	[Address(RVA = "0x303FB70", Offset = "0x303EF70", Length = "0xB0")]
	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithTextureFormat", HasExplicitThis = True)]
	[Token(Token = "0x6000DB7")]
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	[Address(RVA = "0x303FB00", Offset = "0x303EF00", Length = "0x6B")]
	[Token(Token = "0x6000E31")]
	private static bool ReinitializeWithTextureFormatImpl_Injected(IntPtr _unity_self, int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	[Address(RVA = "0x303FC30", Offset = "0x303F030", Length = "0xC8")]
	[Obsolete("Texture2D.Resize(int, int) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32)", False)]
	[Token(Token = "0x6000E0B")]
	public bool Resize(int width, int height) { }

	[Address(RVA = "0x303FB70", Offset = "0x303EF70", Length = "0xB0")]
	[Obsolete("Texture2D.Resize(int, int, TextureFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, TextureFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.TextureFormat, [*] System.Boolean)", False)]
	[Token(Token = "0x6000E0C")]
	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	[Address(RVA = "0x303FD00", Offset = "0x303F100", Length = "0xE9")]
	[Obsolete("Texture2D.Resize(int, int, GraphicsFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, GraphicsFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, [*] System.Boolean)", False)]
	[Token(Token = "0x6000E0D")]
	public bool Resize(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	[Address(RVA = "0x3042F40", Offset = "0x3042340", Length = "0xBB")]
	[Token(Token = "0x6000E1B")]
	public void set_ignoreMipmapLimit(bool value) { }

	[Address(RVA = "0x3043050", Offset = "0x3042450", Length = "0x86")]
	[FreeFunction(Name = "GetTextureStreamingManager().SetLoadAllMips", HasExplicitThis = True)]
	[Token(Token = "0x6000DC9")]
	internal void set_loadAllMips(bool value) { }

	[Address(RVA = "0x3043000", Offset = "0x3042400", Length = "0x42")]
	[Token(Token = "0x6000E43")]
	private static void set_loadAllMips_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3043120", Offset = "0x3042520", Length = "0x83")]
	[FreeFunction(Name = "GetTextureStreamingManager().SetMinimumMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000DC7")]
	public void set_minimumMipmapLevel(int value) { }

	[Address(RVA = "0x30430E0", Offset = "0x30424E0", Length = "0x40")]
	[Token(Token = "0x6000E41")]
	private static void set_minimumMipmapLevel_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x30431F0", Offset = "0x30425F0", Length = "0x83")]
	[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000DC5")]
	public void set_requestedMipmapLevel(int value) { }

	[Address(RVA = "0x30431B0", Offset = "0x30425B0", Length = "0x40")]
	[Token(Token = "0x6000E3F")]
	private static void set_requestedMipmapLevel_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x303FE50", Offset = "0x303F250", Length = "0x114")]
	[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000DD2")]
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[Address(RVA = "0x303FDF0", Offset = "0x303F1F0", Length = "0x52")]
	[Token(Token = "0x6000E4C")]
	private static void SetAllPixels32_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, int miplevel) { }

	[Address(RVA = "0x303FFD0", Offset = "0x303F3D0", Length = "0x14D")]
	[FreeFunction("Texture2DScripting::SetBlockOfPixels32", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000DD3")]
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[Address(RVA = "0x303FF70", Offset = "0x303F370", Length = "0x60")]
	[Token(Token = "0x6000E4D")]
	private static void SetBlockOfPixels32_Injected(IntPtr _unity_self, int x, int y, int blockWidth, int blockHeight, ref ManagedSpanWrapper colors, int miplevel) { }

	[Address(RVA = "0x3040170", Offset = "0x303F570", Length = "0x86")]
	[Token(Token = "0x6000DA2")]
	private void SetIgnoreMipmapLimitAndReload(bool value) { }

	[Address(RVA = "0x3040120", Offset = "0x303F520", Length = "0x42")]
	[Token(Token = "0x6000E1E")]
	private static void SetIgnoreMipmapLimitAndReload_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3040560", Offset = "0x303F960", Length = "0xE8")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000DF4")]
	public void SetPixel(int x, int y, Color color) { }

	[Address(RVA = "0x3040650", Offset = "0x303FA50", Length = "0xEA")]
	[Token(Token = "0x6000DF5")]
	public void SetPixel(int x, int y, Color color, int mipLevel) { }

	[Address(RVA = "0x944020", Offset = "0x943420", Length = "0x1DD")]
	[Token(Token = "0x6000E02")]
	public void SetPixelData(NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0) { }

	[Address(RVA = "0x943E00", Offset = "0x943200", Length = "0x212")]
	[Token(Token = "0x6000E01")]
	public void SetPixelData(T[] data, int mipLevel, int sourceDataStartIndex = 0) { }

	[Address(RVA = "0x3040390", Offset = "0x303F790", Length = "0xA7")]
	[FreeFunction(Name = "Texture2DScripting::SetPixelData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000DBD")]
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[Address(RVA = "0x3040320", Offset = "0x303F720", Length = "0x62")]
	[Token(Token = "0x6000E37")]
	private static bool SetPixelDataImpl_Injected(IntPtr _unity_self, IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex) { }

	[Address(RVA = "0x3040270", Offset = "0x303F670", Length = "0xA7")]
	[FreeFunction(Name = "Texture2DScripting::SetPixelDataArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000DBC")]
	private bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[Address(RVA = "0x3040200", Offset = "0x303F600", Length = "0x62")]
	[Token(Token = "0x6000E36")]
	private static bool SetPixelDataImplArray_Injected(IntPtr _unity_self, Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex) { }

	[Address(RVA = "0x30404A0", Offset = "0x303F8A0", Length = "0xB9")]
	[NativeName("SetPixel")]
	[Token(Token = "0x6000DB3")]
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	[Address(RVA = "0x3040440", Offset = "0x303F840", Length = "0x60")]
	[Token(Token = "0x6000E2D")]
	private static void SetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, in Color color) { }

	[Address(RVA = "0x3040B60", Offset = "0x303FF60", Length = "0x18A")]
	[Token(Token = "0x6000DF6")]
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	[Address(RVA = "0x3040DA0", Offset = "0x30401A0", Length = "0xA6")]
	[Token(Token = "0x6000DF8")]
	public void SetPixels(Color[] colors, int miplevel) { }

	[Address(RVA = "0x3040CF0", Offset = "0x30400F0", Length = "0x75")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000DF9")]
	public void SetPixels(Color[] colors) { }

	[Address(RVA = "0x3040D70", Offset = "0x3040170", Length = "0x2B")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000DF7")]
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	[Address(RVA = "0x303FE50", Offset = "0x303F250", Length = "0x114")]
	[Token(Token = "0x6000E11")]
	public void SetPixels32(Color32[] colors, int miplevel) { }

	[Address(RVA = "0x3040740", Offset = "0x303FB40", Length = "0x107")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000E12")]
	public void SetPixels32(Color32[] colors) { }

	[Address(RVA = "0x3040850", Offset = "0x303FC50", Length = "0x14A")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000E14")]
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	[Address(RVA = "0x303FFD0", Offset = "0x303F3D0", Length = "0x14D")]
	[Token(Token = "0x6000E13")]
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[Address(RVA = "0x3040A00", Offset = "0x303FE00", Length = "0x158")]
	[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000DB9")]
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[Address(RVA = "0x30409A0", Offset = "0x303FDA0", Length = "0x60")]
	[Token(Token = "0x6000E33")]
	private static void SetPixelsImpl_Injected(IntPtr _unity_self, int x, int y, int w, int h, ref ManagedSpanWrapper pixel, int miplevel, int frame) { }

	[Address(RVA = "0x3040EA0", Offset = "0x30402A0", Length = "0x85")]
	[FreeFunction("Texture2DScripting::UpdateExternalTexture", HasExplicitThis = True)]
	[Token(Token = "0x6000DD1")]
	public void UpdateExternalTexture(IntPtr nativeTex) { }

	[Address(RVA = "0x3040E50", Offset = "0x3040250", Length = "0x42")]
	[Token(Token = "0x6000E4B")]
	private static void UpdateExternalTexture_Injected(IntPtr _unity_self, IntPtr nativeTex) { }

	[Address(RVA = "0x3040F30", Offset = "0x3040330", Length = "0x125")]
	[Token(Token = "0x6000DE0")]
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	[Address(RVA = "0x3041060", Offset = "0x3040460", Length = "0xD6")]
	[Token(Token = "0x6000DDF")]
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

}

