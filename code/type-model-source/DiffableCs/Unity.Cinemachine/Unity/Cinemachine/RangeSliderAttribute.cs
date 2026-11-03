namespace Unity.Cinemachine;

[Obsolete("Use RangeAttribute instead")]
[Token(Token = "0x20000A2")]
public sealed class RangeSliderAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400028B")]
	public float Min; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400028C")]
	public float Max; //Field offset: 0x1C

	[Address(RVA = "0x2846A40", Offset = "0x2845E40", Length = "0x3A")]
	[Token(Token = "0x600032C")]
	public RangeSliderAttribute(float min, float max) { }

}

