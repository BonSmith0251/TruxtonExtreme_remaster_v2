namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[Token(Token = "0x20001F0")]
public class LinkedList : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	[Token(Token = "0x20001F1")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000749")]
		private LinkedList<T> _list; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400074A")]
		private LinkedListNode<T> _node; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400074B")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400074C")]
		private T _current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400074D")]
		private int _index; //Field offset: 0x0

		[Token(Token = "0x17000274")]
		public override T Current
		{
			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[Token(Token = "0x6000C9B")]
			 get { } //Length: 11
		}

		[Token(Token = "0x17000275")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x195AFF0", Offset = "0x195A3F0", Length = "0xD4")]
			[Token(Token = "0x6000C9C")]
			private get { } //Length: 212
		}

		[Address(RVA = "0x195B3F0", Offset = "0x195A7F0", Length = "0x52")]
		[Token(Token = "0x6000C99")]
		internal Enumerator(LinkedList<T> list) { }

		[Address(RVA = "0x195B140", Offset = "0x195A540", Length = "0x39")]
		[Token(Token = "0x6000C9A")]
		private Enumerator(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000C9F")]
		public override void Dispose() { }

		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[Token(Token = "0x6000C9B")]
		public override T get_Current() { }

		[Address(RVA = "0x1958B60", Offset = "0x1957F60", Length = "0x11E")]
		[Token(Token = "0x6000C9D")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195AFF0", Offset = "0x195A3F0", Length = "0xD4")]
		[Token(Token = "0x6000C9C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x195A640", Offset = "0x1959A40", Length = "0x94")]
		[Token(Token = "0x6000C9E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x195B100", Offset = "0x195A500", Length = "0x39")]
		[Token(Token = "0x6000CA1")]
		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		[Address(RVA = "0x195B140", Offset = "0x195A540", Length = "0x39")]
		[Token(Token = "0x6000CA0")]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	[Token(Token = "0x4000746")]
	private const string VersionName = "Version"; //Field offset: 0x0
	[Token(Token = "0x4000747")]
	private const string CountName = "Count"; //Field offset: 0x0
	[Token(Token = "0x4000748")]
	private const string ValuesName = "Data"; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000741")]
	internal LinkedListNode<T> head; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000742")]
	internal int count; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000743")]
	internal int version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000744")]
	private object _syncRoot; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000745")]
	private SerializationInfo _siInfo; //Field offset: 0x0

	[Token(Token = "0x1700026E")]
	public override int Count
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000C7A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700026F")]
	public LinkedListNode<T> First
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C7B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000270")]
	public LinkedListNode<T> Last
	{
		[Address(RVA = "0xB09E70", Offset = "0xB09270", Length = "0x13")]
		[Token(Token = "0x6000C7C")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000271")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C7D")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000272")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C95")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000273")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xB09830", Offset = "0xB08C30", Length = "0x68")]
		[Token(Token = "0x6000C96")]
		private get { } //Length: 104
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000C78")]
	public LinkedList`1() { }

	[Address(RVA = "0xAFFCD0", Offset = "0xAFF0D0", Length = "0x31")]
	[Token(Token = "0x6000C79")]
	protected LinkedList`1(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xB00300", Offset = "0xAFF700", Length = "0x1DC")]
	[Token(Token = "0x6000C7F")]
	public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) { }

	[Address(RVA = "0xB00FD0", Offset = "0xB003D0", Length = "0x131")]
	[Token(Token = "0x6000C80")]
	public LinkedListNode<T> AddFirst(T value) { }

	[Address(RVA = "0xB005D0", Offset = "0xAFF9D0", Length = "0x180")]
	[Token(Token = "0x6000C81")]
	public void AddFirst(LinkedListNode<T> node) { }

	[Address(RVA = "0xB016A0", Offset = "0xB00AA0", Length = "0x10F")]
	[Token(Token = "0x6000C82")]
	public LinkedListNode<T> AddLast(T value) { }

	[Address(RVA = "0xB01110", Offset = "0xB00510", Length = "0x162")]
	[Token(Token = "0x6000C83")]
	public void AddLast(LinkedListNode<T> node) { }

	[Address(RVA = "0xB01B30", Offset = "0xB00F30", Length = "0xAD")]
	[Token(Token = "0x6000C84")]
	public override void Clear() { }

	[Address(RVA = "0xB01CE0", Offset = "0xB010E0", Length = "0x30")]
	[Token(Token = "0x6000C85")]
	public override bool Contains(T value) { }

	[Address(RVA = "0xB02A90", Offset = "0xB01E90", Length = "0x211")]
	[Token(Token = "0x6000C86")]
	public override void CopyTo(T[] array, int index) { }

	[Address(RVA = "0xB03860", Offset = "0xB02C60", Length = "0x1A1")]
	[Token(Token = "0x6000C87")]
	public LinkedListNode<T> Find(T value) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000C7A")]
	public override int get_Count() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C7B")]
	public LinkedListNode<T> get_First() { }

	[Address(RVA = "0xB09E70", Offset = "0xB09270", Length = "0x13")]
	[Token(Token = "0x6000C7C")]
	public LinkedListNode<T> get_Last() { }

	[Address(RVA = "0xB03D70", Offset = "0xB03170", Length = "0x37")]
	[Token(Token = "0x6000C88")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xB04880", Offset = "0xB03C80", Length = "0x183")]
	[Token(Token = "0x6000C8E")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0xB04D60", Offset = "0xB04160", Length = "0x84")]
	[Token(Token = "0x6000C90")]
	private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) { }

	[Address(RVA = "0xB04DF0", Offset = "0xB041F0", Length = "0x58")]
	[Token(Token = "0x6000C91")]
	private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode) { }

	[Address(RVA = "0xB04F30", Offset = "0xB04330", Length = "0xC9")]
	[Token(Token = "0x6000C92")]
	internal void InternalRemoveNode(LinkedListNode<T> node) { }

	[Address(RVA = "0xB06440", Offset = "0xB05840", Length = "0x30B")]
	[Token(Token = "0x6000C8F")]
	public override void OnDeserialization(object sender) { }

	[Address(RVA = "0xB071A0", Offset = "0xB065A0", Length = "0x6B")]
	[Token(Token = "0x6000C8A")]
	public override bool Remove(T value) { }

	[Address(RVA = "0xB06DF0", Offset = "0xB061F0", Length = "0xB3")]
	[Token(Token = "0x6000C8B")]
	public void Remove(LinkedListNode<T> node) { }

	[Address(RVA = "0xB06A80", Offset = "0xB05E80", Length = "0x76")]
	[Token(Token = "0x6000C8C")]
	public void RemoveFirst() { }

	[Address(RVA = "0xB06B80", Offset = "0xB05F80", Length = "0x7A")]
	[Token(Token = "0x6000C8D")]
	public void RemoveLast() { }

	[Address(RVA = "0xB07250", Offset = "0xB06650", Length = "0x2A")]
	[Token(Token = "0x6000C7E")]
	private override void System.Collections.Generic.ICollection<T>.Add(T value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C7D")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0xB074E0", Offset = "0xB068E0", Length = "0x92")]
	[Token(Token = "0x6000C89")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xB08400", Offset = "0xB07800", Length = "0x3FF")]
	[Token(Token = "0x6000C97")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C95")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0xB09830", Offset = "0xB08C30", Length = "0x68")]
	[Token(Token = "0x6000C96")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xB074E0", Offset = "0xB068E0", Length = "0x92")]
	[Token(Token = "0x6000C98")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xB09BB0", Offset = "0xB08FB0", Length = "0x9D")]
	[Token(Token = "0x6000C93")]
	internal void ValidateNewNode(LinkedListNode<T> node) { }

	[Address(RVA = "0xB09D10", Offset = "0xB09110", Length = "0x9C")]
	[Token(Token = "0x6000C94")]
	internal void ValidateNode(LinkedListNode<T> node) { }

}

