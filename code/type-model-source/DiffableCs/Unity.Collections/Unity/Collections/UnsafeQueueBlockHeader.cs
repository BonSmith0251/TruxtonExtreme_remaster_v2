namespace Unity.Collections;

[Token(Token = "0x20000EA")]
internal struct UnsafeQueueBlockHeader
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000457")]
	public UnsafeQueueBlockHeader* m_NextBlock; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000458")]
	public int m_NumItems; //Field offset: 0x8

}

