namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000211")]
public class Ene_TimeUp : PawnEnemy
{
	[Token(Token = "0x40012B6")]
	private const string BulletName = "timeup_fire"; //Field offset: 0x0
	[Token(Token = "0x40012BB")]
	private const float FireIntervalMax = 1; //Field offset: 0x0
	[Token(Token = "0x40012BC")]
	private const float FireIntervalMin = 0.2; //Field offset: 0x0
	[Token(Token = "0x40012BD")]
	private const float FireIntervalDec = 0.05; //Field offset: 0x0
	[Token(Token = "0x40012BE")]
	private const float FireIntervalInt = 2.5; //Field offset: 0x0
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40012B7")]
	private BulletTemplate _bt; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x40012B8")]
	private float _fireTimer; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x40012B9")]
	private float _fireInterval; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40012BA")]
	private float _intervalTimer; //Field offset: 0x1C0

	[Address(RVA = "0x1D08AE0", Offset = "0x1D07EE0", Length = "0x244")]
	[Token(Token = "0x6000F8E")]
	private void _update() { }

	[Address(RVA = "0x1D08A90", Offset = "0x1D07E90", Length = "0x49")]
	[Token(Token = "0x6000F90")]
	public Ene_TimeUp() { }

	[Address(RVA = "0x1D08890", Offset = "0x1D07C90", Length = "0xB9")]
	[Token(Token = "0x6000F8F")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1D08950", Offset = "0x1D07D50", Length = "0x20")]
	[Token(Token = "0x6000F8D")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1D08970", Offset = "0x1D07D70", Length = "0x11B")]
	[Token(Token = "0x6000F8C")]
	public virtual void ReStart(bool withPlay) { }

}

