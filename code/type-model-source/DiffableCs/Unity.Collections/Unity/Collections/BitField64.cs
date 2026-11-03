namespace Unity.Collections;

[DebuggerTypeProxy(typeof(BitField64DebugView))]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200003A")]
public struct BitField64
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000084")]
	public ulong Value; //Field offset: 0x0

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x600012B")]
	public BitField64(ulong initialValue = 0) { }

	[Address(RVA = "0x28A9F40", Offset = "0x28A9340", Length = "0xBA")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000137")]
	private static void CheckArgs(int pos, int numBits) { }

	[Address(RVA = "0x604930", Offset = "0x603D30", Length = "0x8")]
	[Token(Token = "0x600012C")]
	public void Clear() { }

	[Address(RVA = "0x28AA000", Offset = "0x28A9400", Length = "0x5D")]
	[Token(Token = "0x6000134")]
	public int CountBits() { }

	[Address(RVA = "0x28AA060", Offset = "0x28A9460", Length = "0x5D")]
	[Token(Token = "0x6000135")]
	public int CountLeadingZeros() { }

	[Address(RVA = "0x28AA0C0", Offset = "0x28A94C0", Length = "0x68")]
	[Token(Token = "0x6000136")]
	public int CountTrailingZeros() { }

	[Address(RVA = "0x28AA130", Offset = "0x28A9530", Length = "0x25")]
	[Token(Token = "0x600012F")]
	public ulong GetBits(int pos, int numBits = 1) { }

	[Address(RVA = "0x28AA160", Offset = "0x28A9560", Length = "0x12")]
	[Token(Token = "0x6000130")]
	public bool IsSet(int pos) { }

	[Address(RVA = "0x28AA180", Offset = "0x28A9580", Length = "0x2E")]
	[Token(Token = "0x600012D")]
	public void SetBits(int pos, bool value) { }

	[Address(RVA = "0x28AA1B0", Offset = "0x28A95B0", Length = "0x3D")]
	[Token(Token = "0x600012E")]
	public void SetBits(int pos, bool value, int numBits = 1) { }

	[Address(RVA = "0x28AA1F0", Offset = "0x28A95F0", Length = "0x2B")]
	[Token(Token = "0x6000133")]
	public bool TestAll(int pos, int numBits = 1) { }

	[Address(RVA = "0x28AA220", Offset = "0x28A9620", Length = "0x28")]
	[Token(Token = "0x6000132")]
	public bool TestAny(int pos, int numBits = 1) { }

	[Address(RVA = "0x28AA250", Offset = "0x28A9650", Length = "0x28")]
	[Token(Token = "0x6000131")]
	public bool TestNone(int pos, int numBits = 1) { }

}

