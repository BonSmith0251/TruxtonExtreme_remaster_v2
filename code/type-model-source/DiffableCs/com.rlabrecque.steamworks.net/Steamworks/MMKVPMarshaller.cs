namespace Steamworks;

[Token(Token = "0x200018E")]
public class MMKVPMarshaller
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A5F")]
	private IntPtr m_pNativeArray; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A60")]
	private IntPtr m_pArrayEntries; //Field offset: 0x18

	[Address(RVA = "0x60E1B0", Offset = "0x60D5B0", Length = "0x1EF")]
	[Token(Token = "0x60008FF")]
	public MMKVPMarshaller(MatchMakingKeyValuePair_t[] filters) { }

	[Address(RVA = "0x60E0E0", Offset = "0x60D4E0", Length = "0xC6")]
	[Token(Token = "0x6000900")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
	[Token(Token = "0x6000901")]
	public static IntPtr op_Implicit(MMKVPMarshaller that) { }

}

