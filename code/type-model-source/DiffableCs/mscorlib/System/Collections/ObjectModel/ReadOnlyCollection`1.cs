namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[DefaultMember("Item")]
[Token(Token = "0x20005DF")]
public class ReadOnlyCollection : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001844")]
	private IList<T> list; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001845")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x170006C3")]
	public override int Count
	{
		[Address(RVA = "0xEB68A0", Offset = "0xEB5CA0", Length = "0x46")]
		[Token(Token = "0x6002BA1")]
		 get { } //Length: 70
	}

	[Token(Token = "0x170006C4")]
	public override T Item
	{
		[Address(RVA = "0xEAB730", Offset = "0xEAAB30", Length = "0xCD")]
		[Token(Token = "0x6002BA2")]
		 get { } //Length: 205
	}

	[Token(Token = "0x170006C5")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002BA7")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006C6")]
	private override T System.Collections.Generic.IList<T>.Item
	{
		[Address(RVA = "0xEAB730", Offset = "0xEAAB30", Length = "0xCD")]
		[Token(Token = "0x6002BA8")]
		private get { } //Length: 205
		[Address(RVA = "0xEAB700", Offset = "0xEAAB00", Length = "0xC")]
		[Token(Token = "0x6002BA9")]
		private set { } //Length: 12
	}

	[Token(Token = "0x170006C7")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002BB0")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006C8")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xEB2B10", Offset = "0xEB1F10", Length = "0xD4")]
		[Token(Token = "0x6002BB1")]
		private get { } //Length: 212
	}

	[Token(Token = "0x170006C9")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002BB3")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006CA")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002BB4")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006CB")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0xEB64E0", Offset = "0xEB58E0", Length = "0xE5")]
		[Token(Token = "0x6002BB5")]
		private get { } //Length: 229
		[Address(RVA = "0xEAB700", Offset = "0xEAAB00", Length = "0xC")]
		[Token(Token = "0x6002BB6")]
		private set { } //Length: 12
	}

	[Address(RVA = "0xEB6850", Offset = "0xEB5C50", Length = "0x42")]
	[Token(Token = "0x6002BA0")]
	public ReadOnlyCollection`1(IList<T> list) { }

	[Address(RVA = "0xEAA8C0", Offset = "0xEA9CC0", Length = "0xCC")]
	[Token(Token = "0x6002BA3")]
	public override bool Contains(T value) { }

	[Address(RVA = "0xEAAEE0", Offset = "0xEAA2E0", Length = "0x6A")]
	[Token(Token = "0x6002BA4")]
	public override void CopyTo(T[] array, int index) { }

	[Address(RVA = "0xEB68A0", Offset = "0xEB5CA0", Length = "0x46")]
	[Token(Token = "0x6002BA1")]
	public override int get_Count() { }

	[Address(RVA = "0xEAB730", Offset = "0xEAAB30", Length = "0xCD")]
	[Token(Token = "0x6002BA2")]
	public override T get_Item(int index) { }

	[Address(RVA = "0xEAAF50", Offset = "0xEAA350", Length = "0x46")]
	[Token(Token = "0x6002BA5")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0xEAB160", Offset = "0xEAA560", Length = "0xCC")]
	[Token(Token = "0x6002BA6")]
	public override int IndexOf(T value) { }

	[Address(RVA = "0xEAB6A0", Offset = "0xEAAAA0", Length = "0x58")]
	[Token(Token = "0x6002BB9")]
	private static bool IsCompatibleObject(object value) { }

	[Address(RVA = "0xEAB700", Offset = "0xEAAB00", Length = "0xC")]
	[Token(Token = "0x6002BAA")]
	private override void System.Collections.Generic.ICollection<T>.Add(T value) { }

	[Address(RVA = "0xEAB700", Offset = "0xEAAB00", Length = "0xC")]
	[Token(Token = "0x6002BAB")]
	private override void System.Collections.Generic.ICollection<T>.Clear() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6002BA7")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0xEAB710", Offset = "0xEAAB10", Length = "0x17")]
	[Token(Token = "0x6002BAD")]
	private override bool System.Collections.Generic.ICollection<T>.Remove(T value) { }

	[Address(RVA = "0xEAB730", Offset = "0xEAAB30", Length = "0xCD")]
	[Token(Token = "0x6002BA8")]
	private override T System.Collections.Generic.IList<T>.get_Item(int index) { }

	[Address(RVA = "0xEAB700", Offset = "0xEAAB00", Length = "0xC")]
	[Token(Token = "0x6002BAC")]
	private override void System.Collections.Generic.IList<T>.Insert(int index, T value) { }

	[Address(RVA = "0xEAB700", Offset = "0xEAAB00", Length = "0xC")]
	[Token(Token = "0x6002BAE")]
	private override void System.Collections.Generic.IList<T>.RemoveAt(int index) { }

	[Address(RVA = "0xEAB700", Offset = "0xEAAB00", Length = "0xC")]
	[Token(Token = "0x6002BA9")]
	private override void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }

	[Address(RVA = "0xEACBD0", Offset = "0xEABFD0", Length = "0x426")]
	[Token(Token = "0x6002BB2")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002BB0")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0xEB2B10", Offset = "0xEB1F10", Length = "0xD4")]
	[Token(Token = "0x6002BB1")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xEB4020", Offset = "0xEB3420", Length = "0x46")]
	[Token(Token = "0x6002BAF")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xEB4750", Offset = "0xEB3B50", Length = "0x1A")]
	[Token(Token = "0x6002BB7")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0xEAB700", Offset = "0xEAAB00", Length = "0xC")]
	[Token(Token = "0x6002BB8")]
	private override void System.Collections.IList.Clear() { }

	[Address(RVA = "0xEB4770", Offset = "0xEB3B70", Length = "0x1A2")]
	[Token(Token = "0x6002BBA")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6002BB3")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6002BB4")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0xEB64E0", Offset = "0xEB58E0", Length = "0xE5")]
	[Token(Token = "0x6002BB5")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0xEB5570", Offset = "0xEB4970", Length = "0x1A2")]
	[Token(Token = "0x6002BBB")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0xEAB700", Offset = "0xEAAB00", Length = "0xC")]
	[Token(Token = "0x6002BBC")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0xEAB700", Offset = "0xEAAB00", Length = "0xC")]
	[Token(Token = "0x6002BBD")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0xEAB700", Offset = "0xEAAB00", Length = "0xC")]
	[Token(Token = "0x6002BBE")]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[Address(RVA = "0xEAB700", Offset = "0xEAAB00", Length = "0xC")]
	[Token(Token = "0x6002BB6")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

