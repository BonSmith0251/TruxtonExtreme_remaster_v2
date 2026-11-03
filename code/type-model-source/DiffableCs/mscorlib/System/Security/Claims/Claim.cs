namespace System.Security.Claims;

[Token(Token = "0x200033F")]
public class Claim
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DAE")]
	private string m_issuer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DAF")]
	private string m_originalIssuer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DB0")]
	private string m_type; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DB1")]
	private string m_value; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000DB2")]
	private string m_valueType; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000DB3")]
	private Byte[] m_userSerializationData; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000DB4")]
	private Dictionary<String, String> m_properties; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000DB5")]
	private object m_propertyLock; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000DB6")]
	private ClaimsIdentity m_subject; //Field offset: 0x50

	[Token(Token = "0x170002AE")]
	public IDictionary<String, String> Properties
	{
		[Address(RVA = "0x1ED8530", Offset = "0x1ED7930", Length = "0x103")]
		[Token(Token = "0x6001A3E")]
		 get { } //Length: 259
	}

	[Token(Token = "0x170002AF")]
	public internal ClaimsIdentity Subject
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6001A3F")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x6001A40")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002B0")]
	public string Type
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001A41")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002B1")]
	public string Value
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001A42")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1ED7EB0", Offset = "0x1ED72B0", Length = "0x46")]
	[Token(Token = "0x6001A3A")]
	public Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

	[Address(RVA = "0x1ED8270", Offset = "0x1ED7670", Length = "0x2BB")]
	[Token(Token = "0x6001A3B")]
	internal Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

	[Address(RVA = "0x1ED7F00", Offset = "0x1ED7300", Length = "0x363")]
	[Token(Token = "0x6001A3C")]
	protected Claim(Claim other, ClaimsIdentity subject) { }

	[Address(RVA = "0x1ED7D60", Offset = "0x1ED7160", Length = "0x64")]
	[Token(Token = "0x6001A43")]
	public override Claim Clone(ClaimsIdentity identity) { }

	[Address(RVA = "0x1ED8530", Offset = "0x1ED7930", Length = "0x103")]
	[Token(Token = "0x6001A3E")]
	public IDictionary<String, String> get_Properties() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6001A3F")]
	public ClaimsIdentity get_Subject() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001A41")]
	public string get_Type() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001A42")]
	public string get_Value() { }

	[Address(RVA = "0x1ED7DD0", Offset = "0x1ED71D0", Length = "0x5C")]
	[OnDeserialized]
	[Token(Token = "0x6001A3D")]
	private void OnDeserializedMethod(StreamingContext context) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x6001A40")]
	internal void set_Subject(ClaimsIdentity value) { }

	[Address(RVA = "0x1ED7E30", Offset = "0x1ED7230", Length = "0x73")]
	[Token(Token = "0x6001A44")]
	public virtual string ToString() { }

}

