namespace System.Runtime.Remoting.Channels;

[Token(Token = "0x2000383")]
internal class CrossAppDomainData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E6D")]
	private object _ContextID; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E6E")]
	private int _DomainID; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E6F")]
	private string _processGuid; //Field offset: 0x20

	[Token(Token = "0x170002FF")]
	internal int DomainID
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6001BE9")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000300")]
	internal string ProcessID
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001BEA")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1F00E60", Offset = "0x1F00260", Length = "0x98")]
	[Token(Token = "0x6001BE8")]
	internal CrossAppDomainData(int domainId) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6001BE9")]
	internal int get_DomainID() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001BEA")]
	internal string get_ProcessID() { }

}

