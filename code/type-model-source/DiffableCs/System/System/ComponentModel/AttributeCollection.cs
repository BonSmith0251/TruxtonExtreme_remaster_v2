namespace System.ComponentModel;

[DefaultMember("Item")]
[Token(Token = "0x200015C")]
public class AttributeCollection : ICollection, IEnumerable
{
	[Token(Token = "0x200015D")]
	private struct AttributeEntry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000602")]
		public Type type; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000603")]
		public int index; //Field offset: 0x8

	}

	[Token(Token = "0x40005FC")]
	public static readonly AttributeCollection Empty; //Field offset: 0x0
	[Token(Token = "0x40005FD")]
	private static Hashtable s_defaultAttributes; //Field offset: 0x8
	[Token(Token = "0x40005FF")]
	private static readonly object s_internalSyncObject; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005FE")]
	private readonly Attribute[] _attributes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000600")]
	private AttributeEntry[] _foundAttributeTypes; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000601")]
	private int _index; //Field offset: 0x20

	[Token(Token = "0x17000191")]
	protected override Attribute[] Attributes
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600086B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000192")]
	public int Count
	{
		[Address(RVA = "0x2641380", Offset = "0x2640780", Length = "0x29")]
		[Token(Token = "0x600086C")]
		 get { } //Length: 41
	}

	[Token(Token = "0x17000193")]
	public override Attribute Item
	{
		[Address(RVA = "0x2641640", Offset = "0x2640A40", Length = "0x566")]
		[Token(Token = "0x600086D")]
		 get { } //Length: 1382
	}

	[Token(Token = "0x17000196")]
	private override int System.Collections.ICollection.Count
	{
		[Address(RVA = "0x2641380", Offset = "0x2640780", Length = "0x29")]
		[Token(Token = "0x6000873")]
		private get { } //Length: 41
	}

	[Token(Token = "0x17000194")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000871")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000195")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000872")]
		private get { } //Length: 3
	}

	[Address(RVA = "0x26413B0", Offset = "0x26407B0", Length = "0x18F")]
	[Token(Token = "0x6000876")]
	private static AttributeCollection() { }

	[Address(RVA = "0x2641540", Offset = "0x2640940", Length = "0xFC")]
	[Token(Token = "0x600086A")]
	public AttributeCollection(Attribute[] attributes) { }

	[Address(RVA = "0x2640D20", Offset = "0x2640120", Length = "0x72")]
	[Token(Token = "0x600086E")]
	public bool Contains(Attribute attribute) { }

	[Address(RVA = "0x2640DA0", Offset = "0x26401A0", Length = "0x89")]
	[Token(Token = "0x6000875")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600086B")]
	protected override Attribute[] get_Attributes() { }

	[Address(RVA = "0x2641380", Offset = "0x2640780", Length = "0x29")]
	[Token(Token = "0x600086C")]
	public int get_Count() { }

	[Address(RVA = "0x2641640", Offset = "0x2640A40", Length = "0x566")]
	[Token(Token = "0x600086D")]
	public override Attribute get_Item(Type attributeType) { }

	[Address(RVA = "0x2640E30", Offset = "0x2640230", Length = "0x515")]
	[Token(Token = "0x600086F")]
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	[Address(RVA = "0x2641350", Offset = "0x2640750", Length = "0x2F")]
	[Token(Token = "0x6000870")]
	public IEnumerator GetEnumerator() { }

	[Address(RVA = "0x2641380", Offset = "0x2640780", Length = "0x29")]
	[Token(Token = "0x6000873")]
	private override int System.Collections.ICollection.get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000871")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000872")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x2641350", Offset = "0x2640750", Length = "0x2F")]
	[Token(Token = "0x6000874")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

