namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[Token(Token = "0x2000207")]
public class SortedSet : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	[CompilerGenerated]
	[Token(Token = "0x200020A")]
	private sealed class <>c__DisplayClass52_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400079E")]
		public int index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400079F")]
		public int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A0")]
		public T[] array; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000DC6")]
		public <>c__DisplayClass52_0() { }

		[Address(RVA = "0xA73CE0", Offset = "0xA730E0", Length = "0x66")]
		[Token(Token = "0x6000DC7")]
		internal bool <CopyTo>b__0(Node<T> node) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200020B")]
	private sealed class <>c__DisplayClass53_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A1")]
		public int index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A2")]
		public Object[] objects; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000DC8")]
		public <>c__DisplayClass53_0() { }

		[Address(RVA = "0xA73E90", Offset = "0xA73290", Length = "0xAC")]
		[Token(Token = "0x6000DC9")]
		internal bool <System.Collections.ICollection.CopyTo>b__0(Node<T> node) { }

	}

	[Token(Token = "0x2000209")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
	{
		[Token(Token = "0x4000798")]
		private static readonly Node<T> s_dummyNode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000799")]
		private SortedSet<T> _tree; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400079A")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400079B")]
		private Stack<Node<T>> _stack; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400079C")]
		private Node<T> _current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400079D")]
		private bool _reverse; //Field offset: 0x0

		[Token(Token = "0x170002CB")]
		public override T Current
		{
			[Address(RVA = "0x195BDB0", Offset = "0x195B1B0", Length = "0x59")]
			[Token(Token = "0x6000DC0")]
			 get { } //Length: 89
		}

		[Token(Token = "0x170002CD")]
		internal bool NotStartedOrEnded
		{
			[Address(RVA = "0x195BEB0", Offset = "0x195B2B0", Length = "0x9")]
			[Token(Token = "0x6000DC2")]
			internal get { } //Length: 9
		}

		[Token(Token = "0x170002CC")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x195ACD0", Offset = "0x195A0D0", Length = "0xA4")]
			[Token(Token = "0x6000DC1")]
			private get { } //Length: 164
		}

		[Address(RVA = "0x195B260", Offset = "0x195A660", Length = "0x114")]
		[Token(Token = "0x6000DC5")]
		private static Enumerator() { }

		[Address(RVA = "0x195B9B0", Offset = "0x195ADB0", Length = "0x97")]
		[Token(Token = "0x6000DB9")]
		internal Enumerator(SortedSet<T> set) { }

		[Address(RVA = "0x195BA50", Offset = "0x195AE50", Length = "0x1BF")]
		[Token(Token = "0x6000DBA")]
		internal Enumerator(SortedSet<T> set, bool reverse) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000DBF")]
		public override void Dispose() { }

		[Address(RVA = "0x195BDB0", Offset = "0x195B1B0", Length = "0x59")]
		[Token(Token = "0x6000DC0")]
		public override T get_Current() { }

		[Address(RVA = "0x195BEB0", Offset = "0x195B2B0", Length = "0x9")]
		[Token(Token = "0x6000DC2")]
		internal bool get_NotStartedOrEnded() { }

		[Address(RVA = "0x1957CD0", Offset = "0x19570D0", Length = "0x1B7")]
		[Token(Token = "0x6000DBD")]
		private void Initialize() { }

		[Address(RVA = "0x1959700", Offset = "0x1958B00", Length = "0x2CE")]
		[Token(Token = "0x6000DBE")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195A260", Offset = "0x1959660", Length = "0x120")]
		[Token(Token = "0x6000DC3")]
		internal void Reset() { }

		[Address(RVA = "0x195ACD0", Offset = "0x195A0D0", Length = "0xA4")]
		[Token(Token = "0x6000DC1")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x195A3D0", Offset = "0x19597D0", Length = "0x87")]
		[Token(Token = "0x6000DC4")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x195B100", Offset = "0x195A500", Length = "0x39")]
		[Token(Token = "0x6000DBC")]
		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		[Address(RVA = "0x195B140", Offset = "0x195A540", Length = "0x39")]
		[Token(Token = "0x6000DBB")]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	[Token(Token = "0x2000208")]
	public sealed class Node
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000794")]
		private T <Item>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000795")]
		private Node<T> <Left>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000796")]
		private Node<T> <Right>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000797")]
		private NodeColor <Color>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x170002C6")]
		public NodeColor Color
		{
			[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000DA7")]
			 get { } //Length: 5
			[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000DA8")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170002C9")]
		public bool Is2Node
		{
			[Address(RVA = "0xD998F0", Offset = "0xD98CF0", Length = "0xB4")]
			[Token(Token = "0x6000DAB")]
			 get { } //Length: 180
		}

		[Token(Token = "0x170002CA")]
		public bool Is4Node
		{
			[Address(RVA = "0xD99A70", Offset = "0xD98E70", Length = "0x98")]
			[Token(Token = "0x6000DAC")]
			 get { } //Length: 152
		}

		[Token(Token = "0x170002C7")]
		public bool IsBlack
		{
			[Address(RVA = "0xD99BB0", Offset = "0xD98FB0", Length = "0x8")]
			[Token(Token = "0x6000DA9")]
			 get { } //Length: 8
		}

		[Token(Token = "0x170002C8")]
		public bool IsRed
		{
			[Address(RVA = "0xD99C20", Offset = "0xD99020", Length = "0x8")]
			[Token(Token = "0x6000DAA")]
			 get { } //Length: 8
		}

		[Token(Token = "0x170002C3")]
		public T Item
		{
			[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
			[CompilerGenerated]
			[Token(Token = "0x6000DA1")]
			 get { } //Length: 11
			[Address(RVA = "0xD99E80", Offset = "0xD99280", Length = "0x12")]
			[CompilerGenerated]
			[Token(Token = "0x6000DA2")]
			 set { } //Length: 18
		}

		[Token(Token = "0x170002C4")]
		public Node<T> Left
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000DA3")]
			 get { } //Length: 5
			[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000DA4")]
			 set { } //Length: 13
		}

		[Token(Token = "0x170002C5")]
		public Node<T> Right
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000DA5")]
			 get { } //Length: 5
			[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000DA6")]
			 set { } //Length: 13
		}

		[Address(RVA = "0xD994E0", Offset = "0xD988E0", Length = "0x46")]
		[Token(Token = "0x6000D9E")]
		public Node(T item, NodeColor color) { }

		[Address(RVA = "0xD985E0", Offset = "0xD979E0", Length = "0x5")]
		[Token(Token = "0x6000DAD")]
		public void ColorBlack() { }

		[Address(RVA = "0xD985F0", Offset = "0xD979F0", Length = "0x5")]
		[Token(Token = "0x6000DAE")]
		public void ColorRed() { }

		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000DA7")]
		public NodeColor get_Color() { }

		[Address(RVA = "0xD998F0", Offset = "0xD98CF0", Length = "0xB4")]
		[Token(Token = "0x6000DAB")]
		public bool get_Is2Node() { }

		[Address(RVA = "0xD99A70", Offset = "0xD98E70", Length = "0x98")]
		[Token(Token = "0x6000DAC")]
		public bool get_Is4Node() { }

		[Address(RVA = "0xD99BB0", Offset = "0xD98FB0", Length = "0x8")]
		[Token(Token = "0x6000DA9")]
		public bool get_IsBlack() { }

		[Address(RVA = "0xD99C20", Offset = "0xD99020", Length = "0x8")]
		[Token(Token = "0x6000DAA")]
		public bool get_IsRed() { }

		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000DA1")]
		public T get_Item() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000DA3")]
		public Node<T> get_Left() { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000DA5")]
		public Node<T> get_Right() { }

		[Address(RVA = "0xD98620", Offset = "0xD97A20", Length = "0x7E")]
		[Token(Token = "0x6000DAF")]
		public TreeRotation GetRotation(Node<T> current, Node<T> sibling) { }

		[Address(RVA = "0xD98740", Offset = "0xD97B40", Length = "0x10")]
		[Token(Token = "0x6000DB0")]
		public Node<T> GetSibling(Node<T> node) { }

		[Address(RVA = "0xD98850", Offset = "0xD97C50", Length = "0x35")]
		[Token(Token = "0x6000D9F")]
		public static bool IsNonNullRed(Node<T> node) { }

		[Address(RVA = "0xD98890", Offset = "0xD97C90", Length = "0x35")]
		[Token(Token = "0x6000DA0")]
		public static bool IsNullOrBlack(Node<T> node) { }

		[Address(RVA = "0xD98960", Offset = "0xD97D60", Length = "0x2C")]
		[Token(Token = "0x6000DB7")]
		public void Merge2Nodes() { }

		[Address(RVA = "0xD98A40", Offset = "0xD97E40", Length = "0x2E")]
		[Token(Token = "0x6000DB8")]
		public void ReplaceChild(Node<T> child, Node<T> newChild) { }

		[Address(RVA = "0xD991B0", Offset = "0xD985B0", Length = "0x1C5")]
		[Token(Token = "0x6000DB2")]
		public Node<T> Rotate(TreeRotation rotation) { }

		[Address(RVA = "0xD98CA0", Offset = "0xD980A0", Length = "0x4A")]
		[Token(Token = "0x6000DB3")]
		public Node<T> RotateLeft() { }

		[Address(RVA = "0xD98AF0", Offset = "0xD97EF0", Length = "0x7E")]
		[Token(Token = "0x6000DB4")]
		public Node<T> RotateLeftRight() { }

		[Address(RVA = "0xD98F50", Offset = "0xD98350", Length = "0x4A")]
		[Token(Token = "0x6000DB5")]
		public Node<T> RotateRight() { }

		[Address(RVA = "0xD98DA0", Offset = "0xD981A0", Length = "0x7E")]
		[Token(Token = "0x6000DB6")]
		public Node<T> RotateRightLeft() { }

		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000DA8")]
		public void set_Color(NodeColor value) { }

		[Address(RVA = "0xD99E80", Offset = "0xD99280", Length = "0x12")]
		[CompilerGenerated]
		[Token(Token = "0x6000DA2")]
		public void set_Item(T value) { }

		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000DA4")]
		public void set_Left(Node<T> value) { }

		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000DA6")]
		public void set_Right(Node<T> value) { }

		[Address(RVA = "0xD99430", Offset = "0xD98830", Length = "0x2C")]
		[Token(Token = "0x6000DB1")]
		public void Split4Node() { }

	}

	[Token(Token = "0x4000789")]
	private const string VersionName = "Version"; //Field offset: 0x0
	[Token(Token = "0x4000791")]
	private const string LowerBoundActiveName = "lBoundActive"; //Field offset: 0x0
	[Token(Token = "0x4000790")]
	private const string MaxName = "Max"; //Field offset: 0x0
	[Token(Token = "0x400078F")]
	private const string MinName = "Min"; //Field offset: 0x0
	[Token(Token = "0x400078E")]
	private const string EnumVersionName = "EnumVersion"; //Field offset: 0x0
	[Token(Token = "0x400078D")]
	private const string ReverseName = "Reverse"; //Field offset: 0x0
	[Token(Token = "0x400078C")]
	private const string EnumStartName = "EnumStarted"; //Field offset: 0x0
	[Token(Token = "0x400078B")]
	private const string NodeValueName = "Item"; //Field offset: 0x0
	[Token(Token = "0x400078A")]
	private const string TreeName = "Tree"; //Field offset: 0x0
	[Token(Token = "0x4000793")]
	internal const int StackAllocThreshold = 100; //Field offset: 0x0
	[Token(Token = "0x4000788")]
	private const string ItemsName = "Items"; //Field offset: 0x0
	[Token(Token = "0x4000787")]
	private const string CountName = "Count"; //Field offset: 0x0
	[Token(Token = "0x4000786")]
	private const string ComparerName = "Comparer"; //Field offset: 0x0
	[Token(Token = "0x4000792")]
	private const string UpperBoundActiveName = "uBoundActive"; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000785")]
	private SerializationInfo siInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000784")]
	private object _syncRoot; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000783")]
	private int version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000782")]
	private int count; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000781")]
	private IComparer<T> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000780")]
	private Node<T> root; //Field offset: 0x0

	[Token(Token = "0x170002BF")]
	public override int Count
	{
		[Address(RVA = "0xF76940", Offset = "0xF75D40", Length = "0x25")]
		[Token(Token = "0x6000D81")]
		 get { } //Length: 37
	}

	[Token(Token = "0x170002C0")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000D82")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170002C1")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000D83")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170002C2")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xF76640", Offset = "0xF75A40", Length = "0x6B")]
		[Token(Token = "0x6000D84")]
		private get { } //Length: 107
	}

	[Address(RVA = "0xF76880", Offset = "0xF75C80", Length = "0x44")]
	[Token(Token = "0x6000D7D")]
	public SortedSet`1() { }

	[Address(RVA = "0xF768D0", Offset = "0xF75CD0", Length = "0x63")]
	[Token(Token = "0x6000D7E")]
	public SortedSet`1(IComparer<T> comparer) { }

	[Address(RVA = "0xF767D0", Offset = "0xF75BD0", Length = "0x31")]
	[Token(Token = "0x6000D7F")]
	protected SortedSet`1(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xF72C90", Offset = "0xF72090", Length = "0x29")]
	[Token(Token = "0x6000D87")]
	public override bool Add(T item) { }

	[Address(RVA = "0xF72690", Offset = "0xF71A90", Length = "0x5F6")]
	[Token(Token = "0x6000D89")]
	internal override bool AddIfNotPresent(T item) { }

	[Address(RVA = "0xF72DB0", Offset = "0xF721B0", Length = "0x2C")]
	[Token(Token = "0x6000D8C")]
	public override void Clear() { }

	[Address(RVA = "0xF72ED0", Offset = "0xF722D0", Length = "0x2F")]
	[Token(Token = "0x6000D8D")]
	public override bool Contains(T item) { }

	[Address(RVA = "0xF73220", Offset = "0xF72620", Length = "0x296")]
	[Token(Token = "0x6000D8F")]
	public void CopyTo(T[] array, int index, int count) { }

	[Address(RVA = "0xF734C0", Offset = "0xF728C0", Length = "0x73")]
	[Token(Token = "0x6000D8E")]
	public override void CopyTo(T[] array, int index) { }

	[Address(RVA = "0xF73A90", Offset = "0xF72E90", Length = "0x568")]
	[Token(Token = "0x6000D8B")]
	internal override bool DoRemove(T item) { }

	[Address(RVA = "0xF741C0", Offset = "0xF735C0", Length = "0x13C")]
	[Token(Token = "0x6000D97")]
	internal override Node<T> FindNode(T item) { }

	[Address(RVA = "0xF76940", Offset = "0xF75D40", Length = "0x25")]
	[Token(Token = "0x6000D81")]
	public override int get_Count() { }

	[Address(RVA = "0xF74300", Offset = "0xF73700", Length = "0x39")]
	[Token(Token = "0x6000D91")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xF74380", Offset = "0xF73780", Length = "0x203")]
	[Token(Token = "0x6000D9A")]
	protected override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xF74A20", Offset = "0xF73E20", Length = "0x17B")]
	[Token(Token = "0x6000D80")]
	internal override bool InOrderTreeWalk(TreeWalkPredicate<T> action) { }

	[Address(RVA = "0xF74BA0", Offset = "0xF73FA0", Length = "0x161")]
	[Token(Token = "0x6000D94")]
	private void InsertionBalance(Node<T> current, ref Node<T> parent, Node<T> grandParent, Node<T> greatGrandParent) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000D86")]
	internal override bool IsWithinRange(T item) { }

	[Address(RVA = "0xF74EA0", Offset = "0xF742A0", Length = "0xD")]
	[Token(Token = "0x6000D9D")]
	private static int Log2(int value) { }

	[Address(RVA = "0xF752E0", Offset = "0xF746E0", Length = "0x39A")]
	[Token(Token = "0x6000D9C")]
	protected override void OnDeserialization(object sender) { }

	[Address(RVA = "0xF75680", Offset = "0xF74A80", Length = "0x29")]
	[Token(Token = "0x6000D8A")]
	public override bool Remove(T item) { }

	[Address(RVA = "0xF757F0", Offset = "0xF74BF0", Length = "0x47")]
	[Token(Token = "0x6000D95")]
	private void ReplaceChildOrRoot(Node<T> parent, Node<T> child, Node<T> newChild) { }

	[Address(RVA = "0xF75840", Offset = "0xF74C40", Length = "0x127")]
	[Token(Token = "0x6000D96")]
	private void ReplaceNode(Node<T> match, Node<T> parentOfMatch, Node<T> successor, Node<T> parentOfSuccessor) { }

	[Address(RVA = "0xF72C90", Offset = "0xF72090", Length = "0x29")]
	[Token(Token = "0x6000D88")]
	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000D82")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0xF75CE0", Offset = "0xF750E0", Length = "0x90")]
	[Token(Token = "0x6000D92")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xF761E0", Offset = "0xF755E0", Length = "0x45B")]
	[Token(Token = "0x6000D90")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000D83")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0xF76640", Offset = "0xF75A40", Length = "0x6B")]
	[Token(Token = "0x6000D84")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xF75CE0", Offset = "0xF750E0", Length = "0x90")]
	[Token(Token = "0x6000D93")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xF76720", Offset = "0xF75B20", Length = "0x14")]
	[Token(Token = "0x6000D9B")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0xF76740", Offset = "0xF75B40", Length = "0x2A")]
	[Token(Token = "0x6000D99")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xF76770", Offset = "0xF75B70", Length = "0x4")]
	[Token(Token = "0x6000D98")]
	internal void UpdateVersion() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000D85")]
	internal override void VersionCheck() { }

}

