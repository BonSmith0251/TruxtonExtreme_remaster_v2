namespace Steamworks;

[Token(Token = "0x20001AE")]
public static class Packsize
{
	[Token(Token = "0x20001AF")]
	private struct ValvePackingSentinel_t
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A84")]
		private uint m_u32; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A85")]
		private ulong m_u64; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A86")]
		private ushort m_u16; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A87")]
		private double m_d; //Field offset: 0x18

	}

	[Token(Token = "0x4000A83")]
	public const int value = 8; //Field offset: 0x0

	[Address(RVA = "0x639040", Offset = "0x638440", Length = "0xB7")]
	[Token(Token = "0x6000977")]
	public static bool Test() { }

}

