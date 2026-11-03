namespace System.Security.Cryptography;

[Token(Token = "0x2000013")]
public sealed class AesManaged : Aes
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000001")]
	private RijndaelManaged m_rijndael; //Field offset: 0x48

	[Token(Token = "0x17000001")]
	public virtual int FeedbackSize
	{
		[Address(RVA = "0x2229850", Offset = "0x2228C50", Length = "0x2A")]
		[Token(Token = "0x6000027")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000002")]
	public virtual Byte[] IV
	{
		[Address(RVA = "0x2229880", Offset = "0x2228C80", Length = "0x2A")]
		[Token(Token = "0x6000028")]
		 get { } //Length: 42
		[Address(RVA = "0x2229970", Offset = "0x2228D70", Length = "0x2A")]
		[Token(Token = "0x6000029")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000003")]
	public virtual Byte[] Key
	{
		[Address(RVA = "0x22298E0", Offset = "0x2228CE0", Length = "0x2A")]
		[Token(Token = "0x600002A")]
		 get { } //Length: 42
		[Address(RVA = "0x22299D0", Offset = "0x2228DD0", Length = "0x2A")]
		[Token(Token = "0x600002B")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000004")]
	public virtual int KeySize
	{
		[Address(RVA = "0x22298B0", Offset = "0x2228CB0", Length = "0x2A")]
		[Token(Token = "0x600002C")]
		 get { } //Length: 42
		[Address(RVA = "0x22299A0", Offset = "0x2228DA0", Length = "0x2A")]
		[Token(Token = "0x600002D")]
		 set { } //Length: 42
	}

	[Token(Token = "0x17000005")]
	public virtual CipherMode Mode
	{
		[Address(RVA = "0x2229910", Offset = "0x2228D10", Length = "0x2A")]
		[Token(Token = "0x600002E")]
		 get { } //Length: 42
		[Address(RVA = "0x2229A00", Offset = "0x2228E00", Length = "0xA1")]
		[Token(Token = "0x600002F")]
		 set { } //Length: 161
	}

	[Token(Token = "0x17000006")]
	public virtual PaddingMode Padding
	{
		[Address(RVA = "0x2229940", Offset = "0x2228D40", Length = "0x2A")]
		[Token(Token = "0x6000030")]
		 get { } //Length: 42
		[Address(RVA = "0x2229AB0", Offset = "0x2228EB0", Length = "0x2A")]
		[Token(Token = "0x6000031")]
		 set { } //Length: 42
	}

	[Address(RVA = "0x22296C0", Offset = "0x2228AC0", Length = "0x187")]
	[Token(Token = "0x6000026")]
	public AesManaged() { }

	[Address(RVA = "0x2229210", Offset = "0x2228610", Length = "0x191")]
	[Token(Token = "0x6000033")]
	public virtual ICryptoTransform CreateDecryptor(Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x22293B0", Offset = "0x22287B0", Length = "0x2A")]
	[Token(Token = "0x6000032")]
	public virtual ICryptoTransform CreateDecryptor() { }

	[Address(RVA = "0x22293E0", Offset = "0x22287E0", Length = "0x191")]
	[Token(Token = "0x6000035")]
	public virtual ICryptoTransform CreateEncryptor(Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x2229580", Offset = "0x2228980", Length = "0x2A")]
	[Token(Token = "0x6000034")]
	public virtual ICryptoTransform CreateEncryptor() { }

	[Address(RVA = "0x22295B0", Offset = "0x22289B0", Length = "0xAC")]
	[Token(Token = "0x6000036")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x2229660", Offset = "0x2228A60", Length = "0x2A")]
	[Token(Token = "0x6000037")]
	public virtual void GenerateIV() { }

	[Address(RVA = "0x2229690", Offset = "0x2228A90", Length = "0x2A")]
	[Token(Token = "0x6000038")]
	public virtual void GenerateKey() { }

	[Address(RVA = "0x2229850", Offset = "0x2228C50", Length = "0x2A")]
	[Token(Token = "0x6000027")]
	public virtual int get_FeedbackSize() { }

	[Address(RVA = "0x2229880", Offset = "0x2228C80", Length = "0x2A")]
	[Token(Token = "0x6000028")]
	public virtual Byte[] get_IV() { }

	[Address(RVA = "0x22298E0", Offset = "0x2228CE0", Length = "0x2A")]
	[Token(Token = "0x600002A")]
	public virtual Byte[] get_Key() { }

	[Address(RVA = "0x22298B0", Offset = "0x2228CB0", Length = "0x2A")]
	[Token(Token = "0x600002C")]
	public virtual int get_KeySize() { }

	[Address(RVA = "0x2229910", Offset = "0x2228D10", Length = "0x2A")]
	[Token(Token = "0x600002E")]
	public virtual CipherMode get_Mode() { }

	[Address(RVA = "0x2229940", Offset = "0x2228D40", Length = "0x2A")]
	[Token(Token = "0x6000030")]
	public virtual PaddingMode get_Padding() { }

	[Address(RVA = "0x2229970", Offset = "0x2228D70", Length = "0x2A")]
	[Token(Token = "0x6000029")]
	public virtual void set_IV(Byte[] value) { }

	[Address(RVA = "0x22299D0", Offset = "0x2228DD0", Length = "0x2A")]
	[Token(Token = "0x600002B")]
	public virtual void set_Key(Byte[] value) { }

	[Address(RVA = "0x22299A0", Offset = "0x2228DA0", Length = "0x2A")]
	[Token(Token = "0x600002D")]
	public virtual void set_KeySize(int value) { }

	[Address(RVA = "0x2229A00", Offset = "0x2228E00", Length = "0xA1")]
	[Token(Token = "0x600002F")]
	public virtual void set_Mode(CipherMode value) { }

	[Address(RVA = "0x2229AB0", Offset = "0x2228EB0", Length = "0x2A")]
	[Token(Token = "0x6000031")]
	public virtual void set_Padding(PaddingMode value) { }

}

