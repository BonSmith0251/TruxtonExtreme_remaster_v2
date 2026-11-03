namespace System;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x2000174")]
internal struct ByReference
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000569")]
	private IntPtr _value; //Field offset: 0x0

	[Token(Token = "0x17000118")]
	public T Value
	{
		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[Intrinsic]
		[Token(Token = "0x6000D6B")]
		 get { } //Length: 57
	}

	[Address(RVA = "0x1026870", Offset = "0x1025C70", Length = "0x39")]
	[Intrinsic]
	[Token(Token = "0x6000D6A")]
	public ByReference`1(ref T value) { }

	[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
	[Intrinsic]
	[Token(Token = "0x6000D6B")]
	public T get_Value() { }

}

