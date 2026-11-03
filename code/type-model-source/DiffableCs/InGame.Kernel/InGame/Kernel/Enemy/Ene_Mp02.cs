namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001FE")]
public class Ene_Mp02 : PawnEnemy
{
	[Token(Token = "0x20001FF")]
	internal class RouteNameArraClass
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001206")]
		public String[] arrays; //Field offset: 0x10

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000F30")]
		public RouteNameArraClass(String[] _arrays) { }

	}

	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x4001203")]
	private Kind _item; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4001204")]
	private EnemyData _enemyData; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[Token(Token = "0x4001205")]
	private RouteNameArraClass[] _routeNames; //Field offset: 0x1C0

	[Address(RVA = "0x1CFDBD0", Offset = "0x1CFCFD0", Length = "0x1E5")]
	[Token(Token = "0x6000F2E")]
	protected virtual void _callDeadEffect() { }

	[Address(RVA = "0x1CFDDC0", Offset = "0x1CFD1C0", Length = "0x49")]
	[Token(Token = "0x6000F2F")]
	public Ene_Mp02() { }

	[Address(RVA = "0x1CFD8C0", Offset = "0x1CFCCC0", Length = "0x20B")]
	[Token(Token = "0x6000F2C")]
	public virtual void CreateRouteData(EnemyData sourceData, Vector3 startPosition) { }

	[Address(RVA = "0x1CFDAD0", Offset = "0x1CFCED0", Length = "0xFD")]
	[Token(Token = "0x6000F2D")]
	public virtual List<String> GetRouteNames() { }

}

