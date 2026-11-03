namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000325")]
public abstract class TripleDES : SymmetricAlgorithm
{
	[Token(Token = "0x4000D49")]
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	[Token(Token = "0x4000D4A")]
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8

	[Token(Token = "0x17000294")]
	public virtual Byte[] Key
	{
		[Address(RVA = "0x1ED5B70", Offset = "0x1ED4F70", Length = "0xCA")]
		[Token(Token = "0x6001978")]
		 get { } //Length: 202
		[Address(RVA = "0x1ED5C40", Offset = "0x1ED5040", Length = "0x21B")]
		[Token(Token = "0x6001979")]
		 set { } //Length: 539
	}

	[Address(RVA = "0x1ED5950", Offset = "0x1ED4D50", Length = "0x168")]
	[Token(Token = "0x600197E")]
	private static TripleDES() { }

	[Address(RVA = "0x1ED5AC0", Offset = "0x1ED4EC0", Length = "0xAC")]
	[Token(Token = "0x6001977")]
	protected TripleDES() { }

	[Address(RVA = "0x1ED5480", Offset = "0x1ED4880", Length = "0x44")]
	[Token(Token = "0x600197A")]
	public static TripleDES Create() { }

	[Address(RVA = "0x1ED54D0", Offset = "0x1ED48D0", Length = "0x252")]
	[Token(Token = "0x600197C")]
	private static bool EqualBytes(Byte[] rgbKey, int start1, int start2, int count) { }

	[Address(RVA = "0x1ED5B70", Offset = "0x1ED4F70", Length = "0xCA")]
	[Token(Token = "0x6001978")]
	public virtual Byte[] get_Key() { }

	[Address(RVA = "0x1ED5730", Offset = "0x1ED4B30", Length = "0x19")]
	[Token(Token = "0x600197D")]
	private static bool IsLegalKeySize(Byte[] rgbKey) { }

	[Address(RVA = "0x1ED5750", Offset = "0x1ED4B50", Length = "0x1FD")]
	[Token(Token = "0x600197B")]
	public static bool IsWeakKey(Byte[] rgbKey) { }

	[Address(RVA = "0x1ED5C40", Offset = "0x1ED5040", Length = "0x21B")]
	[Token(Token = "0x6001979")]
	public virtual void set_Key(Byte[] value) { }

}

