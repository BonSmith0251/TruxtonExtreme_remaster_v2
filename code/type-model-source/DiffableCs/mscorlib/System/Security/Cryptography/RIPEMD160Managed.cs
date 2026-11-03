namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000311")]
public class RIPEMD160Managed : RIPEMD160
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D15")]
	private Byte[] _buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D16")]
	private long _count; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D17")]
	private UInt32[] _stateMD160; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D18")]
	private UInt32[] _blockDWords; //Field offset: 0x40

	[Address(RVA = "0x1EBDD70", Offset = "0x1EBD170", Length = "0x1AC")]
	[Token(Token = "0x60018EF")]
	private Byte[] _EndHash() { }

	[Address(RVA = "0x1EBDF20", Offset = "0x1EBD320", Length = "0x195")]
	[Token(Token = "0x60018EE")]
	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	[Address(RVA = "0x1EBE0C0", Offset = "0x1EBD4C0", Length = "0x13F")]
	[Token(Token = "0x60018E9")]
	public RIPEMD160Managed() { }

	[Address(RVA = "0x1EBBB70", Offset = "0x1EBAF70", Length = "0x8")]
	[Token(Token = "0x60018F1")]
	private static uint F(uint x, uint y, uint z) { }

	[Address(RVA = "0x1EBBB80", Offset = "0x1EBAF80", Length = "0xC")]
	[Token(Token = "0x60018F2")]
	private static uint G(uint x, uint y, uint z) { }

	[Address(RVA = "0x1EBBB90", Offset = "0x1EBAF90", Length = "0xA")]
	[Token(Token = "0x60018F3")]
	private static uint H(uint x, uint y, uint z) { }

	[Address(RVA = "0x1EBBBA0", Offset = "0x1EBAFA0", Length = "0xE")]
	[Token(Token = "0x60018EB")]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x1EBBBB0", Offset = "0x1EBAFB0", Length = "0x7")]
	[Token(Token = "0x60018EC")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1EBBBC0", Offset = "0x1EBAFC0", Length = "0xD")]
	[Token(Token = "0x60018F4")]
	private static uint I(uint x, uint y, uint z) { }

	[Address(RVA = "0x1EBBC60", Offset = "0x1EBB060", Length = "0x50")]
	[Token(Token = "0x60018EA")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1EBBBD0", Offset = "0x1EBAFD0", Length = "0x8A")]
	[Token(Token = "0x60018ED")]
	private void InitializeState() { }

	[Address(RVA = "0x1EBBCC0", Offset = "0x1EBB0C0", Length = "0xD")]
	[Token(Token = "0x60018F5")]
	private static uint J(uint x, uint y, uint z) { }

	[Address(RVA = "0x1EBBCD0", Offset = "0x1EBB0D0", Length = "0x209D")]
	[Token(Token = "0x60018F0")]
	private static void MDTransform(UInt32* blockDWords, UInt32* state, Byte* block) { }

}

