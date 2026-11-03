namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001EB")]
public class Ene_Mi01 : PawnEnemy
{
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x4001102")]
	private Kind _item; //Field offset: 0x1B0

	[Address(RVA = "0x1DC6B40", Offset = "0x1DC5F40", Length = "0x10D")]
	[Token(Token = "0x6000EBA")]
	protected virtual void _callDeadEffect() { }

	[Address(RVA = "0x1DC6C50", Offset = "0x1DC6050", Length = "0x49")]
	[Token(Token = "0x6000EBB")]
	public Ene_Mi01() { }

}

