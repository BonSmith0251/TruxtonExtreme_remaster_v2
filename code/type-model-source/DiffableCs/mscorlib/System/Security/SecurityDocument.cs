namespace System.Security;

[Token(Token = "0x20002CC")]
internal sealed class SecurityDocument
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C0D")]
	internal Byte[] m_data; //Field offset: 0x10

	[Address(RVA = "0x1EAB7D0", Offset = "0x1EAABD0", Length = "0x5D")]
	[Token(Token = "0x6001780")]
	public SecurityDocument(int numData) { }

	[Address(RVA = "0x1EAADA0", Offset = "0x1EAA1A0", Length = "0x142")]
	[Token(Token = "0x6001782")]
	public void AddString(string str, ref int position) { }

	[Address(RVA = "0x1EAAEF0", Offset = "0x1EAA2F0", Length = "0xE4")]
	[Token(Token = "0x6001786")]
	public void AddToken(byte b, ref int position) { }

	[Address(RVA = "0x1EAAFE0", Offset = "0x1EAA3E0", Length = "0x9D")]
	[Token(Token = "0x6001783")]
	public void AppendString(string str, ref int position) { }

	[Address(RVA = "0x1EAB080", Offset = "0x1EAA480", Length = "0x1D")]
	[Token(Token = "0x6001784")]
	public static int EncodedStringSize(string str) { }

	[Address(RVA = "0x1EAB0A0", Offset = "0x1EAA4A0", Length = "0x1A")]
	[Token(Token = "0x6001788")]
	public SecurityElement GetElement(int position, bool bCreate) { }

	[Address(RVA = "0x1EAB0C0", Offset = "0x1EAA4C0", Length = "0x21")]
	[Token(Token = "0x6001787")]
	public SecurityElement GetRootElement() { }

	[Address(RVA = "0x1EAB0F0", Offset = "0x1EAA4F0", Length = "0x3A7")]
	[Token(Token = "0x6001785")]
	public string GetString(ref int position, bool bCreate) { }

	[Address(RVA = "0x1EAB4A0", Offset = "0x1EAA8A0", Length = "0xA2")]
	[Token(Token = "0x6001781")]
	public void GuaranteeSize(int size) { }

	[Address(RVA = "0x1EAB550", Offset = "0x1EAA950", Length = "0x275")]
	[Token(Token = "0x6001789")]
	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }

}

