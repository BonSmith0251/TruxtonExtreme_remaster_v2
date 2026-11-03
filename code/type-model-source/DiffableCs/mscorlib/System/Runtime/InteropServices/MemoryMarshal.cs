namespace System.Runtime.InteropServices;

[Token(Token = "0x200043E")]
public static class MemoryMarshal
{

	[Address(RVA = "0x8831E0", Offset = "0x8825E0", Length = "0x90")]
	[Token(Token = "0x600200F")]
	public static Span<Byte> AsBytes(Span<T> span) { }

	[Address(RVA = "0x8834E0", Offset = "0x8828E0", Length = "0x90")]
	[Token(Token = "0x6002010")]
	public static ReadOnlySpan<Byte> AsBytes(ReadOnlySpan<T> span) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x6002011")]
	public static Memory<T> AsMemory(ReadOnlyMemory<T> memory) { }

	[Address(RVA = "0x883630", Offset = "0x882A30", Length = "0x46")]
	[Token(Token = "0x6002016")]
	public static Span<TTo> Cast(Span<TFrom> span) { }

	[Address(RVA = "0x8837F0", Offset = "0x882BF0", Length = "0x47")]
	[Token(Token = "0x6002017")]
	public static ReadOnlySpan<T> CreateReadOnlySpan(ref T reference, int length) { }

	[Address(RVA = "0x883840", Offset = "0x882C40", Length = "0x32")]
	[Token(Token = "0x6002014")]
	internal static T GetNonNullPinnableReference(Span<T> span) { }

	[Address(RVA = "0x883840", Offset = "0x882C40", Length = "0x32")]
	[Token(Token = "0x6002015")]
	internal static T GetNonNullPinnableReference(ReadOnlySpan<T> span) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6002012")]
	public static T GetReference(Span<T> span) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6002013")]
	public static T GetReference(ReadOnlySpan<T> span) { }

	[Address(RVA = "0x8838E0", Offset = "0x882CE0", Length = "0x2B5")]
	[Token(Token = "0x6002018")]
	public static bool TryGetArray(ReadOnlyMemory<T> memory, out ArraySegment<T>& segment) { }

}

