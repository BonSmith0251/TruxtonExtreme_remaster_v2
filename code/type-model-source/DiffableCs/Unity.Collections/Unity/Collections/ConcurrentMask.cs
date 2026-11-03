namespace Unity.Collections;

[Token(Token = "0x2000044")]
internal class ConcurrentMask
{
	[Token(Token = "0x40000A3")]
	internal const int ErrorFailedToFree = -1; //Field offset: 0x0
	[Token(Token = "0x40000A4")]
	internal const int ErrorFailedToAllocate = -2; //Field offset: 0x0
	[Token(Token = "0x40000A5")]
	internal const int ErrorAllocationCrossesWordBoundary = -3; //Field offset: 0x0
	[Token(Token = "0x40000A6")]
	internal const int EmptyBeforeAllocation = 0; //Field offset: 0x0
	[Token(Token = "0x40000A7")]
	internal const int EmptyAfterFree = 0; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600016D")]
	public ConcurrentMask() { }

	[Address(RVA = "0x28AC3F0", Offset = "0x28AB7F0", Length = "0x58")]
	[Token(Token = "0x600015F")]
	internal static long AtomicAnd(ref long destination, long source) { }

	[Address(RVA = "0x28AC450", Offset = "0x28AB850", Length = "0x58")]
	[Token(Token = "0x600015E")]
	internal static long AtomicOr(ref long destination, long source) { }

	[Address(RVA = "0x28AC8D0", Offset = "0x28ABCD0", Length = "0x13A")]
	[Token(Token = "0x6000161")]
	internal static bool foundAtLeastThisManyConsecutiveOnes(long value, int minimum, out int offset, out int count) { }

	[Address(RVA = "0x28ACA10", Offset = "0x28ABE10", Length = "0x141")]
	[Token(Token = "0x6000162")]
	internal static bool foundAtLeastThisManyConsecutiveZeroes(long value, int minimum, out int offset, out int count) { }

	[Address(RVA = "0x28ACB60", Offset = "0x28ABF60", Length = "0x9D")]
	[Token(Token = "0x6000160")]
	internal static void longestConsecutiveOnes(long value, out int offset, out int count) { }

	[Address(RVA = "0x28AC4B0", Offset = "0x28AB8B0", Length = "0x21")]
	[Token(Token = "0x6000164")]
	internal static long MakeMask(int offset, int bits) { }

	[Address(RVA = "0x28AC4E0", Offset = "0x28AB8E0", Length = "0xA")]
	[Token(Token = "0x6000163")]
	internal static bool Succeeded(int error) { }

	[Address(RVA = "0x28AC6F0", Offset = "0x28ABAF0", Length = "0xE3")]
	[Token(Token = "0x6000165")]
	internal static int TryAllocate(ref long l, int offset, int bits) { }

	[Address(RVA = "0x28AC4F0", Offset = "0x28AB8F0", Length = "0x1F2")]
	[Token(Token = "0x6000167")]
	internal static int TryAllocate(ref long l, out int offset, int bits) { }

	[Address(RVA = "0x7A8B20", Offset = "0x7A7F20", Length = "0x88")]
	[Token(Token = "0x6000168")]
	internal static int TryAllocate(ref T t, int offset, int bits) { }

	[Address(RVA = "0x7A8BB0", Offset = "0x7A7FB0", Length = "0xDC")]
	[Token(Token = "0x600016A")]
	internal static int TryAllocate(ref T t, out int offset, int begin, int end, int bits) { }

	[Address(RVA = "0x7A89E0", Offset = "0x7A7DE0", Length = "0x13B")]
	[Token(Token = "0x600016B")]
	internal static int TryAllocate(ref T t, out int offset, int begin, int bits) { }

	[Address(RVA = "0x7A88E0", Offset = "0x7A7CE0", Length = "0xF6")]
	[Token(Token = "0x600016C")]
	internal static int TryAllocate(ref T t, out int offset, int bits) { }

	[Address(RVA = "0x28AC7E0", Offset = "0x28ABBE0", Length = "0xE2")]
	[Token(Token = "0x6000166")]
	internal static int TryFree(ref long l, int offset, int bits) { }

	[Address(RVA = "0x7A8D90", Offset = "0x7A8190", Length = "0x6A")]
	[Token(Token = "0x6000169")]
	internal static int TryFree(ref T t, int offset, int bits) { }

}

