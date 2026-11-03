namespace System.Net;

[Token(Token = "0x2000251")]
public class NetworkCredential : ICredentials
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000944")]
	private string m_domain; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000945")]
	private string m_userName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000946")]
	private SecureString m_password; //Field offset: 0x20

	[Token(Token = "0x17000335")]
	public string Domain
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000F8D")]
		 get { } //Length: 5
		[Address(RVA = "0x26AB7C0", Offset = "0x26AABC0", Length = "0x29")]
		[Token(Token = "0x6000F8E")]
		 set { } //Length: 41
	}

	[Token(Token = "0x17000334")]
	public string Password
	{
		[Address(RVA = "0x26AB580", Offset = "0x26AA980", Length = "0xB")]
		[Token(Token = "0x6000F8B")]
		 get { } //Length: 11
		[Address(RVA = "0x26AB7F0", Offset = "0x26AABF0", Length = "0x2B")]
		[Token(Token = "0x6000F8C")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000333")]
	public string UserName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000F89")]
		 get { } //Length: 5
		[Address(RVA = "0x26AB820", Offset = "0x26AAC20", Length = "0x29")]
		[Token(Token = "0x6000F8A")]
		 set { } //Length: 41
	}

	[Address(RVA = "0x26AB590", Offset = "0x26AA990", Length = "0xB5")]
	[Token(Token = "0x6000F86")]
	public NetworkCredential() { }

	[Address(RVA = "0x26AB700", Offset = "0x26AAB00", Length = "0xB5")]
	[Token(Token = "0x6000F87")]
	public NetworkCredential(string userName, string password) { }

	[Address(RVA = "0x26AB650", Offset = "0x26AAA50", Length = "0xA7")]
	[Token(Token = "0x6000F88")]
	public NetworkCredential(string userName, string password, string domain) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000F8D")]
	public string get_Domain() { }

	[Address(RVA = "0x26AB580", Offset = "0x26AA980", Length = "0xB")]
	[Token(Token = "0x6000F8B")]
	public string get_Password() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000F89")]
	public string get_UserName() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000F92")]
	public override NetworkCredential GetCredential(Uri uri, string authType) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000F91")]
	internal string InternalGetDomain() { }

	[Address(RVA = "0x26AB580", Offset = "0x26AA980", Length = "0xB")]
	[Token(Token = "0x6000F90")]
	internal string InternalGetPassword() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000F8F")]
	internal string InternalGetUserName() { }

	[Address(RVA = "0x26AB7C0", Offset = "0x26AABC0", Length = "0x29")]
	[Token(Token = "0x6000F8E")]
	public void set_Domain(string value) { }

	[Address(RVA = "0x26AB7F0", Offset = "0x26AABF0", Length = "0x2B")]
	[Token(Token = "0x6000F8C")]
	public void set_Password(string value) { }

	[Address(RVA = "0x26AB820", Offset = "0x26AAC20", Length = "0x29")]
	[Token(Token = "0x6000F8A")]
	public void set_UserName(string value) { }

}

