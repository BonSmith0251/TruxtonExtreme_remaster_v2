namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001EC")]
public class Ene_Mj01b : PawnEnemy
{
	[Token(Token = "0x20001ED")]
	private enum STATE : int
	{
		READY = -1,
		SPLINE_MOVE = 0,
		WAIT = 1,
		AWAY = 2,
		EXIT = 3,
	}

	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4001103")]
	private STATE _state; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x4001104")]
	private Vector3 _stopPos; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4001105")]
	private Func<PawnEnemy, Boolean> _callback; //Field offset: 0x1C0

	[Address(RVA = "0x1DC7040", Offset = "0x1DC6440", Length = "0x49")]
	[Token(Token = "0x6000EC4")]
	public Ene_Mj01b() { }

	[Address(RVA = "0x1DC6CA0", Offset = "0x1DC60A0", Length = "0x11")]
	[Token(Token = "0x6000EBD")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1DC6CC0", Offset = "0x1DC60C0", Length = "0xB")]
	[Token(Token = "0x6000EC2")]
	public bool IsStarted() { }

	[Address(RVA = "0x1DC6CD0", Offset = "0x1DC60D0", Length = "0x1ED")]
	[Token(Token = "0x6000EBF")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1DC6EC0", Offset = "0x1DC62C0", Length = "0x12")]
	[Token(Token = "0x6000EBC")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[Token(Token = "0x6000EC1")]
	public void SetKillSendCallback(Func<PawnEnemy, Boolean> cb) { }

	[Address(RVA = "0x1DC6F00", Offset = "0x1DC6300", Length = "0x68")]
	[Token(Token = "0x6000EC0")]
	public void SetParentKilled() { }

	[Address(RVA = "0x1CDAF40", Offset = "0x1CDA340", Length = "0x7")]
	[Token(Token = "0x6000EC3")]
	private void SetState(STATE ts) { }

	[Address(RVA = "0x1DC6F70", Offset = "0x1DC6370", Length = "0xCE")]
	[Token(Token = "0x6000EBE")]
	public virtual void ToDestroid() { }

}

