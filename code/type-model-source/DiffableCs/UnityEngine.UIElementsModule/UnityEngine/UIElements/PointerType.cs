namespace UnityEngine.UIElements;

[Token(Token = "0x2000221")]
public static class PointerType
{
	[Token(Token = "0x40008B3")]
	public static readonly string mouse; //Field offset: 0x0
	[Token(Token = "0x40008B4")]
	public static readonly string touch; //Field offset: 0x8
	[Token(Token = "0x40008B5")]
	public static readonly string pen; //Field offset: 0x10
	[Token(Token = "0x40008B6")]
	public static readonly string tracked; //Field offset: 0x18
	[Token(Token = "0x40008B7")]
	public static readonly string unknown; //Field offset: 0x20

	[Address(RVA = "0x33DA8F0", Offset = "0x33D9CF0", Length = "0x16E")]
	[Token(Token = "0x6000ECD")]
	private static PointerType() { }

	[Address(RVA = "0x33DA6B0", Offset = "0x33D9AB0", Length = "0x1AB")]
	[Token(Token = "0x6000ECB")]
	internal static string GetPointerType(int pointerId) { }

	[Address(RVA = "0x33DA860", Offset = "0x33D9C60", Length = "0x82")]
	[Token(Token = "0x6000ECC")]
	internal static bool IsDirectManipulationDevice(string pointerType) { }

}

