namespace System.ComponentModel;

[DefaultMember("Item")]
[Token(Token = "0x2000174")]
public class EventDescriptorCollection : ICollection, IEnumerable, IList
{
	[Token(Token = "0x2000175")]
	private class ArraySubsetEnumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000629")]
		private readonly Array _array; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400062A")]
		private readonly int _total; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400062B")]
		private int _current; //Field offset: 0x1C

		[Token(Token = "0x170001B4")]
		public override object Current
		{
			[Address(RVA = "0x265B890", Offset = "0x265AC90", Length = "0x6C")]
			[Token(Token = "0x6000913")]
			 get { } //Length: 108
		}

		[Address(RVA = "0x265B840", Offset = "0x265AC40", Length = "0x49")]
		[Token(Token = "0x6000910")]
		public ArraySubsetEnumerator(Array array, int count) { }

		[Address(RVA = "0x265B890", Offset = "0x265AC90", Length = "0x6C")]
		[Token(Token = "0x6000913")]
		public override object get_Current() { }

		[Address(RVA = "0x265B810", Offset = "0x265AC10", Length = "0x13")]
		[Token(Token = "0x6000911")]
		public override bool MoveNext() { }

		[Address(RVA = "0x265B830", Offset = "0x265AC30", Length = "0x8")]
		[Token(Token = "0x6000912")]
		public override void Reset() { }

	}

	[Token(Token = "0x4000627")]
	public static readonly EventDescriptorCollection Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000621")]
	private EventDescriptor[] _events; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000622")]
	private String[] _namedSort; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000623")]
	private readonly IComparer _comparer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000624")]
	private bool _eventsOwned; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000625")]
	private bool _needSort; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000626")]
	private readonly bool _readOnly; //Field offset: 0x2A
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000628")]
	private int <Count>k__BackingField; //Field offset: 0x2C

	[Token(Token = "0x170001AB")]
	public private int Count
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008EE")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008EF")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001AC")]
	public override EventDescriptor Item
	{
		[Address(RVA = "0x2662BF0", Offset = "0x2661FF0", Length = "0x7E")]
		[Token(Token = "0x60008F0")]
		 get { } //Length: 126
	}

	[Token(Token = "0x170001AD")]
	public override EventDescriptor Item
	{
		[Address(RVA = "0x2662BD0", Offset = "0x2661FD0", Length = "0x17")]
		[Token(Token = "0x60008F1")]
		 get { } //Length: 23
	}

	[Token(Token = "0x170001B0")]
	private override int System.Collections.ICollection.Count
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6000902")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170001AE")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000900")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001AF")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000901")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001B3")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
		[Token(Token = "0x600090E")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170001B2")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
		[Token(Token = "0x600090D")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170001B1")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x22F7FC0", Offset = "0x22F73C0", Length = "0x14")]
		[Token(Token = "0x6000904")]
		private get { } //Length: 20
		[Address(RVA = "0x2662840", Offset = "0x2661C40", Length = "0x1A5")]
		[Token(Token = "0x6000905")]
		private set { } //Length: 421
	}

	[Address(RVA = "0x26629F0", Offset = "0x2661DF0", Length = "0xA7")]
	[Token(Token = "0x600090F")]
	private static EventDescriptorCollection() { }

	[Address(RVA = "0x2662AA0", Offset = "0x2661EA0", Length = "0x88")]
	[Token(Token = "0x60008EC")]
	public EventDescriptorCollection(EventDescriptor[] events) { }

	[Address(RVA = "0x2662B30", Offset = "0x2661F30", Length = "0x9A")]
	[Token(Token = "0x60008ED")]
	public EventDescriptorCollection(EventDescriptor[] events, bool readOnly) { }

	[Address(RVA = "0x26615A0", Offset = "0x26609A0", Length = "0xE5")]
	[Token(Token = "0x60008F2")]
	public int Add(EventDescriptor value) { }

	[Address(RVA = "0x2661690", Offset = "0x2660A90", Length = "0x58")]
	[Token(Token = "0x60008F3")]
	public void Clear() { }

	[Address(RVA = "0x26616F0", Offset = "0x2660AF0", Length = "0x5B")]
	[Token(Token = "0x60008F4")]
	public bool Contains(EventDescriptor value) { }

	[Address(RVA = "0x2661750", Offset = "0x2660B50", Length = "0xA7")]
	[Token(Token = "0x60008F6")]
	private void EnsureEventsOwned() { }

	[Address(RVA = "0x2661800", Offset = "0x2660C00", Length = "0x111")]
	[Token(Token = "0x60008F7")]
	private void EnsureSize(int sizeNeeded) { }

	[Address(RVA = "0x2661920", Offset = "0x2660D20", Length = "0x139")]
	[Token(Token = "0x60008F8")]
	public override EventDescriptor Find(string name, bool ignoreCase) { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008EE")]
	public int get_Count() { }

	[Address(RVA = "0x2662BF0", Offset = "0x2661FF0", Length = "0x7E")]
	[Token(Token = "0x60008F0")]
	public override EventDescriptor get_Item(int index) { }

	[Address(RVA = "0x2662BD0", Offset = "0x2661FD0", Length = "0x17")]
	[Token(Token = "0x60008F1")]
	public override EventDescriptor get_Item(string name) { }

	[Address(RVA = "0x2661A60", Offset = "0x2660E60", Length = "0xA1")]
	[Token(Token = "0x60008FD")]
	public IEnumerator GetEnumerator() { }

	[Address(RVA = "0x2661B10", Offset = "0x2660F10", Length = "0x56")]
	[Token(Token = "0x60008F9")]
	public int IndexOf(EventDescriptor value) { }

	[Address(RVA = "0x2661B70", Offset = "0x2660F70", Length = "0x109")]
	[Token(Token = "0x60008FA")]
	public void Insert(int index, EventDescriptor value) { }

	[Address(RVA = "0x2661C80", Offset = "0x2661080", Length = "0x73")]
	[Token(Token = "0x60008FF")]
	protected void InternalSort(IComparer sorter) { }

	[Address(RVA = "0x2661D00", Offset = "0x2661100", Length = "0x395")]
	[Token(Token = "0x60008FE")]
	protected void InternalSort(String[] names) { }

	[Address(RVA = "0x2662160", Offset = "0x2661560", Length = "0xA6")]
	[Token(Token = "0x60008FB")]
	public void Remove(EventDescriptor value) { }

	[Address(RVA = "0x26620A0", Offset = "0x26614A0", Length = "0xB7")]
	[Token(Token = "0x60008FC")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008EF")]
	private void set_Count(int value) { }

	[Address(RVA = "0x2662210", Offset = "0x2661610", Length = "0x50")]
	[Token(Token = "0x60008F5")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000902")]
	private override int System.Collections.ICollection.get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000900")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000901")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x2662260", Offset = "0x2661660", Length = "0xA6")]
	[Token(Token = "0x6000903")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x2662310", Offset = "0x2661710", Length = "0x145")]
	[Token(Token = "0x6000906")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x2661690", Offset = "0x2660A90", Length = "0x58")]
	[Token(Token = "0x6000908")]
	private override void System.Collections.IList.Clear() { }

	[Address(RVA = "0x2662460", Offset = "0x2661860", Length = "0xAF")]
	[Token(Token = "0x6000907")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
	[Token(Token = "0x600090E")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x1CC53A0", Offset = "0x1CC47A0", Length = "0x5")]
	[Token(Token = "0x600090D")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0x22F7FC0", Offset = "0x22F73C0", Length = "0x14")]
	[Token(Token = "0x6000904")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x2662510", Offset = "0x2661910", Length = "0xAA")]
	[Token(Token = "0x6000909")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x26625C0", Offset = "0x26619C0", Length = "0x165")]
	[Token(Token = "0x600090A")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x2662740", Offset = "0x2661B40", Length = "0xFB")]
	[Token(Token = "0x600090B")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x2662730", Offset = "0x2661B30", Length = "0x8")]
	[Token(Token = "0x600090C")]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[Address(RVA = "0x2662840", Offset = "0x2661C40", Length = "0x1A5")]
	[Token(Token = "0x6000905")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

