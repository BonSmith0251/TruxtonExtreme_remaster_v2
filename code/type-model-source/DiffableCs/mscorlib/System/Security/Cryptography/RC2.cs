namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200030A")]
public abstract class RC2 : SymmetricAlgorithm
{
	[Token(Token = "0x4000CF4")]
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	[Token(Token = "0x4000CF5")]
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000CF3")]
	protected int EffectiveKeySizeValue; //Field offset: 0x48

	[Token(Token = "0x1700027F")]
	public override int EffectiveKeySize
	{
		[Address(RVA = "0x1EBBAE0", Offset = "0x1EBAEE0", Length = "0xE")]
		[Token(Token = "0x60018C0")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000280")]
	public virtual int KeySize
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x60018C1")]
		 get { } //Length: 4
		[Address(RVA = "0x1EBBAF0", Offset = "0x1EBAEF0", Length = "0x7E")]
		[Token(Token = "0x60018C2")]
		 set { } //Length: 126
	}

	[Address(RVA = "0x1EBB8D0", Offset = "0x1EBACD0", Length = "0x162")]
	[Token(Token = "0x60018C3")]
	private static RC2() { }

	[Address(RVA = "0x1EBBA40", Offset = "0x1EBAE40", Length = "0x9E")]
	[Token(Token = "0x60018BF")]
	protected RC2() { }

	[Address(RVA = "0x1EBBAE0", Offset = "0x1EBAEE0", Length = "0xE")]
	[Token(Token = "0x60018C0")]
	public override int get_EffectiveKeySize() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x60018C1")]
	public virtual int get_KeySize() { }

	[Address(RVA = "0x1EBBAF0", Offset = "0x1EBAEF0", Length = "0x7E")]
	[Token(Token = "0x60018C2")]
	public virtual void set_KeySize(int value) { }

}

