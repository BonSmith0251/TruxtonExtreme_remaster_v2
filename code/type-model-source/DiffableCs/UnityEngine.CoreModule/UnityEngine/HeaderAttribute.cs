namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = True)]
[Token(Token = "0x200016C")]
public class HeaderAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000601")]
	public readonly string header; //Field offset: 0x18

	[Address(RVA = "0x3065720", Offset = "0x3064B20", Length = "0x35")]
	[Token(Token = "0x6001203")]
	public HeaderAttribute(string header) { }

}

