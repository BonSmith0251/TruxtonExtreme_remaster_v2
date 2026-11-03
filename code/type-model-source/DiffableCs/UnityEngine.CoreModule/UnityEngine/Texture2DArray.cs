namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Texture2DArray.h")]
[Token(Token = "0x2000139")]
public sealed class Texture2DArray : Texture
{

	[Token(Token = "0x1700023D")]
	public static int allSlices
	{
		[Address(RVA = "0x303C830", Offset = "0x303BC30", Length = "0x2A")]
		[NativeName("GetAllTextureLayersIdentifier")]
		[Token(Token = "0x6000EC6")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700023E")]
	public virtual bool isReadable
	{
		[Address(RVA = "0x303C8A0", Offset = "0x303BCA0", Length = "0x76")]
		[Token(Token = "0x6000EC7")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x303C210", Offset = "0x303B610", Length = "0x4B")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000ED0")]
	public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x303BC00", Offset = "0x303B000", Length = "0xD1")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000ED7")]
	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	[Address(RVA = "0x303C2C0", Offset = "0x303B6C0", Length = "0xD8")]
	[Token(Token = "0x6000ED6")]
	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[Address(RVA = "0x303C3A0", Offset = "0x303B7A0", Length = "0xDF")]
	[Token(Token = "0x6000ED5")]
	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	[Address(RVA = "0x303C260", Offset = "0x303B660", Length = "0x51")]
	[Token(Token = "0x6000ED4")]
	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	[Address(RVA = "0x303BD70", Offset = "0x303B170", Length = "0x58")]
	[Token(Token = "0x6000ED3")]
	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	[Address(RVA = "0x303C750", Offset = "0x303BB50", Length = "0xD5")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000ECC")]
	public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x303BCE0", Offset = "0x303B0E0", Length = "0x8D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000ECD")]
	public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x303BDD0", Offset = "0x303B1D0", Length = "0x95")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000ECE")]
	public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[Address(RVA = "0x303BE70", Offset = "0x303B270", Length = "0xC1")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000ECF")]
	public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x303C480", Offset = "0x303B880", Length = "0x2CC")]
	[Token(Token = "0x6000ED2")]
	public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[Address(RVA = "0x303BF40", Offset = "0x303B340", Length = "0x2C6")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000ED1")]
	public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[Address(RVA = "0x303C830", Offset = "0x303BC30", Length = "0x2A")]
	[NativeName("GetAllTextureLayersIdentifier")]
	[Token(Token = "0x6000EC6")]
	public static int get_allSlices() { }

	[Address(RVA = "0x303C8A0", Offset = "0x303BCA0", Length = "0x76")]
	[Token(Token = "0x6000EC7")]
	public virtual bool get_isReadable() { }

	[Address(RVA = "0x303C860", Offset = "0x303BC60", Length = "0x33")]
	[Token(Token = "0x6000ED9")]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303B8D0", Offset = "0x303ACD0", Length = "0xB2")]
	[Token(Token = "0x6000EC9")]
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[Address(RVA = "0x303B6B0", Offset = "0x303AAB0", Length = "0x211")]
	[FreeFunction("Texture2DArrayScripting::Create")]
	[Token(Token = "0x6000EC8")]
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[Address(RVA = "0x303B630", Offset = "0x303AA30", Length = "0x72")]
	[Token(Token = "0x6000EDA")]
	private static bool Internal_CreateImpl_Injected(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, ref ManagedSpanWrapper mipmapLimitGroupName) { }

	[Address(RVA = "0x303B990", Offset = "0x303AD90", Length = "0x125")]
	[Token(Token = "0x6000ECB")]
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	[Address(RVA = "0x303BAC0", Offset = "0x303AEC0", Length = "0xD6")]
	[Token(Token = "0x6000ECA")]
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	[Address(RVA = "0x303BBA0", Offset = "0x303AFA0", Length = "0x60")]
	[Token(Token = "0x6000ED8")]
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

