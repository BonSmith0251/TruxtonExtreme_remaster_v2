namespace InGame.Kernel.UI;

[Token(Token = "0x20000BB")]
public class PauseCountDown : MonoBehaviour
{
	[Token(Token = "0x4000596")]
	private static readonly float OneDisplayTime; //Field offset: 0x0
	[Token(Token = "0x4000597")]
	private static readonly float OneFadeStartTime; //Field offset: 0x4
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000598")]
	private UIImage _numImage; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000599")]
	private UIImage _readyImage; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400059A")]
	private Sprite[] _nums; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400059B")]
	private Action _callback; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400059C")]
	private int _index; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400059D")]
	private float _waitTime; //Field offset: 0x44

	[Address(RVA = "0x1D39E90", Offset = "0x1D39290", Length = "0x4E")]
	[Token(Token = "0x60006CD")]
	private static PauseCountDown() { }

	[Address(RVA = "0x1D39EE0", Offset = "0x1D392E0", Length = "0x55")]
	[Token(Token = "0x60006CC")]
	public PauseCountDown() { }

	[Address(RVA = "0x1D39B50", Offset = "0x1D38F50", Length = "0x19A")]
	[Token(Token = "0x60006CB")]
	private void CountDown() { }

	[Address(RVA = "0x1D39CF0", Offset = "0x1D390F0", Length = "0x44")]
	[Token(Token = "0x60006C7")]
	public void SetDisplay(bool isDisplay) { }

	[Address(RVA = "0x1D39D40", Offset = "0x1D39140", Length = "0xED")]
	[Token(Token = "0x60006C8")]
	public void StartCountDown(Action tcallback) { }

	[Address(RVA = "0x1D39E70", Offset = "0x1D39270", Length = "0x15")]
	[Token(Token = "0x60006C9")]
	private void Update() { }

	[Address(RVA = "0x1D39E30", Offset = "0x1D39230", Length = "0x3E")]
	[Token(Token = "0x60006CA")]
	private void UpdateSprite() { }

}

