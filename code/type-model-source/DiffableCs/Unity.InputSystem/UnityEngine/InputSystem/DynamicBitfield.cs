namespace UnityEngine.InputSystem;

[Token(Token = "0x20000E1")]
internal struct DynamicBitfield
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400055E")]
	public InlinedArray<UInt64> array; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400055F")]
	public int length; //Field offset: 0x18

	[Address(RVA = "0x29B5BA0", Offset = "0x29B4FA0", Length = "0x66")]
	[Token(Token = "0x6000C08")]
	public bool AnyBitIsSet() { }

	[Address(RVA = "0x29B5C10", Offset = "0x29B5010", Length = "0xD")]
	[Token(Token = "0x6000C09")]
	private static int BitCountToULongCount(int bitCount) { }

	[Address(RVA = "0x29B5C20", Offset = "0x29B5020", Length = "0x8B")]
	[Token(Token = "0x6000C07")]
	public void ClearBit(int bitIndex) { }

	[Address(RVA = "0x29B5CB0", Offset = "0x29B50B0", Length = "0x8B")]
	[Token(Token = "0x6000C05")]
	public void SetBit(int bitIndex) { }

	[Address(RVA = "0x29B5D40", Offset = "0x29B5140", Length = "0x5A")]
	[Token(Token = "0x6000C04")]
	public void SetLength(int newLength) { }

	[Address(RVA = "0x29B5DA0", Offset = "0x29B51A0", Length = "0x72")]
	[Token(Token = "0x6000C06")]
	public bool TestBit(int bitIndex) { }

}

