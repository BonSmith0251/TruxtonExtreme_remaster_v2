namespace InGame.UI;

[Token(Token = "0x2000008")]
public class InGameValueLevel : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000013")]
	private UILamp[] _lampImage; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000014")]
	private TXESpriteValue _levelNumber; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000015")]
	private int _numLamp; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000016")]
	private int _numLevel; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000017")]
	private int _lampMax; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000018")]
	private int _delayTime; //Field offset: 0x3C

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600001C")]
	public InGameValueLevel() { }

	[Address(RVA = "0x1DD2440", Offset = "0x1DD1840", Length = "0x166")]
	[Token(Token = "0x6000018")]
	public void Initialize() { }

	[Address(RVA = "0x1DD25B0", Offset = "0x1DD19B0", Length = "0x88")]
	[Token(Token = "0x600001B")]
	public void Progress(float dt) { }

	[Address(RVA = "0x1DD2640", Offset = "0x1DD1A40", Length = "0x11F")]
	[Token(Token = "0x600001A")]
	public void SetValue(int nlamp, int nlevel, bool isLevelup, bool isForce = false) { }

	[Address(RVA = "0x1DD2760", Offset = "0x1DD1B60", Length = "0x1D")]
	[Token(Token = "0x6000019")]
	public void Terminate() { }

}

