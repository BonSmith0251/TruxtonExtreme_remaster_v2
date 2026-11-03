namespace System.Collections.Specialized;

[DefaultMember("Item")]
[Token(Token = "0x20001E0")]
public class StringCollection : IList, ICollection, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000715")]
	private readonly ArrayList data; //Field offset: 0x10

	[Token(Token = "0x17000252")]
	public override int Count
	{
		[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
		[Token(Token = "0x6000C11")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000255")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C1A")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000251")]
	public string Item
	{
		[Address(RVA = "0x268E610", Offset = "0x268DA10", Length = "0x4F")]
		[Token(Token = "0x6000C0F")]
		 get { } //Length: 79
		[Address(RVA = "0x268E730", Offset = "0x268DB30", Length = "0x2A")]
		[Token(Token = "0x6000C10")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000256")]
	public override object SyncRoot
	{
		[Address(RVA = "0x1FC0440", Offset = "0x1FBF840", Length = "0x2A")]
		[Token(Token = "0x6000C1D")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000254")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C13")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000253")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C12")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000257")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x268E610", Offset = "0x268DA10", Length = "0x4F")]
		[Token(Token = "0x6000C1E")]
		private get { } //Length: 79
		[Address(RVA = "0x268E660", Offset = "0x268DA60", Length = "0x57")]
		[Token(Token = "0x6000C1F")]
		private set { } //Length: 87
	}

	[Address(RVA = "0x268E6C0", Offset = "0x268DAC0", Length = "0x66")]
	[Token(Token = "0x6000C27")]
	public StringCollection() { }

	[Address(RVA = "0x268E370", Offset = "0x268D770", Length = "0x2A")]
	[Token(Token = "0x6000C14")]
	public int Add(string value) { }

	[Address(RVA = "0x236FFA0", Offset = "0x236F3A0", Length = "0x2A")]
	[Token(Token = "0x6000C15")]
	public override void Clear() { }

	[Address(RVA = "0x1FC0580", Offset = "0x1FBF980", Length = "0x2A")]
	[Token(Token = "0x6000C16")]
	public bool Contains(string value) { }

	[Address(RVA = "0x1FC03E0", Offset = "0x1FBF7E0", Length = "0x2A")]
	[Token(Token = "0x6000C17")]
	public void CopyTo(String[] array, int index) { }

	[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
	[Token(Token = "0x6000C11")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C1A")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x268E610", Offset = "0x268DA10", Length = "0x4F")]
	[Token(Token = "0x6000C0F")]
	public string get_Item(int index) { }

	[Address(RVA = "0x1FC0440", Offset = "0x1FBF840", Length = "0x2A")]
	[Token(Token = "0x6000C1D")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x1FC05B0", Offset = "0x1FBF9B0", Length = "0x2A")]
	[Token(Token = "0x6000C18")]
	public int IndexOf(string value) { }

	[Address(RVA = "0x268E3A0", Offset = "0x268D7A0", Length = "0x2A")]
	[Token(Token = "0x6000C19")]
	public void Insert(int index, string value) { }

	[Address(RVA = "0x268E400", Offset = "0x268D800", Length = "0x2A")]
	[Token(Token = "0x6000C1B")]
	public void Remove(string value) { }

	[Address(RVA = "0x268E3D0", Offset = "0x268D7D0", Length = "0x2A")]
	[Token(Token = "0x6000C1C")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x268E730", Offset = "0x268DB30", Length = "0x2A")]
	[Token(Token = "0x6000C10")]
	public void set_Item(int index, string value) { }

	[Address(RVA = "0x1FC03E0", Offset = "0x1FBF7E0", Length = "0x2A")]
	[Token(Token = "0x6000C25")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x1E3EF90", Offset = "0x1E3E390", Length = "0x2A")]
	[Token(Token = "0x6000C26")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x268E430", Offset = "0x268D830", Length = "0x53")]
	[Token(Token = "0x6000C20")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x268E490", Offset = "0x268D890", Length = "0x53")]
	[Token(Token = "0x6000C21")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C13")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C12")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0x268E610", Offset = "0x268DA10", Length = "0x4F")]
	[Token(Token = "0x6000C1E")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x268E4F0", Offset = "0x268D8F0", Length = "0x53")]
	[Token(Token = "0x6000C22")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x268E550", Offset = "0x268D950", Length = "0x57")]
	[Token(Token = "0x6000C23")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x268E5B0", Offset = "0x268D9B0", Length = "0x53")]
	[Token(Token = "0x6000C24")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x268E660", Offset = "0x268DA60", Length = "0x57")]
	[Token(Token = "0x6000C1F")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

