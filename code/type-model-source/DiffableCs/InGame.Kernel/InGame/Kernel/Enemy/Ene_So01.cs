namespace InGame.Kernel.Enemy;

[Token(Token = "0x200020B")]
public class Ene_So01 : PawnEnemy
{
	[Token(Token = "0x4001274")]
	private static readonly float InSlowStartTime; //Field offset: 0x0
	[Token(Token = "0x4001275")]
	private static readonly float ChageTimeMax; //Field offset: 0x4
	[Token(Token = "0x4001276")]
	private static readonly float _awayAccel; //Field offset: 0x8
	[Token(Token = "0x4001277")]
	private static readonly float _awayMaxVel; //Field offset: 0xC
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x400126D")]
	private ParticleSystem _chargeEffeect; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x400126E")]
	private ParticleSystem _fireEffeect; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400126F")]
	private Vector3 _localPosition; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x4001270")]
	private float _waitTime; //Field offset: 0x1CC
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4001271")]
	private float _speed; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x4001272")]
	private int _state; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4001273")]
	private int _playerIndex; //Field offset: 0x1D8

	[Address(RVA = "0x1D035E0", Offset = "0x1D029E0", Length = "0x58D")]
	[Token(Token = "0x6000F73")]
	private void _moveState(float dt) { }

	[Address(RVA = "0x1D03510", Offset = "0x1D02910", Length = "0x78")]
	[Token(Token = "0x6000F75")]
	private static Ene_So01() { }

	[Address(RVA = "0x1D03590", Offset = "0x1D02990", Length = "0x49")]
	[Token(Token = "0x6000F74")]
	public Ene_So01() { }

	[Address(RVA = "0x1D03350", Offset = "0x1D02750", Length = "0x3C")]
	[Token(Token = "0x6000F71")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1D03390", Offset = "0x1D02790", Length = "0x131")]
	[Token(Token = "0x6000F70")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1D034D0", Offset = "0x1D028D0", Length = "0x31")]
	[Token(Token = "0x6000F72")]
	protected virtual void ProgressEvent(float dt, int eventCount) { }

}

