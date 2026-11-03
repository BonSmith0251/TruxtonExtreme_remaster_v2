namespace InGame.UI;

[Token(Token = "0x2000006")]
public class InGameValueGauge : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400000A")]
	protected UIImage _barImage; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400000B")]
	protected UIImage _frameImage; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000C")]
	private float _startAmount; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400000D")]
	private float _targetAmount; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000E")]
	private float _changeTime; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400000F")]
	private float _passedTime; //Field offset: 0x3C

	[Token(Token = "0x17000001")]
	protected float PassedTime
	{
		[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000002")]
	protected float TargetAmount
	{
		[Address(RVA = "0x1BBC130", Offset = "0x1BBB530", Length = "0x6")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000013")]
	public InGameValueGauge() { }

	[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
	[Token(Token = "0x6000011")]
	protected float get_PassedTime() { }

	[Address(RVA = "0x1BBC130", Offset = "0x1BBB530", Length = "0x6")]
	[Token(Token = "0x6000012")]
	protected float get_TargetAmount() { }

	[Address(RVA = "0x1DD2180", Offset = "0x1DD1580", Length = "0x20")]
	[Token(Token = "0x600000B")]
	public void Initialize() { }

	[Address(RVA = "0x1DD21A0", Offset = "0x1DD15A0", Length = "0x77")]
	[Token(Token = "0x6000010")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x1DD2220", Offset = "0x1DD1620", Length = "0x45")]
	[Token(Token = "0x600000E")]
	public void SetAlpha(float a) { }

	[Address(RVA = "0x1D39CF0", Offset = "0x1D390F0", Length = "0x44")]
	[Token(Token = "0x600000D")]
	public void SetDisplay(bool value) { }

	[Address(RVA = "0x1DD2270", Offset = "0x1DD1670", Length = "0x5A")]
	[Token(Token = "0x600000F")]
	public void SetValue(float rv, float changeTime = 0, bool isForce = false) { }

	[Address(RVA = "0x1DD22D0", Offset = "0x1DD16D0", Length = "0x39")]
	[Token(Token = "0x600000C")]
	public void Terminate() { }

}

