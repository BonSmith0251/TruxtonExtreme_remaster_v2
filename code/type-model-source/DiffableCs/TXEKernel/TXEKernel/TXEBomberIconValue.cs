namespace TXEKernel;

[Token(Token = "0x200010E")]
public class TXEBomberIconValue : MonoBehaviour
{
	[Token(Token = "0x4000562")]
	private static readonly Color[] _bombColors; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000563")]
	private TXESpriteRepeatValue _bomberStock; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000564")]
	private UIImage _gaugeArea; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000565")]
	private UIImage _lastOne; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000566")]
	private float _lastOneAlpha; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000567")]
	private int _armLevel; //Field offset: 0x3C

	[Address(RVA = "0x27265B0", Offset = "0x27259B0", Length = "0x127")]
	[Token(Token = "0x60007AE")]
	private static TXEBomberIconValue() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60007AD")]
	public TXEBomberIconValue() { }

	[Address(RVA = "0x2726250", Offset = "0x2725650", Length = "0x11E")]
	[Token(Token = "0x60007A8")]
	public void Initialize() { }

	[Address(RVA = "0x2726370", Offset = "0x2725770", Length = "0x78")]
	[Token(Token = "0x60007AB")]
	public void Progress(float dt) { }

	[Address(RVA = "0x27263F0", Offset = "0x27257F0", Length = "0x99")]
	[Token(Token = "0x60007AA")]
	public void SetValue(long tnum, int alevel, bool isForce = false) { }

	[Address(RVA = "0x2726490", Offset = "0x2725890", Length = "0x29")]
	[Token(Token = "0x60007A9")]
	public void Terminate() { }

	[Address(RVA = "0x27264C0", Offset = "0x27258C0", Length = "0xE4")]
	[Token(Token = "0x60007AC")]
	private void UpdateIconColor() { }

}

