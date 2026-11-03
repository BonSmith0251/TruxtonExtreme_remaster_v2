namespace InGame.Kernel.Player;

[Token(Token = "0x200012A")]
public class WeaponBombCollision : WeaponCollisionBase
{
	[Token(Token = "0x4000858")]
	private static readonly float _bombTimeMax; //Field offset: 0x0
	[Token(Token = "0x4000859")]
	private static readonly float _startScaleSize; //Field offset: 0x4
	[Token(Token = "0x400085A")]
	private static readonly float _endScaleSize; //Field offset: 0x8
	[Token(Token = "0x400085D")]
	private static readonly Single[] _endScaleSizes; //Field offset: 0x10
	[Token(Token = "0x400085E")]
	private static readonly Single[] _damageScales; //Field offset: 0x18
	[Token(Token = "0x400085F")]
	private static readonly Single[] _timeScales; //Field offset: 0x20
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400085B")]
	private float _bombTime; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x400085C")]
	private int _bombLevel; //Field offset: 0xBC

	[Address(RVA = "0x1D587A0", Offset = "0x1D57BA0", Length = "0x18B")]
	[Token(Token = "0x6000947")]
	private static WeaponBombCollision() { }

	[Address(RVA = "0x1D58930", Offset = "0x1D57D30", Length = "0x67")]
	[Token(Token = "0x6000946")]
	public WeaponBombCollision() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600093A")]
	public virtual bool AddDamageOwner(float n) { }

	[Address(RVA = "0x1D57A50", Offset = "0x1D56E50", Length = "0x8C")]
	[Token(Token = "0x600093C")]
	protected virtual float ContiniousDamage() { }

	[Address(RVA = "0x1D57AE0", Offset = "0x1D56EE0", Length = "0x8C")]
	[Token(Token = "0x600093B")]
	protected virtual float FirstDamage() { }

	[Address(RVA = "0x1D57B70", Offset = "0x1D56F70", Length = "0x117")]
	[Token(Token = "0x6000939")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D57C90", Offset = "0x1D57090", Length = "0xAC")]
	[Token(Token = "0x6000941")]
	public bool IsEndBomb(float dt) { }

	[Address(RVA = "0x1D57D40", Offset = "0x1D57140", Length = "0x1B2")]
	[Token(Token = "0x6000945")]
	private bool IsHitBomb(bool isFirst, HybridCollisionBridge tbrg, out IDamagedObject iobj) { }

	[Address(RVA = "0x1D57F00", Offset = "0x1D57300", Length = "0x6D")]
	[Token(Token = "0x600093F")]
	public virtual bool IsHitEnable() { }

	[Address(RVA = "0x1D57F70", Offset = "0x1D57370", Length = "0xAC")]
	[Token(Token = "0x6000942")]
	protected virtual void OnHitProgress(CollisionOrder aData) { }

	[Address(RVA = "0x1D58020", Offset = "0x1D57420", Length = "0x264")]
	[Token(Token = "0x6000944")]
	protected virtual void OnMultiProgress(CollisionOrder aData, bool isFirst) { }

	[Address(RVA = "0x1D58290", Offset = "0x1D57690", Length = "0xAC")]
	[Token(Token = "0x6000943")]
	protected virtual void OnStayProgress(CollisionOrder aData) { }

	[Address(RVA = "0x1D58340", Offset = "0x1D57740", Length = "0x111")]
	[Token(Token = "0x600093E")]
	public void ProgressBomb(float dt) { }

	[Address(RVA = "0x1D58460", Offset = "0x1D57860", Length = "0x28A")]
	[Token(Token = "0x600093D")]
	public void StartBomb(Vector3 s, int nlevel) { }

	[Address(RVA = "0x1D586F0", Offset = "0x1D57AF0", Length = "0xAE")]
	[Token(Token = "0x6000940")]
	public void StopBomb() { }

}

