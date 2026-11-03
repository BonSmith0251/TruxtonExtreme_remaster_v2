namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x20000F2")]
public static class UTF8ArrayUnsafeUtility
{
	[Token(Token = "0x20000F3")]
	public struct Comparison
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400046C")]
		public bool terminates; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400046D")]
		public int result; //Field offset: 0x4

		[Address(RVA = "0x28C6650", Offset = "0x28C5A50", Length = "0x2F")]
		[Token(Token = "0x6000A76")]
		public Comparison(Rune runeA, ConversionError errorA, Rune runeB, ConversionError errorB) { }

	}


	[Address(RVA = "0x28CFB10", Offset = "0x28CEF10", Length = "0xEB")]
	[Token(Token = "0x6000A6D")]
	public static CopyError Append(Byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, Byte* src, ushort srcLength) { }

	[Address(RVA = "0x28CFA50", Offset = "0x28CEE50", Length = "0x5D")]
	[Token(Token = "0x6000A6E")]
	public static CopyError Append(Byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, Char* src, int srcLength) { }

	[Address(RVA = "0x28CFAB0", Offset = "0x28CEEB0", Length = "0x5F")]
	[Token(Token = "0x6000A6F")]
	public static CopyError Append(Char* dest, ref ushort destLength, ushort destUCS2MaxLengthInChars, Byte* src, ushort srcLength) { }

	[Address(RVA = "0x28CF9F0", Offset = "0x28CEDF0", Length = "0x54")]
	[Token(Token = "0x6000A6C")]
	public static FormatError AppendUTF8Bytes(Byte* dest, ref int destLength, int destCapacity, Byte* src, int srcLength) { }

	[Address(RVA = "0x28CFC00", Offset = "0x28CF000", Length = "0x34")]
	[Token(Token = "0x6000A66")]
	public static CopyError Copy(Byte* dest, out int destLength, int destUTF8MaxLengthInBytes, Char* src, int srcLength) { }

	[Address(RVA = "0x28CFE40", Offset = "0x28CF240", Length = "0x53")]
	[Token(Token = "0x6000A67")]
	public static CopyError Copy(Byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, Char* src, int srcLength) { }

	[Address(RVA = "0x28CFD60", Offset = "0x28CF160", Length = "0xD3")]
	[Token(Token = "0x6000A68")]
	public static CopyError Copy(Byte* dest, out int destLength, int destUTF8MaxLengthInBytes, Byte* src, int srcLength) { }

	[Address(RVA = "0x28CFC80", Offset = "0x28CF080", Length = "0xDA")]
	[Token(Token = "0x6000A69")]
	public static CopyError Copy(Byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, Byte* src, ushort srcLength) { }

	[Address(RVA = "0x28CFC40", Offset = "0x28CF040", Length = "0x34")]
	[Token(Token = "0x6000A6A")]
	public static CopyError Copy(Char* dest, out int destLength, int destUCS2MaxLengthInChars, Byte* src, int srcLength) { }

	[Address(RVA = "0x28CFEA0", Offset = "0x28CF2A0", Length = "0x54")]
	[Token(Token = "0x6000A6B")]
	public static CopyError Copy(Char* dest, out ushort destLength, ushort destUCS2MaxLengthInChars, Byte* src, ushort srcLength) { }

	[Address(RVA = "0x28CFF00", Offset = "0x28CF300", Length = "0xD1")]
	[Token(Token = "0x6000A73")]
	public static bool EqualsUTF8Bytes(Byte* aBytes, int aLength, Byte* bBytes, int bLength) { }

	[Address(RVA = "0x28D04C0", Offset = "0x28CF8C0", Length = "0xB8")]
	[Token(Token = "0x6000A70")]
	public static int StrCmp(Byte* utf8BufferA, int utf8LengthInBytesA, Byte* utf8BufferB, int utf8LengthInBytesB) { }

	[Address(RVA = "0x28D0400", Offset = "0x28CF800", Length = "0xBA")]
	[Token(Token = "0x6000A71")]
	internal static int StrCmp(Byte* utf8BufferA, int utf8LengthInBytesA, Rune* runeBufferB, int lengthInRunesB) { }

	[Address(RVA = "0x28D0260", Offset = "0x28CF660", Length = "0x19D")]
	[Token(Token = "0x6000A72")]
	public static int StrCmp(Char* utf16BufferA, int utf16LengthInCharsA, Char* utf16BufferB, int utf16LengthInCharsB) { }

	[Address(RVA = "0x28D0120", Offset = "0x28CF520", Length = "0x133")]
	[Token(Token = "0x6000A74")]
	public static int StrCmp(Byte* utf8Buffer, int utf8LengthInBytes, Char* utf16Buffer, int utf16LengthInChars) { }

	[Address(RVA = "0x28CFFE0", Offset = "0x28CF3E0", Length = "0x133")]
	[Token(Token = "0x6000A75")]
	public static int StrCmp(Char* utf16Buffer, int utf16LengthInChars, Byte* utf8Buffer, int utf8LengthInBytes) { }

}

