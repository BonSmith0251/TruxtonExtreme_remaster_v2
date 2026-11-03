namespace InGame.Kernel;

[Token(Token = "0x200001A")]
public class InGameBulletTrail : InGameBullet
{
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x40000C6")]
	private Transform _trailHead; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x40000C7")]
	private Transform[] _trails; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40000C8")]
	private MeshRenderer[] _trailImage; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40000C9")]
	private Single[] _trailValue; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40000CA")]
	private int _trailCount; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x40000CB")]
	private int _trailDisplayCount; //Field offset: 0x114

	[Address(RVA = "0x1CCD910", Offset = "0x1CCCD10", Length = "0x49")]
	[Token(Token = "0x6000106")]
	public InGameBulletTrail() { }

	[Address(RVA = "0x1CCD310", Offset = "0x1CCC710", Length = "0x1E5")]
	[Token(Token = "0x6000101")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1CCD500", Offset = "0x1CCC900", Length = "0x31")]
	[Token(Token = "0x6000104")]
	public virtual void ProgressBullet(float dt) { }

	[Address(RVA = "0x1CCD540", Offset = "0x1CCC940", Length = "0xDF")]
	[Token(Token = "0x6000103")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1CCD620", Offset = "0x1CCCA20", Length = "0x51")]
	[Token(Token = "0x6000102")]
	public virtual void Terminate() { }

	[Address(RVA = "0x1CCD680", Offset = "0x1CCCA80", Length = "0x28A")]
	[Token(Token = "0x6000105")]
	private void UpdateTrailDisplay(float dt) { }

}

