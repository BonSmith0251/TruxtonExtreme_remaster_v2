namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002FD")]
public abstract class HMAC : KeyedHashAlgorithm
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000CE0")]
	private int blockSizeValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000CE1")]
	internal string m_hashName; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000CE2")]
	internal HashAlgorithm m_hash1; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000CE3")]
	internal HashAlgorithm m_hash2; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000CE4")]
	private Byte[] m_inner; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000CE5")]
	private Byte[] m_outer; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000CE6")]
	private bool m_hashing; //Field offset: 0x60

	[Token(Token = "0x17000271")]
	protected int BlockSizeValue
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6001881")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x6001882")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000272")]
	public virtual Byte[] Key
	{
		[Address(RVA = "0x1EB9F70", Offset = "0x1EB9370", Length = "0x77")]
		[Token(Token = "0x6001885")]
		 get { } //Length: 119
		[Address(RVA = "0x1EB9FF0", Offset = "0x1EB93F0", Length = "0x7F")]
		[Token(Token = "0x6001886")]
		 set { } //Length: 127
	}

	[Address(RVA = "0x1EB9F60", Offset = "0x1EB9360", Length = "0xE")]
	[Token(Token = "0x600188C")]
	protected HMAC() { }

	[Address(RVA = "0x1EB96E0", Offset = "0x1EB8AE0", Length = "0x117")]
	[Token(Token = "0x6001887")]
	public static HMAC Create() { }

	[Address(RVA = "0x1EB9800", Offset = "0x1EB8C00", Length = "0xE0")]
	[Token(Token = "0x600188B")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6001881")]
	protected int get_BlockSizeValue() { }

	[Address(RVA = "0x1EB9F70", Offset = "0x1EB9370", Length = "0x77")]
	[Token(Token = "0x6001885")]
	public virtual Byte[] get_Key() { }

	[Address(RVA = "0x1EB98E0", Offset = "0x1EB8CE0", Length = "0x10F")]
	[Token(Token = "0x6001889")]
	protected virtual void HashCore(Byte[] rgb, int ib, int cb) { }

	[Address(RVA = "0x1EB99F0", Offset = "0x1EB8DF0", Length = "0x221")]
	[Token(Token = "0x600188A")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1EB9DB0", Offset = "0x1EB91B0", Length = "0x50")]
	[Token(Token = "0x6001888")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1EB9C20", Offset = "0x1EB9020", Length = "0x180")]
	[Token(Token = "0x6001884")]
	internal void InitializeKey(Byte[] key) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x6001882")]
	protected void set_BlockSizeValue(int value) { }

	[Address(RVA = "0x1EB9FF0", Offset = "0x1EB93F0", Length = "0x7F")]
	[Token(Token = "0x6001886")]
	public virtual void set_Key(Byte[] value) { }

	[Address(RVA = "0x1EB9E10", Offset = "0x1EB9210", Length = "0x14F")]
	[Token(Token = "0x6001883")]
	private void UpdateIOPadBuffers() { }

}

