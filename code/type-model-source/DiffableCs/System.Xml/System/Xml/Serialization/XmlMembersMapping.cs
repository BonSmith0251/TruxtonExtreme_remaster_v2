namespace System.Xml.Serialization;

[DefaultMember("Item")]
[Token(Token = "0x2000118")]
public class XmlMembersMapping : XmlMapping
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000640")]
	private bool _hasWrapperElement; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000641")]
	private XmlMemberMapping[] _mapping; //Field offset: 0x50

	[Token(Token = "0x1700034A")]
	public int Count
	{
		[Address(RVA = "0x2563110", Offset = "0x2562510", Length = "0x1A")]
		[Token(Token = "0x6000C99")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700034B")]
	internal bool HasWrapperElement
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[Token(Token = "0x6000C9A")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2563110", Offset = "0x2562510", Length = "0x1A")]
	[Token(Token = "0x6000C99")]
	public int get_Count() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[Token(Token = "0x6000C9A")]
	internal bool get_HasWrapperElement() { }

}

