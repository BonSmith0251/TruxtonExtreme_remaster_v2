namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200031C")]
public class SHA512Managed : SHA512
{
	[Token(Token = "0x4000D3A")]
	private static readonly UInt64[] _K; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D36")]
	private Byte[] _buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D37")]
	private ulong _count; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D38")]
	private UInt64[] _stateSHA512; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D39")]
	private UInt64[] _W; //Field offset: 0x40

	[Address(RVA = "0x1ED3CC0", Offset = "0x1ED30C0", Length = "0x2C3")]
	[Token(Token = "0x6001947")]
	private Byte[] _EndHash() { }

	[Address(RVA = "0x1ED3F90", Offset = "0x1ED3390", Length = "0x1EF")]
	[Token(Token = "0x6001946")]
	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	[Address(RVA = "0x1ED4180", Offset = "0x1ED3580", Length = "0x8C")]
	[Token(Token = "0x6001951")]
	private static SHA512Managed() { }

	[Address(RVA = "0x1ED4210", Offset = "0x1ED3610", Length = "0xD5")]
	[Token(Token = "0x6001941")]
	public SHA512Managed() { }

	[Address(RVA = "0x1ED1220", Offset = "0x1ED0620", Length = "0x10")]
	[Token(Token = "0x600194A")]
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	[Address(RVA = "0x1ED2B50", Offset = "0x1ED1F50", Length = "0xE")]
	[Token(Token = "0x6001943")]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x1ED2B60", Offset = "0x1ED1F60", Length = "0x7")]
	[Token(Token = "0x6001944")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1ED2CA0", Offset = "0x1ED20A0", Length = "0x50")]
	[Token(Token = "0x6001942")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1ED2B70", Offset = "0x1ED1F70", Length = "0x124")]
	[Token(Token = "0x6001945")]
	private void InitializeState() { }

	[Address(RVA = "0x1ED13E0", Offset = "0x1ED07E0", Length = "0x10")]
	[Token(Token = "0x600194B")]
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	[Address(RVA = "0x1ED13F0", Offset = "0x1ED07F0", Length = "0x1A")]
	[Token(Token = "0x6001949")]
	private static ulong RotateRight(ulong x, int n) { }

	[Address(RVA = "0x1ED2D00", Offset = "0x1ED2100", Length = "0x154")]
	[Token(Token = "0x6001950")]
	private static void SHA512Expand(UInt64* x) { }

	[Address(RVA = "0x1ED2E60", Offset = "0x1ED2260", Length = "0xD5A")]
	[Token(Token = "0x6001948")]
	private static void SHATransform(UInt64* expandedBuffer, UInt64* state, Byte* block) { }

	[Address(RVA = "0x1ED42F0", Offset = "0x1ED36F0", Length = "0x6B")]
	[Token(Token = "0x600194E")]
	private static ulong sigma_0(ulong x) { }

	[Address(RVA = "0x1ED3BC0", Offset = "0x1ED2FC0", Length = "0x76")]
	[Token(Token = "0x600194C")]
	private static ulong Sigma_0(ulong x) { }

	[Address(RVA = "0x1ED4360", Offset = "0x1ED3760", Length = "0x6D")]
	[Token(Token = "0x600194F")]
	private static ulong sigma_1(ulong x) { }

	[Address(RVA = "0x1ED3C40", Offset = "0x1ED3040", Length = "0x76")]
	[Token(Token = "0x600194D")]
	private static ulong Sigma_1(ulong x) { }

}

