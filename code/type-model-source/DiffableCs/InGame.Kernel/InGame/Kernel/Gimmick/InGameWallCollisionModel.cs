namespace InGame.Kernel.Gimmick;

[Token(Token = "0x2000149")]
public class InGameWallCollisionModel : InGameCollisionModel
{
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000958")]
	private Vector3[] _anchorPoints; //Field offset: 0x78

	[Address(RVA = "0x1D6F4C0", Offset = "0x1D6E8C0", Length = "0x7")]
	[Token(Token = "0x6000A42")]
	public InGameWallCollisionModel() { }

	[Address(RVA = "0x1D6F050", Offset = "0x1D6E450", Length = "0x274")]
	[Token(Token = "0x6000A40")]
	public virtual void LateUpdatePosition(Vector3 pos, Quaternion _rotateZ, float lscale) { }

	[Address(RVA = "0x1D6F2D0", Offset = "0x1D6E6D0", Length = "0x1D")]
	[Token(Token = "0x6000A3F")]
	public virtual void OwnerFinish() { }

	[Address(RVA = "0x1D6F2F0", Offset = "0x1D6E6F0", Length = "0xA")]
	[Token(Token = "0x6000A3E")]
	public virtual void SetInArea(bool isinArea) { }

	[Address(RVA = "0x1D6F300", Offset = "0x1D6E700", Length = "0x1B7")]
	[Token(Token = "0x6000A41")]
	private void UpdateCollisionModel() { }

}

