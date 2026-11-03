namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200009D")]
internal class CollectionWrapper : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection
{
	[FieldOffset(Offset = "0x0")]
	[Nullable(2)]
	[Token(Token = "0x400039E")]
	private readonly IList _list; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x400039F")]
	private readonly ICollection<T> _genericCollection; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Nullable(2)]
	[Token(Token = "0x40003A0")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x170000AD")]
	public override int Count
	{
		[Address(RVA = "0x16D42A0", Offset = "0x16D36A0", Length = "0x9B")]
		[Token(Token = "0x600051F")]
		 get { } //Length: 155
	}

	[Token(Token = "0x170000AE")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x16D4340", Offset = "0x16D3740", Length = "0x9E")]
		[Token(Token = "0x6000520")]
		 get { } //Length: 158
	}

	[Token(Token = "0x170000B1")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600052E")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000B2")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x16D3600", Offset = "0x16D2A00", Length = "0x6B")]
		[Token(Token = "0x600052F")]
		private get { } //Length: 107
	}

	[Token(Token = "0x170000AF")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x16D3D80", Offset = "0x16D3180", Length = "0x9E")]
		[Token(Token = "0x6000529")]
		private get { } //Length: 158
	}

	[Nullable(2)]
	[Token(Token = "0x170000B0")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x16D3E20", Offset = "0x16D3220", Length = "0xA5")]
		[NullableContext(2)]
		[Token(Token = "0x600052B")]
		private get { } //Length: 165
		[Address(RVA = "0x16D3ED0", Offset = "0x16D32D0", Length = "0x15F")]
		[NullableContext(2)]
		[Token(Token = "0x600052C")]
		private set { } //Length: 351
	}

	[Token(Token = "0x170000B3")]
	public override object UnderlyingCollection
	{
		[Address(RVA = "0x16D43E0", Offset = "0x16D37E0", Length = "0xE")]
		[Token(Token = "0x6000532")]
		 get { } //Length: 14
	}

	[Address(RVA = "0x16D41E0", Offset = "0x16D35E0", Length = "0xB1")]
	[Token(Token = "0x6000519")]
	public CollectionWrapper`1(IList list) { }

	[Address(RVA = "0x16D4170", Offset = "0x16D3570", Length = "0x62")]
	[Token(Token = "0x600051A")]
	public CollectionWrapper`1(ICollection<T> list) { }

	[Address(RVA = "0x16D2C20", Offset = "0x16D2020", Length = "0x1D5")]
	[Token(Token = "0x600051B")]
	public override void Add(T item) { }

	[Address(RVA = "0x16D2E00", Offset = "0x16D2200", Length = "0x9E")]
	[Token(Token = "0x600051C")]
	public override void Clear() { }

	[Address(RVA = "0x16D2EA0", Offset = "0x16D22A0", Length = "0x167")]
	[Token(Token = "0x600051D")]
	public override bool Contains(T item) { }

	[Address(RVA = "0x16D3010", Offset = "0x16D2410", Length = "0x11E")]
	[Token(Token = "0x600051E")]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0x16D42A0", Offset = "0x16D36A0", Length = "0x9B")]
	[Token(Token = "0x600051F")]
	public override int get_Count() { }

	[Address(RVA = "0x16D4340", Offset = "0x16D3740", Length = "0x9E")]
	[Token(Token = "0x6000520")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x16D43E0", Offset = "0x16D37E0", Length = "0xE")]
	[Token(Token = "0x6000532")]
	public override object get_UnderlyingCollection() { }

	[Address(RVA = "0x16D3130", Offset = "0x16D2530", Length = "0x76")]
	[Token(Token = "0x6000522")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0x16D31B0", Offset = "0x16D25B0", Length = "0x15C")]
	[NullableContext(2)]
	[Token(Token = "0x6000531")]
	private static bool IsCompatibleObject(object value) { }

	[Address(RVA = "0x16D3310", Offset = "0x16D2710", Length = "0x24F")]
	[Token(Token = "0x6000521")]
	public override bool Remove(T item) { }

	[Address(RVA = "0x16D3560", Offset = "0x16D2960", Length = "0x95")]
	[Token(Token = "0x600052D")]
	private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600052E")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x16D3600", Offset = "0x16D2A00", Length = "0x6B")]
	[Token(Token = "0x600052F")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x16D3670", Offset = "0x16D2A70", Length = "0x4F")]
	[Token(Token = "0x6000523")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x16D36C0", Offset = "0x16D2AC0", Length = "0x10D")]
	[NullableContext(2)]
	[Token(Token = "0x6000524")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x16D37D0", Offset = "0x16D2BD0", Length = "0x118")]
	[NullableContext(2)]
	[Token(Token = "0x6000525")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x16D3D80", Offset = "0x16D3180", Length = "0x9E")]
	[Token(Token = "0x6000529")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x16D3E20", Offset = "0x16D3220", Length = "0xA5")]
	[NullableContext(2)]
	[Token(Token = "0x600052B")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x16D38F0", Offset = "0x16D2CF0", Length = "0x16A")]
	[NullableContext(2)]
	[Token(Token = "0x6000526")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x16D3A60", Offset = "0x16D2E60", Length = "0x15F")]
	[NullableContext(2)]
	[Token(Token = "0x6000528")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x16D3C70", Offset = "0x16D3070", Length = "0x104")]
	[NullableContext(2)]
	[Token(Token = "0x600052A")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x16D3BC0", Offset = "0x16D2FC0", Length = "0xA8")]
	[Token(Token = "0x6000527")]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[Address(RVA = "0x16D3ED0", Offset = "0x16D32D0", Length = "0x15F")]
	[NullableContext(2)]
	[Token(Token = "0x600052C")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

	[Address(RVA = "0x16D4030", Offset = "0x16D3430", Length = "0x13D")]
	[NullableContext(2)]
	[Token(Token = "0x6000530")]
	private static void VerifyValueType(object value) { }

}

