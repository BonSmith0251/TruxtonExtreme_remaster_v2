namespace System.Security.Cryptography;

[Token(Token = "0x2000014")]
public sealed class AesCryptoServiceProvider : Aes
{

	[Token(Token = "0x1700000A")]
	public virtual int FeedbackSize
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000044")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000007")]
	public virtual Byte[] IV
	{
		[Address(RVA = "0x2229140", Offset = "0x2228540", Length = "0x7")]
		[Token(Token = "0x600003E")]
		 get { } //Length: 7
		[Address(RVA = "0x2229160", Offset = "0x2228560", Length = "0x8")]
		[Token(Token = "0x600003F")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000008")]
	public virtual Byte[] Key
	{
		[Address(RVA = "0x2229150", Offset = "0x2228550", Length = "0x7")]
		[Token(Token = "0x6000040")]
		 get { } //Length: 7
		[Address(RVA = "0x2229180", Offset = "0x2228580", Length = "0x8")]
		[Token(Token = "0x6000041")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000009")]
	public virtual int KeySize
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000042")]
		 get { } //Length: 4
		[Address(RVA = "0x2229170", Offset = "0x2228570", Length = "0x8")]
		[Token(Token = "0x6000043")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700000B")]
	public virtual CipherMode Mode
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x6000045")]
		 get { } //Length: 4
		[Address(RVA = "0x2229190", Offset = "0x2228590", Length = "0x67")]
		[Token(Token = "0x6000046")]
		 set { } //Length: 103
	}

	[Token(Token = "0x1700000C")]
	public virtual PaddingMode Padding
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x6000047")]
		 get { } //Length: 4
		[Address(RVA = "0x2229200", Offset = "0x2228600", Length = "0x8")]
		[Token(Token = "0x6000048")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x22290E0", Offset = "0x22284E0", Length = "0x51")]
	[Token(Token = "0x6000039")]
	public AesCryptoServiceProvider() { }

	[Address(RVA = "0x1ED44F0", Offset = "0x1ED38F0", Length = "0x61")]
	[Token(Token = "0x6000049")]
	public virtual ICryptoTransform CreateDecryptor() { }

	[Address(RVA = "0x2228E70", Offset = "0x2228270", Length = "0xFD")]
	[Token(Token = "0x600003C")]
	public virtual ICryptoTransform CreateDecryptor(Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x1ED4560", Offset = "0x1ED3960", Length = "0x61")]
	[Token(Token = "0x600004A")]
	public virtual ICryptoTransform CreateEncryptor() { }

	[Address(RVA = "0x2228F70", Offset = "0x2228370", Length = "0xFD")]
	[Token(Token = "0x600003D")]
	public virtual ICryptoTransform CreateEncryptor(Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x2229070", Offset = "0x2228470", Length = "0x8")]
	[Token(Token = "0x600004B")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x2229080", Offset = "0x2228480", Length = "0x2B")]
	[Token(Token = "0x600003A")]
	public virtual void GenerateIV() { }

	[Address(RVA = "0x22290B0", Offset = "0x22284B0", Length = "0x2B")]
	[Token(Token = "0x600003B")]
	public virtual void GenerateKey() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6000044")]
	public virtual int get_FeedbackSize() { }

	[Address(RVA = "0x2229140", Offset = "0x2228540", Length = "0x7")]
	[Token(Token = "0x600003E")]
	public virtual Byte[] get_IV() { }

	[Address(RVA = "0x2229150", Offset = "0x2228550", Length = "0x7")]
	[Token(Token = "0x6000040")]
	public virtual Byte[] get_Key() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000042")]
	public virtual int get_KeySize() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x6000045")]
	public virtual CipherMode get_Mode() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x6000047")]
	public virtual PaddingMode get_Padding() { }

	[Address(RVA = "0x2229160", Offset = "0x2228560", Length = "0x8")]
	[Token(Token = "0x600003F")]
	public virtual void set_IV(Byte[] value) { }

	[Address(RVA = "0x2229180", Offset = "0x2228580", Length = "0x8")]
	[Token(Token = "0x6000041")]
	public virtual void set_Key(Byte[] value) { }

	[Address(RVA = "0x2229170", Offset = "0x2228570", Length = "0x8")]
	[Token(Token = "0x6000043")]
	public virtual void set_KeySize(int value) { }

	[Address(RVA = "0x2229190", Offset = "0x2228590", Length = "0x67")]
	[Token(Token = "0x6000046")]
	public virtual void set_Mode(CipherMode value) { }

	[Address(RVA = "0x2229200", Offset = "0x2228600", Length = "0x8")]
	[Token(Token = "0x6000048")]
	public virtual void set_Padding(PaddingMode value) { }

}

