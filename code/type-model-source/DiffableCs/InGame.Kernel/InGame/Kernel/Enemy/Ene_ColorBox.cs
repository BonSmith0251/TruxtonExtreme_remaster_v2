namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001D8")]
public class Ene_ColorBox : PawnEnemyGround
{
	[FieldOffset(Offset = "0x200")]
	[SerializeField]
	[Token(Token = "0x400105E")]
	private Kind _SwapDrop; //Field offset: 0x200

	[Address(RVA = "0x1DBB9C0", Offset = "0x1DBADC0", Length = "0x49")]
	[Token(Token = "0x6000E4E")]
	public Ene_ColorBox() { }

	[Address(RVA = "0x1DBB2F0", Offset = "0x1DBA6F0", Length = "0x114")]
	[Token(Token = "0x6000E4D")]
	protected virtual bool DropItem(Kind dkind, Transform root, Vector3 curpos, float alivetime) { }

}

