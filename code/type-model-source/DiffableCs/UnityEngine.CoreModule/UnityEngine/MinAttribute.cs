namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
[Token(Token = "0x200016E")]
public sealed class MinAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000604")]
	public readonly float min; //Field offset: 0x18

	[Address(RVA = "0x3065DC0", Offset = "0x30651C0", Length = "0x2C")]
	[Token(Token = "0x6001205")]
	public MinAttribute(float min) { }

}

