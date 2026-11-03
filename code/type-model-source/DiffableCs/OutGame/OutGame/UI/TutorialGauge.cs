namespace OutGame.UI;

[Token(Token = "0x2000149")]
public class TutorialGauge : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40005B3")]
	private GameObject _OKMark; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40005B4")]
	private InGameValueGauge _gauge; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005B5")]
	private float _gaugeAlpha; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40005B6")]
	private float _gaugeRate; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005B7")]
	private float _okRate; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40005B8")]
	private bool _isAction; //Field offset: 0x3C
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x40005B9")]
	private bool _isOKDisplay; //Field offset: 0x3D
	[FieldOffset(Offset = "0x3E")]
	[Token(Token = "0x40005BA")]
	private bool _isOKSEPlay; //Field offset: 0x3E

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000833")]
	public TutorialGauge() { }

	[Address(RVA = "0x22073B0", Offset = "0x22067B0", Length = "0x31")]
	[Token(Token = "0x600082F")]
	public void EndAction() { }

	[Address(RVA = "0x22073F0", Offset = "0x22067F0", Length = "0x46")]
	[Token(Token = "0x600082D")]
	public void Initialize() { }

	[Address(RVA = "0x2207440", Offset = "0x2206840", Length = "0x17B")]
	[Token(Token = "0x6000832")]
	private void OKDisplay(float dt) { }

	[Address(RVA = "0x22075C0", Offset = "0x22069C0", Length = "0x7D")]
	[Token(Token = "0x6000830")]
	public void SetRate(float trate) { }

	[Address(RVA = "0x2207640", Offset = "0x2206A40", Length = "0x5E")]
	[Token(Token = "0x600082E")]
	public void StartAction() { }

	[Address(RVA = "0x22076A0", Offset = "0x2206AA0", Length = "0x22D")]
	[Token(Token = "0x6000831")]
	private void Update() { }

}

