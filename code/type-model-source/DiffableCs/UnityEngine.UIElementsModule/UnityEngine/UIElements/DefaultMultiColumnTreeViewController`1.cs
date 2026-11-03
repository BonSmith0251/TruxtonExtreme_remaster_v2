namespace UnityEngine.UIElements;

[Token(Token = "0x200005D")]
public class DefaultMultiColumnTreeViewController : MultiColumnTreeViewController
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001CC")]
	private TreeDataController<T> m_TreeDataController; //Field offset: 0x0

	[Token(Token = "0x1700006B")]
	public virtual IList itemsSource
	{
		[Address(RVA = "0x17D40F0", Offset = "0x17D34F0", Length = "0x19")]
		[Token(Token = "0x600031D")]
		 get { } //Length: 25
		[Address(RVA = "0x17D4230", Offset = "0x17D3630", Length = "0x113")]
		[Token(Token = "0x600031E")]
		 set { } //Length: 275
	}

	[Token(Token = "0x1700006A")]
	private TreeDataController<T> treeDataController
	{
		[Address(RVA = "0x17D41A0", Offset = "0x17D35A0", Length = "0x83")]
		[Token(Token = "0x600031B")]
		private get { } //Length: 131
	}

	[Address(RVA = "0x17D40E0", Offset = "0x17D34E0", Length = "0xE")]
	[Token(Token = "0x600031C")]
	public DefaultMultiColumnTreeViewController`1(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	[Address(RVA = "0x17D4080", Offset = "0x17D3480", Length = "0x25")]
	[CompilerGenerated]
	[Token(Token = "0x6000321")]
	private HierarchyNode <SetRootItems>b__7_0(HierarchyNode node) { }

	[Address(RVA = "0x17D40B0", Offset = "0x17D34B0", Length = "0x2E")]
	[CompilerGenerated]
	[Token(Token = "0x6000322")]
	private void <SetRootItems>b__7_1(int id, HierarchyNode node) { }

	[Address(RVA = "0x17D40F0", Offset = "0x17D34F0", Length = "0x19")]
	[Token(Token = "0x600031D")]
	public virtual IList get_itemsSource() { }

	[Address(RVA = "0x17D41A0", Offset = "0x17D35A0", Length = "0x83")]
	[Token(Token = "0x600031B")]
	private TreeDataController<T> get_treeDataController() { }

	[Address(RVA = "0x17D3A80", Offset = "0x17D2E80", Length = "0x7D")]
	[Token(Token = "0x6000320")]
	public virtual object GetItemForIndex(int index) { }

	[Address(RVA = "0x17D4230", Offset = "0x17D3630", Length = "0x113")]
	[Token(Token = "0x600031E")]
	public virtual void set_itemsSource(IList value) { }

	[Address(RVA = "0x17D3E50", Offset = "0x17D3250", Length = "0x228")]
	[Token(Token = "0x600031F")]
	public override void SetRootItems(IList<TreeViewItemData`1<T>> items) { }

}

