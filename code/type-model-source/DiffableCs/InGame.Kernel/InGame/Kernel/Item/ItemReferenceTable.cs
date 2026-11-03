namespace InGame.Kernel.Item;

[CreateAssetMenu(menuName = "KANAI/ItemReferenceTable")]
[Token(Token = "0x2000146")]
public class ItemReferenceTable : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000953")]
	private List<Kind> _tableList; //Field offset: 0x18

	[Token(Token = "0x170001C0")]
	public int Count
	{
		[Address(RVA = "0x1D71490", Offset = "0x1D70890", Length = "0x3C")]
		[Token(Token = "0x6000A30")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x1D713B0", Offset = "0x1D707B0", Length = "0xDD")]
	[Token(Token = "0x6000A32")]
	public ItemReferenceTable() { }

	[Address(RVA = "0x1D71490", Offset = "0x1D70890", Length = "0x3C")]
	[Token(Token = "0x6000A30")]
	public int get_Count() { }

	[Address(RVA = "0x1D71350", Offset = "0x1D70750", Length = "0x51")]
	[Token(Token = "0x6000A31")]
	public Kind GetKind(int index) { }

}

