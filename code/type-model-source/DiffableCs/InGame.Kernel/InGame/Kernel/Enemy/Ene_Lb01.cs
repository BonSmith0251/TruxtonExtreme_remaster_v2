namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001DD")]
public class Ene_Lb01 : PawnEnemyDD
{
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4001076")]
	private EnemyData _enemyData; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	[Token(Token = "0x4001077")]
	private String[] _routeNames; //Field offset: 0x1D8

	[Address(RVA = "0x1DBCE50", Offset = "0x1DBC250", Length = "0x7")]
	[Token(Token = "0x6000E73")]
	public Ene_Lb01() { }

	[Address(RVA = "0x1DBCC90", Offset = "0x1DBC090", Length = "0x12B")]
	[Token(Token = "0x6000E70")]
	public virtual void CreateRouteData(EnemyData sourceData, Vector3 startPosition) { }

	[Address(RVA = "0x1DBCDC0", Offset = "0x1DBC1C0", Length = "0x64")]
	[Token(Token = "0x6000E72")]
	public virtual List<String> GetRouteNames() { }

	[Address(RVA = "0x1DBCE30", Offset = "0x1DBC230", Length = "0x1F")]
	[Token(Token = "0x6000E71")]
	public virtual void ToDestroid() { }

}

