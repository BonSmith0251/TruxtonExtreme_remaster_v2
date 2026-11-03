namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F7")]
public abstract class DES : SymmetricAlgorithm
{
	[Token(Token = "0x4000CD3")]
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	[Token(Token = "0x4000CD4")]
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8

	[Token(Token = "0x17000270")]
	public virtual Byte[] Key
	{
		[Address(RVA = "0x1EB73C0", Offset = "0x1EB67C0", Length = "0xF1")]
		[Token(Token = "0x6001867")]
		 get { } //Length: 241
		[Address(RVA = "0x1EB74C0", Offset = "0x1EB68C0", Length = "0x2A7")]
		[Token(Token = "0x6001868")]
		 set { } //Length: 679
	}

	[Address(RVA = "0x1EB71C0", Offset = "0x1EB65C0", Length = "0x15C")]
	[Token(Token = "0x600186E")]
	private static DES() { }

	[Address(RVA = "0x1EB7320", Offset = "0x1EB6720", Length = "0x9E")]
	[Token(Token = "0x6001866")]
	protected DES() { }

	[Address(RVA = "0x1EB6CB0", Offset = "0x1EB60B0", Length = "0x174")]
	[Token(Token = "0x6001869")]
	public static DES Create() { }

	[Address(RVA = "0x1EB73C0", Offset = "0x1EB67C0", Length = "0xF1")]
	[Token(Token = "0x6001867")]
	public virtual Byte[] get_Key() { }

	[Address(RVA = "0x1EB6E30", Offset = "0x1EB6230", Length = "0x10")]
	[Token(Token = "0x600186C")]
	private static bool IsLegalKeySize(Byte[] rgbKey) { }

	[Address(RVA = "0x1EB6E40", Offset = "0x1EB6240", Length = "0x1A7")]
	[Token(Token = "0x600186B")]
	public static bool IsSemiWeakKey(Byte[] rgbKey) { }

	[Address(RVA = "0x1EB6FF0", Offset = "0x1EB63F0", Length = "0x11B")]
	[Token(Token = "0x600186A")]
	public static bool IsWeakKey(Byte[] rgbKey) { }

	[Address(RVA = "0x1EB7110", Offset = "0x1EB6510", Length = "0xAB")]
	[Token(Token = "0x600186D")]
	private static ulong QuadWordFromBigEndian(Byte[] block) { }

	[Address(RVA = "0x1EB74C0", Offset = "0x1EB68C0", Length = "0x2A7")]
	[Token(Token = "0x6001868")]
	public virtual void set_Key(Byte[] value) { }

}

