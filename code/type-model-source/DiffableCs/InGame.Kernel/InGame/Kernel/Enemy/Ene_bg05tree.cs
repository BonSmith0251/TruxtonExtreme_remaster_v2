namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000175")]
public class Ene_bg05tree : PawnEnemyGround
{
	[Token(Token = "0x4000AD3")]
	private static readonly Vector3 _dropItemOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x200")]
	[SerializeField]
	[Space(4)]
	[Token(Token = "0x4000AC9")]
	private string _damageBullet; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000ACA")]
	private BulletTemplate _bt; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[SerializeField]
	[Token(Token = "0x4000ACB")]
	private float _damageExpOffsetY; //Field offset: 0x210
	[FieldOffset(Offset = "0x214")]
	[SerializeField]
	[Token(Token = "0x4000ACC")]
	private int _damageShotWays; //Field offset: 0x214
	[FieldOffset(Offset = "0x218")]
	[SerializeField]
	[Token(Token = "0x4000ACD")]
	private int _damageShotCount; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000ACE")]
	private int _damageCounter; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000ACF")]
	private float _nextLevel; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[SerializeField]
	[Token(Token = "0x4000AD0")]
	private Transform _muz; //Field offset: 0x228
	[FieldOffset(Offset = "0x230")]
	[SerializeField]
	[Token(Token = "0x4000AD1")]
	private float _shotRangeL; //Field offset: 0x230
	[FieldOffset(Offset = "0x234")]
	[SerializeField]
	[Token(Token = "0x4000AD2")]
	private float _shotRangeH; //Field offset: 0x234

	[Address(RVA = "0x1D86590", Offset = "0x1D85990", Length = "0x22A")]
	[Token(Token = "0x6000BBE")]
	private void _expl() { }

	[Address(RVA = "0x1D867C0", Offset = "0x1D85BC0", Length = "0x474")]
	[Token(Token = "0x6000BBF")]
	private void _fire() { }

	[Address(RVA = "0x1D864A0", Offset = "0x1D858A0", Length = "0x4D")]
	[Token(Token = "0x6000BC2")]
	private static Ene_bg05tree() { }

	[Address(RVA = "0x1D864F0", Offset = "0x1D858F0", Length = "0x9F")]
	[Token(Token = "0x6000BC1")]
	public Ene_bg05tree() { }

	[Address(RVA = "0x1D86250", Offset = "0x1D85650", Length = "0x242")]
	[CompilerGenerated]
	[Token(Token = "0x6000BC3")]
	private void <ReStart>b__1_0() { }

	[Address(RVA = "0x1D85D20", Offset = "0x1D85120", Length = "0x2B7")]
	[Token(Token = "0x6000BBD")]
	public virtual bool AddDamageOwner(float n) { }

	[Address(RVA = "0x1D85FE0", Offset = "0x1D853E0", Length = "0xCD")]
	[Token(Token = "0x6000BC0")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1D860B0", Offset = "0x1D854B0", Length = "0xED")]
	[Token(Token = "0x6000BBB")]
	public virtual void InitializeToPlay() { }

	[Address(RVA = "0x1D861A0", Offset = "0x1D855A0", Length = "0xA8")]
	[Token(Token = "0x6000BBC")]
	public virtual void ReStart(bool withPlay) { }

}

