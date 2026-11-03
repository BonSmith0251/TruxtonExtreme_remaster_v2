namespace InGame.Kernel.Item;

[Token(Token = "0x2000145")]
public class ItemEnemyBox : PawnEnemy
{
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000952")]
	private Kind _targetItem; //Field offset: 0x1B0

	[Token(Token = "0x170001BF")]
	protected virtual bool IsExpEffectMove
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000A2B")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x1D70AB0", Offset = "0x1D6FEB0", Length = "0x49")]
	[Token(Token = "0x6000A2F")]
	public ItemEnemyBox() { }

	[Address(RVA = "0x1D70940", Offset = "0x1D6FD40", Length = "0x162")]
	[Token(Token = "0x6000A2E")]
	public void DropItem() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000A2B")]
	protected virtual bool get_IsExpEffectMove() { }

	[Address(RVA = "0x1CDD570", Offset = "0x1CDC970", Length = "0x7")]
	[Token(Token = "0x6000A2D")]
	public Kind GetItem() { }

	[Address(RVA = "0x1CDAF40", Offset = "0x1CDA340", Length = "0x7")]
	[Token(Token = "0x6000A2C")]
	public void SetItem(Kind tdrop) { }

}

