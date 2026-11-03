namespace UnityEngine.UIElements;

[Token(Token = "0x2000058")]
public abstract class BaseTreeViewController : CollectionViewController
{
	[CompilerGenerated]
	[Token(Token = "0x2000059")]
	private sealed class <GetAllItemIds>d__23 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001A6")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40001A7")]
		private int <>2__current; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001A8")]
		private int <>l__initialThreadId; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001A9")]
		private IEnumerable<Int32> rootIds; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001AA")]
		public IEnumerable<Int32> <>3__rootIds; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001AB")]
		public BaseTreeViewController <>4__this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001AC")]
		private Enumerator <>s__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40001AD")]
		private HierarchyFlattenedNode <flattenedNode>5__2; //Field offset: 0x58
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x40001AE")]
		private HierarchyNode <node>5__3; //Field offset: 0x7C
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40001AF")]
		private IEnumerator<Int32> <>s__4; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40001B0")]
		private int <id>5__5; //Field offset: 0x90
		[FieldOffset(Offset = "0x94")]
		[Token(Token = "0x40001B1")]
		private HierarchyNode <parentNode>5__6; //Field offset: 0x94
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40001B2")]
		private HierarchyFlattenedChildrenEnumerable <flattenedNodeChildren>5__7; //Field offset: 0xA0
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x40001B3")]
		private Enumerator <>s__8; //Field offset: 0xD0
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x40001B4")]
		private HierarchyFlattenedNode <flattenedNode>5__9; //Field offset: 0x110

		[Token(Token = "0x17000062")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[DebuggerHidden]
			[Token(Token = "0x60002E9")]
			private get { } //Length: 4
		}

		[Token(Token = "0x17000063")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x224EF90", Offset = "0x224E390", Length = "0x436")]
			[DebuggerHidden]
			[Token(Token = "0x60002EB")]
			private get { } //Length: 1078
		}

		[Address(RVA = "0x113FA40", Offset = "0x113EE40", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60002E5")]
		public <GetAllItemIds>d__23(int <>1__state) { }

		[Address(RVA = "0x3229790", Offset = "0x3228B90", Length = "0x56")]
		[Token(Token = "0x60002E8")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x3228D70", Offset = "0x3228170", Length = "0x8C6")]
		[Token(Token = "0x60002E7")]
		private override bool MoveNext() { }

		[Address(RVA = "0x3229640", Offset = "0x3228A40", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x60002EC")]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[DebuggerHidden]
		[Token(Token = "0x60002E9")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[Address(RVA = "0x3229640", Offset = "0x3228A40", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x60002ED")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x224EF90", Offset = "0x224E390", Length = "0x436")]
		[DebuggerHidden]
		[Token(Token = "0x60002EB")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x32296F0", Offset = "0x3228AF0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60002EA")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x3229730", Offset = "0x3228B30", Length = "0x56")]
		[DebuggerHidden]
		[Token(Token = "0x60002E6")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005A")]
	private sealed class <GetChildrenIds>d__25 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001B5")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40001B6")]
		private int <>2__current; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001B7")]
		private int <>l__initialThreadId; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40001B8")]
		private int id; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001B9")]
		public int <>3__id; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001BA")]
		public BaseTreeViewController <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001BB")]
		private HierarchyNode <nodeById>5__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001BC")]
		private HierarchyNodeChildren <nodes>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001BD")]
		private Enumerator <>s__3; //Field offset: 0x50
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40001BE")]
		private HierarchyNode <node>5__4; //Field offset: 0x70

		[Token(Token = "0x17000064")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[DebuggerHidden]
			[Token(Token = "0x60002F1")]
			private get { } //Length: 4
		}

		[Token(Token = "0x17000065")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x224EF90", Offset = "0x224E390", Length = "0x436")]
			[DebuggerHidden]
			[Token(Token = "0x60002F3")]
			private get { } //Length: 1078
		}

		[Address(RVA = "0x113FA40", Offset = "0x113EE40", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60002EE")]
		public <GetChildrenIds>d__25(int <>1__state) { }

		[Address(RVA = "0x3229AA0", Offset = "0x3228EA0", Length = "0x191")]
		[Token(Token = "0x60002F0")]
		private override bool MoveNext() { }

		[Address(RVA = "0x3229C40", Offset = "0x3229040", Length = "0xA2")]
		[DebuggerHidden]
		[Token(Token = "0x60002F4")]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[DebuggerHidden]
		[Token(Token = "0x60002F1")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[Address(RVA = "0x3229C40", Offset = "0x3229040", Length = "0xA2")]
		[DebuggerHidden]
		[Token(Token = "0x60002F5")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x224EF90", Offset = "0x224E390", Length = "0x436")]
		[DebuggerHidden]
		[Token(Token = "0x60002F3")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x3229CF0", Offset = "0x32290F0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60002F2")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60002EF")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005B")]
	private sealed class <GetChildrenIdsByIndex>d__41 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001BF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40001C0")]
		private int <>2__current; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001C1")]
		private int <>l__initialThreadId; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40001C2")]
		private int index; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001C3")]
		public int <>3__index; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001C4")]
		public BaseTreeViewController <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001C5")]
		private HierarchyNodeChildren <nodes>5__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001C6")]
		private Enumerator <>s__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001C7")]
		private HierarchyNode <node>5__3; //Field offset: 0x68

		[Token(Token = "0x17000066")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[DebuggerHidden]
			[Token(Token = "0x60002F9")]
			private get { } //Length: 4
		}

		[Token(Token = "0x17000067")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x224EF90", Offset = "0x224E390", Length = "0x436")]
			[DebuggerHidden]
			[Token(Token = "0x60002FB")]
			private get { } //Length: 1078
		}

		[Address(RVA = "0x113FA40", Offset = "0x113EE40", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60002F6")]
		public <GetChildrenIdsByIndex>d__41(int <>1__state) { }

		[Address(RVA = "0x32297F0", Offset = "0x3228BF0", Length = "0x1B7")]
		[Token(Token = "0x60002F8")]
		private override bool MoveNext() { }

		[Address(RVA = "0x32299B0", Offset = "0x3228DB0", Length = "0xA2")]
		[DebuggerHidden]
		[Token(Token = "0x60002FC")]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[DebuggerHidden]
		[Token(Token = "0x60002F9")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[Address(RVA = "0x32299B0", Offset = "0x3228DB0", Length = "0xA2")]
		[DebuggerHidden]
		[Token(Token = "0x60002FD")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x224EF90", Offset = "0x224E390", Length = "0x436")]
		[DebuggerHidden]
		[Token(Token = "0x60002FB")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x3229A60", Offset = "0x3228E60", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60002FA")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60002F7")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40001A5")]
	private static readonly ProfilerMarker K_ExpandItemByIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400019E")]
	 Hierarchy m_Hierarchy; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400019F")]
	 HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001A0")]
	 HierarchyViewModel m_HierarchyViewModel; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001A1")]
	 Dictionary<Int32, HierarchyNode> m_IdToNodeDictionary; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001A2")]
	private IHierarchyProperty<Int32> m_TreeViewDataProperty; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001A3")]
	private bool m_HierarchyHasPendingChanged; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001A4")]
	private Action<TreeViewExpansionChangedArgs> itemExpandedChanged; //Field offset: 0x60

	[Token(Token = "0x14000009")]
	internal event Action<TreeViewExpansionChangedArgs> itemExpandedChanged
	{
		[Address(RVA = "0x321EBE0", Offset = "0x321DFE0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60002B0")]
		internal add { } //Length: 172
		[Address(RVA = "0x321ED10", Offset = "0x321E110", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60002B1")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x1700005F")]
	protected BaseTreeView baseTreeView
	{
		[Address(RVA = "0x321EC90", Offset = "0x321E090", Length = "0x72")]
		[Token(Token = "0x60002AF")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000060")]
	 Hierarchy hierarchy
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60002B4")]
		 get { } //Length: 5
		[Address(RVA = "0x321EDC0", Offset = "0x321E1C0", Length = "0x160")]
		[Token(Token = "0x60002B5")]
		 set { } //Length: 352
	}

	[Token(Token = "0x17000061")]
	public virtual IList itemsSource
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60002B7")]
		 get { } //Length: 5
		[Address(RVA = "0x321EF30", Offset = "0x321E330", Length = "0x4E")]
		[Token(Token = "0x60002B8")]
		 set { } //Length: 78
	}

	[Address(RVA = "0x321E970", Offset = "0x321DD70", Length = "0x73")]
	[Token(Token = "0x60002E4")]
	private static BaseTreeViewController() { }

	[Address(RVA = "0x321E9F0", Offset = "0x321DDF0", Length = "0x1E2")]
	[Token(Token = "0x60002B2")]
	protected BaseTreeViewController() { }

	[Address(RVA = "0x321EBE0", Offset = "0x321DFE0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60002B0")]
	internal void add_itemExpandedChanged(Action<TreeViewExpansionChangedArgs> value) { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[Token(Token = "0x60002CD")]
	public override bool CanChangeExpandedState(int id) { }

	[Address(RVA = "0x321AD60", Offset = "0x321A160", Length = "0x44")]
	[Token(Token = "0x60002DE")]
	internal void ClearIdToNodeDictionary() { }

	[Address(RVA = "0x321B1D0", Offset = "0x321A5D0", Length = "0xD6")]
	[Token(Token = "0x60002D3")]
	public void CollapseItem(int id, bool collapseAllChildren, bool refresh = true) { }

	[Address(RVA = "0x321ADB0", Offset = "0x321A1B0", Length = "0x93")]
	[Token(Token = "0x60002D2")]
	public void CollapseItemByIndex(int index, bool collapseAllChildren, bool refresh = true) { }

	[Address(RVA = "0x321AE50", Offset = "0x321A250", Length = "0x37E")]
	[Token(Token = "0x60002D5")]
	private void CollapseItemByNode(in HierarchyNode node, bool collapseAllChildren, bool refresh) { }

	[Address(RVA = "0x321B2B0", Offset = "0x321A6B0", Length = "0x84")]
	[Token(Token = "0x60002DC")]
	internal HierarchyNode CreateNode(in HierarchyNode parent) { }

	[Address(RVA = "0x321B340", Offset = "0x321A740", Length = "0xC8")]
	[Token(Token = "0x60002B6")]
	internal void DisposeHierarchy() { }

	[Address(RVA = "0x321B410", Offset = "0x321A810", Length = "0x51")]
	[Token(Token = "0x60002C7")]
	public bool Exists(int id) { }

	[Address(RVA = "0x321B9C0", Offset = "0x321ADC0", Length = "0xD6")]
	[Token(Token = "0x60002D1")]
	public void ExpandItem(int id, bool expandAllChildren, bool refresh = true) { }

	[Address(RVA = "0x321B470", Offset = "0x321A870", Length = "0x152")]
	[Token(Token = "0x60002D0")]
	public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true) { }

	[Address(RVA = "0x321B5D0", Offset = "0x321A9D0", Length = "0x3E5")]
	[Token(Token = "0x60002D4")]
	private void ExpandItemByNode(in HierarchyNode node, bool expandAllChildren, bool refresh) { }

	[Address(RVA = "0x321BAA0", Offset = "0x321AEA0", Length = "0x57")]
	[Token(Token = "0x60002B3")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x321EC90", Offset = "0x321E090", Length = "0x72")]
	[Token(Token = "0x60002AF")]
	protected BaseTreeView get_baseTreeView() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60002B4")]
	 Hierarchy get_hierarchy() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60002B7")]
	public virtual IList get_itemsSource() { }

	[Address(RVA = "0x321BB00", Offset = "0x321AF00", Length = "0x8E")]
	[IteratorStateMachine(typeof(<GetAllItemIds>d__23))]
	[Token(Token = "0x60002B9")]
	public override IEnumerable<Int32> GetAllItemIds(IEnumerable<Int32> rootIds = null) { }

	[Address(RVA = "0x321BB90", Offset = "0x321AF90", Length = "0x251")]
	[Token(Token = "0x60002CA")]
	public int GetChildIndexForId(int id) { }

	[Address(RVA = "0x321BE70", Offset = "0x321B270", Length = "0x80")]
	[IteratorStateMachine(typeof(<GetChildrenIds>d__25))]
	[Token(Token = "0x60002BB")]
	public override IEnumerable<Int32> GetChildrenIds(int id) { }

	[Address(RVA = "0x321BDF0", Offset = "0x321B1F0", Length = "0x80")]
	[IteratorStateMachine(typeof(<GetChildrenIdsByIndex>d__41))]
	[Token(Token = "0x60002C9")]
	public IEnumerable<Int32> GetChildrenIdsByIndex(int index) { }

	[Address(RVA = "0x321BEF0", Offset = "0x321B2F0", Length = "0x420")]
	[Token(Token = "0x60002D6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void GetExpandedItemIds(List<Int32> list) { }

	[Address(RVA = "0x321C320", Offset = "0x321B720", Length = "0x98")]
	[Token(Token = "0x60002E2")]
	internal HierarchyNode GetHierarchyNodeById(int id) { }

	[Address(RVA = "0x321C3C0", Offset = "0x321B7C0", Length = "0x86")]
	[Token(Token = "0x60002E3")]
	internal HierarchyNode GetHierarchyNodeByIndex(int index) { }

	[Address(RVA = "0x321C450", Offset = "0x321B850", Length = "0x17A")]
	[Token(Token = "0x60002C5")]
	public virtual int GetIdForIndex(int index) { }

	[Address(RVA = "0x321C690", Offset = "0x321BA90", Length = "0xAC")]
	[Token(Token = "0x60002CB")]
	public int GetIndentationDepth(int id) { }

	[Address(RVA = "0x321C5D0", Offset = "0x321B9D0", Length = "0xB9")]
	[Token(Token = "0x60002CC")]
	public int GetIndentationDepthByIndex(int index) { }

	[Address(RVA = "0x321C740", Offset = "0x321BB40", Length = "0xBD")]
	[Token(Token = "0x60002C4")]
	public virtual int GetIndexForId(int id) { }

	[Address(RVA = "0x321C800", Offset = "0x321BC00", Length = "0x1BB")]
	[Token(Token = "0x60002BA")]
	public override int GetParentId(int id) { }

	[Address(RVA = "0x321CA60", Offset = "0x321BE60", Length = "0xA6")]
	[Token(Token = "0x60002C6")]
	public override bool HasChildren(int id) { }

	[Address(RVA = "0x321C9C0", Offset = "0x321BDC0", Length = "0x9D")]
	[Token(Token = "0x60002C8")]
	public bool HasChildrenByIndex(int index) { }

	[Address(RVA = "0x321CB10", Offset = "0x321BF10", Length = "0x223")]
	[Token(Token = "0x60002BE")]
	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	[Address(RVA = "0x321CD40", Offset = "0x321C140", Length = "0x246")]
	[Token(Token = "0x60002BF")]
	internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	[Address(RVA = "0x321CF90", Offset = "0x321C390", Length = "0xA5")]
	[Token(Token = "0x60002BD")]
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	[Address(RVA = "0x321D040", Offset = "0x321C440", Length = "0x186")]
	[Token(Token = "0x60002DA")]
	private bool IsChildOf(int childId, int id) { }

	[Address(RVA = "0x321D320", Offset = "0x321C720", Length = "0x10A")]
	[Token(Token = "0x60002CE")]
	public bool IsExpanded(int id) { }

	[Address(RVA = "0x321D1D0", Offset = "0x321C5D0", Length = "0x14E")]
	[Token(Token = "0x60002CF")]
	public bool IsExpandedByIndex(int index) { }

	[Address(RVA = "0x321D430", Offset = "0x321C830", Length = "0x3A")]
	[Token(Token = "0x60002D9")]
	private bool IsIndexValid(int index) { }

	[Address(RVA = "0x321D470", Offset = "0x321C870", Length = "0x50")]
	[Token(Token = "0x60002D7")]
	internal bool IsViewDataKeyEnabled() { }

	[Address(RVA = "0x321D4D0", Offset = "0x321C8D0", Length = "0x2EE")]
	[Token(Token = "0x60002BC")]
	public override void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true) { }

	[Address(RVA = "0x321D7C0", Offset = "0x321CBC0", Length = "0x653")]
	[Token(Token = "0x60002C1")]
	private void OnItemPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x321DE20", Offset = "0x321D220", Length = "0x200")]
	[Token(Token = "0x60002C3")]
	private void OnToggleValueChanged(ChangeEvent<Boolean> evt) { }

	[Address(RVA = "0x321E030", Offset = "0x321D430", Length = "0x1FA")]
	[Token(Token = "0x60002E0")]
	internal void OnViewDataReadyUpdateNodes() { }

	[Address(RVA = "0x321E230", Offset = "0x321D630", Length = "0x1D9")]
	[Token(Token = "0x60002C0")]
	internal void PostInitRegistration(ReusableTreeViewItem treeItem) { }

	[Address(RVA = "0x321E410", Offset = "0x321D810", Length = "0xE")]
	[Token(Token = "0x60002D8")]
	internal virtual void PreRefresh() { }

	[Address(RVA = "0x321E420", Offset = "0x321D820", Length = "0xA9")]
	[Token(Token = "0x60002C2")]
	private void RaiseItemExpandedChanged(int id, bool isExpanded, bool isAppliedToAllChildren) { }

	[Address(RVA = "0x321E4D0", Offset = "0x321D8D0", Length = "0x19")]
	[Token(Token = "0x60002DB")]
	internal void RaiseItemParentChanged(int id, int newParentId) { }

	[Address(RVA = "0x321ED10", Offset = "0x321E110", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x60002B1")]
	internal void remove_itemExpandedChanged(Action<TreeViewExpansionChangedArgs> value) { }

	[Address(RVA = "0x321EDC0", Offset = "0x321E1C0", Length = "0x160")]
	[Token(Token = "0x60002B5")]
	 void set_hierarchy(Hierarchy value) { }

	[Address(RVA = "0x321EF30", Offset = "0x321E330", Length = "0x4E")]
	[Token(Token = "0x60002B8")]
	public virtual void set_itemsSource(IList value) { }

	[Address(RVA = "0x321E4F0", Offset = "0x321D8F0", Length = "0x84")]
	[Token(Token = "0x60002E1")]
	internal void UpdateHierarchy() { }

	[Address(RVA = "0x321E580", Offset = "0x321D980", Length = "0x13A")]
	[Token(Token = "0x60002DD")]
	internal void UpdateIdToNodeDictionary(int id, in HierarchyNode node, bool isAdd = true) { }

	[Address(RVA = "0x321E6C0", Offset = "0x321DAC0", Length = "0x2A1")]
	[Token(Token = "0x60002DF")]
	internal void UpdateSortOrder(in HierarchyNode newParent, in HierarchyNode insertedNode, int insertedIndex) { }

}

