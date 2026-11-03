namespace UnityEngine.Rendering;

[Token(Token = "0x200012A")]
internal class LogarithmicAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000572")]
	public int min; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000573")]
	public int max; //Field offset: 0x1C

	[Address(RVA = "0x2C0DE90", Offset = "0x2C0D290", Length = "0x34")]
	[Token(Token = "0x6000A51")]
	public LogarithmicAttribute(int min, int max) { }

}

