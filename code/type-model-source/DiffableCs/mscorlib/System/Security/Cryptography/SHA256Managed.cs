namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000318")]
public class SHA256Managed : SHA256
{
	[Token(Token = "0x4000D30")]
	private static readonly UInt32[] _K; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D2C")]
	private Byte[] _buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D2D")]
	private long _count; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D2E")]
	private UInt32[] _stateSHA256; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D2F")]
	private UInt32[] _W; //Field offset: 0x40

	[Address(RVA = "0x1ED0B60", Offset = "0x1ECFF60", Length = "0x239")]
	[Token(Token = "0x6001921")]
	private Byte[] _EndHash() { }

	[Address(RVA = "0x1ED0DA0", Offset = "0x1ED01A0", Length = "0x1DF")]
	[Token(Token = "0x6001920")]
	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	[Address(RVA = "0x1ED0F80", Offset = "0x1ED0380", Length = "0x8C")]
	[Token(Token = "0x600192B")]
	private static SHA256Managed() { }

	[Address(RVA = "0x1ED1010", Offset = "0x1ED0410", Length = "0xD5")]
	[Token(Token = "0x600191B")]
	public SHA256Managed() { }

	[Address(RVA = "0x1ECFB90", Offset = "0x1ECEF90", Length = "0xC")]
	[Token(Token = "0x6001924")]
	private static uint Ch(uint x, uint y, uint z) { }

	[Address(RVA = "0x1ECFBA0", Offset = "0x1ECEFA0", Length = "0xE")]
	[Token(Token = "0x600191D")]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x1ECFBB0", Offset = "0x1ECEFB0", Length = "0x7")]
	[Token(Token = "0x600191E")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1ECFCB0", Offset = "0x1ECF0B0", Length = "0x50")]
	[Token(Token = "0x600191C")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1ECFBC0", Offset = "0x1ECEFC0", Length = "0xE4")]
	[Token(Token = "0x600191F")]
	private void InitializeState() { }

	[Address(RVA = "0x1ECFD10", Offset = "0x1ECF110", Length = "0xD")]
	[Token(Token = "0x6001925")]
	private static uint Maj(uint x, uint y, uint z) { }

	[Address(RVA = "0x1ECFD20", Offset = "0x1ECF120", Length = "0x19")]
	[Token(Token = "0x6001923")]
	private static uint RotateRight(uint x, int n) { }

	[Address(RVA = "0x1ECFD40", Offset = "0x1ECF140", Length = "0x133")]
	[Token(Token = "0x600192A")]
	private static void SHA256Expand(UInt32* x) { }

	[Address(RVA = "0x1ECFE80", Offset = "0x1ECF280", Length = "0xBF3")]
	[Token(Token = "0x6001922")]
	private static void SHATransform(UInt32* expandedBuffer, UInt32* state, Byte* block) { }

	[Address(RVA = "0x1ED10F0", Offset = "0x1ED04F0", Length = "0x5E")]
	[Token(Token = "0x6001926")]
	private static uint sigma_0(uint x) { }

	[Address(RVA = "0x1ED0A80", Offset = "0x1ECFE80", Length = "0x68")]
	[Token(Token = "0x6001928")]
	private static uint Sigma_0(uint x) { }

	[Address(RVA = "0x1ED1150", Offset = "0x1ED0550", Length = "0x5E")]
	[Token(Token = "0x6001927")]
	private static uint sigma_1(uint x) { }

	[Address(RVA = "0x1ED0AF0", Offset = "0x1ECFEF0", Length = "0x68")]
	[Token(Token = "0x6001929")]
	private static uint Sigma_1(uint x) { }

}

