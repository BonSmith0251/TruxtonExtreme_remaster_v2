namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000037")]
internal struct Bitwise
{

	[Address(RVA = "0x28AA280", Offset = "0x28A9680", Length = "0x7")]
	[Token(Token = "0x6000101")]
	internal static int AlignDown(int value, int alignPow2) { }

	[Address(RVA = "0x28AA290", Offset = "0x28A9690", Length = "0xA")]
	[Token(Token = "0x6000102")]
	internal static int AlignUp(int value, int alignPow2) { }

	[Address(RVA = "0x28AA2A0", Offset = "0x28A96A0", Length = "0x19B")]
	[Token(Token = "0x6000119")]
	internal static int CountBits(UInt64* ptr, int length, int pos, int numBits = 1) { }

	[Address(RVA = "0x28AA450", Offset = "0x28A9850", Length = "0xE")]
	[Token(Token = "0x6000104")]
	internal static uint ExtractBits(uint input, int pos, uint mask) { }

	[Address(RVA = "0x28AA440", Offset = "0x28A9840", Length = "0x10")]
	[Token(Token = "0x6000107")]
	internal static ulong ExtractBits(ulong input, int pos, ulong mask) { }

	[Address(RVA = "0x28AB4E0", Offset = "0x28AA8E0", Length = "0x11")]
	[Token(Token = "0x6000115")]
	internal static int Find(UInt64* ptr, int pos, int count, int numBits) { }

	[Address(RVA = "0x28AA460", Offset = "0x28A9860", Length = "0x153")]
	[Token(Token = "0x6000111")]
	private static int FindByte(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[Address(RVA = "0x28AA5C0", Offset = "0x28A99C0", Length = "0x1A9")]
	[Token(Token = "0x600010F")]
	private static int FindUint(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[Address(RVA = "0x28AA770", Offset = "0x28A9B70", Length = "0x1D2")]
	[Token(Token = "0x600010E")]
	private static int FindUlong(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[Address(RVA = "0x28AA950", Offset = "0x28A9D50", Length = "0x125")]
	[Token(Token = "0x6000112")]
	private static int FindUpto14bits(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[Address(RVA = "0x28AAA80", Offset = "0x28A9E80", Length = "0x148")]
	[Token(Token = "0x6000113")]
	private static int FindUpto6bits(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[Address(RVA = "0x28AABD0", Offset = "0x28A9FD0", Length = "0x150")]
	[Token(Token = "0x6000110")]
	private static int FindUshort(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[Address(RVA = "0x28AAD20", Offset = "0x28AA120", Length = "0x7B9")]
	[Token(Token = "0x6000114")]
	internal static int FindWithBeginEnd(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[Address(RVA = "0x1F96CB0", Offset = "0x1F960B0", Length = "0x8")]
	[Token(Token = "0x6000103")]
	internal static int FromBool(bool value) { }

	[Address(RVA = "0x28AB500", Offset = "0x28AA900", Length = "0x8F")]
	[Token(Token = "0x600011B")]
	internal static ulong GetBits(UInt64* ptr, int length, int pos, int numBits = 1) { }

	[Address(RVA = "0x28AB590", Offset = "0x28AA990", Length = "0x1D")]
	[Token(Token = "0x600011A")]
	internal static bool IsSet(UInt64* ptr, int pos) { }

	[Address(RVA = "0x28AB8D0", Offset = "0x28AACD0", Length = "0x45")]
	[Token(Token = "0x600010C")]
	internal static int lzcnt(ushort value) { }

	[Address(RVA = "0x28AB880", Offset = "0x28AAC80", Length = "0x44")]
	[Token(Token = "0x600010A")]
	internal static int lzcnt(byte value) { }

	[Address(RVA = "0x28AB5E0", Offset = "0x28AA9E0", Length = "0x1C")]
	[Token(Token = "0x6000105")]
	internal static uint ReplaceBits(uint input, int pos, uint mask, uint value) { }

	[Address(RVA = "0x28AB5B0", Offset = "0x28AA9B0", Length = "0x21")]
	[Token(Token = "0x6000108")]
	internal static ulong ReplaceBits(ulong input, int pos, ulong mask, ulong value) { }

	[Address(RVA = "0x28AB600", Offset = "0x28AAA00", Length = "0x23")]
	[Token(Token = "0x6000106")]
	internal static uint SetBits(uint input, int pos, uint mask, bool value) { }

	[Address(RVA = "0x28AB630", Offset = "0x28AAA30", Length = "0x25")]
	[Token(Token = "0x6000109")]
	internal static ulong SetBits(ulong input, int pos, ulong mask, bool value) { }

	[Address(RVA = "0x28AB660", Offset = "0x28AAA60", Length = "0xB3")]
	[Token(Token = "0x6000118")]
	internal static bool TestAll(UInt64* ptr, int length, int pos, int numBits = 1) { }

	[Address(RVA = "0x28AB720", Offset = "0x28AAB20", Length = "0xA8")]
	[Token(Token = "0x6000117")]
	internal static bool TestAny(UInt64* ptr, int length, int pos, int numBits = 1) { }

	[Address(RVA = "0x28AB7D0", Offset = "0x28AABD0", Length = "0xA5")]
	[Token(Token = "0x6000116")]
	internal static bool TestNone(UInt64* ptr, int length, int pos, int numBits = 1) { }

	[Address(RVA = "0x28AB970", Offset = "0x28AAD70", Length = "0x4D")]
	[Token(Token = "0x600010D")]
	internal static int tzcnt(ushort value) { }

	[Address(RVA = "0x28AB920", Offset = "0x28AAD20", Length = "0x4D")]
	[Token(Token = "0x600010B")]
	internal static int tzcnt(byte value) { }

}

