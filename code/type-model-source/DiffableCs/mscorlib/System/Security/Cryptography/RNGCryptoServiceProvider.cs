namespace System.Security.Cryptography;

[Token(Token = "0x200032D")]
public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
{
	[Token(Token = "0x4000D6F")]
	private static object _lock; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D70")]
	private IntPtr _handle; //Field offset: 0x10

	[Address(RVA = "0x1ECD020", Offset = "0x1ECC420", Length = "0x8D")]
	[Token(Token = "0x60019BB")]
	private static RNGCryptoServiceProvider() { }

	[Address(RVA = "0x1ECD0B0", Offset = "0x1ECC4B0", Length = "0x60")]
	[Token(Token = "0x60019BC")]
	public RNGCryptoServiceProvider() { }

	[Address(RVA = "0x1ECCCA0", Offset = "0x1ECC0A0", Length = "0x79")]
	[Token(Token = "0x60019BD")]
	private void Check() { }

	[Address(RVA = "0x1ECCD20", Offset = "0x1ECC120", Length = "0x8")]
	[Token(Token = "0x60019C4")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1ECCD30", Offset = "0x1ECC130", Length = "0xA2")]
	[Token(Token = "0x60019C3")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1ECCDE0", Offset = "0x1ECC1E0", Length = "0x1FA")]
	[Token(Token = "0x60019C2")]
	public virtual void GetBytes(Byte[] data) { }

	[Address(RVA = "0x1ECCFE0", Offset = "0x1ECC3E0", Length = "0x5")]
	[Token(Token = "0x60019C1")]
	private static void RngClose(IntPtr handle) { }

	[Address(RVA = "0x1ECCFF0", Offset = "0x1ECC3F0", Length = "0x5")]
	[Token(Token = "0x60019C0")]
	private static IntPtr RngGetBytes(IntPtr handle, Byte* data, IntPtr data_length) { }

	[Address(RVA = "0x1ECD000", Offset = "0x1ECC400", Length = "0x5")]
	[Token(Token = "0x60019BF")]
	private static IntPtr RngInitialize(Byte* seed, IntPtr seed_length) { }

	[Address(RVA = "0x1ECD010", Offset = "0x1ECC410", Length = "0x5")]
	[Token(Token = "0x60019BE")]
	private static bool RngOpen() { }

}

