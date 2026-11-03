namespace System;

[Extension]
[Token(Token = "0x2000111")]
public static class MemoryExtensions
{

	[Address(RVA = "0x8665B0", Offset = "0x8659B0", Length = "0x8E")]
	[Extension]
	[Token(Token = "0x60008BF")]
	public static Memory<T> AsMemory(T[] array, int start) { }

	[Address(RVA = "0x8666B0", Offset = "0x865AB0", Length = "0x80")]
	[Extension]
	[Token(Token = "0x60008AF")]
	public static Span<T> AsSpan(T[] array, int start) { }

	[Address(RVA = "0x8668E0", Offset = "0x865CE0", Length = "0x5B")]
	[Extension]
	[Token(Token = "0x60008BD")]
	public static Span<T> AsSpan(T[] array) { }

	[Address(RVA = "0x202B5E0", Offset = "0x202A9E0", Length = "0xB4")]
	[Extension]
	[Token(Token = "0x60008B2")]
	public static ReadOnlySpan<Char> AsSpan(string text, int start, int length) { }

	[Address(RVA = "0x202B6A0", Offset = "0x202AAA0", Length = "0x9E")]
	[Extension]
	[Token(Token = "0x60008B1")]
	public static ReadOnlySpan<Char> AsSpan(string text, int start) { }

	[Address(RVA = "0x202B560", Offset = "0x202A960", Length = "0x79")]
	[Extension]
	[Token(Token = "0x60008B0")]
	public static ReadOnlySpan<Char> AsSpan(string text) { }

	[Address(RVA = "0x866730", Offset = "0x865B30", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x60008BE")]
	public static Span<T> AsSpan(T[] array, int start, int length) { }

	[Address(RVA = "0x202B740", Offset = "0x202AB40", Length = "0x30")]
	[Extension]
	[Token(Token = "0x60008A6")]
	public static bool Contains(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, StringComparison comparisonType) { }

	[Address(RVA = "0x202B770", Offset = "0x202AB70", Length = "0x78")]
	[Extension]
	[Token(Token = "0x60008AA")]
	internal static bool Contains(ReadOnlySpan<Char> source, char value) { }

	[Address(RVA = "0x866C40", Offset = "0x866040", Length = "0x84")]
	[Extension]
	[Token(Token = "0x60008C0")]
	public static void CopyTo(T[] source, Span<T> destination) { }

	[Address(RVA = "0x866D60", Offset = "0x866160", Length = "0x11D")]
	[Extension]
	[Token(Token = "0x60008BC")]
	public static bool EndsWith(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }

	[Address(RVA = "0x202B7F0", Offset = "0x202ABF0", Length = "0x3D4")]
	[Extension]
	[Token(Token = "0x60008AD")]
	public static bool EndsWith(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, StringComparison comparisonType) { }

	[Address(RVA = "0x202BD20", Offset = "0x202B120", Length = "0x64")]
	[Extension]
	[Token(Token = "0x60008A7")]
	public static bool Equals(ReadOnlySpan<Char> span, ReadOnlySpan<Char> other, StringComparison comparisonType) { }

	[Address(RVA = "0x202BC90", Offset = "0x202B090", Length = "0x90")]
	[Extension]
	[Token(Token = "0x60008A8")]
	internal static bool EqualsOrdinal(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x202BBE0", Offset = "0x202AFE0", Length = "0xA6")]
	[Extension]
	[Token(Token = "0x60008A9")]
	internal static bool EqualsOrdinalIgnoreCase(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x202C080", Offset = "0x202B480", Length = "0x84")]
	[Extension]
	[Token(Token = "0x60008AB")]
	public static int IndexOf(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, StringComparison comparisonType) { }

	[Address(RVA = "0x867380", Offset = "0x866780", Length = "0x15B")]
	[Extension]
	[Token(Token = "0x60008B8")]
	public static int IndexOf(ReadOnlySpan<T> span, T value) { }

	[Address(RVA = "0x867B90", Offset = "0x866F90", Length = "0x152")]
	[Extension]
	[Token(Token = "0x60008B6")]
	public static int IndexOf(Span<T> span, T value) { }

	[Address(RVA = "0x8674E0", Offset = "0x8668E0", Length = "0x124")]
	[Extension]
	[Token(Token = "0x60008B7")]
	public static int IndexOf(Span<T> span, ReadOnlySpan<T> value) { }

	[Address(RVA = "0x8670B0", Offset = "0x8664B0", Length = "0x124")]
	[Extension]
	[Token(Token = "0x60008B9")]
	public static int IndexOfAny(ReadOnlySpan<T> span, ReadOnlySpan<T> values) { }

	[Address(RVA = "0x842600", Offset = "0x841A00", Length = "0x370")]
	[Token(Token = "0x60008C1")]
	private static bool IsTypeComparableAsBytes(out ulong size) { }

	[Address(RVA = "0x882B60", Offset = "0x881F60", Length = "0xA5")]
	[Extension]
	[Token(Token = "0x60008BA")]
	public static bool SequenceEqual(ReadOnlySpan<T> span, ReadOnlySpan<T> other) { }

	[Address(RVA = "0x882EC0", Offset = "0x8822C0", Length = "0xA5")]
	[Extension]
	[Token(Token = "0x60008BB")]
	public static bool StartsWith(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }

	[Address(RVA = "0x202C2F0", Offset = "0x202B6F0", Length = "0x2A8")]
	[Extension]
	[Token(Token = "0x60008AE")]
	public static bool StartsWith(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, StringComparison comparisonType) { }

	[Address(RVA = "0x202C5B0", Offset = "0x202B9B0", Length = "0x1B4")]
	[Extension]
	[Token(Token = "0x60008AC")]
	public static int ToUpperInvariant(ReadOnlySpan<Char> source, Span<Char> destination) { }

	[Address(RVA = "0x202C990", Offset = "0x202BD90", Length = "0x1A1")]
	[Extension]
	[Token(Token = "0x60008B3")]
	public static ReadOnlySpan<Char> Trim(ReadOnlySpan<Char> span) { }

	[Address(RVA = "0x202C770", Offset = "0x202BB70", Length = "0xF4")]
	[Extension]
	[Token(Token = "0x60008B5")]
	public static ReadOnlySpan<Char> TrimEnd(ReadOnlySpan<Char> span) { }

	[Address(RVA = "0x202C870", Offset = "0x202BC70", Length = "0x111")]
	[Extension]
	[Token(Token = "0x60008B4")]
	public static ReadOnlySpan<Char> TrimStart(ReadOnlySpan<Char> span) { }

}

