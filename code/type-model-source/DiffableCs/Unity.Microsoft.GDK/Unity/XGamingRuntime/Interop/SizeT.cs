namespace Unity.XGamingRuntime.Interop;

[MovedFrom("Unity.GameCore.Interop")]
[Token(Token = "0x20002B8")]
public struct SizeT
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000743")]
	private readonly UIntPtr value; //Field offset: 0x0

	[Token(Token = "0x17000307")]
	public bool IsZero
	{
		[Address(RVA = "0x2B9F050", Offset = "0x2B9E450", Length = "0xD")]
		[Token(Token = "0x6000E1F")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x2B9EFD0", Offset = "0x2B9E3D0", Length = "0x75")]
	[Token(Token = "0x6000E20")]
	public SizeT(int length) { }

	[Address(RVA = "0x2B9EF50", Offset = "0x2B9E350", Length = "0x75")]
	[Token(Token = "0x6000E21")]
	public SizeT(uint length) { }

	[Address(RVA = "0x2B9EEA0", Offset = "0x2B9E2A0", Length = "0x77")]
	[Token(Token = "0x6000E22")]
	public SizeT(long length) { }

	[Address(RVA = "0x2B9EF20", Offset = "0x2B9E320", Length = "0x2D")]
	[Token(Token = "0x6000E23")]
	public SizeT(ulong length) { }

	[Address(RVA = "0x2B9F050", Offset = "0x2B9E450", Length = "0xD")]
	[Token(Token = "0x6000E1F")]
	public bool get_IsZero() { }

	[Address(RVA = "0x2B9ED70", Offset = "0x2B9E170", Length = "0x56")]
	[Token(Token = "0x6000E25")]
	public int ToInt32() { }

	[Address(RVA = "0x2B9EDD0", Offset = "0x2B9E1D0", Length = "0x56")]
	[Token(Token = "0x6000E27")]
	public long ToInt64() { }

	[Address(RVA = "0x2B9EE30", Offset = "0x2B9E230", Length = "0x56")]
	[Token(Token = "0x6000E24")]
	public uint ToUInt32() { }

	[Address(RVA = "0x2B9EE90", Offset = "0x2B9E290", Length = "0x7")]
	[Token(Token = "0x6000E26")]
	public ulong ToUInt64() { }

}

