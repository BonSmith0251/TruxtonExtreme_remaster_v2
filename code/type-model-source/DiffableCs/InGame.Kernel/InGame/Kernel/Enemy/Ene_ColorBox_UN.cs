namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001D9")]
public class Ene_ColorBox_UN : PawnEnemyGround
{
	[Token(Token = "0x400105F")]
	private static readonly float FlushSecondsMax; //Field offset: 0x0
	[Token(Token = "0x4001060")]
	private static readonly float BaseTransparency; //Field offset: 0x4
	[Token(Token = "0x4001061")]
	private static readonly int _PropertyTransparency; //Field offset: 0x8
	[FieldOffset(Offset = "0x200")]
	[SerializeField]
	[Token(Token = "0x4001062")]
	private Renderer _renderer; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4001063")]
	private Material _material; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4001064")]
	private float _FlushSeconds; //Field offset: 0x210

	[Address(RVA = "0x1DBB8F0", Offset = "0x1DBACF0", Length = "0x79")]
	[Token(Token = "0x6000E56")]
	private static Ene_ColorBox_UN() { }

	[Address(RVA = "0x1DBB970", Offset = "0x1DBAD70", Length = "0x49")]
	[Token(Token = "0x6000E55")]
	public Ene_ColorBox_UN() { }

	[Address(RVA = "0x1DBB410", Offset = "0x1DBA810", Length = "0xAC")]
	[Token(Token = "0x6000E51")]
	public virtual bool AddDamageOwner(float n) { }

	[Address(RVA = "0x1DBB4C0", Offset = "0x1DBA8C0", Length = "0x18E")]
	[Token(Token = "0x6000E53")]
	protected virtual bool DropItem(Kind dkind, Transform root, Vector3 curpos, float alivetime) { }

	[Address(RVA = "0x1DBB650", Offset = "0x1DBAA50", Length = "0xCB")]
	[Token(Token = "0x6000E4F")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1DBB720", Offset = "0x1DBAB20", Length = "0x112")]
	[Token(Token = "0x6000E54")]
	protected virtual void PartsFlushUpdate(float delta) { }

	[Address(RVA = "0x1DBB840", Offset = "0x1DBAC40", Length = "0xAD")]
	[Token(Token = "0x6000E50")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D17FD0", Offset = "0x1D173D0", Length = "0x7")]
	[Token(Token = "0x6000E52")]
	public virtual void SetDropItem(Kind ditem) { }

}

