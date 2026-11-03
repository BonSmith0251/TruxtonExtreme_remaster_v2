namespace InGame.Kernel.Player;

[Token(Token = "0x200012D")]
public class WeaponGoldCollision : WeaponLaserCollision
{
	[Token(Token = "0x400086F")]
	private static readonly Matrix4x4 _rotLeft; //Field offset: 0x0
	[Token(Token = "0x4000873")]
	private const int ChildLaserMax = 2; //Field offset: 0x0
	[Token(Token = "0x4000870")]
	private static readonly Matrix4x4 _rotRight; //Field offset: 0x40
	[FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	[Token(Token = "0x4000871")]
	private WeaponGoldCollisionChild[] _childLasers; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000872")]
	private bool _isChildActive; //Field offset: 0x1F0

	[Address(RVA = "0x1D59E00", Offset = "0x1D59200", Length = "0xC9")]
	[Token(Token = "0x6000960")]
	private void _childLaserEnd() { }

	[Address(RVA = "0x1D59CF0", Offset = "0x1D590F0", Length = "0x105")]
	[Token(Token = "0x6000962")]
	private static WeaponGoldCollision() { }

	[Address(RVA = "0x1D59ED0", Offset = "0x1D592D0", Length = "0x7C")]
	[Token(Token = "0x6000961")]
	public WeaponGoldCollision() { }

	[Address(RVA = "0x1D59480", Offset = "0x1D58880", Length = "0x1F")]
	[Token(Token = "0x600095E")]
	public virtual void EndMove() { }

	[Address(RVA = "0x1D594A0", Offset = "0x1D588A0", Length = "0x227")]
	[Token(Token = "0x600095A")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D596D0", Offset = "0x1D58AD0", Length = "0x436")]
	[Token(Token = "0x600095D")]
	public virtual void Progress(float dt, Vector3 wpos, Transform _root) { }

	[Address(RVA = "0x1D59B10", Offset = "0x1D58F10", Length = "0xFC")]
	[Token(Token = "0x600095F")]
	public virtual void SetExBoost(bool v) { }

	[Address(RVA = "0x1D59C10", Offset = "0x1D59010", Length = "0x36")]
	[Token(Token = "0x600095C")]
	public virtual void StartMove(Vector3 tDir, float tSpeed) { }

	[Address(RVA = "0x1D59C50", Offset = "0x1D59050", Length = "0x90")]
	[Token(Token = "0x600095B")]
	public virtual void Terminate() { }

}

