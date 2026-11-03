namespace System;

[Extension]
[Token(Token = "0x2000132")]
internal static class SpanHelpers
{

	[Address(RVA = "0x2049300", Offset = "0x2048700", Length = "0x1FC")]
	[Token(Token = "0x6000A16")]
	public static void ClearWithoutReferences(ref byte b, ulong byteLength) { }

	[Address(RVA = "0x20491D0", Offset = "0x20485D0", Length = "0x12C")]
	[Token(Token = "0x6000A17")]
	public static void ClearWithReferences(ref IntPtr ip, ulong pointerSizeLength) { }

	[Address(RVA = "0x2049560", Offset = "0x2048960", Length = "0x223")]
	[Token(Token = "0x6000A13")]
	public static bool EndsWithCultureHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, CompareInfo compareInfo) { }

	[Address(RVA = "0x2049790", Offset = "0x2048B90", Length = "0x213")]
	[Token(Token = "0x6000A14")]
	public static bool EndsWithCultureIgnoreCaseHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, CompareInfo compareInfo) { }

	[Address(RVA = "0x20499B0", Offset = "0x2048DB0", Length = "0xFC")]
	[Token(Token = "0x6000A15")]
	public static bool EndsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value) { }

	[Address(RVA = "0x8F5260", Offset = "0x8F4660", Length = "0xD9")]
	[Token(Token = "0x6000A09")]
	public static int IndexOf(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) { }

	[Address(RVA = "0x8F4AA0", Offset = "0x8F3EA0", Length = "0x339")]
	[Token(Token = "0x6000A0A")]
	public static int IndexOf(ref T searchSpace, T value, int length) { }

	[Address(RVA = "0x204A2E0", Offset = "0x20496E0", Length = "0xD6")]
	[Token(Token = "0x60009FE")]
	public static int IndexOf(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength) { }

	[Address(RVA = "0x204A3C0", Offset = "0x20497C0", Length = "0x291")]
	[Token(Token = "0x6000A00")]
	public static int IndexOf(ref byte searchSpace, byte value, int length) { }

	[Address(RVA = "0x2049F00", Offset = "0x2049300", Length = "0x3DC")]
	[Token(Token = "0x6000A03")]
	public static int IndexOf(ref char searchSpace, char value, int length) { }

	[Address(RVA = "0x2049AB0", Offset = "0x2048EB0", Length = "0x80")]
	[Token(Token = "0x60009FF")]
	public static int IndexOfAny(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength) { }

	[Address(RVA = "0x8F4870", Offset = "0x8F3C70", Length = "0xA1")]
	[Token(Token = "0x6000A0B")]
	public static int IndexOfAny(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) { }

	[Address(RVA = "0x2049B30", Offset = "0x2048F30", Length = "0x12F")]
	[Token(Token = "0x6000A0D")]
	public static int IndexOfCultureHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, CompareInfo compareInfo) { }

	[Address(RVA = "0x2049C60", Offset = "0x2049060", Length = "0x132")]
	[Token(Token = "0x6000A0E")]
	public static int IndexOfCultureIgnoreCaseHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, CompareInfo compareInfo) { }

	[Address(RVA = "0x2049DA0", Offset = "0x20491A0", Length = "0x158")]
	[Token(Token = "0x6000A0F")]
	public static int IndexOfOrdinalHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, bool ignoreCase) { }

	[Address(RVA = "0x204A660", Offset = "0x2049A60", Length = "0x3D7")]
	[Token(Token = "0x6000A04")]
	public static int LastIndexOf(ref char searchSpace, char value, int length) { }

	[Address(RVA = "0x204AA40", Offset = "0x2049E40", Length = "0x1A")]
	[Token(Token = "0x6000A06")]
	private static int LocateFirstFoundChar(ulong match) { }

	[Address(RVA = "0x204AA60", Offset = "0x2049E60", Length = "0x156")]
	[Token(Token = "0x6000A05")]
	private static int LocateFirstFoundChar(Vector<UInt16> match) { }

	[Address(RVA = "0x204AD10", Offset = "0x204A110", Length = "0x1C")]
	[Token(Token = "0x6000A08")]
	private static int LocateLastFoundChar(ulong match) { }

	[Address(RVA = "0x204ABC0", Offset = "0x2049FC0", Length = "0x14A")]
	[Token(Token = "0x6000A07")]
	private static int LocateLastFoundChar(Vector<UInt16> match) { }

	[Address(RVA = "0x204AD30", Offset = "0x204A130", Length = "0x409")]
	[Token(Token = "0x6000A02")]
	public static int SequenceCompareTo(ref char first, int firstLength, ref char second, int secondLength) { }

	[Address(RVA = "0x8F66C0", Offset = "0x8F5AC0", Length = "0x3C2")]
	[Token(Token = "0x6000A0C")]
	public static bool SequenceEqual(ref T first, ref T second, int length) { }

	[Address(RVA = "0x204B140", Offset = "0x204A540", Length = "0x15F")]
	[Token(Token = "0x6000A01")]
	public static bool SequenceEqual(ref byte first, ref byte second, ulong length) { }

	[Address(RVA = "0x204B2A0", Offset = "0x204A6A0", Length = "0x209")]
	[Token(Token = "0x6000A10")]
	public static bool StartsWithCultureHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, CompareInfo compareInfo) { }

	[Address(RVA = "0x204B4B0", Offset = "0x204A8B0", Length = "0x205")]
	[Token(Token = "0x6000A11")]
	public static bool StartsWithCultureIgnoreCaseHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, CompareInfo compareInfo) { }

	[Address(RVA = "0x204B6C0", Offset = "0x204AAC0", Length = "0xED")]
	[Token(Token = "0x6000A12")]
	public static bool StartsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value) { }

}

