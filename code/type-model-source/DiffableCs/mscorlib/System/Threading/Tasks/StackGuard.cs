namespace System.Threading.Tasks;

[Token(Token = "0x2000273")]
internal class StackGuard
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B1D")]
	private int m_inliningDepth; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60014B1")]
	public StackGuard() { }

	[Address(RVA = "0x20B4DC0", Offset = "0x20B41C0", Length = "0xE")]
	[Token(Token = "0x60014B0")]
	internal void EndInliningScope() { }

	[Address(RVA = "0x20B4DD0", Offset = "0x20B41D0", Length = "0x2B")]
	[Token(Token = "0x60014AF")]
	internal bool TryBeginInliningScope() { }

}

