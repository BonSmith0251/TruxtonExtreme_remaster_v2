namespace UnityEngine;

[Token(Token = "0x200000C")]
internal class GCHandlePool
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000021")]
	private GCHandle[] m_handles; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000022")]
	private int m_current; //Field offset: 0x18

	[Address(RVA = "0x2FC2000", Offset = "0x2FC1400", Length = "0x55")]
	[Token(Token = "0x6000061")]
	public GCHandlePool() { }

	[Address(RVA = "0x2FC1E60", Offset = "0x2FC1260", Length = "0x9C")]
	[Token(Token = "0x6000062")]
	public GCHandle Alloc(object o) { }

	[Address(RVA = "0x2FC1E50", Offset = "0x2FC1250", Length = "0x10")]
	[Token(Token = "0x6000063")]
	public IntPtr AllocHandleIfNotNull(object o) { }

	[Address(RVA = "0x2FC1F00", Offset = "0x2FC1300", Length = "0xFE")]
	[Token(Token = "0x6000064")]
	public void Free(GCHandle h) { }

}

