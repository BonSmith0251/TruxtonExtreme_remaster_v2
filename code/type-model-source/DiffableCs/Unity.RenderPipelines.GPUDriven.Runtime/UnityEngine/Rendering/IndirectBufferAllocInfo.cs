namespace UnityEngine.Rendering;

[Token(Token = "0x20000AA")]
internal struct IndirectBufferAllocInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000325")]
	public int drawAllocIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000326")]
	public int drawCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000327")]
	public int instanceAllocIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000328")]
	public int instanceCount; //Field offset: 0xC

	[Address(RVA = "0x2CF40A0", Offset = "0x2CF34A0", Length = "0x6")]
	[Token(Token = "0x60002FF")]
	public int GetExtraDrawInfoSlotIndex() { }

	[Address(RVA = "0x29217E0", Offset = "0x2920BE0", Length = "0x8")]
	[Token(Token = "0x60002FD")]
	public bool IsEmpty() { }

	[Address(RVA = "0x2CF40B0", Offset = "0x2CF34B0", Length = "0x19")]
	[Token(Token = "0x60002FE")]
	public bool IsWithinLimits(in IndirectBufferLimits limits) { }

}

