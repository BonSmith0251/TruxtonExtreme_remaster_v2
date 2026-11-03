namespace Unity.Collections;

[DebuggerTypeProxy(typeof(BitField32DebugView))]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000038")]
public struct BitField32
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000082")]
	public uint Value; //Field offset: 0x0

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x600011C")]
	public BitField32(uint initialValue = 0) { }

	[Address(RVA = "0x28A9BE0", Offset = "0x28A8FE0", Length = "0xBA")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000128")]
	private static void CheckArgs(int pos, int numBits) { }

	[Address(RVA = "0x1CA23C0", Offset = "0x1CA17C0", Length = "0x7")]
	[Token(Token = "0x600011D")]
	public void Clear() { }

	[Address(RVA = "0x28A9CA0", Offset = "0x28A90A0", Length = "0x36")]
	[Token(Token = "0x6000125")]
	public int CountBits() { }

	[Address(RVA = "0x28A9CE0", Offset = "0x28A90E0", Length = "0x43")]
	[Token(Token = "0x6000126")]
	public int CountLeadingZeros() { }

	[Address(RVA = "0x28A9D30", Offset = "0x28A9130", Length = "0x48")]
	[Token(Token = "0x6000127")]
	public int CountTrailingZeros() { }

	[Address(RVA = "0x28A9D80", Offset = "0x28A9180", Length = "0x1F")]
	[Token(Token = "0x6000120")]
	public uint GetBits(int pos, int numBits = 1) { }

	[Address(RVA = "0x28A9DA0", Offset = "0x28A91A0", Length = "0xD")]
	[Token(Token = "0x6000121")]
	public bool IsSet(int pos) { }

	[Address(RVA = "0x28A9DB0", Offset = "0x28A91B0", Length = "0x2C")]
	[Token(Token = "0x600011E")]
	public void SetBits(int pos, bool value) { }

	[Address(RVA = "0x28A9DE0", Offset = "0x28A91E0", Length = "0x3A")]
	[Token(Token = "0x600011F")]
	public void SetBits(int pos, bool value, int numBits) { }

	[Address(RVA = "0x28A9E20", Offset = "0x28A9220", Length = "0x28")]
	[Token(Token = "0x6000124")]
	public bool TestAll(int pos, int numBits = 1) { }

	[Address(RVA = "0x28A9E50", Offset = "0x28A9250", Length = "0x25")]
	[Token(Token = "0x6000123")]
	public bool TestAny(int pos, int numBits = 1) { }

	[Address(RVA = "0x28A9E80", Offset = "0x28A9280", Length = "0x25")]
	[Token(Token = "0x6000122")]
	public bool TestNone(int pos, int numBits = 1) { }

}

