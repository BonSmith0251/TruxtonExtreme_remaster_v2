namespace System.Security.Cryptography.X509Certificates;

[DefaultMember("Item")]
[Token(Token = "0x2000137")]
public sealed class X509ChainElementCollection : ICollection, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400059E")]
	private ArrayList _list; //Field offset: 0x10

	[Token(Token = "0x17000157")]
	public override int Count
	{
		[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
		[Token(Token = "0x6000786")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000158")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x1FC0410", Offset = "0x1FBF810", Length = "0x2A")]
		[Token(Token = "0x6000787")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000159")]
	public X509ChainElement Item
	{
		[Address(RVA = "0x2651C40", Offset = "0x2651040", Length = "0x98")]
		[Token(Token = "0x6000788")]
		 get { } //Length: 152
	}

	[Token(Token = "0x1700015A")]
	public override object SyncRoot
	{
		[Address(RVA = "0x1FC0440", Offset = "0x1FBF840", Length = "0x2A")]
		[Token(Token = "0x6000789")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2651BD0", Offset = "0x2650FD0", Length = "0x66")]
	[Token(Token = "0x6000785")]
	internal X509ChainElementCollection() { }

	[Address(RVA = "0x26518A0", Offset = "0x2650CA0", Length = "0xAF")]
	[Token(Token = "0x600078D")]
	internal void Add(X509Certificate2 certificate) { }

	[Address(RVA = "0x236FFA0", Offset = "0x236F3A0", Length = "0x2A")]
	[Token(Token = "0x600078E")]
	internal void Clear() { }

	[Address(RVA = "0x2651950", Offset = "0x2650D50", Length = "0x135")]
	[Token(Token = "0x600078F")]
	internal bool Contains(X509Certificate2 certificate) { }

	[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
	[Token(Token = "0x6000786")]
	public override int get_Count() { }

	[Address(RVA = "0x1FC0410", Offset = "0x1FBF810", Length = "0x2A")]
	[Token(Token = "0x6000787")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x2651C40", Offset = "0x2651040", Length = "0x98")]
	[Token(Token = "0x6000788")]
	public X509ChainElement get_Item(int index) { }

	[Address(RVA = "0x1FC0440", Offset = "0x1FBF840", Length = "0x2A")]
	[Token(Token = "0x6000789")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x2651A90", Offset = "0x2650E90", Length = "0x9B")]
	[Token(Token = "0x600078B")]
	public X509ChainElementEnumerator GetEnumerator() { }

	[Address(RVA = "0x1FC03E0", Offset = "0x1FBF7E0", Length = "0x2A")]
	[Token(Token = "0x600078A")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x2651B30", Offset = "0x2650F30", Length = "0x9B")]
	[Token(Token = "0x600078C")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

