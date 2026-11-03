namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200031A")]
public class SHA384Managed : SHA384
{
	[Token(Token = "0x4000D35")]
	private static readonly UInt64[] _K; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D31")]
	private Byte[] _buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D32")]
	private ulong _count; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D33")]
	private UInt64[] _stateSHA384; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D34")]
	private UInt64[] _W; //Field offset: 0x40

	[Address(RVA = "0x1ED23D0", Offset = "0x1ED17D0", Length = "0x2C3")]
	[Token(Token = "0x6001934")]
	private Byte[] _EndHash() { }

	[Address(RVA = "0x1ED26A0", Offset = "0x1ED1AA0", Length = "0x1EF")]
	[Token(Token = "0x6001933")]
	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	[Address(RVA = "0x1ED2890", Offset = "0x1ED1C90", Length = "0x8C")]
	[Token(Token = "0x600193E")]
	private static SHA384Managed() { }

	[Address(RVA = "0x1ED2920", Offset = "0x1ED1D20", Length = "0xD5")]
	[Token(Token = "0x600192E")]
	public SHA384Managed() { }

	[Address(RVA = "0x1ED1220", Offset = "0x1ED0620", Length = "0x10")]
	[Token(Token = "0x6001937")]
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	[Address(RVA = "0x1ED1230", Offset = "0x1ED0630", Length = "0xE")]
	[Token(Token = "0x6001930")]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x1ED1240", Offset = "0x1ED0640", Length = "0x7")]
	[Token(Token = "0x6001931")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1ED1380", Offset = "0x1ED0780", Length = "0x50")]
	[Token(Token = "0x600192F")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1ED1250", Offset = "0x1ED0650", Length = "0x124")]
	[Token(Token = "0x6001932")]
	private void InitializeState() { }

	[Address(RVA = "0x1ED13E0", Offset = "0x1ED07E0", Length = "0x10")]
	[Token(Token = "0x6001938")]
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	[Address(RVA = "0x1ED13F0", Offset = "0x1ED07F0", Length = "0x1A")]
	[Token(Token = "0x6001936")]
	private static ulong RotateRight(ulong x, int n) { }

	[Address(RVA = "0x1ED1410", Offset = "0x1ED0810", Length = "0x154")]
	[Token(Token = "0x600193D")]
	private static void SHA384Expand(UInt64* x) { }

	[Address(RVA = "0x1ED1570", Offset = "0x1ED0970", Length = "0xD5A")]
	[Token(Token = "0x6001935")]
	private static void SHATransform(UInt64* expandedBuffer, UInt64* state, Byte* block) { }

	[Address(RVA = "0x1ED2A00", Offset = "0x1ED1E00", Length = "0x6B")]
	[Token(Token = "0x600193B")]
	private static ulong sigma_0(ulong x) { }

	[Address(RVA = "0x1ED22D0", Offset = "0x1ED16D0", Length = "0x76")]
	[Token(Token = "0x6001939")]
	private static ulong Sigma_0(ulong x) { }

	[Address(RVA = "0x1ED2A70", Offset = "0x1ED1E70", Length = "0x6D")]
	[Token(Token = "0x600193C")]
	private static ulong sigma_1(ulong x) { }

	[Address(RVA = "0x1ED2350", Offset = "0x1ED1750", Length = "0x76")]
	[Token(Token = "0x600193A")]
	private static ulong Sigma_1(ulong x) { }

}

