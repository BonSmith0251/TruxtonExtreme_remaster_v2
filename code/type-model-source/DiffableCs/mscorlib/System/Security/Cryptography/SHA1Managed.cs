namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000316")]
public class SHA1Managed : SHA1
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D28")]
	private Byte[] _buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D29")]
	private long _count; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D2A")]
	private UInt32[] _stateSHA1; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D2B")]
	private UInt32[] _expandedBuffer; //Field offset: 0x40

	[Address(RVA = "0x1ECF660", Offset = "0x1ECEA60", Length = "0x239")]
	[Token(Token = "0x6001916")]
	private Byte[] _EndHash() { }

	[Address(RVA = "0x1ECF8A0", Offset = "0x1ECECA0", Length = "0x195")]
	[Token(Token = "0x6001915")]
	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	[Address(RVA = "0x1ECFA40", Offset = "0x1ECEE40", Length = "0xD5")]
	[Token(Token = "0x6001910")]
	public SHA1Managed() { }

	[Address(RVA = "0x1ECF010", Offset = "0x1ECE410", Length = "0xE")]
	[Token(Token = "0x6001912")]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x1ECF020", Offset = "0x1ECE420", Length = "0x7")]
	[Token(Token = "0x6001913")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1ECF030", Offset = "0x1ECE430", Length = "0x50")]
	[Token(Token = "0x6001911")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1EBBBD0", Offset = "0x1EBAFD0", Length = "0x8A")]
	[Token(Token = "0x6001914")]
	private void InitializeState() { }

	[Address(RVA = "0x1ECF090", Offset = "0x1ECE490", Length = "0x32")]
	[Token(Token = "0x6001918")]
	private static void SHAExpand(UInt32* x) { }

	[Address(RVA = "0x1ECF0D0", Offset = "0x1ECE4D0", Length = "0x58F")]
	[Token(Token = "0x6001917")]
	private static void SHATransform(UInt32* expandedBuffer, UInt32* state, Byte* block) { }

}

