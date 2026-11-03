namespace InGame.Kernel.Enemy;

[Token(Token = "0x200021B")]
public class MeteoEnemy : PawnEnemy
{
	[Token(Token = "0x40012F5")]
	private const float LimitTime = 15; //Field offset: 0x0
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40012F6")]
	private Quaternion _startRotate; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40012F7")]
	private float _outScreenTime; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x40012F8")]
	private float _limitTtimer; //Field offset: 0x1C4
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40012F9")]
	private bool _inScreen; //Field offset: 0x1C8

	[Address(RVA = "0x1D0C5F0", Offset = "0x1D0B9F0", Length = "0x7D")]
	[Token(Token = "0x6000FDD")]
	public MeteoEnemy() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000FDA")]
	protected virtual string GetDebugString() { }

	[Address(RVA = "0x1D0C4A0", Offset = "0x1D0B8A0", Length = "0x50")]
	[Token(Token = "0x6000FDB")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1D0C500", Offset = "0x1D0B900", Length = "0x2E")]
	[Token(Token = "0x6000FD6")]
	public virtual void InitializeToPlay() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000FD7")]
	public virtual bool IsDestroyRateTarget() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000FD9")]
	public virtual bool IsPhysicsMove() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000FD8")]
	public virtual bool IsPoseRecord() { }

	[Address(RVA = "0x1D0C530", Offset = "0x1D0B930", Length = "0xBC")]
	[Token(Token = "0x6000FDC")]
	protected virtual void ProgressEvent(float dt, int eventCount) { }

}

