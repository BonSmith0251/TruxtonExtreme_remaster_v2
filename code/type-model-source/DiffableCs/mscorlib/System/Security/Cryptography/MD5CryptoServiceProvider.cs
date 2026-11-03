namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200032B")]
public sealed class MD5CryptoServiceProvider : MD5
{
	[Token(Token = "0x4000D67")]
	private static readonly UInt32[] K; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D62")]
	private UInt32[] _H; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D63")]
	private UInt32[] buff; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D64")]
	private ulong count; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D65")]
	private Byte[] _ProcessingBuffer; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000D66")]
	private int _ProcessingBufferCount; //Field offset: 0x48

	[Address(RVA = "0x1ECB990", Offset = "0x1ECAD90", Length = "0x8C")]
	[Token(Token = "0x60019B7")]
	private static MD5CryptoServiceProvider() { }

	[Address(RVA = "0x1ECBA20", Offset = "0x1ECAE20", Length = "0xBA")]
	[Token(Token = "0x60019AE")]
	public MD5CryptoServiceProvider() { }

	[Address(RVA = "0x1ECA070", Offset = "0x1EC9470", Length = "0xD6")]
	[Token(Token = "0x60019B6")]
	internal void AddLength(ulong length, Byte[] buffer, int position) { }

	[Address(RVA = "0x1ECA150", Offset = "0x1EC9550", Length = "0x80")]
	[Token(Token = "0x60019B0")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1ECA1D0", Offset = "0x1EC95D0", Length = "0x65")]
	[Token(Token = "0x60019AF")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1ECA240", Offset = "0x1EC9640", Length = "0x139")]
	[Token(Token = "0x60019B1")]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x1ECA380", Offset = "0x1EC9780", Length = "0xEE")]
	[Token(Token = "0x60019B2")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1ECA470", Offset = "0x1EC9870", Length = "0x75")]
	[Token(Token = "0x60019B3")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1ECA4F0", Offset = "0x1EC98F0", Length = "0x1255")]
	[Token(Token = "0x60019B4")]
	private void ProcessBlock(Byte[] inputBuffer, int inputOffset) { }

	[Address(RVA = "0x1ECB750", Offset = "0x1ECAB50", Length = "0x236")]
	[Token(Token = "0x60019B5")]
	private void ProcessFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

