namespace UnityEngine.UIElements;

[Token(Token = "0x2000061")]
public abstract class MultiColumnTreeViewController : BaseTreeViewController
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001CF")]
	private MultiColumnController m_ColumnController; //Field offset: 0x68

	[Token(Token = "0x17000070")]
	public MultiColumnController columnController
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6000341")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3225790", Offset = "0x3224B90", Length = "0xC0")]
	[Token(Token = "0x6000342")]
	protected MultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	[Address(RVA = "0x3225470", Offset = "0x3224870", Length = "0x91")]
	[Token(Token = "0x6000346")]
	protected virtual void BindItem(VisualElement element, int index) { }

	[Address(RVA = "0x3225510", Offset = "0x3224910", Length = "0x1E")]
	[Token(Token = "0x6000348")]
	protected virtual void DestroyItem(VisualElement element) { }

	[Address(RVA = "0x3225530", Offset = "0x3224930", Length = "0x6B")]
	[Token(Token = "0x600034A")]
	public virtual void Dispose() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6000341")]
	public MultiColumnController get_columnController() { }

	[Address(RVA = "0x32255A0", Offset = "0x32249A0", Length = "0x13D")]
	[Token(Token = "0x6000344")]
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	[Address(RVA = "0x32256E0", Offset = "0x3224AE0", Length = "0x1D")]
	[Token(Token = "0x6000345")]
	protected virtual VisualElement MakeItem() { }

	[Address(RVA = "0x3225740", Offset = "0x3224B40", Length = "0x25")]
	[Token(Token = "0x6000349")]
	protected virtual void PrepareView() { }

	[Address(RVA = "0x3225700", Offset = "0x3224B00", Length = "0x30")]
	[Token(Token = "0x6000343")]
	internal virtual void PreRefresh() { }

	[Address(RVA = "0x3225770", Offset = "0x3224B70", Length = "0x1E")]
	[Token(Token = "0x6000347")]
	protected virtual void UnbindItem(VisualElement element, int index) { }

}

