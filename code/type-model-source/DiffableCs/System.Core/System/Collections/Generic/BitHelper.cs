namespace System.Collections.Generic;

[Token(Token = "0x2000286")]
internal sealed class BitHelper
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400048A")]
	private readonly int _length; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400048B")]
	private readonly Int32* _arrayPtr; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400048C")]
	private readonly Int32[] _array; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400048D")]
	private readonly bool _useStackAlloc; //Field offset: 0x28

	[Address(RVA = "0x22ADAE0", Offset = "0x22ACEE0", Length = "0x3A")]
	[Token(Token = "0x6000CBA")]
	internal BitHelper(Int32* bitArrayPtr, int length) { }

	[Address(RVA = "0x22ADB20", Offset = "0x22ACF20", Length = "0x42")]
	[Token(Token = "0x6000CBB")]
	internal BitHelper(Int32[] bitArray, int length) { }

	[Address(RVA = "0x22AD9D0", Offset = "0x22ACDD0", Length = "0x7C")]
	[Token(Token = "0x6000CBD")]
	internal bool IsMarked(int bitPosition) { }

	[Address(RVA = "0x22ADA50", Offset = "0x22ACE50", Length = "0x6F")]
	[Token(Token = "0x6000CBC")]
	internal void MarkBit(int bitPosition) { }

	[Address(RVA = "0x22ADAC0", Offset = "0x22ACEC0", Length = "0x16")]
	[Token(Token = "0x6000CBE")]
	internal static int ToIntArrayLength(int n) { }

}

