namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001E4")]
public class Ene_Mb01 : PawnEnemy
{
	[Token(Token = "0x40010BE")]
	private static readonly List<List`1<RouteEvent>> _routeEventLists; //Field offset: 0x0
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40010BF")]
	private EnemyData _enemyData; //Field offset: 0x1B0

	[Address(RVA = "0x1DBFB80", Offset = "0x1DBEF80", Length = "0x1452")]
	[Token(Token = "0x6000E9B")]
	private static Ene_Mb01() { }

	[Address(RVA = "0x1DC0FE0", Offset = "0x1DC03E0", Length = "0x49")]
	[Token(Token = "0x6000E9A")]
	public Ene_Mb01() { }

	[Address(RVA = "0x1DBF1C0", Offset = "0x1DBE5C0", Length = "0x30A")]
	[Token(Token = "0x6000E97")]
	public virtual void CreateRouteData(EnemyData sourceData, Vector3 startPosition) { }

	[Address(RVA = "0x1DBF4D0", Offset = "0x1DBE8D0", Length = "0x39A")]
	[Token(Token = "0x6000E98")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1DBF870", Offset = "0x1DBEC70", Length = "0x302")]
	[Token(Token = "0x6000E99")]
	public virtual List<String> GetRouteNames() { }

}

