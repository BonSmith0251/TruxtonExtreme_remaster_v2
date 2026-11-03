namespace DG.Tweening.Plugins.Options;

[Token(Token = "0x2000090")]
public struct VectorOptions : IPlugOptions
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018A")]
	public AxisConstraint axisConstraint; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400018B")]
	public bool snapping; //Field offset: 0x4

	[Address(RVA = "0x67EA70", Offset = "0x67DE70", Length = "0xF7")]
	[Token(Token = "0x6000361")]
	public override void Reset() { }

}

