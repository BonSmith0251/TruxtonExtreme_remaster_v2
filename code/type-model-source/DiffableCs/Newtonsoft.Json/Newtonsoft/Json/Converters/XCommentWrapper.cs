namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x20001CD")]
internal class XCommentWrapper : XObjectWrapper
{

	[Token(Token = "0x1700028D")]
	public virtual IXmlNode ParentNode
	{
		[Address(RVA = "0x21B0D50", Offset = "0x21B0150", Length = "0xA4")]
		[Token(Token = "0x6000F7B")]
		 get { } //Length: 164
	}

	[Nullable(1)]
	[Token(Token = "0x1700028B")]
	private XComment Text
	{
		[Address(RVA = "0x21B0E00", Offset = "0x21B0200", Length = "0x6B")]
		[NullableContext(1)]
		[Token(Token = "0x6000F77")]
		private get { } //Length: 107
	}

	[Token(Token = "0x1700028C")]
	public virtual string Value
	{
		[Address(RVA = "0x21B0E70", Offset = "0x21B0270", Length = "0x71")]
		[Token(Token = "0x6000F79")]
		 get { } //Length: 113
		[Address(RVA = "0x21B0EF0", Offset = "0x21B02F0", Length = "0xA1")]
		[Token(Token = "0x6000F7A")]
		 set { } //Length: 161
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[NullableContext(1)]
	[Token(Token = "0x6000F78")]
	public XCommentWrapper(XComment text) { }

	[Address(RVA = "0x21B0D50", Offset = "0x21B0150", Length = "0xA4")]
	[Token(Token = "0x6000F7B")]
	public virtual IXmlNode get_ParentNode() { }

	[Address(RVA = "0x21B0E00", Offset = "0x21B0200", Length = "0x6B")]
	[NullableContext(1)]
	[Token(Token = "0x6000F77")]
	private XComment get_Text() { }

	[Address(RVA = "0x21B0E70", Offset = "0x21B0270", Length = "0x71")]
	[Token(Token = "0x6000F79")]
	public virtual string get_Value() { }

	[Address(RVA = "0x21B0EF0", Offset = "0x21B02F0", Length = "0xA1")]
	[Token(Token = "0x6000F7A")]
	public virtual void set_Value(string value) { }

}

