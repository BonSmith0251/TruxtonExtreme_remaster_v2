namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x200006C")]
public class CustomStyleAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400016F")]
	public readonly string ussStyle; //Field offset: 0x10

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x600032A")]
	public CustomStyleAttribute(string ussStyle) { }

}

