namespace System.Runtime.Remoting;

[Token(Token = "0x2000352")]
internal class ChannelData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DF9")]
	internal string Ref; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DFA")]
	internal string Type; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DFB")]
	internal string Id; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DFC")]
	internal string DelayLoadAsClientChannel; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000DFD")]
	private ArrayList _serverProviders; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000DFE")]
	private ArrayList _clientProviders; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000DFF")]
	private Hashtable _customProperties; //Field offset: 0x40

	[Token(Token = "0x170002D3")]
	public ArrayList ClientProviders
	{
		[Address(RVA = "0x1ED7AF0", Offset = "0x1ED6EF0", Length = "0x69")]
		[Token(Token = "0x6001AD1")]
		 get { } //Length: 105
	}

	[Token(Token = "0x170002D4")]
	public Hashtable CustomProperties
	{
		[Address(RVA = "0x1ED7B60", Offset = "0x1ED6F60", Length = "0x69")]
		[Token(Token = "0x6001AD2")]
		 get { } //Length: 105
	}

	[Token(Token = "0x170002D2")]
	internal ArrayList ServerProviders
	{
		[Address(RVA = "0x1ED7BD0", Offset = "0x1ED6FD0", Length = "0x69")]
		[Token(Token = "0x6001AD0")]
		internal get { } //Length: 105
	}

	[Address(RVA = "0x1ED7A20", Offset = "0x1ED6E20", Length = "0xC4")]
	[Token(Token = "0x6001AD4")]
	public ChannelData() { }

	[Address(RVA = "0x1ED70E0", Offset = "0x1ED64E0", Length = "0x93B")]
	[Token(Token = "0x6001AD3")]
	public void CopyFrom(ChannelData other) { }

	[Address(RVA = "0x1ED7AF0", Offset = "0x1ED6EF0", Length = "0x69")]
	[Token(Token = "0x6001AD1")]
	public ArrayList get_ClientProviders() { }

	[Address(RVA = "0x1ED7B60", Offset = "0x1ED6F60", Length = "0x69")]
	[Token(Token = "0x6001AD2")]
	public Hashtable get_CustomProperties() { }

	[Address(RVA = "0x1ED7BD0", Offset = "0x1ED6FD0", Length = "0x69")]
	[Token(Token = "0x6001AD0")]
	internal ArrayList get_ServerProviders() { }

}

