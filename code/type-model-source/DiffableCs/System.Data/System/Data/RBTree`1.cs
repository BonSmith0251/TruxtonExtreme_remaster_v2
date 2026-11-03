namespace System.Data;

[DefaultMember("Item")]
[Token(Token = "0x200007C")]
internal abstract class RBTree : IEnumerable
{
	[Token(Token = "0x200007E")]
	private struct Node
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400027E")]
		internal int _selfId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400027F")]
		internal int _leftId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000280")]
		internal int _rightId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000281")]
		internal int _parentId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000282")]
		internal int _nextId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000283")]
		internal int _subTreeSize; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000284")]
		internal K _keyOfNode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000285")]
		internal NodeColor<K> _nodeColor; //Field offset: 0x0

	}

	[Token(Token = "0x200007D")]
	private enum NodeColor : int
	{
		red = 0,
		black = 1,
	}

	[IsReadOnly]
	[Token(Token = "0x200007F")]
	private struct NodePath
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000286")]
		internal readonly int _nodeID; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000287")]
		internal readonly int _mainTreeNodeID; //Field offset: 0x0

		[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
		[Token(Token = "0x60006B9")]
		internal NodePath(int nodeID, int mainTreeNodeID) { }

	}

	[Token(Token = "0x2000081")]
	public struct RBTreeEnumerator : IEnumerator<K>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028D")]
		private readonly RBTree<K> _tree; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028E")]
		private readonly int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028F")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000290")]
		private int _mainTreeNodeId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000291")]
		private K _current; //Field offset: 0x0

		[Token(Token = "0x17000108")]
		public override K Current
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[Token(Token = "0x60006C4")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000109")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xE82CE0", Offset = "0xE820E0", Length = "0x5E")]
			[Token(Token = "0x60006C5")]
			private get { } //Length: 94
		}

		[Address(RVA = "0xE82E70", Offset = "0xE82270", Length = "0x45")]
		[Token(Token = "0x60006C0")]
		internal RBTreeEnumerator(RBTree<K> tree) { }

		[Address(RVA = "0xE82F10", Offset = "0xE82310", Length = "0xB3")]
		[Token(Token = "0x60006C1")]
		internal RBTreeEnumerator(RBTree<K> tree, int position) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60006C2")]
		public override void Dispose() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x60006C4")]
		public override K get_Current() { }

		[Address(RVA = "0xE824B0", Offset = "0xE818B0", Length = "0x21F")]
		[Token(Token = "0x60006C3")]
		public override bool MoveNext() { }

		[Address(RVA = "0xE82CE0", Offset = "0xE820E0", Length = "0x5E")]
		[Token(Token = "0x60006C5")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xE82C20", Offset = "0xE82020", Length = "0x51")]
		[Token(Token = "0x60006C6")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[Token(Token = "0x2000080")]
	private sealed class TreePage
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000288")]
		internal readonly Node<K>[] _slots; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000289")]
		internal readonly Int32[] _slotMap; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028A")]
		private int _inUseCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028B")]
		private int _pageId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028C")]
		private int _nextFreeSlotLine; //Field offset: 0x0

		[Token(Token = "0x17000106")]
		internal int InUseCount
		{
			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[Token(Token = "0x60006BC")]
			internal get { } //Length: 4
			[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
			[Token(Token = "0x60006BD")]
			internal set { } //Length: 4
		}

		[Token(Token = "0x17000107")]
		internal int PageId
		{
			[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
			[Token(Token = "0x60006BE")]
			internal get { } //Length: 4
			[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
			[Token(Token = "0x60006BF")]
			internal set { } //Length: 4
		}

		[Address(RVA = "0x109C5C0", Offset = "0x109B9C0", Length = "0xCC")]
		[Token(Token = "0x60006BA")]
		internal TreePage(int size) { }

		[Address(RVA = "0x109C450", Offset = "0x109B850", Length = "0x164")]
		[Token(Token = "0x60006BB")]
		internal int AllocSlot(RBTree<K> tree) { }

		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60006BC")]
		internal int get_InUseCount() { }

		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x60006BE")]
		internal int get_PageId() { }

		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x60006BD")]
		internal void set_InUseCount(int value) { }

		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x60006BF")]
		internal void set_PageId(int value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000272")]
	private TreePage<K>[] _pageTable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000273")]
	private Int32[] _pageTableMap; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000274")]
	private int _inUsePageCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000275")]
	private int _nextFreePageLine; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000276")]
	public int root; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000277")]
	private int _version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000278")]
	private int _inUseNodeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000279")]
	private int _inUseSatelliteTreeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400027A")]
	private readonly TreeAccessMethod _accessMethod; //Field offset: 0x0

	[Token(Token = "0x17000103")]
	public int Count
	{
		[Address(RVA = "0xE8A790", Offset = "0xE89B90", Length = "0x6")]
		[Token(Token = "0x6000685")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000104")]
	public bool HasDuplicates
	{
		[Address(RVA = "0xE8A7A0", Offset = "0xE89BA0", Length = "0x8")]
		[Token(Token = "0x6000686")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000105")]
	public K Item
	{
		[Address(RVA = "0xE8A7B0", Offset = "0xE89BB0", Length = "0x6A")]
		[Token(Token = "0x6000694")]
		 get { } //Length: 106
	}

	[Address(RVA = "0xE8A6E0", Offset = "0xE89AE0", Length = "0x47")]
	[Token(Token = "0x600067C")]
	protected RBTree`1(TreeAccessMethod accessMethod) { }

	[Address(RVA = "0xE836C0", Offset = "0xE82AC0", Length = "0x74")]
	[Token(Token = "0x600069F")]
	public int Add(K item) { }

	[Address(RVA = "0xE83740", Offset = "0xE82B40", Length = "0x29F")]
	[Token(Token = "0x600067F")]
	private TreePage<K> AllocPage(int size) { }

	[Address(RVA = "0xE839E0", Offset = "0xE82DE0", Length = "0x26")]
	[Token(Token = "0x60006A5")]
	public void Clear() { }

	[Address(RVA = "0xE8A730", Offset = "0xE89B30", Length = "0x52")]
	[Token(Token = "0x60006B5")]
	private NodeColor<K> color(int nodeId) { }

	[Token(Token = "0x600067A")]
	protected abstract int CompareNode(K record1, K record2) { }

	[Token(Token = "0x600067B")]
	protected abstract int CompareSateliteTreeNode(K record1, K record2) { }

	[Address(RVA = "0xE83A10", Offset = "0xE82E10", Length = "0x1B0")]
	[Token(Token = "0x6000699")]
	private int ComputeIndexByNode(int nodeId) { }

	[Address(RVA = "0xE83BD0", Offset = "0xE82FD0", Length = "0x22A")]
	[Token(Token = "0x600069A")]
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }

	[Address(RVA = "0xE83E00", Offset = "0xE83200", Length = "0x107")]
	[Token(Token = "0x600069D")]
	private int ComputeNodeByIndex(int x_id, int index) { }

	[Address(RVA = "0xE83F10", Offset = "0xE83310", Length = "0x26D")]
	[Token(Token = "0x600069C")]
	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }

	[Address(RVA = "0xE84330", Offset = "0xE83730", Length = "0x17B")]
	[Token(Token = "0x60006A7")]
	public void CopyTo(K[] array, int index) { }

	[Address(RVA = "0xE84180", Offset = "0xE83580", Length = "0x1A6")]
	[Token(Token = "0x60006A6")]
	public void CopyTo(Array array, int index) { }

	[Address(RVA = "0xE844B0", Offset = "0xE838B0", Length = "0x52")]
	[Token(Token = "0x60006B1")]
	private void DecreaseSize(int nodeId) { }

	[Address(RVA = "0xE84510", Offset = "0xE83910", Length = "0xB0")]
	[Token(Token = "0x600068F")]
	public K DeleteByIndex(int i) { }

	[Address(RVA = "0xE845D0", Offset = "0xE839D0", Length = "0x172")]
	[Token(Token = "0x6000683")]
	private void FreeNode(int nodeId) { }

	[Address(RVA = "0xE84750", Offset = "0xE83B50", Length = "0x86")]
	[Token(Token = "0x600067E")]
	private void FreePage(TreePage<K> page) { }

	[Address(RVA = "0xE8A790", Offset = "0xE89B90", Length = "0x6")]
	[Token(Token = "0x6000685")]
	public int get_Count() { }

	[Address(RVA = "0xE8A7A0", Offset = "0xE89BA0", Length = "0x8")]
	[Token(Token = "0x6000686")]
	public bool get_HasDuplicates() { }

	[Address(RVA = "0xE8A7B0", Offset = "0xE89BB0", Length = "0x6A")]
	[Token(Token = "0x6000694")]
	public K get_Item(int index) { }

	[Address(RVA = "0xE847E0", Offset = "0xE83BE0", Length = "0x8E")]
	[Token(Token = "0x60006A0")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0xE84870", Offset = "0xE83C70", Length = "0x112")]
	[Token(Token = "0x6000696")]
	public int GetIndexByKey(K key) { }

	[Address(RVA = "0xE84A50", Offset = "0xE83E50", Length = "0x1DB")]
	[Token(Token = "0x6000697")]
	public int GetIndexByNode(int node) { }

	[Address(RVA = "0xE84990", Offset = "0xE83D90", Length = "0xB8")]
	[Token(Token = "0x6000698")]
	private int GetIndexByNodePath(NodePath<K> path) { }

	[Address(RVA = "0xE84C30", Offset = "0xE84030", Length = "0x19D")]
	[Token(Token = "0x6000684")]
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }

	[Address(RVA = "0xE84DD0", Offset = "0xE841D0", Length = "0x67")]
	[Token(Token = "0x6000682")]
	private static int GetIntValueFromBitMap(uint bitMap) { }

	[Address(RVA = "0xE84E40", Offset = "0xE84240", Length = "0x21B")]
	[Token(Token = "0x6000687")]
	private int GetNewNode(K key) { }

	[Address(RVA = "0xE85060", Offset = "0xE84460", Length = "0xD4")]
	[Token(Token = "0x600069B")]
	private NodePath<K> GetNodeByIndex(int userIndex) { }

	[Address(RVA = "0xE85140", Offset = "0xE84540", Length = "0x272")]
	[Token(Token = "0x6000695")]
	private NodePath<K> GetNodeByKey(K key) { }

	[Address(RVA = "0xE853C0", Offset = "0xE847C0", Length = "0x52")]
	[Token(Token = "0x60006AF")]
	private void IncreaseSize(int nodeId) { }

	[Address(RVA = "0xE85420", Offset = "0xE84820", Length = "0x17E")]
	[Token(Token = "0x60006A1")]
	public int IndexOf(int nodeId, K item) { }

	[Address(RVA = "0xE855A0", Offset = "0xE849A0", Length = "0x16C")]
	[Token(Token = "0x600067D")]
	private void InitTree() { }

	[Address(RVA = "0xE857B0", Offset = "0xE84BB0", Length = "0x91")]
	[Token(Token = "0x60006A2")]
	public int Insert(int position, K item) { }

	[Address(RVA = "0xE836C0", Offset = "0xE82AC0", Length = "0x74")]
	[Token(Token = "0x600069E")]
	public int Insert(K item) { }

	[Address(RVA = "0xE85710", Offset = "0xE84B10", Length = "0x94")]
	[Token(Token = "0x60006A3")]
	public int InsertAt(int position, K item, bool append) { }

	[Address(RVA = "0xE85850", Offset = "0xE84C50", Length = "0x52")]
	[Token(Token = "0x60006B8")]
	public K Key(int nodeId) { }

	[Address(RVA = "0xE86130", Offset = "0xE85530", Length = "0x52")]
	[Token(Token = "0x60006B3")]
	public int Left(int nodeId) { }

	[Address(RVA = "0xE858B0", Offset = "0xE84CB0", Length = "0x872")]
	[Token(Token = "0x600068B")]
	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }

	[Address(RVA = "0xE86190", Offset = "0xE85590", Length = "0x52")]
	[Token(Token = "0x6000681")]
	private void MarkPageFree(TreePage<K> page) { }

	[Address(RVA = "0xE861F0", Offset = "0xE855F0", Length = "0x52")]
	[Token(Token = "0x6000680")]
	private void MarkPageFull(TreePage<K> page) { }

	[Address(RVA = "0xE86250", Offset = "0xE85650", Length = "0x85")]
	[Token(Token = "0x600068A")]
	private int Minimum(int x_id) { }

	[Address(RVA = "0xE862E0", Offset = "0xE856E0", Length = "0x52")]
	[Token(Token = "0x60006B6")]
	public int Next(int nodeId) { }

	[Address(RVA = "0xE86340", Offset = "0xE85740", Length = "0x52")]
	[Token(Token = "0x60006B4")]
	public int Parent(int nodeId) { }

	[Address(RVA = "0xE88000", Offset = "0xE87400", Length = "0x2D")]
	[Token(Token = "0x6000690")]
	public int RBDelete(int z_id) { }

	[Address(RVA = "0xE863A0", Offset = "0xE857A0", Length = "0x902")]
	[Token(Token = "0x6000692")]
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }

	[Address(RVA = "0xE86CB0", Offset = "0xE860B0", Length = "0x1345")]
	[Token(Token = "0x6000691")]
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }

	[Address(RVA = "0xE88030", Offset = "0xE87430", Length = "0x13B2")]
	[Token(Token = "0x600068D")]
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }

	[Address(RVA = "0xE893F0", Offset = "0xE887F0", Length = "0x1BD")]
	[Token(Token = "0x60006B0")]
	private void RecomputeSize(int nodeId) { }

	[Address(RVA = "0xE895B0", Offset = "0xE889B0", Length = "0xAB")]
	[Token(Token = "0x60006A4")]
	public void RemoveAt(int position) { }

	[Address(RVA = "0xE89EE0", Offset = "0xE892E0", Length = "0x52")]
	[Token(Token = "0x60006B2")]
	public int Right(int nodeId) { }

	[Address(RVA = "0xE89660", Offset = "0xE88A60", Length = "0x872")]
	[Token(Token = "0x600068C")]
	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }

	[Address(RVA = "0xE89F40", Offset = "0xE89340", Length = "0xFF")]
	[Token(Token = "0x6000693")]
	private int SearchSubTree(int root_id, K key) { }

	[Address(RVA = "0xE8A040", Offset = "0xE89440", Length = "0x53")]
	[Token(Token = "0x60006AB")]
	private void SetColor(int nodeId, NodeColor<K> color) { }

	[Address(RVA = "0xE8A0A0", Offset = "0xE894A0", Length = "0x53")]
	[Token(Token = "0x60006AC")]
	private void SetKey(int nodeId, K key) { }

	[Address(RVA = "0xE8A100", Offset = "0xE89500", Length = "0x53")]
	[Token(Token = "0x60006A9")]
	private void SetLeft(int nodeId, int leftNodeId) { }

	[Address(RVA = "0xE8A160", Offset = "0xE89560", Length = "0x53")]
	[Token(Token = "0x60006AD")]
	private void SetNext(int nodeId, int nextNodeId) { }

	[Address(RVA = "0xE8A1C0", Offset = "0xE895C0", Length = "0x53")]
	[Token(Token = "0x60006AA")]
	private void SetParent(int nodeId, int parentNodeId) { }

	[Address(RVA = "0xE8A220", Offset = "0xE89620", Length = "0x53")]
	[Token(Token = "0x60006A8")]
	private void SetRight(int nodeId, int rightNodeId) { }

	[Address(RVA = "0xE8A280", Offset = "0xE89680", Length = "0x53")]
	[Token(Token = "0x60006AE")]
	private void SetSubTreeSize(int nodeId, int size) { }

	[Address(RVA = "0xE8A2E0", Offset = "0xE896E0", Length = "0x52")]
	[Token(Token = "0x60006B7")]
	public int SubTreeSize(int nodeId) { }

	[Address(RVA = "0xE8A490", Offset = "0xE89890", Length = "0x132")]
	[Token(Token = "0x6000688")]
	private int Successor(int x_id) { }

	[Address(RVA = "0xE8A340", Offset = "0xE89740", Length = "0x14C")]
	[Token(Token = "0x6000689")]
	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }

	[Address(RVA = "0xE8A5D0", Offset = "0xE899D0", Length = "0x10B")]
	[Token(Token = "0x600068E")]
	public void UpdateNodeKey(K currentKey, K newKey) { }

}

