namespace InGame.Kernel.Enemy;

[Token(Token = "0x200020C")]
public class Ene_Sq01 : PawnEnemy
{
	[Token(Token = "0x4001278")]
	private static readonly RouteEvent laser1; //Field offset: 0x0
	[Token(Token = "0x4001279")]
	private static readonly RouteEvent laser2; //Field offset: 0x8
	[Token(Token = "0x400127A")]
	private static readonly RouteEvent stop1; //Field offset: 0x10
	[Token(Token = "0x400127B")]
	private static readonly RouteEvent stop2; //Field offset: 0x18
	[Token(Token = "0x400127C")]
	private static readonly List<List`1<RouteEvent>> _routeEventLists; //Field offset: 0x20
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400127D")]
	private EnemyData _enemyData; //Field offset: 0x1B0

	[Address(RVA = "0x1D043A0", Offset = "0x1D037A0", Length = "0x1446")]
	[Token(Token = "0x6000F7A")]
	private static Ene_Sq01() { }

	[Address(RVA = "0x1D057F0", Offset = "0x1D04BF0", Length = "0x49")]
	[Token(Token = "0x6000F79")]
	public Ene_Sq01() { }

	[Address(RVA = "0x1D03B70", Offset = "0x1D02F70", Length = "0x152")]
	[Token(Token = "0x6000F76")]
	public virtual void CreateRouteData(EnemyData sourceData, Vector3 startPosition) { }

	[Address(RVA = "0x1D03CD0", Offset = "0x1D030D0", Length = "0x3BA")]
	[Token(Token = "0x6000F77")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1D04090", Offset = "0x1D03490", Length = "0x302")]
	[Token(Token = "0x6000F78")]
	public virtual List<String> GetRouteNames() { }

}

