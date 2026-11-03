namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000206")]
public class Ene_Sj01 : PawnEnemy
{
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4001241")]
	private int _state; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x4001242")]
	private float _stateTime; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4001243")]
	private float _wave; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x4001244")]
	private float _waveRate; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4001245")]
	private float _awaySpeed; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x4001246")]
	private float _waveMult; //Field offset: 0x1C4
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4001247")]
	private float _timeLimit; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x4001248")]
	private bool _parentDie; //Field offset: 0x1CC

	[Address(RVA = "0x1D015A0", Offset = "0x1D009A0", Length = "0x483")]
	[Token(Token = "0x6000F52")]
	private void _moveState(float dt) { }

	[Address(RVA = "0x1D01550", Offset = "0x1D00950", Length = "0x49")]
	[Token(Token = "0x6000F54")]
	public Ene_Sj01() { }

	[Address(RVA = "0x1D01430", Offset = "0x1D00830", Length = "0x5E")]
	[Token(Token = "0x6000F53")]
	public virtual void CommonEvent(int num) { }

	[Address(RVA = "0x1D01490", Offset = "0x1D00890", Length = "0x6A")]
	[Token(Token = "0x6000F51")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1D01500", Offset = "0x1D00900", Length = "0x43")]
	[Token(Token = "0x6000F50")]
	public virtual void ReStart(bool withPlay) { }

}

