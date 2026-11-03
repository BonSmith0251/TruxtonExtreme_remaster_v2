namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20001CC")]
internal class XTextWrapper : XObjectWrapper
{

	[Token(Token = "0x1700028A")]
	public virtual IXmlNode ParentNode
	{
		[Address(RVA = "0x21B36A0", Offset = "0x21B2AA0", Length = "0xA4")]
		[Token(Token = "0x6000F76")]
		 get { } //Length: 164
	}

	[Nullable(1)]
	[Token(Token = "0x17000288")]
	private XText Text
	{
		[Address(RVA = "0x21B3750", Offset = "0x21B2B50", Length = "0x6B")]
		[NullableContext(1)]
		[Token(Token = "0x6000F72")]
		private get { } //Length: 107
	}

	[Token(Token = "0x17000289")]
	public virtual string Value
	{
		[Address(RVA = "0x21B37C0", Offset = "0x21B2BC0", Length = "0x71")]
		[Token(Token = "0x6000F74")]
		 get { } //Length: 113
		[Address(RVA = "0x21B3840", Offset = "0x21B2C40", Length = "0xA1")]
		[Token(Token = "0x6000F75")]
		 set { } //Length: 161
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[NullableContext(1)]
	[Token(Token = "0x6000F73")]
	public XTextWrapper(XText text) { }

	[Address(RVA = "0x21B36A0", Offset = "0x21B2AA0", Length = "0xA4")]
	[Token(Token = "0x6000F76")]
	public virtual IXmlNode get_ParentNode() { }

	[Address(RVA = "0x21B3750", Offset = "0x21B2B50", Length = "0x6B")]
	[NullableContext(1)]
	[Token(Token = "0x6000F72")]
	private XText get_Text() { }

	[Address(RVA = "0x21B37C0", Offset = "0x21B2BC0", Length = "0x71")]
	[Token(Token = "0x6000F74")]
	public virtual string get_Value() { }

	[Address(RVA = "0x21B3840", Offset = "0x21B2C40", Length = "0xA1")]
	[Token(Token = "0x6000F75")]
	public virtual void set_Value(string value) { }

}

