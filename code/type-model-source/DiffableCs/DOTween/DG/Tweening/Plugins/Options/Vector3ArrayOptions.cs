namespace DG.Tweening.Plugins.Options;

[Token(Token = "0x200008A")]
public struct Vector3ArrayOptions : IPlugOptions
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400017F")]
	public AxisConstraint axisConstraint; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000180")]
	public bool snapping; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000181")]
	internal Single[] durations; //Field offset: 0x8

	[Address(RVA = "0x67C490", Offset = "0x67B890", Length = "0x16")]
	[Token(Token = "0x600035B")]
	public override void Reset() { }

}

