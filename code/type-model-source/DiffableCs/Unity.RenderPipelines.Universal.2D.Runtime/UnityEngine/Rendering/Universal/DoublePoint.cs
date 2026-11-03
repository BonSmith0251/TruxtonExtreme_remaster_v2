namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000007")]
internal struct DoublePoint
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000007")]
	public double X; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000008")]
	public double Y; //Field offset: 0x8

	[Address(RVA = "0x27F69D0", Offset = "0x27F5DD0", Length = "0xA")]
	[Token(Token = "0x6000009")]
	public DoublePoint(double x = 0, double y = 0) { }

	[Address(RVA = "0x289C960", Offset = "0x289BD60", Length = "0xF")]
	[Token(Token = "0x600000A")]
	public DoublePoint(DoublePoint dp) { }

	[Address(RVA = "0x2D18050", Offset = "0x2D17450", Length = "0x1C")]
	[Token(Token = "0x600000B")]
	public DoublePoint(IntPoint ip) { }

}

