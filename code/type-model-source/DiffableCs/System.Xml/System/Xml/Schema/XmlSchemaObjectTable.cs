namespace System.Xml.Schema;

[DefaultMember("Item")]
[Token(Token = "0x2000233")]
public class XmlSchemaObjectTable
{
	[Token(Token = "0x2000234")]
	public enum EnumeratorType : int
	{
		Keys = 0,
		Values = 1,
		DictionaryEntry = 2,
	}

	[Token(Token = "0x2000236")]
	public class ValuesCollection : ICollection, IEnumerable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BAF")]
		private List<XmlSchemaObjectEntry> entries; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000BB0")]
		private int size; //Field offset: 0x18

		[Token(Token = "0x17000623")]
		public override int Count
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[Token(Token = "0x6001629")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000625")]
		public override bool IsSynchronized
		{
			[Address(RVA = "0x24913A0", Offset = "0x24907A0", Length = "0x49")]
			[Token(Token = "0x600162B")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000624")]
		public override object SyncRoot
		{
			[Address(RVA = "0x24913F0", Offset = "0x24907F0", Length = "0x49")]
			[Token(Token = "0x600162A")]
			 get { } //Length: 73
		}

		[Address(RVA = "0xF63E90", Offset = "0xF63290", Length = "0x42")]
		[Token(Token = "0x6001628")]
		internal ValuesCollection(List<XmlSchemaObjectEntry> entries, int size) { }

		[Address(RVA = "0x24911D0", Offset = "0x24905D0", Length = "0x139")]
		[Token(Token = "0x600162C")]
		public override void CopyTo(Array array, int arrayIndex) { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6001629")]
		public override int get_Count() { }

		[Address(RVA = "0x24913A0", Offset = "0x24907A0", Length = "0x49")]
		[Token(Token = "0x600162B")]
		public override bool get_IsSynchronized() { }

		[Address(RVA = "0x24913F0", Offset = "0x24907F0", Length = "0x49")]
		[Token(Token = "0x600162A")]
		public override object get_SyncRoot() { }

		[Address(RVA = "0x2491310", Offset = "0x2490710", Length = "0x82")]
		[Token(Token = "0x600162D")]
		public override IEnumerator GetEnumerator() { }

	}

	[Token(Token = "0x2000235")]
	public struct XmlSchemaObjectEntry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BAD")]
		internal XmlQualifiedName qname; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BAE")]
		internal XmlSchemaObject xso; //Field offset: 0x8

		[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
		[Token(Token = "0x6001627")]
		public XmlSchemaObjectEntry(XmlQualifiedName name, XmlSchemaObject value) { }

	}

	[Token(Token = "0x2000238")]
	public class XSODictionaryEnumerator : XSOEnumerator, IDictionaryEnumerator, IEnumerator
	{

		[Token(Token = "0x17000627")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x24914A0", Offset = "0x24908A0", Length = "0x18F")]
			[Token(Token = "0x6001633")]
			 get { } //Length: 399
		}

		[Token(Token = "0x17000628")]
		public override object Key
		{
			[Address(RVA = "0x2491630", Offset = "0x2490A30", Length = "0x174")]
			[Token(Token = "0x6001634")]
			 get { } //Length: 372
		}

		[Token(Token = "0x17000629")]
		public override object Value
		{
			[Address(RVA = "0x24917B0", Offset = "0x2490BB0", Length = "0x174")]
			[Token(Token = "0x6001635")]
			 get { } //Length: 372
		}

		[Address(RVA = "0x2491440", Offset = "0x2490840", Length = "0x59")]
		[Token(Token = "0x6001632")]
		internal XSODictionaryEnumerator(List<XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

		[Address(RVA = "0x24914A0", Offset = "0x24908A0", Length = "0x18F")]
		[Token(Token = "0x6001633")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x2491630", Offset = "0x2490A30", Length = "0x174")]
		[Token(Token = "0x6001634")]
		public override object get_Key() { }

		[Address(RVA = "0x24917B0", Offset = "0x2490BB0", Length = "0x174")]
		[Token(Token = "0x6001635")]
		public override object get_Value() { }

	}

	[Token(Token = "0x2000237")]
	public class XSOEnumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BB1")]
		private List<XmlSchemaObjectEntry> entries; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000BB2")]
		private EnumeratorType enumType; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000BB3")]
		protected int currentIndex; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BB4")]
		protected int size; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BB5")]
		protected XmlQualifiedName currentKey; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BB6")]
		protected XmlSchemaObject currentValue; //Field offset: 0x30

		[Token(Token = "0x17000626")]
		public override object Current
		{
			[Address(RVA = "0x2491A50", Offset = "0x2490E50", Length = "0x209")]
			[Token(Token = "0x600162F")]
			 get { } //Length: 521
		}

		[Address(RVA = "0x2491440", Offset = "0x2490840", Length = "0x59")]
		[Token(Token = "0x600162E")]
		internal XSOEnumerator(List<XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

		[Address(RVA = "0x2491A50", Offset = "0x2490E50", Length = "0x209")]
		[Token(Token = "0x600162F")]
		public override object get_Current() { }

		[Address(RVA = "0x2491930", Offset = "0x2490D30", Length = "0xD5")]
		[Token(Token = "0x6001630")]
		public override bool MoveNext() { }

		[Address(RVA = "0x2491A10", Offset = "0x2490E10", Length = "0x3B")]
		[Token(Token = "0x6001631")]
		public override void Reset() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BA7")]
	private Dictionary<XmlQualifiedName, XmlSchemaObject> table; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BA8")]
	private List<XmlSchemaObjectEntry> entries; //Field offset: 0x18

	[Token(Token = "0x17000620")]
	public int Count
	{
		[Address(RVA = "0x2498AF0", Offset = "0x2497EF0", Length = "0x44")]
		[Token(Token = "0x6001622")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000621")]
	public XmlSchemaObject Item
	{
		[Address(RVA = "0x2498B40", Offset = "0x2497F40", Length = "0x78")]
		[Token(Token = "0x6001624")]
		 get { } //Length: 120
	}

	[Token(Token = "0x17000622")]
	public ICollection Values
	{
		[Address(RVA = "0x2498BC0", Offset = "0x2497FC0", Length = "0x99")]
		[Token(Token = "0x6001625")]
		 get { } //Length: 153
	}

	[Address(RVA = "0x2498A30", Offset = "0x2497E30", Length = "0xBD")]
	[Token(Token = "0x600161B")]
	internal XmlSchemaObjectTable() { }

	[Address(RVA = "0x2498360", Offset = "0x2497760", Length = "0x12F")]
	[Token(Token = "0x600161C")]
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	[Address(RVA = "0x2498490", Offset = "0x2497890", Length = "0x80")]
	[Token(Token = "0x600161F")]
	internal void Clear() { }

	[Address(RVA = "0x2498520", Offset = "0x2497920", Length = "0x53")]
	[Token(Token = "0x6001623")]
	public bool Contains(XmlQualifiedName name) { }

	[Address(RVA = "0x2498580", Offset = "0x2497980", Length = "0xB4")]
	[Token(Token = "0x6001621")]
	private int FindIndexByValue(XmlSchemaObject xso) { }

	[Address(RVA = "0x2498AF0", Offset = "0x2497EF0", Length = "0x44")]
	[Token(Token = "0x6001622")]
	public int get_Count() { }

	[Address(RVA = "0x2498B40", Offset = "0x2497F40", Length = "0x78")]
	[Token(Token = "0x6001624")]
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	[Address(RVA = "0x2498BC0", Offset = "0x2497FC0", Length = "0x99")]
	[Token(Token = "0x6001625")]
	public ICollection get_Values() { }

	[Address(RVA = "0x2498640", Offset = "0x2497A40", Length = "0xA7")]
	[Token(Token = "0x6001626")]
	public IDictionaryEnumerator GetEnumerator() { }

	[Address(RVA = "0x24986F0", Offset = "0x2497AF0", Length = "0x148")]
	[Token(Token = "0x600161D")]
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	[Address(RVA = "0x2498840", Offset = "0x2497C40", Length = "0xBD")]
	[Token(Token = "0x6001620")]
	internal void Remove(XmlQualifiedName name) { }

	[Address(RVA = "0x2498900", Offset = "0x2497D00", Length = "0x12B")]
	[Token(Token = "0x600161E")]
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

}

