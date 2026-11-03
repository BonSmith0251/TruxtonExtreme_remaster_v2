namespace UnityEngine.UIElements;

[DefaultMember("Item")]
[Token(Token = "0x2000056")]
internal class ReadOnlyHierarchyViewModelList : IList, ICollection, IEnumerable
{
	[Token(Token = "0x2000057")]
	private struct Enumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400019C")]
		private readonly HierarchyViewModel m_HierarchyViewModel; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400019D")]
		private Enumerator m_Enumerator; //Field offset: 0x8

		[Token(Token = "0x1700005E")]
		public override object Current
		{
			[Address(RVA = "0x3223BB0", Offset = "0x3222FB0", Length = "0xD2")]
			[Token(Token = "0x60002AC")]
			 get { } //Length: 210
		}

		[Address(RVA = "0x3223B50", Offset = "0x3222F50", Length = "0x56")]
		[Token(Token = "0x60002AB")]
		public Enumerator(HierarchyViewModel hierarchyViewModel) { }

		[Address(RVA = "0x3223BB0", Offset = "0x3222FB0", Length = "0xD2")]
		[Token(Token = "0x60002AC")]
		public override object get_Current() { }

		[Address(RVA = "0x3223AC0", Offset = "0x3222EC0", Length = "0x39")]
		[Token(Token = "0x60002AD")]
		public override bool MoveNext() { }

		[Address(RVA = "0x3223B00", Offset = "0x3222F00", Length = "0x42")]
		[Token(Token = "0x60002AE")]
		public override void Reset() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400019B")]
	private readonly HierarchyViewModel m_HierarchyViewModel; //Field offset: 0x10

	[Token(Token = "0x1700005A")]
	public override int Count
	{
		[Address(RVA = "0x3225F30", Offset = "0x3225330", Length = "0x1D")]
		[Token(Token = "0x600029C")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000058")]
	public override bool IsFixedSize
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600029A")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000059")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600029B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700005C")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x3225F50", Offset = "0x3225350", Length = "0x3E")]
		[Token(Token = "0x60002A4")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700005B")]
	public override object Item
	{
		[Address(RVA = "0x3225F90", Offset = "0x3225390", Length = "0x8B")]
		[Token(Token = "0x60002A0")]
		 get { } //Length: 139
		[Address(RVA = "0x3226060", Offset = "0x3225460", Length = "0x3E")]
		[Token(Token = "0x60002A1")]
		 set { } //Length: 62
	}

	[Token(Token = "0x1700005D")]
	public override object SyncRoot
	{
		[Address(RVA = "0x3226020", Offset = "0x3225420", Length = "0x3E")]
		[Token(Token = "0x60002A5")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x600029F")]
	public ReadOnlyHierarchyViewModelList(HierarchyViewModel viewModel) { }

	[Address(RVA = "0x3225A90", Offset = "0x3224E90", Length = "0x3E")]
	[Token(Token = "0x60002A6")]
	public override int Add(object value) { }

	[Address(RVA = "0x3225AD0", Offset = "0x3224ED0", Length = "0x3E")]
	[Token(Token = "0x60002A7")]
	public override void Clear() { }

	[Address(RVA = "0x3225B10", Offset = "0x3224F10", Length = "0xA1")]
	[Token(Token = "0x600029D")]
	public override bool Contains(object value) { }

	[Address(RVA = "0x3225BC0", Offset = "0x3224FC0", Length = "0xFB")]
	[Token(Token = "0x60002A2")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x3225F30", Offset = "0x3225330", Length = "0x1D")]
	[Token(Token = "0x600029C")]
	public override int get_Count() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600029A")]
	public override bool get_IsFixedSize() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600029B")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x3225F50", Offset = "0x3225350", Length = "0x3E")]
	[Token(Token = "0x60002A4")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x3225F90", Offset = "0x3225390", Length = "0x8B")]
	[Token(Token = "0x60002A0")]
	public override object get_Item(int index) { }

	[Address(RVA = "0x3226020", Offset = "0x3225420", Length = "0x3E")]
	[Token(Token = "0x60002A5")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x3225CC0", Offset = "0x32250C0", Length = "0xC4")]
	[Token(Token = "0x60002A3")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x3225D90", Offset = "0x3225190", Length = "0xD7")]
	[Token(Token = "0x600029E")]
	public override int IndexOf(object value) { }

	[Address(RVA = "0x3225E70", Offset = "0x3225270", Length = "0x3E")]
	[Token(Token = "0x60002A8")]
	public override void Insert(int index, object value) { }

	[Address(RVA = "0x3225EF0", Offset = "0x32252F0", Length = "0x3E")]
	[Token(Token = "0x60002A9")]
	public override void Remove(object value) { }

	[Address(RVA = "0x3225EB0", Offset = "0x32252B0", Length = "0x3E")]
	[Token(Token = "0x60002AA")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x3226060", Offset = "0x3225460", Length = "0x3E")]
	[Token(Token = "0x60002A1")]
	public override void set_Item(int index, object value) { }

}

