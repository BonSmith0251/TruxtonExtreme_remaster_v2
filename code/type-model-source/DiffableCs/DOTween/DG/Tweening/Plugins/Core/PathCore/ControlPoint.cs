namespace DG.Tweening.Plugins.Core.PathCore;

[Token(Token = "0x2000098")]
public struct ControlPoint
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001A0")]
	public Vector3 a; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001A1")]
	public Vector3 b; //Field offset: 0xC

	[Address(RVA = "0x665C80", Offset = "0x665080", Length = "0x20")]
	[Token(Token = "0x600037D")]
	public ControlPoint(Vector3 a, Vector3 b) { }

	[Address(RVA = "0x665CA0", Offset = "0x6650A0", Length = "0x8C")]
	[Token(Token = "0x600037E")]
	public static ControlPoint op_Addition(ControlPoint cp, Vector3 v) { }

	[Address(RVA = "0x665B60", Offset = "0x664F60", Length = "0x11C")]
	[Token(Token = "0x600037F")]
	public virtual string ToString() { }

}

