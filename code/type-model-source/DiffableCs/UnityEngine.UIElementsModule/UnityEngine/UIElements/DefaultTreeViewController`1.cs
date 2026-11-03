namespace UnityEngine.UIElements;

[Token(Token = "0x200005E")]
public class DefaultTreeViewController : TreeViewController
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001CD")]
	private TreeDataController<T> m_TreeDataController; //Field offset: 0x0

	[Token(Token = "0x1700006D")]
	public virtual IList itemsSource
	{
		[Address(RVA = "0x17D40F0", Offset = "0x17D34F0", Length = "0x19")]
		[Token(Token = "0x6000324")]
		 get { } //Length: 25
		[Address(RVA = "0x17D4BB0", Offset = "0x17D3FB0", Length = "0x113")]
		[Token(Token = "0x6000325")]
		 set { } //Length: 275
	}

	[Token(Token = "0x1700006C")]
	private TreeDataController<T> treeDataController
	{
		[Address(RVA = "0x17D4A00", Offset = "0x17D3E00", Length = "0x83")]
		[Token(Token = "0x6000323")]
		private get { } //Length: 131
	}

	[Address(RVA = "0x17D4960", Offset = "0x17D3D60", Length = "0x7")]
	[Token(Token = "0x6000328")]
	public DefaultTreeViewController`1() { }

	[Address(RVA = "0x17D4080", Offset = "0x17D3480", Length = "0x25")]
	[CompilerGenerated]
	[Token(Token = "0x6000329")]
	private HierarchyNode <SetRootItems>b__6_0(HierarchyNode node) { }

	[Address(RVA = "0x17D40B0", Offset = "0x17D34B0", Length = "0x2E")]
	[CompilerGenerated]
	[Token(Token = "0x600032A")]
	private void <SetRootItems>b__6_1(int id, HierarchyNode node) { }

	[Address(RVA = "0x17D40F0", Offset = "0x17D34F0", Length = "0x19")]
	[Token(Token = "0x6000324")]
	public virtual IList get_itemsSource() { }

	[Address(RVA = "0x17D4A00", Offset = "0x17D3E00", Length = "0x83")]
	[Token(Token = "0x6000323")]
	private TreeDataController<T> get_treeDataController() { }

	[Address(RVA = "0x17D4470", Offset = "0x17D3870", Length = "0x7D")]
	[Token(Token = "0x6000327")]
	public virtual object GetItemForIndex(int index) { }

	[Address(RVA = "0x17D4BB0", Offset = "0x17D3FB0", Length = "0x113")]
	[Token(Token = "0x6000325")]
	public virtual void set_itemsSource(IList value) { }

	[Address(RVA = "0x17D44F0", Offset = "0x17D38F0", Length = "0x228")]
	[Token(Token = "0x6000326")]
	public override void SetRootItems(IList<TreeViewItemData`1<T>> items) { }

}

