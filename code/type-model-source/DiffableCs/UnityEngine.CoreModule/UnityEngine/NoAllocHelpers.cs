namespace UnityEngine;

[Token(Token = "0x20001B7")]
[VisibleToOtherModules]
internal static class NoAllocHelpers
{
	[Token(Token = "0x20001B8")]
	private class ListPrivateFieldAccess
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000681")]
		internal T[] _items; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000682")]
		internal int _size; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000683")]
		internal int _version; //Field offset: 0x0

	}


	[Address(RVA = "0x899970", Offset = "0x898D70", Length = "0xA5")]
	[Token(Token = "0x60013F0")]
	public static ReadOnlySpan<T> CreateReadOnlySpan(List<T> list) { }

	[Address(RVA = "0x899A20", Offset = "0x898E20", Length = "0x109")]
	[Token(Token = "0x60013EC")]
	public static void EnsureListElemCount(List<T> list, int count) { }

	[Address(RVA = "0x899DD0", Offset = "0x8991D0", Length = "0x5A")]
	[Token(Token = "0x60013EF")]
	public static T[] ExtractArrayFromList(List<T> list) { }

	[Address(RVA = "0x3068140", Offset = "0x3067540", Length = "0xD5")]
	[RequiredByNativeCode]
	[Token(Token = "0x60013F3")]
	private static Array PrepareListForNativeFill(object list, Type elementType, int newSize) { }

	[Address(RVA = "0x899E90", Offset = "0x899290", Length = "0x7D")]
	[Token(Token = "0x60013F1")]
	public static void ResetListContents(List<T> list, ReadOnlySpan<T> span) { }

	[Address(RVA = "0x89A230", Offset = "0x899630", Length = "0x111")]
	[Token(Token = "0x60013F2")]
	public static void ResetListSize(List<T> list, int size) { }

	[Address(RVA = "0x3068220", Offset = "0x3067620", Length = "0x1C")]
	[Token(Token = "0x60013ED")]
	public static int SafeLength(Array values) { }

	[Address(RVA = "0x89A4B0", Offset = "0x8998B0", Length = "0x2E")]
	[Token(Token = "0x60013EE")]
	public static int SafeLength(List<T> values) { }

}

