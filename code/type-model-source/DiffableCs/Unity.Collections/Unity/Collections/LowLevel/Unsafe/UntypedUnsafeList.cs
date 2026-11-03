namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000114")]
internal struct UntypedUnsafeList
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40004C2")]
	internal readonly Void* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004C3")]
	internal readonly int m_length; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40004C4")]
	internal readonly int m_capacity; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004C5")]
	internal readonly AllocatorHandle Allocator; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004C6")]
	internal readonly int padding; //Field offset: 0x14

}

