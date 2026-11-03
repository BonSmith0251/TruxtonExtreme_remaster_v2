namespace UnityEngine.Rendering;

[Token(Token = "0x20000B2")]
internal struct InstanceOcclusionTestSubviewSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400034F")]
	public int testCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000350")]
	public int occluderSubviewIndices; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000351")]
	public int occluderSubviewMask; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000352")]
	public int cullingSplitIndices; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000353")]
	public int cullingSplitMask; //Field offset: 0x10

	[Address(RVA = "0x2CF5FA0", Offset = "0x2CF53A0", Length = "0xC2")]
	[Token(Token = "0x600030F")]
	public static InstanceOcclusionTestSubviewSettings FromSpan(ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests) { }

}

