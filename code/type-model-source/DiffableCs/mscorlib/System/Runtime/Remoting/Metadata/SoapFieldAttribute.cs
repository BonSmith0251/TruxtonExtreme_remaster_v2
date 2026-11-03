namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(AttributeTargets::Field (256))]
[ComVisible(True)]
[Token(Token = "0x200039B")]
public sealed class SoapFieldAttribute : SoapAttribute
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E83")]
	private string _elementName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E84")]
	private bool _isElement; //Field offset: 0x30

	[Token(Token = "0x1700031A")]
	public string XmlElementName
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001C30")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6001C2F")]
	public SoapFieldAttribute() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001C30")]
	public string get_XmlElementName() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6001C31")]
	public bool IsInteropXmlElement() { }

	[Address(RVA = "0x1F14820", Offset = "0x1F13C20", Length = "0xA7")]
	[Token(Token = "0x6001C32")]
	internal virtual void SetReflectionObject(object reflectionObject) { }

}

