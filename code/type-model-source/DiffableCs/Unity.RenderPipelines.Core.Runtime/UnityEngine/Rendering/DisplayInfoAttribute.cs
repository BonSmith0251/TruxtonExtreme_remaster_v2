namespace UnityEngine.Rendering;

[AttributeUsage(260, AllowMultiple = False)]
[Token(Token = "0x2000034")]
public class DisplayInfoAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C3")]
	public string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C4")]
	public int order; //Field offset: 0x18

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000486")]
	public DisplayInfoAttribute() { }

}

