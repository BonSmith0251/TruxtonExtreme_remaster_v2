namespace System.Collections;

[Token(Token = "0x20005B8")]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017C9")]
	private ArrayList _list; //Field offset: 0x10

	[Token(Token = "0x17000641")]
	public override int Count
	{
		[Address(RVA = "0x1FCBF00", Offset = "0x1FCB300", Length = "0x30")]
		[Token(Token = "0x60029C8")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000640")]
	protected ArrayList InnerList
	{
		[Address(RVA = "0x1FCBF40", Offset = "0x1FCB340", Length = "0xA1")]
		[Token(Token = "0x60029C7")]
		 get { } //Length: 161
	}

	[Token(Token = "0x17000642")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x1FCBE80", Offset = "0x1FCB280", Length = "0x30")]
		[Token(Token = "0x60029C9")]
		private get { } //Length: 48
	}

	[Token(Token = "0x17000643")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x1FCBEC0", Offset = "0x1FCB2C0", Length = "0x30")]
		[Token(Token = "0x60029CA")]
		private get { } //Length: 48
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60029CD")]
	protected ReadOnlyCollectionBase() { }

	[Address(RVA = "0x1FCBF00", Offset = "0x1FCB300", Length = "0x30")]
	[Token(Token = "0x60029C8")]
	public override int get_Count() { }

	[Address(RVA = "0x1FCBF40", Offset = "0x1FCB340", Length = "0xA1")]
	[Token(Token = "0x60029C7")]
	protected ArrayList get_InnerList() { }

	[Address(RVA = "0x1FCBDF0", Offset = "0x1FCB1F0", Length = "0x30")]
	[Token(Token = "0x60029CC")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x1FCBE30", Offset = "0x1FCB230", Length = "0x48")]
	[Token(Token = "0x60029CB")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x1FCBE80", Offset = "0x1FCB280", Length = "0x30")]
	[Token(Token = "0x60029C9")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x1FCBEC0", Offset = "0x1FCB2C0", Length = "0x30")]
	[Token(Token = "0x60029CA")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

}

