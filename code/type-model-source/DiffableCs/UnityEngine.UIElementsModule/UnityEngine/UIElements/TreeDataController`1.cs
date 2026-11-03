namespace UnityEngine.UIElements;

[Token(Token = "0x2000062")]
internal sealed class TreeDataController
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D0")]
	private Dictionary<HierarchyNode, TreeViewItemData`1<T>> m_NodeToItemDataDictionary; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D1")]
	private Stack<IEnumerator`1<TreeViewItemData`1<T>>> m_ItemStack; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D2")]
	private Stack<HierarchyNode> m_NodeStack; //Field offset: 0x0

	[Address(RVA = "0x109C1B0", Offset = "0x109B5B0", Length = "0x12E")]
	[Token(Token = "0x600034F")]
	public TreeDataController`1() { }

	[Address(RVA = "0x109B350", Offset = "0x109A750", Length = "0x2D")]
	[Token(Token = "0x600034E")]
	internal void ClearNodeToDataDictionary() { }

	[Address(RVA = "0x109B8E0", Offset = "0x109ACE0", Length = "0x429")]
	[Token(Token = "0x600034C")]
	internal void ConvertTreeViewItemDataToHierarchy(IEnumerable<TreeViewItemData`1<T>> list, Func<HierarchyNode, HierarchyNode> createNode, Action<Int32, HierarchyNode> updateDictionary) { }

	[Address(RVA = "0x109BF00", Offset = "0x109B300", Length = "0x4F")]
	[Token(Token = "0x600034B")]
	public T GetDataForNode(HierarchyNode node) { }

	[Address(RVA = "0x109BF50", Offset = "0x109B350", Length = "0x48")]
	[Token(Token = "0x600034D")]
	internal void UpdateNodeToDataDictionary(HierarchyNode node, TreeViewItemData<T> item) { }

}

