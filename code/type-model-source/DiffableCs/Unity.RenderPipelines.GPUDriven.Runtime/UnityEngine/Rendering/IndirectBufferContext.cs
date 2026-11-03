namespace UnityEngine.Rendering;

[Token(Token = "0x20000AB")]
internal struct IndirectBufferContext
{
	[Token(Token = "0x20000AC")]
	internal enum BufferState : int
	{
		Pending = 0,
		Zeroed = 1,
		NoOcclusionTest = 2,
		AllInstancesOcclusionTested = 3,
		OccludedInstancesReTested = 4,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000329")]
	public JobHandle cullingJobHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400032A")]
	public BufferState bufferState; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400032B")]
	public int occluderVersion; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400032C")]
	public int subviewMask; //Field offset: 0x18

	[Address(RVA = "0x120D460", Offset = "0x120C860", Length = "0x10")]
	[Token(Token = "0x6000300")]
	public IndirectBufferContext(JobHandle cullingJobHandle) { }

	[Address(RVA = "0x2CF5210", Offset = "0x2CF4610", Length = "0x16")]
	[Token(Token = "0x6000301")]
	public bool Matches(BufferState bufferState, int occluderVersion, int subviewMask) { }

}

