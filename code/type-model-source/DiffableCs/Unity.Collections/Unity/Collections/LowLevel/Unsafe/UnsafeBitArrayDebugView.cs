namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000108")]
internal sealed class UnsafeBitArrayDebugView
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004A6")]
	private UnsafeBitArray Data; //Field offset: 0x10

	[Token(Token = "0x17000140")]
	public Boolean[] Bits
	{
		[Address(RVA = "0x28D1920", Offset = "0x28D0D20", Length = "0x97")]
		[Token(Token = "0x6000B33")]
		 get { } //Length: 151
	}

	[Address(RVA = "0x11A7D10", Offset = "0x11A7110", Length = "0x33")]
	[Token(Token = "0x6000B32")]
	public UnsafeBitArrayDebugView(UnsafeBitArray data) { }

	[Address(RVA = "0x28D1920", Offset = "0x28D0D20", Length = "0x97")]
	[Token(Token = "0x6000B33")]
	public Boolean[] get_Bits() { }

}

