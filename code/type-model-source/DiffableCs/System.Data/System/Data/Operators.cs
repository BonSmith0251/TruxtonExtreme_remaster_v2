namespace System.Data;

[Token(Token = "0x200006E")]
internal sealed class Operators
{
	[Token(Token = "0x4000239")]
	private static readonly Int32[] s_priority; //Field offset: 0x0
	[Token(Token = "0x400023A")]
	private static readonly String[] s_looks; //Field offset: 0x8

	[Address(RVA = "0x234A460", Offset = "0x2349860", Length = "0x7FC")]
	[Token(Token = "0x600061E")]
	private static Operators() { }

	[Address(RVA = "0x234A2C0", Offset = "0x23496C0", Length = "0x12")]
	[Token(Token = "0x6000619")]
	internal static bool IsArithmetical(int op) { }

	[Address(RVA = "0x234A2E0", Offset = "0x23496E0", Length = "0x19")]
	[Token(Token = "0x600061A")]
	internal static bool IsLogical(int op) { }

	[Address(RVA = "0x234A300", Offset = "0x2349700", Length = "0xF")]
	[Token(Token = "0x600061B")]
	internal static bool IsRelational(int op) { }

	[Address(RVA = "0x234A310", Offset = "0x2349710", Length = "0x9E")]
	[Token(Token = "0x600061C")]
	internal static int Priority(int op) { }

	[Address(RVA = "0x234A3B0", Offset = "0x23497B0", Length = "0xAF")]
	[Token(Token = "0x600061D")]
	internal static string ToString(int op) { }

}

