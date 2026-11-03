namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Texture.h")]
[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
[Token(Token = "0x2000135")]
[UsedByNativeCode]
public class Texture : object
{
	[Token(Token = "0x40003FE")]
	public static readonly int GenerateAllMips; //Field offset: 0x0

	[Token(Token = "0x1700021A")]
	internal ColorSpace activeTextureColorSpace
	{
		[Address(RVA = "0x3044FF0", Offset = "0x30443F0", Length = "0xAC")]
		[Token(Token = "0x6000D7B")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"})]
		internal get { } //Length: 172
	}

	[Token(Token = "0x17000216")]
	public int anisoLevel
	{
		[Address(RVA = "0x30450E0", Offset = "0x30444E0", Length = "0x97")]
		[Token(Token = "0x6000D73")]
		 get { } //Length: 151
		[Address(RVA = "0x3045880", Offset = "0x3044C80", Length = "0xA4")]
		[Token(Token = "0x6000D74")]
		 set { } //Length: 164
	}

	[Token(Token = "0x1700020F")]
	public override TextureDimension dimension
	{
		[Address(RVA = "0x3044680", Offset = "0x3043A80", Length = "0x97")]
		[Token(Token = "0x6000D69")]
		 get { } //Length: 151
		[Address(RVA = "0x3045930", Offset = "0x3044D30", Length = "0x3E")]
		[Token(Token = "0x6000D6A")]
		 set { } //Length: 62
	}

	[Token(Token = "0x17000215")]
	public FilterMode filterMode
	{
		[Address(RVA = "0x30451C0", Offset = "0x30445C0", Length = "0x97")]
		[Token(Token = "0x6000D71")]
		 get { } //Length: 151
		[Address(RVA = "0x30459B0", Offset = "0x3044DB0", Length = "0xA4")]
		[Token(Token = "0x6000D72")]
		 set { } //Length: 164
	}

	[Token(Token = "0x1700020C")]
	public override GraphicsFormat graphicsFormat
	{
		[Address(RVA = "0x3045260", Offset = "0x3044660", Length = "0x49")]
		[Token(Token = "0x6000D61")]
		 get { } //Length: 73
	}

	[Token(Token = "0x1700020E")]
	public override int height
	{
		[Address(RVA = "0x30444C0", Offset = "0x30438C0", Length = "0x97")]
		[Token(Token = "0x6000D67")]
		 get { } //Length: 151
		[Address(RVA = "0x3045A60", Offset = "0x3044E60", Length = "0x3E")]
		[Token(Token = "0x6000D68")]
		 set { } //Length: 62
	}

	[Token(Token = "0x17000210")]
	public override bool isReadable
	{
		[Address(RVA = "0x30452F0", Offset = "0x30446F0", Length = "0x97")]
		[Token(Token = "0x6000D6B")]
		 get { } //Length: 151
	}

	[Token(Token = "0x17000217")]
	public float mipMapBias
	{
		[Address(RVA = "0x30453D0", Offset = "0x30447D0", Length = "0x97")]
		[Token(Token = "0x6000D75")]
		 get { } //Length: 151
		[Address(RVA = "0x3045AF0", Offset = "0x3044EF0", Length = "0xA7")]
		[Token(Token = "0x6000D76")]
		 set { } //Length: 167
	}

	[Token(Token = "0x1700020B")]
	public int mipmapCount
	{
		[Address(RVA = "0x30454B0", Offset = "0x30448B0", Length = "0x97")]
		[NativeName("GetMipmapCount")]
		[Token(Token = "0x6000D60")]
		 get { } //Length: 151
	}

	[Token(Token = "0x1700021B")]
	public static bool streamingTextureDiscardUnusedMips
	{
		[Address(RVA = "0x3045550", Offset = "0x3044950", Length = "0x2A")]
		[FreeFunction(Name = "GetTextureStreamingManager().GetDiscardUnusedMips")]
		[Token(Token = "0x6000D7E")]
		 get { } //Length: 42
		[Address(RVA = "0x3045BA0", Offset = "0x3044FA0", Length = "0x33")]
		[FreeFunction(Name = "GetTextureStreamingManager().SetDiscardUnusedMips")]
		[Token(Token = "0x6000D7F")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000218")]
	public Vector2 texelSize
	{
		[Address(RVA = "0x30455D0", Offset = "0x30449D0", Length = "0xA8")]
		[NativeName("GetTexelSize")]
		[Token(Token = "0x6000D77")]
		 get { } //Length: 168
	}

	[Token(Token = "0x17000219")]
	public uint updateCount
	{
		[Address(RVA = "0x30456C0", Offset = "0x3044AC0", Length = "0x97")]
		[Token(Token = "0x6000D78")]
		 get { } //Length: 151
	}

	[Token(Token = "0x1700020D")]
	public override int width
	{
		[Address(RVA = "0x30445A0", Offset = "0x30439A0", Length = "0x97")]
		[Token(Token = "0x6000D65")]
		 get { } //Length: 151
		[Address(RVA = "0x3045BE0", Offset = "0x3044FE0", Length = "0x3E")]
		[Token(Token = "0x6000D66")]
		 set { } //Length: 62
	}

	[Token(Token = "0x17000211")]
	public TextureWrapMode wrapMode
	{
		[Address(RVA = "0x30457A0", Offset = "0x3044BA0", Length = "0x97")]
		[NativeName("GetWrapModeU")]
		[Token(Token = "0x6000D6C")]
		 get { } //Length: 151
		[Address(RVA = "0x3045F30", Offset = "0x3045330", Length = "0xF8")]
		[Token(Token = "0x6000D6D")]
		 set { } //Length: 248
	}

	[Token(Token = "0x17000212")]
	public TextureWrapMode wrapModeU
	{
		[Address(RVA = "0x3045C60", Offset = "0x3045060", Length = "0xA4")]
		[Token(Token = "0x6000D6E")]
		 set { } //Length: 164
	}

	[Token(Token = "0x17000213")]
	public TextureWrapMode wrapModeV
	{
		[Address(RVA = "0x3045D50", Offset = "0x3045150", Length = "0xA4")]
		[Token(Token = "0x6000D6F")]
		 set { } //Length: 164
	}

	[Token(Token = "0x17000214")]
	public TextureWrapMode wrapModeW
	{
		[Address(RVA = "0x3045E40", Offset = "0x3045240", Length = "0xA4")]
		[Token(Token = "0x6000D70")]
		 set { } //Length: 164
	}

	[Address(RVA = "0x3044F60", Offset = "0x3044360", Length = "0x39")]
	[Token(Token = "0x6000D89")]
	private static Texture() { }

	[Address(RVA = "0x3044FA0", Offset = "0x30443A0", Length = "0x49")]
	[Token(Token = "0x6000D5F")]
	protected Texture() { }

	[Address(RVA = "0x3044390", Offset = "0x3043790", Length = "0x58")]
	[Token(Token = "0x6000D88")]
	internal UnityException CreateNativeArrayLengthOverflowException() { }

	[Address(RVA = "0x30443F0", Offset = "0x30437F0", Length = "0x8A")]
	[Token(Token = "0x6000D86")]
	internal UnityException CreateNonReadableException(Texture t) { }

	[Address(RVA = "0x3044FF0", Offset = "0x30443F0", Length = "0xAC")]
	[Token(Token = "0x6000D7B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"})]
	internal ColorSpace get_activeTextureColorSpace() { }

	[Address(RVA = "0x30450E0", Offset = "0x30444E0", Length = "0x97")]
	[Token(Token = "0x6000D73")]
	public int get_anisoLevel() { }

	[Address(RVA = "0x30450A0", Offset = "0x30444A0", Length = "0x33")]
	[Token(Token = "0x6000D96")]
	private static int get_anisoLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3044680", Offset = "0x3043A80", Length = "0x97")]
	[Token(Token = "0x6000D69")]
	public override TextureDimension get_dimension() { }

	[Address(RVA = "0x30451C0", Offset = "0x30445C0", Length = "0x97")]
	[Token(Token = "0x6000D71")]
	public FilterMode get_filterMode() { }

	[Address(RVA = "0x3045180", Offset = "0x3044580", Length = "0x33")]
	[Token(Token = "0x6000D94")]
	private static FilterMode get_filterMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3045260", Offset = "0x3044660", Length = "0x49")]
	[Token(Token = "0x6000D61")]
	public override GraphicsFormat get_graphicsFormat() { }

	[Address(RVA = "0x30444C0", Offset = "0x30438C0", Length = "0x97")]
	[Token(Token = "0x6000D67")]
	public override int get_height() { }

	[Address(RVA = "0x30452F0", Offset = "0x30446F0", Length = "0x97")]
	[Token(Token = "0x6000D6B")]
	public override bool get_isReadable() { }

	[Address(RVA = "0x30452B0", Offset = "0x30446B0", Length = "0x33")]
	[Token(Token = "0x6000D8E")]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30453D0", Offset = "0x30447D0", Length = "0x97")]
	[Token(Token = "0x6000D75")]
	public float get_mipMapBias() { }

	[Address(RVA = "0x3045390", Offset = "0x3044790", Length = "0x33")]
	[Token(Token = "0x6000D98")]
	private static float get_mipMapBias_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30454B0", Offset = "0x30448B0", Length = "0x97")]
	[NativeName("GetMipmapCount")]
	[Token(Token = "0x6000D60")]
	public int get_mipmapCount() { }

	[Address(RVA = "0x3045470", Offset = "0x3044870", Length = "0x33")]
	[Token(Token = "0x6000D8A")]
	private static int get_mipmapCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3045550", Offset = "0x3044950", Length = "0x2A")]
	[FreeFunction(Name = "GetTextureStreamingManager().GetDiscardUnusedMips")]
	[Token(Token = "0x6000D7E")]
	public static bool get_streamingTextureDiscardUnusedMips() { }

	[Address(RVA = "0x30455D0", Offset = "0x30449D0", Length = "0xA8")]
	[NativeName("GetTexelSize")]
	[Token(Token = "0x6000D77")]
	public Vector2 get_texelSize() { }

	[Address(RVA = "0x3045580", Offset = "0x3044980", Length = "0x42")]
	[Token(Token = "0x6000D9A")]
	private static void get_texelSize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x30456C0", Offset = "0x3044AC0", Length = "0x97")]
	[Token(Token = "0x6000D78")]
	public uint get_updateCount() { }

	[Address(RVA = "0x3045680", Offset = "0x3044A80", Length = "0x33")]
	[Token(Token = "0x6000D9B")]
	private static uint get_updateCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30445A0", Offset = "0x30439A0", Length = "0x97")]
	[Token(Token = "0x6000D65")]
	public override int get_width() { }

	[Address(RVA = "0x30457A0", Offset = "0x3044BA0", Length = "0x97")]
	[NativeName("GetWrapModeU")]
	[Token(Token = "0x6000D6C")]
	public TextureWrapMode get_wrapMode() { }

	[Address(RVA = "0x3045760", Offset = "0x3044B60", Length = "0x33")]
	[Token(Token = "0x6000D8F")]
	private static TextureWrapMode get_wrapMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30444C0", Offset = "0x30438C0", Length = "0x97")]
	[ThreadSafe]
	[Token(Token = "0x6000D63")]
	private int GetDataHeight() { }

	[Address(RVA = "0x3044480", Offset = "0x3043880", Length = "0x33")]
	[Token(Token = "0x6000D8C")]
	private static int GetDataHeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30445A0", Offset = "0x30439A0", Length = "0x97")]
	[ThreadSafe]
	[Token(Token = "0x6000D62")]
	private int GetDataWidth() { }

	[Address(RVA = "0x3044560", Offset = "0x3043960", Length = "0x33")]
	[Token(Token = "0x6000D8B")]
	private static int GetDataWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3044680", Offset = "0x3043A80", Length = "0x97")]
	[ThreadSafe]
	[Token(Token = "0x6000D64")]
	private TextureDimension GetDimension() { }

	[Address(RVA = "0x3044640", Offset = "0x3043A40", Length = "0x33")]
	[Token(Token = "0x6000D8D")]
	private static TextureDimension GetDimension_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3044770", Offset = "0x3043B70", Length = "0xB4")]
	[Token(Token = "0x6000D81")]
	internal ulong GetPixelDataOffset(int mipLevel, int element = 0) { }

	[Address(RVA = "0x3044720", Offset = "0x3043B20", Length = "0x50")]
	[Token(Token = "0x6000D9F")]
	private static ulong GetPixelDataOffset_Injected(IntPtr _unity_self, int mipLevel, int element) { }

	[Address(RVA = "0x3044880", Offset = "0x3043C80", Length = "0xB4")]
	[Token(Token = "0x6000D80")]
	internal ulong GetPixelDataSize(int mipLevel, int element = 0) { }

	[Address(RVA = "0x3044830", Offset = "0x3043C30", Length = "0x50")]
	[Token(Token = "0x6000D9E")]
	private static ulong GetPixelDataSize_Injected(IntPtr _unity_self, int mipLevel, int element) { }

	[Address(RVA = "0x3044990", Offset = "0x3043D90", Length = "0x9")]
	[Token(Token = "0x6000D82")]
	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	[Address(RVA = "0x3044940", Offset = "0x3043D40", Length = "0x4B")]
	[Token(Token = "0x6000D83")]
	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	[Address(RVA = "0x30449A0", Offset = "0x3043DA0", Length = "0x8A")]
	[Token(Token = "0x6000D87")]
	internal UnityException IgnoreMipmapLimitCannotBeToggledException(Texture t) { }

	[Address(RVA = "0x3044A70", Offset = "0x3043E70", Length = "0x97")]
	[Token(Token = "0x6000D79")]
	public void IncrementUpdateCount() { }

	[Address(RVA = "0x3044A30", Offset = "0x3043E30", Length = "0x33")]
	[Token(Token = "0x6000D9C")]
	private static void IncrementUpdateCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3044B50", Offset = "0x3043F50", Length = "0x97")]
	[NativeMethod("GetActiveTextureColorSpace")]
	[Token(Token = "0x6000D7A")]
	private int Internal_GetActiveTextureColorSpace() { }

	[Address(RVA = "0x3044B10", Offset = "0x3043F10", Length = "0x33")]
	[Token(Token = "0x6000D9D")]
	private static int Internal_GetActiveTextureColorSpace_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3045880", Offset = "0x3044C80", Length = "0xA4")]
	[Token(Token = "0x6000D74")]
	public void set_anisoLevel(int value) { }

	[Address(RVA = "0x3045840", Offset = "0x3044C40", Length = "0x40")]
	[Token(Token = "0x6000D97")]
	private static void set_anisoLevel_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3045930", Offset = "0x3044D30", Length = "0x3E")]
	[Token(Token = "0x6000D6A")]
	public override void set_dimension(TextureDimension value) { }

	[Address(RVA = "0x30459B0", Offset = "0x3044DB0", Length = "0xA4")]
	[Token(Token = "0x6000D72")]
	public void set_filterMode(FilterMode value) { }

	[Address(RVA = "0x3045970", Offset = "0x3044D70", Length = "0x40")]
	[Token(Token = "0x6000D95")]
	private static void set_filterMode_Injected(IntPtr _unity_self, FilterMode value) { }

	[Address(RVA = "0x3045A60", Offset = "0x3044E60", Length = "0x3E")]
	[Token(Token = "0x6000D68")]
	public override void set_height(int value) { }

	[Address(RVA = "0x3045AF0", Offset = "0x3044EF0", Length = "0xA7")]
	[Token(Token = "0x6000D76")]
	public void set_mipMapBias(float value) { }

	[Address(RVA = "0x3045AA0", Offset = "0x3044EA0", Length = "0x43")]
	[Token(Token = "0x6000D99")]
	private static void set_mipMapBias_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3045BA0", Offset = "0x3044FA0", Length = "0x33")]
	[FreeFunction(Name = "GetTextureStreamingManager().SetDiscardUnusedMips")]
	[Token(Token = "0x6000D7F")]
	public static void set_streamingTextureDiscardUnusedMips(bool value) { }

	[Address(RVA = "0x3045BE0", Offset = "0x3044FE0", Length = "0x3E")]
	[Token(Token = "0x6000D66")]
	public override void set_width(int value) { }

	[Address(RVA = "0x3045F30", Offset = "0x3045330", Length = "0xF8")]
	[Token(Token = "0x6000D6D")]
	public void set_wrapMode(TextureWrapMode value) { }

	[Address(RVA = "0x3045EF0", Offset = "0x30452F0", Length = "0x40")]
	[Token(Token = "0x6000D90")]
	private static void set_wrapMode_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	[Address(RVA = "0x3045C60", Offset = "0x3045060", Length = "0xA4")]
	[Token(Token = "0x6000D6E")]
	public void set_wrapModeU(TextureWrapMode value) { }

	[Address(RVA = "0x3045C20", Offset = "0x3045020", Length = "0x40")]
	[Token(Token = "0x6000D91")]
	private static void set_wrapModeU_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	[Address(RVA = "0x3045D50", Offset = "0x3045150", Length = "0xA4")]
	[Token(Token = "0x6000D6F")]
	public void set_wrapModeV(TextureWrapMode value) { }

	[Address(RVA = "0x3045D10", Offset = "0x3045110", Length = "0x40")]
	[Token(Token = "0x6000D92")]
	private static void set_wrapModeV_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	[Address(RVA = "0x3045E40", Offset = "0x3045240", Length = "0xA4")]
	[Token(Token = "0x6000D70")]
	public void set_wrapModeW(TextureWrapMode value) { }

	[Address(RVA = "0x3045E00", Offset = "0x3045200", Length = "0x40")]
	[Token(Token = "0x6000D93")]
	private static void set_wrapModeW_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	[Address(RVA = "0x3044C30", Offset = "0x3044030", Length = "0x62")]
	[Token(Token = "0x6000D7D")]
	public static void SetStreamingTextureMaterialDebugProperties(int materialTextureSlot) { }

	[Address(RVA = "0x3044BF0", Offset = "0x3043FF0", Length = "0x31")]
	[FreeFunction("GetTextureStreamingManager().SetStreamingTextureMaterialDebugPropertiesWithSlot")]
	[Token(Token = "0x6000D7C")]
	private static void SetStreamingTextureMaterialDebugPropertiesWithSlot(int materialTextureSlot) { }

	[Address(RVA = "0x3044E40", Offset = "0x3044240", Length = "0x117")]
	[Token(Token = "0x6000D85")]
	internal bool ValidateFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

	[Address(RVA = "0x3044CA0", Offset = "0x30440A0", Length = "0x194")]
	[Token(Token = "0x6000D84")]
	internal bool ValidateFormat(TextureFormat format) { }

}

