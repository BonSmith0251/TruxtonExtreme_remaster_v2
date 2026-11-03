namespace InGame.Kernel;

[Token(Token = "0x20000B1")]
public class SimpleMoveRocket : SimpleMove
{
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x4000555")]
	[Tooltip("初期速度")]
	private float FirstTimeSpeed; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[SerializeField]
	[Token(Token = "0x4000556")]
	[Tooltip("減速終了秒")]
	private float decelerationTime; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000557")]
	[Tooltip("最小速度係数")]
	private float minDecelerationRate; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	[Token(Token = "0x4000558")]
	[Tooltip("最小速度維持時間")]
	private float minSpeedTime; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x4000559")]
	[Tooltip("最高速到達時間")]
	private float accelerationTime; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[SerializeField]
	[Token(Token = "0x400055A")]
	private BulletSE _fireSound; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x400055B")]
	private float _fireSoundSec; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x400055C")]
	private float _initialSpeed; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400055D")]
	private float _localTime; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x400055E")]
	private float _SEplayTime; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400055F")]
	private bool _isSEPlay; //Field offset: 0x110

	[Address(RVA = "0x1D42AE0", Offset = "0x1D41EE0", Length = "0xA7")]
	[Token(Token = "0x600066F")]
	protected virtual void _updateMove(float dt) { }

	[Address(RVA = "0x1D42A80", Offset = "0x1D41E80", Length = "0x57")]
	[Token(Token = "0x6000673")]
	public SimpleMoveRocket() { }

	[Address(RVA = "0x1D42770", Offset = "0x1D41B70", Length = "0x9")]
	[Token(Token = "0x6000670")]
	public virtual float GetFirstSpeed() { }

	[Address(RVA = "0x1D42780", Offset = "0x1D41B80", Length = "0xFB")]
	[Token(Token = "0x600066E")]
	public virtual void StartMove(Vector3 s, Vector3 ndir, float speedRate, bool isLookAt = false, MoveType mt = 0) { }

	[Address(RVA = "0x1D42880", Offset = "0x1D41C80", Length = "0x8F")]
	[Token(Token = "0x6000671")]
	private void UpdateSound(float dt) { }

	[Address(RVA = "0x1D42910", Offset = "0x1D41D10", Length = "0x167")]
	[Token(Token = "0x6000672")]
	private void UpdateSpeed(float dt) { }

}

