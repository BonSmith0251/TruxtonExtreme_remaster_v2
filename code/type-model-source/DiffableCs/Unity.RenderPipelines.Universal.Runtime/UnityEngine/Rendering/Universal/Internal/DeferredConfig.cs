namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x20001FE")]
internal static class DeferredConfig
{
	[CompilerGenerated]
	[Token(Token = "0x4000C10")]
	private static bool <IsOpenGL>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x4000C11")]
	private static bool <IsDX10>k__BackingField; //Field offset: 0x1

	[Token(Token = "0x170002A5")]
	internal static bool IsDX10
	{
		[Address(RVA = "0x2DFEAD0", Offset = "0x2DFDED0", Length = "0x37")]
		[CompilerGenerated]
		[Token(Token = "0x6000AE1")]
		internal get { } //Length: 55
		[Address(RVA = "0x2DFEB50", Offset = "0x2DFDF50", Length = "0x3C")]
		[CompilerGenerated]
		[Token(Token = "0x6000AE2")]
		internal set { } //Length: 60
	}

	[Token(Token = "0x170002A4")]
	internal static bool IsOpenGL
	{
		[Address(RVA = "0x2DFEB10", Offset = "0x2DFDF10", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x6000ADF")]
		internal get { } //Length: 54
		[Address(RVA = "0x2DFEB90", Offset = "0x2DFDF90", Length = "0x3B")]
		[CompilerGenerated]
		[Token(Token = "0x6000AE0")]
		internal set { } //Length: 59
	}

	[Address(RVA = "0x2DFEAD0", Offset = "0x2DFDED0", Length = "0x37")]
	[CompilerGenerated]
	[Token(Token = "0x6000AE1")]
	internal static bool get_IsDX10() { }

	[Address(RVA = "0x2DFEB10", Offset = "0x2DFDF10", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x6000ADF")]
	internal static bool get_IsOpenGL() { }

	[Address(RVA = "0x2DFEB50", Offset = "0x2DFDF50", Length = "0x3C")]
	[CompilerGenerated]
	[Token(Token = "0x6000AE2")]
	internal static void set_IsDX10(bool value) { }

	[Address(RVA = "0x2DFEB90", Offset = "0x2DFDF90", Length = "0x3B")]
	[CompilerGenerated]
	[Token(Token = "0x6000AE0")]
	internal static void set_IsOpenGL(bool value) { }

}

