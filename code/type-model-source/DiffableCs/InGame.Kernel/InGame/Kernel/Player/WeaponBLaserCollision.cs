namespace InGame.Kernel.Player;

[Token(Token = "0x2000129")]
public class WeaponBLaserCollision : WeaponLaserCollision
{
	[Token(Token = "0x4000853")]
	protected static readonly float _laserLimitXT; //Field offset: 0x0
	[Token(Token = "0x4000854")]
	protected static readonly Vector3 _laserLimitD2; //Field offset: 0x4
	[FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	[Token(Token = "0x400084F")]
	private GameObject _muzzleEffect; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000850")]
	private bool _isLaserOutside; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F4")]
	[Token(Token = "0x4000851")]
	private Vector3 _outsidePosition; //Field offset: 0x1F4
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000852")]
	private Vector3 _outSideStart; //Field offset: 0x200
	[FieldOffset(Offset = "0x20C")]
	[Token(Token = "0x4000855")]
	protected Vector3 _laserLimitLS; //Field offset: 0x20C
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000856")]
	protected Vector3 _laserLimitRS; //Field offset: 0x218
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000857")]
	protected Vector3 _laserLimitBS; //Field offset: 0x224

	[Address(RVA = "0x1D57570", Offset = "0x1D56970", Length = "0x9B")]
	[Token(Token = "0x6000938")]
	private static WeaponBLaserCollision() { }

	[Address(RVA = "0x1D57610", Offset = "0x1D56A10", Length = "0x1A4")]
	[Token(Token = "0x6000937")]
	public WeaponBLaserCollision() { }

	[Address(RVA = "0x1D56DC0", Offset = "0x1D561C0", Length = "0x6B8")]
	[Token(Token = "0x6000936")]
	protected virtual void ProgressDirection(Transform _root, HybridCollisionBridge _moreNear, Vector3 lpos, float lSpeed) { }

	[Address(RVA = "0x1D57480", Offset = "0x1D56880", Length = "0x77")]
	[Token(Token = "0x6000934")]
	protected virtual void ProgressLockOn() { }

	[Address(RVA = "0x1D57500", Offset = "0x1D56900", Length = "0x4A")]
	[Token(Token = "0x6000933")]
	public virtual void StartMove(Vector3 tDir, float tSpeed) { }

	[Address(RVA = "0x1D57550", Offset = "0x1D56950", Length = "0x17")]
	[Token(Token = "0x6000935")]
	public virtual void StopMuzzle() { }

}

