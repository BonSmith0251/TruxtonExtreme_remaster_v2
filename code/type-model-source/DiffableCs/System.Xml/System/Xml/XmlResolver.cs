namespace System.Xml;

[Token(Token = "0x20000E2")]
public abstract class XmlResolver
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000B93")]
	protected XmlResolver() { }

	[Token(Token = "0x6000B8F")]
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	[Address(RVA = "0x255D220", Offset = "0x255C620", Length = "0x3E")]
	[Token(Token = "0x6000B92")]
	public override Task<Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	[Address(RVA = "0x255D260", Offset = "0x255C660", Length = "0x1E4")]
	[Token(Token = "0x6000B90")]
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	[Address(RVA = "0x255D450", Offset = "0x255C850", Length = "0x11D")]
	[Token(Token = "0x6000B91")]
	public override bool SupportsType(Uri absoluteUri, Type type) { }

}

