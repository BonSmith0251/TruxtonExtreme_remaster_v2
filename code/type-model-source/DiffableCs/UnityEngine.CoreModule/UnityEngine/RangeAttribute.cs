namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
[Token(Token = "0x200016D")]
public sealed class RangeAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000602")]
	public readonly float min; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000603")]
	public readonly float max; //Field offset: 0x1C

	[Address(RVA = "0x306FB50", Offset = "0x306EF50", Length = "0x3E")]
	[Token(Token = "0x6001204")]
	public RangeAttribute(float min, float max) { }

}

