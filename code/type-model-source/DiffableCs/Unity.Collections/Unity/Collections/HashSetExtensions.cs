namespace Unity.Collections;

[Extension]
[Token(Token = "0x20000AC")]
public static class HashSetExtensions
{

	[Address(RVA = "0x81B6A0", Offset = "0x81AAA0", Length = "0x28E")]
	[Extension]
	[Token(Token = "0x6000837")]
	public static void ExceptWith(ref NativeHashSet<T>& container, FixedList128Bytes<T> other) { }

	[Address(RVA = "0x81A6E0", Offset = "0x819AE0", Length = "0x23E")]
	[Extension]
	[Token(Token = "0x6000864")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, FixedList64Bytes<T> other) { }

	[Address(RVA = "0x81B430", Offset = "0x81A830", Length = "0x26E")]
	[Extension]
	[Token(Token = "0x6000861")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, FixedList512Bytes<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x600086A")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, NativeHashSet<T> other) { }

	[Address(RVA = "0x81C010", Offset = "0x81B410", Length = "0x25E")]
	[Extension]
	[Token(Token = "0x600085E")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x81BDE0", Offset = "0x81B1E0", Length = "0x22B")]
	[Extension]
	[Token(Token = "0x600085B")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, FixedList32Bytes<T> other) { }

	[Address(RVA = "0x81B6A0", Offset = "0x81AAA0", Length = "0x28E")]
	[Extension]
	[Token(Token = "0x6000858")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, FixedList128Bytes<T> other) { }

	[Address(RVA = "0x81B930", Offset = "0x81AD30", Length = "0x292")]
	[Extension]
	[Token(Token = "0x6000855")]
	public static void ExceptWith(ref NativeHashSet<T>& container, NativeList<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x600086D")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000852")]
	public static void ExceptWith(ref NativeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x600084C")]
	public static void ExceptWith(ref NativeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81AB40", Offset = "0x819F40", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000870")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, NativeParallelHashSet<T> other) { }

	[Address(RVA = "0x81BBD0", Offset = "0x81AFD0", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x6000849")]
	public static void ExceptWith(ref NativeHashSet<T>& container, NativeHashSet<T> other) { }

	[Address(RVA = "0x81AD60", Offset = "0x81A160", Length = "0x2A7")]
	[Extension]
	[Token(Token = "0x6000846")]
	public static void ExceptWith(ref NativeHashSet<T>& container, NativeArray<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x600084F")]
	public static void ExceptWith(ref NativeHashSet<T>& container, NativeParallelHashSet<T> other) { }

	[Address(RVA = "0x81AD60", Offset = "0x81A160", Length = "0x2A7")]
	[Extension]
	[Token(Token = "0x6000867")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, NativeArray<T> other) { }

	[Address(RVA = "0x81A6E0", Offset = "0x819AE0", Length = "0x23E")]
	[Extension]
	[Token(Token = "0x6000843")]
	public static void ExceptWith(ref NativeHashSet<T>& container, FixedList64Bytes<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000873")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81B930", Offset = "0x81AD30", Length = "0x292")]
	[Extension]
	[Token(Token = "0x6000876")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, NativeList<T> other) { }

	[Address(RVA = "0x81BDE0", Offset = "0x81B1E0", Length = "0x22B")]
	[Extension]
	[Token(Token = "0x600083A")]
	public static void ExceptWith(ref NativeHashSet<T>& container, FixedList32Bytes<T> other) { }

	[Address(RVA = "0x81B430", Offset = "0x81A830", Length = "0x26E")]
	[Extension]
	[Token(Token = "0x6000840")]
	public static void ExceptWith(ref NativeHashSet<T>& container, FixedList512Bytes<T> other) { }

	[Address(RVA = "0x81C010", Offset = "0x81B410", Length = "0x25E")]
	[Extension]
	[Token(Token = "0x600083D")]
	public static void ExceptWith(ref NativeHashSet<T>& container, FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x81E690", Offset = "0x81DA90", Length = "0x339")]
	[Extension]
	[Token(Token = "0x6000865")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, FixedList64Bytes<T> other) { }

	[Address(RVA = "0x81CF70", Offset = "0x81C370", Length = "0x389")]
	[Extension]
	[Token(Token = "0x6000838")]
	public static void IntersectWith(ref NativeHashSet<T>& container, FixedList128Bytes<T> other) { }

	[Address(RVA = "0x81C270", Offset = "0x81B670", Length = "0x369")]
	[Extension]
	[Token(Token = "0x6000862")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, FixedList512Bytes<T> other) { }

	[Address(RVA = "0x81C5E0", Offset = "0x81B9E0", Length = "0x359")]
	[Extension]
	[Token(Token = "0x600085F")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x81DA40", Offset = "0x81CE40", Length = "0x329")]
	[Extension]
	[Token(Token = "0x600083B")]
	public static void IntersectWith(ref NativeHashSet<T>& container, FixedList32Bytes<T> other) { }

	[Address(RVA = "0x81C940", Offset = "0x81BD40", Length = "0x306")]
	[Extension]
	[Token(Token = "0x600086B")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, NativeHashSet<T> other) { }

	[Address(RVA = "0x81DA40", Offset = "0x81CE40", Length = "0x329")]
	[Extension]
	[Token(Token = "0x600085C")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, FixedList32Bytes<T> other) { }

	[Address(RVA = "0x81CF70", Offset = "0x81C370", Length = "0x389")]
	[Extension]
	[Token(Token = "0x6000859")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, FixedList128Bytes<T> other) { }

	[Address(RVA = "0x81D300", Offset = "0x81C700", Length = "0x396")]
	[Extension]
	[Token(Token = "0x6000877")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, NativeList<T> other) { }

	[Address(RVA = "0x81D300", Offset = "0x81C700", Length = "0x396")]
	[Extension]
	[Token(Token = "0x6000856")]
	public static void IntersectWith(ref NativeHashSet<T>& container, NativeList<T> other) { }

	[Address(RVA = "0x81C5E0", Offset = "0x81B9E0", Length = "0x359")]
	[Extension]
	[Token(Token = "0x600083E")]
	public static void IntersectWith(ref NativeHashSet<T>& container, FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x81D6A0", Offset = "0x81CAA0", Length = "0x39C")]
	[Extension]
	[Token(Token = "0x6000847")]
	public static void IntersectWith(ref NativeHashSet<T>& container, NativeArray<T> other) { }

	[Address(RVA = "0x81E070", Offset = "0x81D470", Length = "0x30C")]
	[Extension]
	[Token(Token = "0x6000871")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, NativeParallelHashSet<T> other) { }

	[Address(RVA = "0x81E380", Offset = "0x81D780", Length = "0x300")]
	[Extension]
	[Token(Token = "0x600084A")]
	public static void IntersectWith(ref NativeHashSet<T>& container, NativeHashSet<T> other) { }

	[Address(RVA = "0x81C270", Offset = "0x81B670", Length = "0x369")]
	[Extension]
	[Token(Token = "0x6000841")]
	public static void IntersectWith(ref NativeHashSet<T>& container, FixedList512Bytes<T> other) { }

	[Address(RVA = "0x81C940", Offset = "0x81BD40", Length = "0x306")]
	[Extension]
	[Token(Token = "0x600084D")]
	public static void IntersectWith(ref NativeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81D6A0", Offset = "0x81CAA0", Length = "0x39C")]
	[Extension]
	[Token(Token = "0x6000868")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, NativeArray<T> other) { }

	[Address(RVA = "0x81E690", Offset = "0x81DA90", Length = "0x339")]
	[Extension]
	[Token(Token = "0x6000844")]
	public static void IntersectWith(ref NativeHashSet<T>& container, FixedList64Bytes<T> other) { }

	[Address(RVA = "0x81C940", Offset = "0x81BD40", Length = "0x306")]
	[Extension]
	[Token(Token = "0x600086E")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000853")]
	public static void IntersectWith(ref NativeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000874")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000850")]
	public static void IntersectWith(ref NativeHashSet<T>& container, NativeParallelHashSet<T> other) { }

	[Address(RVA = "0x81AB40", Offset = "0x819F40", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000872")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, NativeParallelHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000875")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x600086C")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, NativeHashSet<T> other) { }

	[Address(RVA = "0x81AD60", Offset = "0x81A160", Length = "0x2A7")]
	[Extension]
	[Token(Token = "0x6000869")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, NativeArray<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x600086F")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81B930", Offset = "0x81AD30", Length = "0x292")]
	[Extension]
	[Token(Token = "0x6000857")]
	public static void UnionWith(ref NativeHashSet<T>& container, NativeList<T> other) { }

	[Address(RVA = "0x81B430", Offset = "0x81A830", Length = "0x26E")]
	[Extension]
	[Token(Token = "0x6000863")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, FixedList512Bytes<T> other) { }

	[Address(RVA = "0x81C010", Offset = "0x81B410", Length = "0x25E")]
	[Extension]
	[Token(Token = "0x6000860")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x81BDE0", Offset = "0x81B1E0", Length = "0x22B")]
	[Extension]
	[Token(Token = "0x600085D")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, FixedList32Bytes<T> other) { }

	[Address(RVA = "0x81B6A0", Offset = "0x81AAA0", Length = "0x28E")]
	[Extension]
	[Token(Token = "0x600085A")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, FixedList128Bytes<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000854")]
	public static void UnionWith(ref NativeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000851")]
	public static void UnionWith(ref NativeHashSet<T>& container, NativeParallelHashSet<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x600084E")]
	public static void UnionWith(ref NativeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81BBD0", Offset = "0x81AFD0", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x600084B")]
	public static void UnionWith(ref NativeHashSet<T>& container, NativeHashSet<T> other) { }

	[Address(RVA = "0x81AD60", Offset = "0x81A160", Length = "0x2A7")]
	[Extension]
	[Token(Token = "0x6000848")]
	public static void UnionWith(ref NativeHashSet<T>& container, NativeArray<T> other) { }

	[Address(RVA = "0x81A6E0", Offset = "0x819AE0", Length = "0x23E")]
	[Extension]
	[Token(Token = "0x6000845")]
	public static void UnionWith(ref NativeHashSet<T>& container, FixedList64Bytes<T> other) { }

	[Address(RVA = "0x81B430", Offset = "0x81A830", Length = "0x26E")]
	[Extension]
	[Token(Token = "0x6000842")]
	public static void UnionWith(ref NativeHashSet<T>& container, FixedList512Bytes<T> other) { }

	[Address(RVA = "0x81C010", Offset = "0x81B410", Length = "0x25E")]
	[Extension]
	[Token(Token = "0x600083F")]
	public static void UnionWith(ref NativeHashSet<T>& container, FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x81BDE0", Offset = "0x81B1E0", Length = "0x22B")]
	[Extension]
	[Token(Token = "0x600083C")]
	public static void UnionWith(ref NativeHashSet<T>& container, FixedList32Bytes<T> other) { }

	[Address(RVA = "0x81B6A0", Offset = "0x81AAA0", Length = "0x28E")]
	[Extension]
	[Token(Token = "0x6000839")]
	public static void UnionWith(ref NativeHashSet<T>& container, FixedList128Bytes<T> other) { }

	[Address(RVA = "0x81A6E0", Offset = "0x819AE0", Length = "0x23E")]
	[Extension]
	[Token(Token = "0x6000866")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, FixedList64Bytes<T> other) { }

	[Address(RVA = "0x81B930", Offset = "0x81AD30", Length = "0x292")]
	[Extension]
	[Token(Token = "0x6000878")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, NativeList<T> other) { }

}

