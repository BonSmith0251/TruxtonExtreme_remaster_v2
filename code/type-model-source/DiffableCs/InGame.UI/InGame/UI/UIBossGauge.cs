namespace InGame.UI;

[Token(Token = "0x2000012")]
public class UIBossGauge : MonoBehaviour
{
	[Token(Token = "0x4000040")]
	public static readonly float defaultBossTimeMax; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000041")]
	private InGameValueGauge _lifeGauge; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000042")]
	private TXESpriteValue _mTime; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000043")]
	private TXESpriteValue _sTime; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000044")]
	private UIImage _separate; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000045")]
	private CanvasGroup _canvasGroup; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000046")]
	private float _bossTimeMax; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000047")]
	private float _remainSecond; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000048")]
	private bool isInitialized; //Field offset: 0x50

	[Token(Token = "0x17000005")]
	public int RemainSecond
	{
		[Address(RVA = "0x1DD51B0", Offset = "0x1DD45B0", Length = "0x55")]
		[Token(Token = "0x6000055")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x1DD5170", Offset = "0x1DD4570", Length = "0x39")]
	[Token(Token = "0x6000057")]
	private static UIBossGauge() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000056")]
	public UIBossGauge() { }

	[Address(RVA = "0x1DD51B0", Offset = "0x1DD45B0", Length = "0x55")]
	[Token(Token = "0x6000055")]
	public int get_RemainSecond() { }

	[Address(RVA = "0x1DD49B0", Offset = "0x1DD3DB0", Length = "0xA0")]
	[Token(Token = "0x600004B")]
	public void Initialize() { }

	[Address(RVA = "0x1DD4A60", Offset = "0x1DD3E60", Length = "0x35")]
	[Token(Token = "0x6000054")]
	public void Progress(float dt) { }

	[Address(RVA = "0x1DD4AA0", Offset = "0x1DD3EA0", Length = "0xAE")]
	[Token(Token = "0x600004E")]
	public void Reset() { }

	[Address(RVA = "0x1DD4B50", Offset = "0x1DD3F50", Length = "0x1E")]
	[Token(Token = "0x6000053")]
	public void SetAlpha(float talpha) { }

	[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
	[Token(Token = "0x6000052")]
	public void SetBossTimeMax(float tsec) { }

	[Address(RVA = "0x1DD4B80", Offset = "0x1DD3F80", Length = "0x8B")]
	[Token(Token = "0x6000050")]
	public void SetColor(Color tcolor) { }

	[Address(RVA = "0x1DD4C10", Offset = "0x1DD4010", Length = "0x71")]
	[Token(Token = "0x600004D")]
	public void SetDisplay(bool isDisplay) { }

	[Address(RVA = "0x1DD4EF0", Offset = "0x1DD42F0", Length = "0x1A2")]
	[Token(Token = "0x600004F")]
	public int SetValue(int mv, int sv, float grate, float changeTime, bool isForce) { }

	[Address(RVA = "0x1DD4C90", Offset = "0x1DD4090", Length = "0x255")]
	[Token(Token = "0x6000051")]
	public void SetValuePassTime(float passTime, float grate, float changeTime = 0) { }

	[Address(RVA = "0x1DD50A0", Offset = "0x1DD44A0", Length = "0xC1")]
	[Token(Token = "0x600004C")]
	public void Terminate() { }

}

