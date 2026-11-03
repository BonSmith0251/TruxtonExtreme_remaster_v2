namespace UnityEngine;

[Token(Token = "0x20000A2")]
[UsedByNativeCode]
public struct CachedAssetBundle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E0")]
	private string m_Name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001E1")]
	private Hash128 m_Hash; //Field offset: 0x8

	[Token(Token = "0x17000068")]
	public Hash128 hash
	{
		[Address(RVA = "0x2FD0300", Offset = "0x2FCF700", Length = "0xB")]
		[Token(Token = "0x60002B6")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000067")]
	public string name
	{
		[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
		[Token(Token = "0x60002B5")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAEE500", Offset = "0xAED900", Length = "0x2A")]
	[Token(Token = "0x60002B4")]
	public CachedAssetBundle(string name, Hash128 hash) { }

	[Address(RVA = "0x2FD0300", Offset = "0x2FCF700", Length = "0xB")]
	[Token(Token = "0x60002B6")]
	public Hash128 get_hash() { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x60002B5")]
	public string get_name() { }

}

