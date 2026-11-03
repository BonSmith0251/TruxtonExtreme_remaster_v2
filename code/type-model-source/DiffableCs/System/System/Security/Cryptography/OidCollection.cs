namespace System.Security.Cryptography;

[DefaultMember("Item")]
[Token(Token = "0x2000118")]
public sealed class OidCollection : ICollection, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004EE")]
	private readonly List<Oid> _list; //Field offset: 0x10

	[Token(Token = "0x17000110")]
	public override int Count
	{
		[Address(RVA = "0x262F500", Offset = "0x262E900", Length = "0x3C")]
		[Token(Token = "0x60006C0")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000111")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60006C4")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700010F")]
	public Oid Item
	{
		[Address(RVA = "0x262F540", Offset = "0x262E940", Length = "0x51")]
		[Token(Token = "0x60006BF")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000112")]
	public override object SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x60006C5")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x262F480", Offset = "0x262E880", Length = "0x77")]
	[Token(Token = "0x60006BD")]
	public OidCollection() { }

	[Address(RVA = "0x262F0F0", Offset = "0x262E4F0", Length = "0xD0")]
	[Token(Token = "0x60006BE")]
	public int Add(Oid oid) { }

	[Address(RVA = "0x262F500", Offset = "0x262E900", Length = "0x3C")]
	[Token(Token = "0x60006C0")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60006C4")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x262F540", Offset = "0x262E940", Length = "0x51")]
	[Token(Token = "0x60006BF")]
	public Oid get_Item(int index) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60006C5")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x262F1D0", Offset = "0x262E5D0", Length = "0x67")]
	[Token(Token = "0x60006C1")]
	public OidEnumerator GetEnumerator() { }

	[Address(RVA = "0x262F240", Offset = "0x262E640", Length = "0x23A")]
	[Token(Token = "0x60006C3")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x262F1D0", Offset = "0x262E5D0", Length = "0x67")]
	[Token(Token = "0x60006C2")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

