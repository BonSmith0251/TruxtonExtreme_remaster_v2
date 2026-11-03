namespace System.Runtime.Serialization;

[Token(Token = "0x20003EB")]
internal class FixupHolder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F5D")]
	internal long m_id; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F5E")]
	internal object m_fixupInfo; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F5F")]
	internal int m_fixupType; //Field offset: 0x20

	[Address(RVA = "0x1F1C6B0", Offset = "0x1F1BAB0", Length = "0x53")]
	[Token(Token = "0x6001E26")]
	internal FixupHolder(long id, object fixupInfo, int fixupType) { }

}

