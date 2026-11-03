namespace UnityEngine.Rendering;

[Token(Token = "0x20001C3")]
public static class FSRUtils
{
	[Token(Token = "0x20001C4")]
	private static class ShaderConstants
	{
		[Token(Token = "0x40008C9")]
		public static readonly int _FsrEasuConstants0; //Field offset: 0x0
		[Token(Token = "0x40008CA")]
		public static readonly int _FsrEasuConstants1; //Field offset: 0x4
		[Token(Token = "0x40008CB")]
		public static readonly int _FsrEasuConstants2; //Field offset: 0x8
		[Token(Token = "0x40008CC")]
		public static readonly int _FsrEasuConstants3; //Field offset: 0xC
		[Token(Token = "0x40008CD")]
		public static readonly int _FsrRcasConstants; //Field offset: 0x10

		[Address(RVA = "0x2C648F0", Offset = "0x2C63CF0", Length = "0xFB")]
		[Token(Token = "0x6000E0B")]
		private static ShaderConstants() { }

	}

	[Token(Token = "0x40008C6")]
	internal const float kMaxSharpnessStops = 2.5; //Field offset: 0x0
	[Token(Token = "0x40008C7")]
	public const float kDefaultSharpnessStops = 0.2; //Field offset: 0x0
	[Token(Token = "0x40008C8")]
	public const float kDefaultSharpnessLinear = 0.92; //Field offset: 0x0

	[Address(RVA = "0x2C5BA20", Offset = "0x2C5AE20", Length = "0x16")]
	[Token(Token = "0x6000E0A")]
	public static bool IsSupported() { }

	[Address(RVA = "0x2C5BA40", Offset = "0x2C5AE40", Length = "0x2F5")]
	[Token(Token = "0x6000E04")]
	public static void SetEasuConstants(CommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels) { }

	[Address(RVA = "0x2C5BD40", Offset = "0x2C5B140", Length = "0x24")]
	[Token(Token = "0x6000E05")]
	public static void SetEasuConstants(BaseCommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels) { }

	[Address(RVA = "0x2C5BDD0", Offset = "0x2C5B1D0", Length = "0xCD")]
	[Token(Token = "0x6000E06")]
	public static void SetRcasConstants(CommandBuffer cmd, float sharpnessStops = 0.2) { }

	[Address(RVA = "0x2C5BEA0", Offset = "0x2C5B2A0", Length = "0x1E")]
	[Token(Token = "0x6000E07")]
	public static void SetRcasConstants(BaseCommandBuffer cmd, float sharpnessStops = 0.2) { }

	[Address(RVA = "0x2C5BD70", Offset = "0x2C5B170", Length = "0x1F")]
	[Token(Token = "0x6000E08")]
	public static void SetRcasConstantsLinear(CommandBuffer cmd, float sharpnessLinear = 0.92) { }

	[Address(RVA = "0x2C5BD90", Offset = "0x2C5B190", Length = "0x35")]
	[Token(Token = "0x6000E09")]
	public static void SetRcasConstantsLinear(RasterCommandBuffer cmd, float sharpnessLinear = 0.92) { }

}

