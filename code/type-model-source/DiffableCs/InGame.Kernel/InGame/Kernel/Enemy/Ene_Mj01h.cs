namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001EE")]
public class Ene_Mj01h : KnightEnemy
{
	[Token(Token = "0x4001112")]
	public static readonly Vector3 gravityVector; //Field offset: 0x0
	[Token(Token = "0x4001113")]
	private static readonly float _unitDistance; //Field offset: 0xC
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400110C")]
	private Vector3 _startPosition; //Field offset: 0x210
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x400110D")]
	private float _passed; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400110E")]
	private int _callCount; //Field offset: 0x220
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x400110F")]
	private int _killCount; //Field offset: 0x224
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4001110")]
	private bool _moveEnd; //Field offset: 0x228
	[FieldOffset(Offset = "0x229")]
	[Token(Token = "0x4001111")]
	private bool _breakChildren; //Field offset: 0x229

	[Address(RVA = "0x1DC7D70", Offset = "0x1DC7170", Length = "0x253")]
	[Token(Token = "0x6000EC9")]
	protected virtual void _callDeadEffect() { }

	[Address(RVA = "0x1DC7FD0", Offset = "0x1DC73D0", Length = "0x62")]
	[Token(Token = "0x6000ED0")]
	private static Ene_Mj01h() { }

	[Address(RVA = "0x1DC8040", Offset = "0x1DC7440", Length = "0x7")]
	[Token(Token = "0x6000ECF")]
	public Ene_Mj01h() { }

	[Address(RVA = "0x1DC7090", Offset = "0x1DC6490", Length = "0x1AB")]
	[Token(Token = "0x6000ECC")]
	private void CallMJ01Body(float dt) { }

	[Address(RVA = "0x1DC7240", Offset = "0x1DC6640", Length = "0x329")]
	[Token(Token = "0x6000EC6")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1DC7570", Offset = "0x1DC6970", Length = "0x1C")]
	[Token(Token = "0x6000ECB")]
	private bool IsCallChildren() { }

	[Address(RVA = "0x1DC7590", Offset = "0x1DC6990", Length = "0x2F5")]
	[Token(Token = "0x6000ECA")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1DC8050", Offset = "0x1DC7450", Length = "0x12A")]
	[Token(Token = "0x6000EC8")]
	private void moveEndCallback() { }

	[Address(RVA = "0x1DC78B0", Offset = "0x1DC6CB0", Length = "0x22A")]
	[Token(Token = "0x6000EC7")]
	private bool ReceiveKill(PawnEnemy pe) { }

	[Address(RVA = "0x1DC7890", Offset = "0x1DC6C90", Length = "0x20")]
	[Token(Token = "0x6000EC5")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1DC7AE0", Offset = "0x1DC6EE0", Length = "0x1AA")]
	[Token(Token = "0x6000ECD")]
	private void SendMessage() { }

	[Address(RVA = "0x1DC7C90", Offset = "0x1DC7090", Length = "0xD3")]
	[Token(Token = "0x6000ECE")]
	public virtual EnemyChildData[] SubEnemys() { }

}

