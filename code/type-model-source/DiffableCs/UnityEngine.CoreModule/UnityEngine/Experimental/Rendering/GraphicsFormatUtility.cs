namespace UnityEngine.Experimental.Rendering;

[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Graphics/Format.h")]
[NativeHeader("Runtime/Graphics/TextureFormat.h")]
[Token(Token = "0x2000428")]
public class GraphicsFormatUtility
{
	[Token(Token = "0x4000EDC")]
	private static readonly GraphicsFormat[] tableNoStencil; //Field offset: 0x0
	[Token(Token = "0x4000EDD")]
	private static readonly GraphicsFormat[] tableStencil; //Field offset: 0x8

	[Address(RVA = "0x30C00B0", Offset = "0x30BF4B0", Length = "0xEA")]
	[Token(Token = "0x6001F8C")]
	private static GraphicsFormatUtility() { }

	[Address(RVA = "0x30BF250", Offset = "0x30BE650", Length = "0x64")]
	[Token(Token = "0x6001F7D")]
	internal static bool CanDecompressFormat(GraphicsFormat format) { }

	[Address(RVA = "0x30BF2C0", Offset = "0x30BE6C0", Length = "0x40")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F7C")]
	private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) { }

	[Address(RVA = "0x30BF300", Offset = "0x30BE700", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F77")]
	public static uint GetAlphaComponentCount(GraphicsFormat format) { }

	[Address(RVA = "0x30BF340", Offset = "0x30BE740", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F8B")]
	public static uint GetBlockSize(GraphicsFormat format) { }

	[Address(RVA = "0x30BF380", Offset = "0x30BE780", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F78")]
	public static uint GetComponentCount(GraphicsFormat format) { }

	[Address(RVA = "0x30BF3C0", Offset = "0x30BE7C0", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F71")]
	public static int GetDepthBits(GraphicsFormat format) { }

	[Address(RVA = "0x30BF440", Offset = "0x30BE840", Length = "0x62")]
	[Token(Token = "0x6001F70")]
	public static GraphicsFormat GetDepthStencilFormat(int depthBits) { }

	[Address(RVA = "0x30BF4B0", Offset = "0x30BE8B0", Length = "0x28C")]
	[Token(Token = "0x6001F72")]
	public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) { }

	[Address(RVA = "0x30BF400", Offset = "0x30BE800", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F6F")]
	private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) { }

	[Address(RVA = "0x30BF8B0", Offset = "0x30BECB0", Length = "0xBC")]
	[FreeFunction("GetGraphicsFormat_Native_Texture")]
	[Token(Token = "0x6001F69")]
	internal static GraphicsFormat GetFormat(Texture texture) { }

	[Address(RVA = "0x30BF870", Offset = "0x30BEC70", Length = "0x33")]
	[Token(Token = "0x6001F8D")]
	private static GraphicsFormat GetFormat_Injected(IntPtr texture) { }

	[Address(RVA = "0x30BF780", Offset = "0x30BEB80", Length = "0xE5")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F79")]
	public static string GetFormatString(GraphicsFormat format) { }

	[Address(RVA = "0x30BF740", Offset = "0x30BEB40", Length = "0x40")]
	[Token(Token = "0x6001F8E")]
	private static void GetFormatString_Injected(GraphicsFormat format, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x30BFB40", Offset = "0x30BEF40", Length = "0x71")]
	[Token(Token = "0x6001F6A")]
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[Address(RVA = "0x30BF9F0", Offset = "0x30BEDF0", Length = "0xC1")]
	[Token(Token = "0x6001F6E")]
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[Address(RVA = "0x30BFAC0", Offset = "0x30BEEC0", Length = "0x71")]
	[Token(Token = "0x6001F6C")]
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[Address(RVA = "0x30BF970", Offset = "0x30BED70", Length = "0x40")]
	[FreeFunction(IsThreadSafe = False)]
	[Token(Token = "0x6001F6D")]
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	[Address(RVA = "0x30BF9B0", Offset = "0x30BEDB0", Length = "0x40")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F6B")]
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	[Address(RVA = "0x30BFBC0", Offset = "0x30BEFC0", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F75")]
	public static GraphicsFormat GetLinearFormat(GraphicsFormat format) { }

	[Address(RVA = "0x30BFC00", Offset = "0x30BF000", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F76")]
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[Address(RVA = "0x30BFC40", Offset = "0x30BF040", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F74")]
	public static GraphicsFormat GetSRGBFormat(GraphicsFormat format) { }

	[Address(RVA = "0x30BFC80", Offset = "0x30BF080", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F8A")]
	public static FormatSwizzle GetSwizzleA(GraphicsFormat format) { }

	[Address(RVA = "0x30BFCC0", Offset = "0x30BF0C0", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F89")]
	public static FormatSwizzle GetSwizzleB(GraphicsFormat format) { }

	[Address(RVA = "0x30BFD00", Offset = "0x30BF100", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F88")]
	public static FormatSwizzle GetSwizzleG(GraphicsFormat format) { }

	[Address(RVA = "0x30BFD40", Offset = "0x30BF140", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F87")]
	public static FormatSwizzle GetSwizzleR(GraphicsFormat format) { }

	[Address(RVA = "0x30BFD80", Offset = "0x30BF180", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F7F")]
	public static bool HasAlphaChannel(GraphicsFormat format) { }

	[Address(RVA = "0x30BFDC0", Offset = "0x30BF1C0", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F7E")]
	public static bool IsAlphaOnlyFormat(GraphicsFormat format) { }

	[Address(RVA = "0x30BFE40", Offset = "0x30BF240", Length = "0x62")]
	[Token(Token = "0x6001F7B")]
	public static bool IsCompressedFormat(TextureFormat format) { }

	[Address(RVA = "0x30BFE00", Offset = "0x30BF200", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F7A")]
	private static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format) { }

	[Address(RVA = "0x30BFEB0", Offset = "0x30BF2B0", Length = "0x31")]
	[FreeFunction("IsCompressedCrunchTextureFormat", IsThreadSafe = True)]
	[Token(Token = "0x6001F86")]
	public static bool IsCrunchFormat(TextureFormat format) { }

	[Address(RVA = "0x30BFEF0", Offset = "0x30BF2F0", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F80")]
	public static bool IsDepthFormat(GraphicsFormat format) { }

	[Address(RVA = "0x30BFF30", Offset = "0x30BF330", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F82")]
	public static bool IsDepthStencilFormat(GraphicsFormat format) { }

	[Address(RVA = "0x30BFF70", Offset = "0x30BF370", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F83")]
	public static bool IsFloatFormat(GraphicsFormat format) { }

	[Address(RVA = "0x30BFFB0", Offset = "0x30BF3B0", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F84")]
	public static bool IsHalfFormat(GraphicsFormat format) { }

	[Address(RVA = "0x30BFFF0", Offset = "0x30BF3F0", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Obsolete("Texture compression format PVRTC has been deprecated and will be removed in a future release", False)]
	[Token(Token = "0x6001F85")]
	public static bool IsPVRTCFormat(GraphicsFormat format) { }

	[Address(RVA = "0x30C0030", Offset = "0x30BF430", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F73")]
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[Address(RVA = "0x30C0070", Offset = "0x30BF470", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6001F81")]
	public static bool IsStencilFormat(GraphicsFormat format) { }

}

