namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F6")]
public sealed class CspParameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CCE")]
	public int ProviderType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CCF")]
	public string ProviderName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000CD0")]
	public string KeyContainerName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000CD1")]
	public int KeyNumber; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000CD2")]
	private int m_flags; //Field offset: 0x2C

	[Token(Token = "0x1700026F")]
	public CspProviderFlags Flags
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6001860")]
		 get { } //Length: 4
		[Address(RVA = "0x1EB65E0", Offset = "0x1EB59E0", Length = "0xDF")]
		[Token(Token = "0x6001861")]
		 set { } //Length: 223
	}

	[Address(RVA = "0x1EB6480", Offset = "0x1EB5880", Length = "0x56")]
	[Token(Token = "0x6001862")]
	public CspParameters() { }

	[Address(RVA = "0x1EB6420", Offset = "0x1EB5820", Length = "0x57")]
	[Token(Token = "0x6001863")]
	public CspParameters(int dwTypeIn) { }

	[Address(RVA = "0x1EB6560", Offset = "0x1EB5960", Length = "0x71")]
	[Token(Token = "0x6001864")]
	public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	[Address(RVA = "0x1EB64E0", Offset = "0x1EB58E0", Length = "0x73")]
	[Token(Token = "0x6001865")]
	internal CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6001860")]
	public CspProviderFlags get_Flags() { }

	[Address(RVA = "0x1EB65E0", Offset = "0x1EB59E0", Length = "0xDF")]
	[Token(Token = "0x6001861")]
	public void set_Flags(CspProviderFlags value) { }

}

