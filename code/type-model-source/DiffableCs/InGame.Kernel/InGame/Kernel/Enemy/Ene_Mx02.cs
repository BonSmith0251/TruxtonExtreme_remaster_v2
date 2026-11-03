namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000200")]
public class Ene_Mx02 : PawnEnemy
{
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x4001207")]
	private Kind _item; //Field offset: 0x1B0

	[Address(RVA = "0x1CFDE10", Offset = "0x1CFD210", Length = "0x124")]
	[Token(Token = "0x6000F31")]
	protected virtual void _callDeadEffect() { }

	[Address(RVA = "0x1CFDF40", Offset = "0x1CFD340", Length = "0x49")]
	[Token(Token = "0x6000F32")]
	public Ene_Mx02() { }

}

