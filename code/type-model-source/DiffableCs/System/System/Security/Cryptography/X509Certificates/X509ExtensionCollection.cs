namespace System.Security.Cryptography.X509Certificates;

[DefaultMember("Item")]
[Token(Token = "0x200013F")]
public sealed class X509ExtensionCollection : ICollection, IEnumerable
{
	[Token(Token = "0x40005BE")]
	private static Byte[] Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005BF")]
	private ArrayList _list; //Field offset: 0x10

	[Token(Token = "0x17000172")]
	public override int Count
	{
		[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
		[Token(Token = "0x60007E2")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000173")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x1FC0410", Offset = "0x1FBF810", Length = "0x2A")]
		[Token(Token = "0x60007E3")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000175")]
	public X509Extension Item
	{
		[Address(RVA = "0x2658910", Offset = "0x2657D10", Length = "0x25F")]
		[Token(Token = "0x60007E5")]
		 get { } //Length: 607
	}

	[Token(Token = "0x17000174")]
	public override object SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x60007E4")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2658830", Offset = "0x2657C30", Length = "0x65")]
	[Token(Token = "0x60007EA")]
	private static X509ExtensionCollection() { }

	[Address(RVA = "0x26588A0", Offset = "0x2657CA0", Length = "0x66")]
	[Token(Token = "0x60007E1")]
	public X509ExtensionCollection() { }

	[Address(RVA = "0x2658530", Offset = "0x2657930", Length = "0x81")]
	[Token(Token = "0x60007E6")]
	public int Add(X509Extension extension) { }

	[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
	[Token(Token = "0x60007E2")]
	public override int get_Count() { }

	[Address(RVA = "0x1FC0410", Offset = "0x1FBF810", Length = "0x2A")]
	[Token(Token = "0x60007E3")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x2658910", Offset = "0x2657D10", Length = "0x25F")]
	[Token(Token = "0x60007E5")]
	public X509Extension get_Item(string oid) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60007E4")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x26585C0", Offset = "0x26579C0", Length = "0x85")]
	[Token(Token = "0x60007E8")]
	public X509ExtensionEnumerator GetEnumerator() { }

	[Address(RVA = "0x2658650", Offset = "0x2657A50", Length = "0x149")]
	[Token(Token = "0x60007E7")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x26587A0", Offset = "0x2657BA0", Length = "0x85")]
	[Token(Token = "0x60007E9")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

