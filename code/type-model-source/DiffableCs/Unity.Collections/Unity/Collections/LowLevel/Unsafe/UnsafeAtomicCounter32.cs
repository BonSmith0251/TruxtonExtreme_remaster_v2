namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000104")]
public struct UnsafeAtomicCounter32
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400049E")]
	public Int32* Counter; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000AF6")]
	public UnsafeAtomicCounter32(Void* ptr) { }

	[Address(RVA = "0x28D1620", Offset = "0x28D0A20", Length = "0x45")]
	[Token(Token = "0x6000AF8")]
	public int Add(int value) { }

	[Address(RVA = "0x28D15A0", Offset = "0x28D09A0", Length = "0x7F")]
	[Token(Token = "0x6000AFA")]
	public int AddSat(int value, int max = 2147483647) { }

	[Address(RVA = "0x28D1670", Offset = "0x28D0A70", Length = "0x6")]
	[Token(Token = "0x6000AF7")]
	public void Reset(int value = 0) { }

	[Address(RVA = "0x28D1700", Offset = "0x28D0B00", Length = "0x47")]
	[Token(Token = "0x6000AF9")]
	public int Sub(int value) { }

	[Address(RVA = "0x28D1680", Offset = "0x28D0A80", Length = "0x80")]
	[Token(Token = "0x6000AFB")]
	public int SubSat(int value, int min = -2147483648) { }

}

