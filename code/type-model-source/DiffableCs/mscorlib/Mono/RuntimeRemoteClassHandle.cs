namespace Mono;

[Token(Token = "0x2000031")]
internal struct RuntimeRemoteClassHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000108")]
	private RemoteClass* value; //Field offset: 0x0

	[Token(Token = "0x17000006")]
	internal RuntimeClassHandle ProxyClass
	{
		[Address(RVA = "0x1E648C0", Offset = "0x1E63CC0", Length = "0x1A")]
		[Token(Token = "0x6000050")]
		internal get { } //Length: 26
	}

	[Address(RVA = "0x1E648C0", Offset = "0x1E63CC0", Length = "0x1A")]
	[Token(Token = "0x6000050")]
	internal RuntimeClassHandle get_ProxyClass() { }

}

