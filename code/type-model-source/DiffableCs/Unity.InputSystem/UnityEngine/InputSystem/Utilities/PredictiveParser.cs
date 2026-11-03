namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000262")]
internal struct PredictiveParser
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CCC")]
	private int m_Position; //Field offset: 0x0

	[Address(RVA = "0x2925160", Offset = "0x2924560", Length = "0x56")]
	[Token(Token = "0x6001610")]
	public void AcceptInt(ReadOnlySpan<Char> str) { }

	[Address(RVA = "0x29251C0", Offset = "0x29245C0", Length = "0x32")]
	[Token(Token = "0x600160E")]
	public bool AcceptSingleChar(ReadOnlySpan<Char> str, char c) { }

	[Address(RVA = "0x2925200", Offset = "0x2924600", Length = "0x16A")]
	[Token(Token = "0x600160F")]
	public bool AcceptString(ReadOnlySpan<Char> input, out ReadOnlySpan<Char>& output) { }

	[Address(RVA = "0x2925370", Offset = "0x2924770", Length = "0x144")]
	[Token(Token = "0x600160C")]
	public int ExpectInt(ReadOnlySpan<Char> str) { }

	[Address(RVA = "0x29254C0", Offset = "0x29248C0", Length = "0xFA")]
	[Token(Token = "0x600160B")]
	public void ExpectSingleChar(ReadOnlySpan<Char> str, char c) { }

	[Address(RVA = "0x29255C0", Offset = "0x29249C0", Length = "0x29E")]
	[Token(Token = "0x600160D")]
	public ReadOnlySpan<Char> ExpectString(ReadOnlySpan<Char> str) { }

}

