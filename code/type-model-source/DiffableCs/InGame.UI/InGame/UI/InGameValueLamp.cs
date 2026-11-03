namespace InGame.UI;

[Token(Token = "0x2000007")]
public class InGameValueLamp : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000010")]
	private UIImage[] _lampImage; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000011")]
	private int _lampLevel; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000012")]
	private int _lampMax; //Field offset: 0x2C

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000017")]
	public InGameValueLamp() { }

	[Address(RVA = "0x1DD2310", Offset = "0x1DD1710", Length = "0x8E")]
	[Token(Token = "0x6000014")]
	public void Initialize() { }

	[Address(RVA = "0x1DD23A0", Offset = "0x1DD17A0", Length = "0x91")]
	[Token(Token = "0x6000016")]
	public void SetValue(int nlevel, bool isForce = false) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000015")]
	public void Terminate() { }

}

