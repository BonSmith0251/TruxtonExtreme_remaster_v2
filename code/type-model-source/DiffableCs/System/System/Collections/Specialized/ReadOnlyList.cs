namespace System.Collections.Specialized;

[DefaultMember("Item")]
[Token(Token = "0x20001E5")]
internal sealed class ReadOnlyList : IList, ICollection, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000721")]
	private readonly IList _list; //Field offset: 0x10

	[Token(Token = "0x17000258")]
	public override int Count
	{
		[Address(RVA = "0x268D7A0", Offset = "0x268CBA0", Length = "0x49")]
		[Token(Token = "0x6000C33")]
		 get { } //Length: 73
	}

	[Token(Token = "0x1700025A")]
	public override bool IsFixedSize
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000C35")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000259")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000C34")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700025B")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x268D7F0", Offset = "0x268CBF0", Length = "0x49")]
		[Token(Token = "0x6000C36")]
		 get { } //Length: 73
	}

	[Token(Token = "0x1700025C")]
	public override object Item
	{
		[Address(RVA = "0x268D840", Offset = "0x268CC40", Length = "0x54")]
		[Token(Token = "0x6000C37")]
		 get { } //Length: 84
		[Address(RVA = "0x268D8F0", Offset = "0x268CCF0", Length = "0x4E")]
		[Token(Token = "0x6000C38")]
		 set { } //Length: 78
	}

	[Token(Token = "0x1700025D")]
	public override object SyncRoot
	{
		[Address(RVA = "0x268D8A0", Offset = "0x268CCA0", Length = "0x49")]
		[Token(Token = "0x6000C39")]
		 get { } //Length: 73
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000C32")]
	internal ReadOnlyList(IList list) { }

	[Address(RVA = "0x268D420", Offset = "0x268C820", Length = "0x4E")]
	[Token(Token = "0x6000C3A")]
	public override int Add(object value) { }

	[Address(RVA = "0x268D470", Offset = "0x268C870", Length = "0x4E")]
	[Token(Token = "0x6000C3B")]
	public override void Clear() { }

	[Address(RVA = "0x268D4C0", Offset = "0x268C8C0", Length = "0xC3")]
	[Token(Token = "0x6000C3C")]
	public override bool Contains(object value) { }

	[Address(RVA = "0x268D590", Offset = "0x268C990", Length = "0x67")]
	[Token(Token = "0x6000C3D")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x268D7A0", Offset = "0x268CBA0", Length = "0x49")]
	[Token(Token = "0x6000C33")]
	public override int get_Count() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000C35")]
	public override bool get_IsFixedSize() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000C34")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x268D7F0", Offset = "0x268CBF0", Length = "0x49")]
	[Token(Token = "0x6000C36")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x268D840", Offset = "0x268CC40", Length = "0x54")]
	[Token(Token = "0x6000C37")]
	public override object get_Item(int index) { }

	[Address(RVA = "0x268D8A0", Offset = "0x268CCA0", Length = "0x49")]
	[Token(Token = "0x6000C39")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x268D600", Offset = "0x268CA00", Length = "0x46")]
	[Token(Token = "0x6000C3E")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x268D650", Offset = "0x268CA50", Length = "0x58")]
	[Token(Token = "0x6000C3F")]
	public override int IndexOf(object value) { }

	[Address(RVA = "0x268D6B0", Offset = "0x268CAB0", Length = "0x4E")]
	[Token(Token = "0x6000C40")]
	public override void Insert(int index, object value) { }

	[Address(RVA = "0x268D750", Offset = "0x268CB50", Length = "0x4E")]
	[Token(Token = "0x6000C41")]
	public override void Remove(object value) { }

	[Address(RVA = "0x268D700", Offset = "0x268CB00", Length = "0x4E")]
	[Token(Token = "0x6000C42")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x268D8F0", Offset = "0x268CCF0", Length = "0x4E")]
	[Token(Token = "0x6000C38")]
	public override void set_Item(int index, object value) { }

}

