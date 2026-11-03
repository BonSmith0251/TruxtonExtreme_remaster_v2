namespace UnityEngine.Bindings;

[IsByRefLike]
[IsReadOnly]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x2000256")]
[VisibleToOtherModules]
internal struct ManagedSpanWrapper
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007C4")]
	public readonly Void* begin; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007C5")]
	public readonly int length; //Field offset: 0x8

	[Address(RVA = "0xAEE300", Offset = "0xAED700", Length = "0x8")]
	[Token(Token = "0x600183F")]
	public ManagedSpanWrapper(Void* begin, int length) { }

	[Address(RVA = "0x863F70", Offset = "0x863370", Length = "0x67")]
	[Token(Token = "0x6001840")]
	public static ReadOnlySpan<T> ToReadOnlySpan(ManagedSpanWrapper spanWrapper) { }

}

