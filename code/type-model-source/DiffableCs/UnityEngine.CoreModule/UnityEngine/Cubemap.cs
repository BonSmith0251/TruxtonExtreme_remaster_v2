namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
[Token(Token = "0x2000137")]
public sealed class Cubemap : Texture
{

	[Token(Token = "0x17000239")]
	public int desiredMipmapLevel
	{
		[Address(RVA = "0x301F970", Offset = "0x301ED70", Length = "0x76")]
		[FreeFunction(Name = "GetTextureStreamingManager().GetDesiredMipmapLevel", HasExplicitThis = True)]
		[Token(Token = "0x6000E70")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000232")]
	public TextureFormat format
	{
		[Address(RVA = "0x301FA30", Offset = "0x301EE30", Length = "0x76")]
		[NativeName("GetTextureFormat")]
		[Token(Token = "0x6000E55")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000234")]
	internal bool isPreProcessed
	{
		[Address(RVA = "0x301FAF0", Offset = "0x301EEF0", Length = "0x76")]
		[Token(Token = "0x6000E69")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x17000233")]
	public virtual bool isReadable
	{
		[Address(RVA = "0x301FBB0", Offset = "0x301EFB0", Length = "0x76")]
		[Token(Token = "0x6000E5A")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000238")]
	internal bool loadAllMips
	{
		[Address(RVA = "0x301FC70", Offset = "0x301F070", Length = "0x76")]
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadAllMips", HasExplicitThis = True)]
		[Token(Token = "0x6000E6E")]
		internal get { } //Length: 118
		[Address(RVA = "0x3020100", Offset = "0x301F500", Length = "0x86")]
		[FreeFunction(Name = "GetTextureStreamingManager().SetLoadAllMips", HasExplicitThis = True)]
		[Token(Token = "0x6000E6F")]
		internal set { } //Length: 134
	}

	[Token(Token = "0x1700023B")]
	public int loadedMipmapLevel
	{
		[Address(RVA = "0x301FD30", Offset = "0x301F130", Length = "0x76")]
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadedMipmapLevel", HasExplicitThis = True)]
		[Token(Token = "0x6000E72")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700023A")]
	public int loadingMipmapLevel
	{
		[Address(RVA = "0x301FDF0", Offset = "0x301F1F0", Length = "0x76")]
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadingMipmapLevel", HasExplicitThis = True)]
		[Token(Token = "0x6000E71")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000237")]
	public int requestedMipmapLevel
	{
		[Address(RVA = "0x301FEB0", Offset = "0x301F2B0", Length = "0x76")]
		[FreeFunction(Name = "GetTextureStreamingManager().GetRequestedMipmapLevel", HasExplicitThis = True)]
		[Token(Token = "0x6000E6C")]
		 get { } //Length: 118
		[Address(RVA = "0x30201D0", Offset = "0x301F5D0", Length = "0x83")]
		[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = True)]
		[Token(Token = "0x6000E6D")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000235")]
	public bool streamingMipmaps
	{
		[Address(RVA = "0x3020030", Offset = "0x301F430", Length = "0x76")]
		[Token(Token = "0x6000E6A")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000236")]
	public int streamingMipmapsPriority
	{
		[Address(RVA = "0x301FF70", Offset = "0x301F370", Length = "0x76")]
		[Token(Token = "0x6000E6B")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x301F680", Offset = "0x301EA80", Length = "0x24")]
	[Token(Token = "0x6000E7F")]
	public Cubemap(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	[Address(RVA = "0x301F350", Offset = "0x301E750", Length = "0x25D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000E7A")]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x301F6B0", Offset = "0x301EAB0", Length = "0x279")]
	[Token(Token = "0x6000E7B")]
	internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	[Address(RVA = "0x301F5D0", Offset = "0x301E9D0", Length = "0xA3")]
	[Token(Token = "0x6000E7C")]
	public Cubemap(int width, TextureFormat textureFormat, bool mipChain) { }

	[Address(RVA = "0x301F110", Offset = "0x301E510", Length = "0xA8")]
	[Token(Token = "0x6000E7D")]
	public Cubemap(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	[Address(RVA = "0x301F5B0", Offset = "0x301E9B0", Length = "0x1E")]
	[Token(Token = "0x6000E7E")]
	public Cubemap(int width, TextureFormat format, int mipCount) { }

	[Address(RVA = "0x301F2B0", Offset = "0x301E6B0", Length = "0x95")]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x6000E79")]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x301F260", Offset = "0x301E660", Length = "0x49")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000E78")]
	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x301F1C0", Offset = "0x301E5C0", Length = "0x9E")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000E77")]
	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x301D260", Offset = "0x301C660", Length = "0xCD")]
	[Token(Token = "0x6000E88")]
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x301D250", Offset = "0x301C650", Length = "0xD")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000E8A")]
	public void Apply() { }

	[Address(RVA = "0x301D330", Offset = "0x301C730", Length = "0xB")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000E89")]
	public void Apply(bool updateMipmaps) { }

	[Address(RVA = "0x301D1B0", Offset = "0x301C5B0", Length = "0x98")]
	[FreeFunction(Name = "CubemapScripting::Apply", HasExplicitThis = True)]
	[Token(Token = "0x6000E58")]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x301D150", Offset = "0x301C550", Length = "0x55")]
	[Token(Token = "0x6000E90")]
	private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x301D380", Offset = "0x301C780", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().ClearRequestedMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000E73")]
	public void ClearRequestedMipmapLevel() { }

	[Address(RVA = "0x301D340", Offset = "0x301C740", Length = "0x33")]
	[Token(Token = "0x6000EA8")]
	private static void ClearRequestedMipmapLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301DA60", Offset = "0x301CE60", Length = "0x159")]
	[Token(Token = "0x6000E8C")]
	public void CopyPixels(Texture src, int srcElement, int srcMip, CubemapFace dstFace, int dstMip) { }

	[Address(RVA = "0x301D7C0", Offset = "0x301CBC0", Length = "0x137")]
	[Token(Token = "0x6000E8B")]
	public void CopyPixels(Texture src) { }

	[Address(RVA = "0x301D900", Offset = "0x301CD00", Length = "0x15D")]
	[Token(Token = "0x6000E8D")]
	public void CopyPixels(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, CubemapFace dstFace, int dstMip, int dstX, int dstY) { }

	[Address(RVA = "0x301D450", Offset = "0x301C850", Length = "0xBA")]
	[FreeFunction(Name = "CubemapScripting::CopyPixels", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000E65")]
	private void CopyPixels_Full(Texture src) { }

	[Address(RVA = "0x301D400", Offset = "0x301C800", Length = "0x42")]
	[Token(Token = "0x6000E9A")]
	private static void CopyPixels_Full_Injected(IntPtr _unity_self, IntPtr src) { }

	[Address(RVA = "0x301D580", Offset = "0x301C980", Length = "0xE4")]
	[FreeFunction(Name = "CubemapScripting::CopyPixels", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000E67")]
	private void CopyPixels_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstFace, int dstMip, int dstX, int dstY) { }

	[Address(RVA = "0x301D510", Offset = "0x301C910", Length = "0x68")]
	[Token(Token = "0x6000E9C")]
	private static void CopyPixels_Region_Injected(IntPtr _unity_self, IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstFace, int dstMip, int dstX, int dstY) { }

	[Address(RVA = "0x301D6E0", Offset = "0x301CAE0", Length = "0xD2")]
	[FreeFunction(Name = "CubemapScripting::CopyPixels", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000E66")]
	private void CopyPixels_Slice(Texture src, int srcElement, int srcMip, int dstFace, int dstMip) { }

	[Address(RVA = "0x301D670", Offset = "0x301CA70", Length = "0x62")]
	[Token(Token = "0x6000E9B")]
	private static void CopyPixels_Slice_Injected(IntPtr _unity_self, IntPtr src, int srcElement, int srcMip, int dstFace, int dstMip) { }

	[Address(RVA = "0x301DBC0", Offset = "0x301CFC0", Length = "0x123")]
	[Token(Token = "0x6000E80")]
	public static Cubemap CreateExternalTexture(int width, TextureFormat format, bool mipmap, IntPtr nativeTex) { }

	[Address(RVA = "0x301F970", Offset = "0x301ED70", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().GetDesiredMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000E70")]
	public int get_desiredMipmapLevel() { }

	[Address(RVA = "0x301F930", Offset = "0x301ED30", Length = "0x33")]
	[Token(Token = "0x6000EA5")]
	private static int get_desiredMipmapLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301FA30", Offset = "0x301EE30", Length = "0x76")]
	[NativeName("GetTextureFormat")]
	[Token(Token = "0x6000E55")]
	public TextureFormat get_format() { }

	[Address(RVA = "0x301F9F0", Offset = "0x301EDF0", Length = "0x33")]
	[Token(Token = "0x6000E8F")]
	private static TextureFormat get_format_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301FAF0", Offset = "0x301EEF0", Length = "0x76")]
	[Token(Token = "0x6000E69")]
	internal bool get_isPreProcessed() { }

	[Address(RVA = "0x301FAB0", Offset = "0x301EEB0", Length = "0x33")]
	[Token(Token = "0x6000E9E")]
	private static bool get_isPreProcessed_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301FBB0", Offset = "0x301EFB0", Length = "0x76")]
	[Token(Token = "0x6000E5A")]
	public virtual bool get_isReadable() { }

	[Address(RVA = "0x301FB70", Offset = "0x301EF70", Length = "0x33")]
	[Token(Token = "0x6000E92")]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301FC70", Offset = "0x301F070", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadAllMips", HasExplicitThis = True)]
	[Token(Token = "0x6000E6E")]
	internal bool get_loadAllMips() { }

	[Address(RVA = "0x301FC30", Offset = "0x301F030", Length = "0x33")]
	[Token(Token = "0x6000EA3")]
	private static bool get_loadAllMips_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301FD30", Offset = "0x301F130", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadedMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000E72")]
	public int get_loadedMipmapLevel() { }

	[Address(RVA = "0x301FCF0", Offset = "0x301F0F0", Length = "0x33")]
	[Token(Token = "0x6000EA7")]
	private static int get_loadedMipmapLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301FDF0", Offset = "0x301F1F0", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadingMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000E71")]
	public int get_loadingMipmapLevel() { }

	[Address(RVA = "0x301FDB0", Offset = "0x301F1B0", Length = "0x33")]
	[Token(Token = "0x6000EA6")]
	private static int get_loadingMipmapLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301FEB0", Offset = "0x301F2B0", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().GetRequestedMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000E6C")]
	public int get_requestedMipmapLevel() { }

	[Address(RVA = "0x301FE70", Offset = "0x301F270", Length = "0x33")]
	[Token(Token = "0x6000EA1")]
	private static int get_requestedMipmapLevel_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3020030", Offset = "0x301F430", Length = "0x76")]
	[Token(Token = "0x6000E6A")]
	public bool get_streamingMipmaps() { }

	[Address(RVA = "0x301FFF0", Offset = "0x301F3F0", Length = "0x33")]
	[Token(Token = "0x6000E9F")]
	private static bool get_streamingMipmaps_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301FF70", Offset = "0x301F370", Length = "0x76")]
	[Token(Token = "0x6000E6B")]
	public int get_streamingMipmapsPriority() { }

	[Address(RVA = "0x301FF30", Offset = "0x301F330", Length = "0x33")]
	[Token(Token = "0x6000EA0")]
	private static int get_streamingMipmapsPriority_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301DE10", Offset = "0x301D210", Length = "0x110")]
	[Token(Token = "0x6000E87")]
	public Color GetPixel(CubemapFace face, int x, int y, int mip) { }

	[Address(RVA = "0x301DF30", Offset = "0x301D330", Length = "0x10E")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000E86")]
	public Color GetPixel(CubemapFace face, int x, int y) { }

	[Address(RVA = "0x7B9090", Offset = "0x7B8490", Length = "0x3CE")]
	[Token(Token = "0x6000E83")]
	public NativeArray<T> GetPixelData(int mipLevel, CubemapFace face) { }

	[Address(RVA = "0x301DD50", Offset = "0x301D150", Length = "0xBF")]
	[NativeName("GetPixel")]
	[Token(Token = "0x6000E5C")]
	private Color GetPixelImpl(int image, int mip, int x, int y) { }

	[Address(RVA = "0x301DCF0", Offset = "0x301D0F0", Length = "0x60")]
	[Token(Token = "0x6000E94")]
	private static void GetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, out Color ret) { }

	[Address(RVA = "0x301E130", Offset = "0x301D530", Length = "0x86")]
	[Token(Token = "0x6000E60")]
	public Color[] GetPixels(CubemapFace face) { }

	[Address(RVA = "0x301E090", Offset = "0x301D490", Length = "0x93")]
	[FreeFunction(Name = "CubemapScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000E5F")]
	public Color[] GetPixels(CubemapFace face, int miplevel) { }

	[Address(RVA = "0x301E040", Offset = "0x301D440", Length = "0x50")]
	[Token(Token = "0x6000E96")]
	private static Color[] GetPixels_Injected(IntPtr _unity_self, CubemapFace face, int miplevel) { }

	[Address(RVA = "0x301E200", Offset = "0x301D600", Length = "0x83")]
	[Token(Token = "0x6000E68")]
	private IntPtr GetWritableImageData(int frame) { }

	[Address(RVA = "0x301E1C0", Offset = "0x301D5C0", Length = "0x40")]
	[Token(Token = "0x6000E9D")]
	private static IntPtr GetWritableImageData_Injected(IntPtr _unity_self, int frame) { }

	[Address(RVA = "0x301E2F0", Offset = "0x301D6F0", Length = "0xC9")]
	[Token(Token = "0x6000E57")]
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[Address(RVA = "0x301E290", Offset = "0x301D690", Length = "0x60")]
	[FreeFunction("CubemapScripting::Create")]
	[Token(Token = "0x6000E56")]
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[Address(RVA = "0x301E400", Offset = "0x301D800", Length = "0x76")]
	[FreeFunction(Name = "GetTextureStreamingManager().IsRequestedMipmapLevelLoaded", HasExplicitThis = True)]
	[Token(Token = "0x6000E74")]
	public bool IsRequestedMipmapLevelLoaded() { }

	[Address(RVA = "0x301E3C0", Offset = "0x301D7C0", Length = "0x33")]
	[Token(Token = "0x6000EA9")]
	private static bool IsRequestedMipmapLevelLoaded_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3020100", Offset = "0x301F500", Length = "0x86")]
	[FreeFunction(Name = "GetTextureStreamingManager().SetLoadAllMips", HasExplicitThis = True)]
	[Token(Token = "0x6000E6F")]
	internal void set_loadAllMips(bool value) { }

	[Address(RVA = "0x30200B0", Offset = "0x301F4B0", Length = "0x42")]
	[Token(Token = "0x6000EA4")]
	private static void set_loadAllMips_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x30201D0", Offset = "0x301F5D0", Length = "0x83")]
	[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = True)]
	[Token(Token = "0x6000E6D")]
	public void set_requestedMipmapLevel(int value) { }

	[Address(RVA = "0x3020190", Offset = "0x301F590", Length = "0x40")]
	[Token(Token = "0x6000EA2")]
	private static void set_requestedMipmapLevel_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x301E8E0", Offset = "0x301DCE0", Length = "0xFD")]
	[Token(Token = "0x6000E85")]
	public void SetPixel(CubemapFace face, int x, int y, Color color, int mip) { }

	[Address(RVA = "0x301E7E0", Offset = "0x301DBE0", Length = "0xFB")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000E84")]
	public void SetPixel(CubemapFace face, int x, int y, Color color) { }

	[Address(RVA = "0x7B9460", Offset = "0x7B8860", Length = "0x21E")]
	[Token(Token = "0x6000E81")]
	public void SetPixelData(T[] data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0) { }

	[Address(RVA = "0x7B9680", Offset = "0x7B8A80", Length = "0x1F2")]
	[Token(Token = "0x6000E82")]
	public void SetPixelData(NativeArray<T> data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0) { }

	[Address(RVA = "0x301E610", Offset = "0x301DA10", Length = "0xA7")]
	[FreeFunction(Name = "CubemapScripting::SetPixelData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000E63")]
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[Address(RVA = "0x301E5A0", Offset = "0x301D9A0", Length = "0x62")]
	[Token(Token = "0x6000E99")]
	private static bool SetPixelDataImpl_Injected(IntPtr _unity_self, IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex) { }

	[Address(RVA = "0x301E4F0", Offset = "0x301D8F0", Length = "0xA7")]
	[FreeFunction(Name = "CubemapScripting::SetPixelDataArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000E62")]
	private bool SetPixelDataImplArray(Array data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[Address(RVA = "0x301E480", Offset = "0x301D880", Length = "0x62")]
	[Token(Token = "0x6000E98")]
	private static bool SetPixelDataImplArray_Injected(IntPtr _unity_self, Array data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex) { }

	[Address(RVA = "0x301E720", Offset = "0x301DB20", Length = "0xB9")]
	[NativeName("SetPixel")]
	[Token(Token = "0x6000E5B")]
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	[Address(RVA = "0x301E6C0", Offset = "0x301DAC0", Length = "0x60")]
	[Token(Token = "0x6000E93")]
	private static void SetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, in Color color) { }

	[Address(RVA = "0x301EB80", Offset = "0x301DF80", Length = "0x117")]
	[Token(Token = "0x6000E64")]
	public void SetPixels(Color[] colors, CubemapFace face) { }

	[Address(RVA = "0x301EA50", Offset = "0x301DE50", Length = "0x126")]
	[FreeFunction(Name = "CubemapScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000E61")]
	public void SetPixels(Color[] colors, CubemapFace face, int miplevel) { }

	[Address(RVA = "0x301E9E0", Offset = "0x301DDE0", Length = "0x62")]
	[Token(Token = "0x6000E97")]
	private static void SetPixels_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, CubemapFace face, int miplevel) { }

	[Address(RVA = "0x301ED60", Offset = "0x301E160", Length = "0x83")]
	[NativeName("FixupEdges")]
	[Token(Token = "0x6000E5D")]
	public void SmoothEdges(int smoothRegionWidthInPixels) { }

	[Address(RVA = "0x301ECE0", Offset = "0x301E0E0", Length = "0x7B")]
	[Token(Token = "0x6000E5E")]
	public void SmoothEdges() { }

	[Address(RVA = "0x301ECA0", Offset = "0x301E0A0", Length = "0x40")]
	[Token(Token = "0x6000E95")]
	private static void SmoothEdges_Injected(IntPtr _unity_self, int smoothRegionWidthInPixels) { }

	[Address(RVA = "0x301EE40", Offset = "0x301E240", Length = "0x85")]
	[FreeFunction("CubemapScripting::UpdateExternalTexture", HasExplicitThis = True)]
	[Token(Token = "0x6000E59")]
	public void UpdateExternalTexture(IntPtr nativeTexture) { }

	[Address(RVA = "0x301EDF0", Offset = "0x301E1F0", Length = "0x42")]
	[Token(Token = "0x6000E91")]
	private static void UpdateExternalTexture_Injected(IntPtr _unity_self, IntPtr nativeTexture) { }

	[Address(RVA = "0x301EF90", Offset = "0x301E390", Length = "0x114")]
	[Token(Token = "0x6000E76")]
	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	[Address(RVA = "0x301EED0", Offset = "0x301E2D0", Length = "0xBF")]
	[Token(Token = "0x6000E75")]
	internal bool ValidateFormat(TextureFormat format, int width) { }

	[Address(RVA = "0x301F0B0", Offset = "0x301E4B0", Length = "0x60")]
	[Token(Token = "0x6000E8E")]
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

