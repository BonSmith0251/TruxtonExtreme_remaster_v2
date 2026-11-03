namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Texture3D.h")]
[Token(Token = "0x2000138")]
public sealed class Texture3D : Texture
{

	[Token(Token = "0x1700023C")]
	public virtual bool isReadable
	{
		[Address(RVA = "0x3044310", Offset = "0x3043710", Length = "0x76")]
		[Token(Token = "0x6000EAA")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x3043E10", Offset = "0x3043210", Length = "0x1F2")]
	[Token(Token = "0x6000EB7")]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	[Address(RVA = "0x3044180", Offset = "0x3043580", Length = "0xC3")]
	[Token(Token = "0x6000EBA")]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	[Address(RVA = "0x30440C0", Offset = "0x30434C0", Length = "0xBC")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000EB1")]
	public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x3043B40", Offset = "0x3042F40", Length = "0x5E")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000EB2")]
	public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x3044010", Offset = "0x3043410", Length = "0xA5")]
	[ExcludeFromDocs]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EB3")]
	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x3043BA0", Offset = "0x3042FA0", Length = "0x1AC")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000EB4")]
	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x3044290", Offset = "0x3043690", Length = "0x34")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000EB5")]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	[Address(RVA = "0x3044250", Offset = "0x3043650", Length = "0x3F")]
	[Token(Token = "0x6000EB6")]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	[Address(RVA = "0x3043D50", Offset = "0x3043150", Length = "0xC0")]
	[Token(Token = "0x6000EB9")]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	[Address(RVA = "0x3043A80", Offset = "0x3042E80", Length = "0xB8")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000EB8")]
	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	[Address(RVA = "0x3043380", Offset = "0x3042780", Length = "0xD")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000EBD")]
	public void Apply() { }

	[Address(RVA = "0x3043390", Offset = "0x3042790", Length = "0xB")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000EBC")]
	public void Apply(bool updateMipmaps) { }

	[Address(RVA = "0x30433A0", Offset = "0x30427A0", Length = "0xCD")]
	[Token(Token = "0x6000EBB")]
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x30432E0", Offset = "0x30426E0", Length = "0x98")]
	[FreeFunction(Name = "Texture3DScripting::Apply", HasExplicitThis = True)]
	[Token(Token = "0x6000EAE")]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x3043280", Offset = "0x3042680", Length = "0x55")]
	[Token(Token = "0x6000EC3")]
	private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x3044310", Offset = "0x3043710", Length = "0x76")]
	[Token(Token = "0x6000EAA")]
	public virtual bool get_isReadable() { }

	[Address(RVA = "0x30442D0", Offset = "0x30436D0", Length = "0x33")]
	[Token(Token = "0x6000EC1")]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30434B0", Offset = "0x30428B0", Length = "0x76")]
	[Token(Token = "0x6000EB0")]
	private IntPtr GetImageData() { }

	[Address(RVA = "0x3043470", Offset = "0x3042870", Length = "0x33")]
	[Token(Token = "0x6000EC5")]
	private static IntPtr GetImageData_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x944A60", Offset = "0x943E60", Length = "0x2BF")]
	[Token(Token = "0x6000EBF")]
	public NativeArray<T> GetPixelData(int mipLevel) { }

	[Address(RVA = "0x3043590", Offset = "0x3042990", Length = "0xE5")]
	[Token(Token = "0x6000EAD")]
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[Address(RVA = "0x3043530", Offset = "0x3042930", Length = "0x60")]
	[FreeFunction("Texture3DScripting::Create")]
	[Token(Token = "0x6000EAC")]
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[Address(RVA = "0x30437A0", Offset = "0x3042BA0", Length = "0xFC")]
	[Token(Token = "0x6000EBE")]
	public void SetPixel(int x, int y, int z, Color color, int mipLevel) { }

	[Address(RVA = "0x30436E0", Offset = "0x3042AE0", Length = "0xB9")]
	[NativeName("SetPixel")]
	[Token(Token = "0x6000EAB")]
	private void SetPixelImpl(int mip, int x, int y, int z, Color color) { }

	[Address(RVA = "0x3043680", Offset = "0x3042A80", Length = "0x60")]
	[Token(Token = "0x6000EC2")]
	private static void SetPixelImpl_Injected(IntPtr _unity_self, int mip, int x, int y, int z, in Color color) { }

	[Address(RVA = "0x3043900", Offset = "0x3042D00", Length = "0x114")]
	[FreeFunction(Name = "Texture3DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000EAF")]
	public void SetPixels(Color[] colors, int miplevel) { }

	[Address(RVA = "0x30438A0", Offset = "0x3042CA0", Length = "0x52")]
	[Token(Token = "0x6000EC4")]
	private static void SetPixels_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, int miplevel) { }

	[Address(RVA = "0x3043A20", Offset = "0x3042E20", Length = "0x60")]
	[Token(Token = "0x6000EC0")]
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

