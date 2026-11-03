namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001E7")]
public class Ene_Md01 : PawnEnemy
{
	[Token(Token = "0x40010CD")]
	private const string MOVE_ENTER = "common_D100"; //Field offset: 0x0
	[Token(Token = "0x40010DB")]
	private static readonly RouteEvent bullet1; //Field offset: 0x0
	[Token(Token = "0x40010DA")]
	private const string MOVE_Rx4 = "common_R160"; //Field offset: 0x0
	[Token(Token = "0x40010D9")]
	private const string MOVE_Rx2 = "common_R80"; //Field offset: 0x0
	[Token(Token = "0x40010D8")]
	private const string MOVE_Rx1 = "common_R40"; //Field offset: 0x0
	[Token(Token = "0x40010D7")]
	private const string MOVE_R05 = "common_R20"; //Field offset: 0x0
	[Token(Token = "0x40010D5")]
	private const string MOVE_Lx2 = "common_L80"; //Field offset: 0x0
	[Token(Token = "0x40010D6")]
	private const string MOVE_Lx4 = "common_L160"; //Field offset: 0x0
	[Token(Token = "0x40010D3")]
	private const string MOVE_L05 = "common_L20"; //Field offset: 0x0
	[Token(Token = "0x40010D2")]
	private const string MOVE_Dx2 = "common_D60"; //Field offset: 0x0
	[Token(Token = "0x40010D1")]
	private const string MOVE_Dx1 = "common_D30"; //Field offset: 0x0
	[Token(Token = "0x40010D0")]
	private const string MOVE_Ux2 = "common_U60"; //Field offset: 0x0
	[Token(Token = "0x40010CF")]
	private const string MOVE_Ux1 = "common_U30"; //Field offset: 0x0
	[Token(Token = "0x40010CE")]
	private const string MOVE_LEAVE = "common_D200"; //Field offset: 0x0
	[Token(Token = "0x40010D4")]
	private const string MOVE_Lx1 = "common_L40"; //Field offset: 0x0
	[Token(Token = "0x40010DC")]
	private static readonly RouteEvent bullet2; //Field offset: 0x8
	[Token(Token = "0x40010DD")]
	private static readonly RouteEvent bullet3; //Field offset: 0x10
	[Token(Token = "0x40010DE")]
	private static readonly List<List`1<RouteEvent>> _routeEventLists; //Field offset: 0x18
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40010DF")]
	private EnemyData _enemyData; //Field offset: 0x1B0

	[Address(RVA = "0x1DC2420", Offset = "0x1DC1820", Length = "0x2F1F")]
	[Token(Token = "0x6000EAA")]
	private static Ene_Md01() { }

	[Address(RVA = "0x1DC5340", Offset = "0x1DC4740", Length = "0x49")]
	[Token(Token = "0x6000EA9")]
	public Ene_Md01() { }

	[Address(RVA = "0x1DC1C10", Offset = "0x1DC1010", Length = "0x13A")]
	[Token(Token = "0x6000EA6")]
	public virtual void CreateRouteData(EnemyData sourceData, Vector3 startPosition) { }

	[Address(RVA = "0x1DC1D50", Offset = "0x1DC1150", Length = "0x3BA")]
	[Token(Token = "0x6000EA7")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1DC2110", Offset = "0x1DC1510", Length = "0x302")]
	[Token(Token = "0x6000EA8")]
	public virtual List<String> GetRouteNames() { }

}

