namespace System.Security.Cryptography;

[Token(Token = "0x2000117")]
public sealed class Oid
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004EB")]
	private string _value; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004EC")]
	private string _friendlyName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004ED")]
	private OidGroup _group; //Field offset: 0x20

	[Token(Token = "0x1700010E")]
	public string FriendlyName
	{
		[Address(RVA = "0x262F920", Offset = "0x262ED20", Length = "0x8D")]
		[Token(Token = "0x60006BB")]
		 get { } //Length: 141
	}

	[Token(Token = "0x1700010D")]
	public string Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60006B9")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60006BA")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60006B4")]
	public Oid() { }

	[Address(RVA = "0x262F890", Offset = "0x262EC90", Length = "0x84")]
	[Token(Token = "0x60006B5")]
	public Oid(string oid) { }

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60006B6")]
	public Oid(string value, string friendlyName) { }

	[Address(RVA = "0x262F7F0", Offset = "0x262EBF0", Length = "0x97")]
	[Token(Token = "0x60006B7")]
	public Oid(Oid oid) { }

	[Address(RVA = "0x22AE270", Offset = "0x22AD670", Length = "0x5F")]
	[Token(Token = "0x60006BC")]
	private Oid(string value, string friendlyName, OidGroup group) { }

	[Address(RVA = "0x262F680", Offset = "0x262EA80", Length = "0x160")]
	[Token(Token = "0x60006B8")]
	public static Oid FromOidValue(string oidValue, OidGroup group) { }

	[Address(RVA = "0x262F920", Offset = "0x262ED20", Length = "0x8D")]
	[Token(Token = "0x60006BB")]
	public string get_FriendlyName() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60006B9")]
	public string get_Value() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60006BA")]
	public void set_Value(string value) { }

}

