namespace Mono.Security.Authenticode;

[Token(Token = "0x2000053")]
public class AuthenticodeBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000231")]
	private Byte[] fileblock; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000232")]
	private Stream fs; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000233")]
	private int blockNo; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000234")]
	private int blockLength; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000235")]
	private int peOffset; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000236")]
	private int dirSecurityOffset; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000237")]
	private int dirSecuritySize; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000238")]
	private int coffSymbolTableOffset; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000239")]
	private bool pe64; //Field offset: 0x38

	[Token(Token = "0x17000083")]
	internal int PEOffset
	{
		[Address(RVA = "0x1E46A80", Offset = "0x1E45E80", Length = "0x28")]
		[Token(Token = "0x60001CF")]
		internal get { } //Length: 40
	}

	[Address(RVA = "0x1E46A20", Offset = "0x1E45E20", Length = "0x55")]
	[Token(Token = "0x60001CE")]
	public AuthenticodeBase() { }

	[Address(RVA = "0x1E45F50", Offset = "0x1E45350", Length = "0x45")]
	[Token(Token = "0x60001D2")]
	internal void Close() { }

	[Address(RVA = "0x1E46A80", Offset = "0x1E45E80", Length = "0x28")]
	[Token(Token = "0x60001CF")]
	internal int get_PEOffset() { }

	[Address(RVA = "0x1E45FA0", Offset = "0x1E453A0", Length = "0x4E1")]
	[Token(Token = "0x60001D6")]
	internal Byte[] GetHash(HashAlgorithm hash) { }

	[Address(RVA = "0x1E46490", Offset = "0x1E45890", Length = "0xC7")]
	[Token(Token = "0x60001D5")]
	internal Byte[] GetSecurityEntry() { }

	[Address(RVA = "0x1E46560", Offset = "0x1E45960", Length = "0xC0")]
	[Token(Token = "0x60001D0")]
	internal void Open(string filename) { }

	[Address(RVA = "0x1E46620", Offset = "0x1E45A20", Length = "0xA9")]
	[Token(Token = "0x60001D1")]
	internal void Open(Byte[] rawdata) { }

	[Address(RVA = "0x1E466D0", Offset = "0x1E45AD0", Length = "0x279")]
	[Token(Token = "0x60001D4")]
	internal int ProcessFirstBlock() { }

	[Address(RVA = "0x1E46950", Offset = "0x1E45D50", Length = "0xD0")]
	[Token(Token = "0x60001D3")]
	internal void ReadFirstBlock() { }

}

