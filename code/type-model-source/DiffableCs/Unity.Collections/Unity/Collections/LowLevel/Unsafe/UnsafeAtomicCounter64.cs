namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000105")]
public struct UnsafeAtomicCounter64
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400049F")]
	public Int64* Counter; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000AFC")]
	public UnsafeAtomicCounter64(Void* ptr) { }

	[Address(RVA = "0x28D17E0", Offset = "0x28D0BE0", Length = "0x48")]
	[Token(Token = "0x6000AFE")]
	public long Add(long value) { }

	[Address(RVA = "0x28D1750", Offset = "0x28D0B50", Length = "0x88")]
	[Token(Token = "0x6000B00")]
	public long AddSat(long value, long max = 9223372036854775807) { }

	[Address(RVA = "0x28D1830", Offset = "0x28D0C30", Length = "0x7")]
	[Token(Token = "0x6000AFD")]
	public void Reset(long value = 0) { }

	[Address(RVA = "0x28D18D0", Offset = "0x28D0CD0", Length = "0x4B")]
	[Token(Token = "0x6000AFF")]
	public long Sub(long value) { }

	[Address(RVA = "0x28D1840", Offset = "0x28D0C40", Length = "0x8A")]
	[Token(Token = "0x6000B01")]
	public long SubSat(long value, long min = -9223372036854775808) { }

}

