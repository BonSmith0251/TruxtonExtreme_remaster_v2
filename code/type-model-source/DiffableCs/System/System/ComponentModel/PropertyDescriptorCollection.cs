namespace System.ComponentModel;

[DefaultMember("Item")]
[Token(Token = "0x200018C")]
public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary
{
	[Token(Token = "0x200018D")]
	private class PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400065C")]
		private PropertyDescriptorCollection _owner; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400065D")]
		private int _index; //Field offset: 0x18

		[Token(Token = "0x170001E4")]
		public override object Current
		{
			[Address(RVA = "0x2668F70", Offset = "0x2668370", Length = "0xA5")]
			[Token(Token = "0x60009CF")]
			 get { } //Length: 165
		}

		[Token(Token = "0x170001E5")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x2669020", Offset = "0x2668420", Length = "0x75")]
			[Token(Token = "0x60009D0")]
			 get { } //Length: 117
		}

		[Token(Token = "0x170001E6")]
		public override object Key
		{
			[Address(RVA = "0x26690A0", Offset = "0x26684A0", Length = "0x4B")]
			[Token(Token = "0x60009D1")]
			 get { } //Length: 75
		}

		[Token(Token = "0x170001E7")]
		public override object Value
		{
			[Address(RVA = "0x26690A0", Offset = "0x26684A0", Length = "0x4B")]
			[Token(Token = "0x60009D2")]
			 get { } //Length: 75
		}

		[Address(RVA = "0x2536CB0", Offset = "0x25360B0", Length = "0x38")]
		[Token(Token = "0x60009CE")]
		public PropertyDescriptorEnumerator(PropertyDescriptorCollection owner) { }

		[Address(RVA = "0x2668F70", Offset = "0x2668370", Length = "0xA5")]
		[Token(Token = "0x60009CF")]
		public override object get_Current() { }

		[Address(RVA = "0x2669020", Offset = "0x2668420", Length = "0x75")]
		[Token(Token = "0x60009D0")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x26690A0", Offset = "0x26684A0", Length = "0x4B")]
		[Token(Token = "0x60009D1")]
		public override object get_Key() { }

		[Address(RVA = "0x26690A0", Offset = "0x26684A0", Length = "0x4B")]
		[Token(Token = "0x60009D2")]
		public override object get_Value() { }

		[Address(RVA = "0x2668F40", Offset = "0x2668340", Length = "0x2D")]
		[Token(Token = "0x60009D3")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195A120", Offset = "0x1959520", Length = "0x8")]
		[Token(Token = "0x60009D4")]
		public override void Reset() { }

	}

	[Token(Token = "0x4000651")]
	public static readonly PropertyDescriptorCollection Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000652")]
	private IDictionary _cachedFoundProperties; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000653")]
	private bool _cachedIgnoreCase; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000654")]
	private PropertyDescriptor[] _properties; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000655")]
	private readonly String[] _namedSort; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000656")]
	private readonly IComparer _comparer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000657")]
	private bool _propsOwned; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000658")]
	private bool _needSort; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000659")]
	private bool _readOnly; //Field offset: 0x3A
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400065A")]
	private readonly object _internalSyncObject; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400065B")]
	private int <Count>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x170001D6")]
	public private int Count
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60009A0")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60009A1")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001D7")]
	public override PropertyDescriptor Item
	{
		[Address(RVA = "0x2668EA0", Offset = "0x26682A0", Length = "0x7E")]
		[Token(Token = "0x60009A2")]
		 get { } //Length: 126
	}

	[Token(Token = "0x170001D8")]
	public override PropertyDescriptor Item
	{
		[Address(RVA = "0x2668F20", Offset = "0x2668320", Length = "0x17")]
		[Token(Token = "0x60009A3")]
		 get { } //Length: 23
	}

	[Token(Token = "0x170001DB")]
	private override int System.Collections.ICollection.Count
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x60009B5")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170001D9")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60009B3")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001DA")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60009B4")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001DC")]
	private override bool System.Collections.IDictionary.IsFixedSize
	{
		[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
		[Token(Token = "0x60009BD")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170001DD")]
	private override bool System.Collections.IDictionary.IsReadOnly
	{
		[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
		[Token(Token = "0x60009BE")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170001DE")]
	private override object System.Collections.IDictionary.Item
	{
		[Address(RVA = "0x2667DA0", Offset = "0x26671A0", Length = "0x59")]
		[Token(Token = "0x60009BF")]
		private get { } //Length: 89
		[Address(RVA = "0x2667FA0", Offset = "0x26673A0", Length = "0x443")]
		[Token(Token = "0x60009C0")]
		private set { } //Length: 1091
	}

	[Token(Token = "0x170001DF")]
	private override ICollection System.Collections.IDictionary.Keys
	{
		[Address(RVA = "0x2667E00", Offset = "0x2667200", Length = "0xCA")]
		[Token(Token = "0x60009C1")]
		private get { } //Length: 202
	}

	[Token(Token = "0x170001E0")]
	private override ICollection System.Collections.IDictionary.Values
	{
		[Address(RVA = "0x2667ED0", Offset = "0x26672D0", Length = "0xC9")]
		[Token(Token = "0x60009C2")]
		private get { } //Length: 201
	}

	[Token(Token = "0x170001E2")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
		[Token(Token = "0x60009C9")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170001E1")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
		[Token(Token = "0x60009C8")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170001E3")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x2668870", Offset = "0x2667C70", Length = "0x14")]
		[Token(Token = "0x60009CB")]
		private get { } //Length: 20
		[Address(RVA = "0x2668890", Offset = "0x2667C90", Length = "0x22E")]
		[Token(Token = "0x60009CC")]
		private set { } //Length: 558
	}

	[Address(RVA = "0x2668AC0", Offset = "0x2667EC0", Length = "0xEC")]
	[Token(Token = "0x60009CD")]
	private static PropertyDescriptorCollection() { }

	[Address(RVA = "0x2668BB0", Offset = "0x2667FB0", Length = "0x139")]
	[Token(Token = "0x600099F")]
	private PropertyDescriptorCollection(PropertyDescriptor[] properties, int propCount, String[] namedSort, IComparer comparer) { }

	[Address(RVA = "0x2668CF0", Offset = "0x26680F0", Length = "0xC4")]
	[Token(Token = "0x600099D")]
	public PropertyDescriptorCollection(PropertyDescriptor[] properties) { }

	[Address(RVA = "0x2668DC0", Offset = "0x26681C0", Length = "0xD1")]
	[Token(Token = "0x600099E")]
	public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly) { }

	[Address(RVA = "0x2666A10", Offset = "0x2665E10", Length = "0xE5")]
	[Token(Token = "0x60009A4")]
	public int Add(PropertyDescriptor value) { }

	[Address(RVA = "0x2666B00", Offset = "0x2665F00", Length = "0x64")]
	[Token(Token = "0x60009A5")]
	public void Clear() { }

	[Address(RVA = "0x2666B70", Offset = "0x2665F70", Length = "0x5B")]
	[Token(Token = "0x60009A6")]
	public bool Contains(PropertyDescriptor value) { }

	[Address(RVA = "0x2666BD0", Offset = "0x2665FD0", Length = "0x50")]
	[Token(Token = "0x60009A7")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x2666C20", Offset = "0x2666020", Length = "0xA7")]
	[Token(Token = "0x60009A8")]
	private void EnsurePropsOwned() { }

	[Address(RVA = "0x2666CD0", Offset = "0x26660D0", Length = "0x111")]
	[Token(Token = "0x60009A9")]
	private void EnsureSize(int sizeNeeded) { }

	[Address(RVA = "0x2666DF0", Offset = "0x26661F0", Length = "0x453")]
	[Token(Token = "0x60009AA")]
	public override PropertyDescriptor Find(string name, bool ignoreCase) { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60009A0")]
	public int get_Count() { }

	[Address(RVA = "0x2668EA0", Offset = "0x26682A0", Length = "0x7E")]
	[Token(Token = "0x60009A2")]
	public override PropertyDescriptor get_Item(int index) { }

	[Address(RVA = "0x2668F20", Offset = "0x2668320", Length = "0x17")]
	[Token(Token = "0x60009A3")]
	public override PropertyDescriptor get_Item(string name) { }

	[Address(RVA = "0x2667250", Offset = "0x2666650", Length = "0xA6")]
	[Token(Token = "0x60009B2")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x2667300", Offset = "0x2666700", Length = "0x56")]
	[Token(Token = "0x60009AB")]
	public int IndexOf(PropertyDescriptor value) { }

	[Address(RVA = "0x2667360", Offset = "0x2666760", Length = "0x109")]
	[Token(Token = "0x60009AC")]
	public void Insert(int index, PropertyDescriptor value) { }

	[Address(RVA = "0x26674F0", Offset = "0x26668F0", Length = "0x395")]
	[Token(Token = "0x60009B0")]
	protected void InternalSort(String[] names) { }

	[Address(RVA = "0x2667470", Offset = "0x2666870", Length = "0x73")]
	[Token(Token = "0x60009B1")]
	protected void InternalSort(IComparer sorter) { }

	[Address(RVA = "0x2667950", Offset = "0x2666D50", Length = "0xA6")]
	[Token(Token = "0x60009AD")]
	public void Remove(PropertyDescriptor value) { }

	[Address(RVA = "0x2667890", Offset = "0x2666C90", Length = "0xB7")]
	[Token(Token = "0x60009AE")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60009A1")]
	private void set_Count(int value) { }

	[Address(RVA = "0x2667A00", Offset = "0x2666E00", Length = "0x167")]
	[Token(Token = "0x60009AF")]
	public override PropertyDescriptorCollection Sort(String[] names) { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x60009B5")]
	private override int System.Collections.ICollection.get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60009B3")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60009B4")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x2667B70", Offset = "0x2666F70", Length = "0xBC")]
	[Token(Token = "0x60009BA")]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[Address(RVA = "0x2666B00", Offset = "0x2665F00", Length = "0x64")]
	[Token(Token = "0x60009B7")]
	private override void System.Collections.IDictionary.Clear() { }

	[Address(RVA = "0x2667C30", Offset = "0x2667030", Length = "0x5F")]
	[Token(Token = "0x60009BB")]
	private override bool System.Collections.IDictionary.Contains(object key) { }

	[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
	[Token(Token = "0x60009BD")]
	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
	[Token(Token = "0x60009BE")]
	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	[Address(RVA = "0x2667DA0", Offset = "0x26671A0", Length = "0x59")]
	[Token(Token = "0x60009BF")]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[Address(RVA = "0x2667E00", Offset = "0x2667200", Length = "0xCA")]
	[Token(Token = "0x60009C1")]
	private override ICollection System.Collections.IDictionary.get_Keys() { }

	[Address(RVA = "0x2667ED0", Offset = "0x26672D0", Length = "0xC9")]
	[Token(Token = "0x60009C2")]
	private override ICollection System.Collections.IDictionary.get_Values() { }

	[Address(RVA = "0x2667C90", Offset = "0x2667090", Length = "0x67")]
	[Token(Token = "0x60009BC")]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[Address(RVA = "0x2667D00", Offset = "0x2667100", Length = "0x9C")]
	[Token(Token = "0x60009C3")]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[Address(RVA = "0x2667FA0", Offset = "0x26673A0", Length = "0x443")]
	[Token(Token = "0x60009C0")]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[Address(RVA = "0x26683F0", Offset = "0x26677F0", Length = "0x14")]
	[Token(Token = "0x60009B8")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x2668410", Offset = "0x2667810", Length = "0x7C")]
	[Token(Token = "0x60009C4")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x2666B00", Offset = "0x2665F00", Length = "0x64")]
	[Token(Token = "0x60009B6")]
	private override void System.Collections.IList.Clear() { }

	[Address(RVA = "0x2668490", Offset = "0x2667890", Length = "0xAF")]
	[Token(Token = "0x60009C5")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
	[Token(Token = "0x60009C9")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
	[Token(Token = "0x60009C8")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0x2668870", Offset = "0x2667C70", Length = "0x14")]
	[Token(Token = "0x60009CB")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x2668540", Offset = "0x2667940", Length = "0xAA")]
	[Token(Token = "0x60009C6")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x26685F0", Offset = "0x26679F0", Length = "0x165")]
	[Token(Token = "0x60009C7")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x2668770", Offset = "0x2667B70", Length = "0xFB")]
	[Token(Token = "0x60009CA")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x2668760", Offset = "0x2667B60", Length = "0x8")]
	[Token(Token = "0x60009B9")]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[Address(RVA = "0x2668890", Offset = "0x2667C90", Length = "0x22E")]
	[Token(Token = "0x60009CC")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

