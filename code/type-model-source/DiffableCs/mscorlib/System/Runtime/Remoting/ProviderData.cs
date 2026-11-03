namespace System.Runtime.Remoting;

[Token(Token = "0x2000353")]
internal class ProviderData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E00")]
	internal string Ref; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E01")]
	internal string Type; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E02")]
	internal string Id; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E03")]
	internal Hashtable CustomProperties; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E04")]
	internal IList CustomData; //Field offset: 0x30

	[Address(RVA = "0x1EE1D60", Offset = "0x1EE1160", Length = "0x66")]
	[Token(Token = "0x6001AD6")]
	public ProviderData() { }

	[Address(RVA = "0x1EE51E0", Offset = "0x1EE45E0", Length = "0x5ED")]
	[Token(Token = "0x6001AD5")]
	public void CopyFrom(ProviderData other) { }

}

