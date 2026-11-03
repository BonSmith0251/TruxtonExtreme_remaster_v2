namespace DG.Tweening.Plugins.Options;

[Token(Token = "0x2000088")]
public struct QuaternionOptions : IPlugOptions
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000179")]
	public RotateMode rotateMode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400017A")]
	public AxisConstraint axisConstraint; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400017B")]
	public Vector3 up; //Field offset: 0x8
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400017C")]
	public bool dynamicLookAt; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400017D")]
	public Vector3 dynamicLookAtWorldPosition; //Field offset: 0x18

	[Address(RVA = "0x66FBC0", Offset = "0x66EFC0", Length = "0x89")]
	[Token(Token = "0x6000359")]
	public override void Reset() { }

}

