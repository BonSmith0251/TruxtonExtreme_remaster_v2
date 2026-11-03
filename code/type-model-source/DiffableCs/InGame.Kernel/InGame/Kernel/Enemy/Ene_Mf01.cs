namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001E8")]
public class Ene_Mf01 : PawnEnemy
{
	[Token(Token = "0x40010E0")]
	private static readonly float _CircleRange; //Field offset: 0x0
	[Token(Token = "0x40010E1")]
	private static readonly float _CenterX; //Field offset: 0x4
	[Token(Token = "0x40010E2")]
	private static readonly float _CenterZ; //Field offset: 0x8
	[Token(Token = "0x40010E3")]
	private static readonly string _BulletNameIn; //Field offset: 0x10
	[Token(Token = "0x40010E4")]
	private static readonly string _BulletNameOut; //Field offset: 0x18
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x40010E5")]
	public Transform _Muzzle; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x40010E6")]
	private BulletTemplate _bulletTemplateIn; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40010E7")]
	private BulletTemplate _bulletTemplateOut; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40010E8")]
	private Vector3 _circlePos; //Field offset: 0x1C8

	[Address(RVA = "0x1DC5880", Offset = "0x1DC4C80", Length = "0xF8")]
	[Token(Token = "0x6000EB1")]
	protected virtual void _callDeadEffect() { }

	[Address(RVA = "0x1DC5B00", Offset = "0x1DC4F00", Length = "0x263")]
	[Token(Token = "0x6000EB0")]
	private void _onBulletFire(CancellationToken token, RouteEvent _event) { }

	[Address(RVA = "0x1DC5980", Offset = "0x1DC4D80", Length = "0xE8")]
	[Token(Token = "0x6000EB3")]
	private static Ene_Mf01() { }

	[Address(RVA = "0x1DC5A70", Offset = "0x1DC4E70", Length = "0x88")]
	[Token(Token = "0x6000EB2")]
	public Ene_Mf01() { }

	[Address(RVA = "0x1DC5390", Offset = "0x1DC4790", Length = "0x14B")]
	[Token(Token = "0x6000EAF")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1DC5660", Offset = "0x1DC4A60", Length = "0x9E")]
	[Token(Token = "0x6000EAB")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1DC54E0", Offset = "0x1DC48E0", Length = "0x178")]
	[Token(Token = "0x6000EAD")]
	public virtual void InitializeToPlay() { }

	[Address(RVA = "0x1DC5700", Offset = "0x1DC4B00", Length = "0x178")]
	[Token(Token = "0x6000EAE")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1DC1920", Offset = "0x1DC0D20", Length = "0x30")]
	[Token(Token = "0x6000EAC")]
	public virtual void Terminate() { }

}

