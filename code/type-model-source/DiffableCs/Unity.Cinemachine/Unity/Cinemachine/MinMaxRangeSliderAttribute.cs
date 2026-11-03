namespace Unity.Cinemachine;

[Token(Token = "0x20000A3")]
public sealed class MinMaxRangeSliderAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400028D")]
	public float Min; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400028E")]
	public float Max; //Field offset: 0x1C

	[Address(RVA = "0x2846A40", Offset = "0x2845E40", Length = "0x3A")]
	[Token(Token = "0x600032D")]
	public MinMaxRangeSliderAttribute(float min, float max) { }

}

