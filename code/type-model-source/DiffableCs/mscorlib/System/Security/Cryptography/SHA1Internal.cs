namespace System.Security.Cryptography;

[Token(Token = "0x2000330")]
internal class SHA1Internal
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D73")]
	private UInt32[] _H; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D74")]
	private ulong count; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D75")]
	private Byte[] _ProcessingBuffer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D76")]
	private int _ProcessingBufferCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D77")]
	private UInt32[] buff; //Field offset: 0x30

	[Address(RVA = "0x1ECEEE0", Offset = "0x1ECE2E0", Length = "0x126")]
	[Token(Token = "0x60019CB")]
	public SHA1Internal() { }

	[Address(RVA = "0x1ECD6D0", Offset = "0x1ECCAD0", Length = "0xD6")]
	[Token(Token = "0x60019D3")]
	internal void AddLength(ulong length, Byte[] buffer, int position) { }

	[Address(RVA = "0x1ECD7B0", Offset = "0x1ECCBB0", Length = "0x327")]
	[Token(Token = "0x60019D1")]
	private static void FillBuff(UInt32[] buff) { }

	[Address(RVA = "0x1ECDAE0", Offset = "0x1ECCEE0", Length = "0x139")]
	[Token(Token = "0x60019CC")]
	public void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x1ECDC20", Offset = "0x1ECD020", Length = "0xEE")]
	[Token(Token = "0x60019CD")]
	public Byte[] HashFinal() { }

	[Address(RVA = "0x1ECDD10", Offset = "0x1ECD110", Length = "0x776")]
	[Token(Token = "0x60019D0")]
	private static void InitialiseBuff(UInt32[] buff, Byte[] input, uint inputOffset) { }

	[Address(RVA = "0x1ECE490", Offset = "0x1ECD890", Length = "0x8B")]
	[Token(Token = "0x60019CE")]
	public void Initialize() { }

	[Address(RVA = "0x1ECE520", Offset = "0x1ECD920", Length = "0x76F")]
	[Token(Token = "0x60019CF")]
	private void ProcessBlock(Byte[] inputBuffer, uint inputOffset) { }

	[Address(RVA = "0x1ECEC90", Offset = "0x1ECE090", Length = "0x243")]
	[Token(Token = "0x60019D2")]
	private void ProcessFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

