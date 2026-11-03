namespace UnityEngine;

[Token(Token = "0x200014F")]
[UsedByNativeCode]
public struct GradientColorKey
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400057E")]
	public Color color; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400057F")]
	public float time; //Field offset: 0x10

	[Address(RVA = "0x3048370", Offset = "0x3047770", Length = "0xC")]
	[Token(Token = "0x6001010")]
	public GradientColorKey(Color col, float time) { }

}

