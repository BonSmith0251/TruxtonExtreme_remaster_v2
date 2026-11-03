namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False)]
[Token(Token = "0x200018E")]
[UsedByNativeCode]
public class HelpURLAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400062F")]
	internal readonly string m_Url; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000630")]
	internal readonly bool m_Dispatcher; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000631")]
	internal readonly string m_DispatchingFieldName; //Field offset: 0x20

	[Token(Token = "0x170002CD")]
	public override string URL
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001290")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3065760", Offset = "0x3064B60", Length = "0x70")]
	[Token(Token = "0x600128F")]
	public HelpURLAttribute(string url) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001290")]
	public override string get_URL() { }

}

