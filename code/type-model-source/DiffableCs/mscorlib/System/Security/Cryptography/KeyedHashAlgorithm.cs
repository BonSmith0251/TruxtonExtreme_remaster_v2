namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000305")]
public abstract class KeyedHashAlgorithm : HashAlgorithm
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000CE9")]
	protected Byte[] KeyValue; //Field offset: 0x28

	[Token(Token = "0x17000278")]
	public override Byte[] Key
	{
		[Address(RVA = "0x1EBAB20", Offset = "0x1EB9F20", Length = "0x77")]
		[Token(Token = "0x60018A3")]
		 get { } //Length: 119
		[Address(RVA = "0x1EBABA0", Offset = "0x1EB9FA0", Length = "0x119")]
		[Token(Token = "0x60018A4")]
		 set { } //Length: 281
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60018A1")]
	protected KeyedHashAlgorithm() { }

	[Address(RVA = "0x1EBAAD0", Offset = "0x1EB9ED0", Length = "0x46")]
	[Token(Token = "0x60018A2")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1EBAB20", Offset = "0x1EB9F20", Length = "0x77")]
	[Token(Token = "0x60018A3")]
	public override Byte[] get_Key() { }

	[Address(RVA = "0x1EBABA0", Offset = "0x1EB9FA0", Length = "0x119")]
	[Token(Token = "0x60018A4")]
	public override void set_Key(Byte[] value) { }

}

