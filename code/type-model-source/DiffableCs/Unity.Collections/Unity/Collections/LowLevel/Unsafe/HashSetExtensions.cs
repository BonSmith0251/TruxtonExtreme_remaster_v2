namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[Token(Token = "0x2000135")]
public static class HashSetExtensions
{

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CB0")]
	public static void ExceptWith(ref NativeHashSet<T>& container, UnsafeHashSet<T> other) { }

	[Address(RVA = "0x81BDE0", Offset = "0x81B1E0", Length = "0x22B")]
	[Extension]
	[Token(Token = "0x6000CD1")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, FixedList32Bytes<T> other) { }

	[Address(RVA = "0x81C010", Offset = "0x81B410", Length = "0x25E")]
	[Extension]
	[Token(Token = "0x6000CD4")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000D1F")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81B430", Offset = "0x81A830", Length = "0x26E")]
	[Extension]
	[Token(Token = "0x6000CD7")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, FixedList512Bytes<T> other) { }

	[Address(RVA = "0x81A6E0", Offset = "0x819AE0", Length = "0x23E")]
	[Extension]
	[Token(Token = "0x6000CDA")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, FixedList64Bytes<T> other) { }

	[Address(RVA = "0x81AD60", Offset = "0x81A160", Length = "0x2A7")]
	[Extension]
	[Token(Token = "0x6000CDD")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, NativeArray<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000D1C")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, NativeParallelHashSet<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x6000CE0")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, NativeHashSet<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x6000CE3")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81AB40", Offset = "0x819F40", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CE6")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, UnsafeHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000D19")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CE9")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81B6A0", Offset = "0x81AAA0", Length = "0x28E")]
	[Extension]
	[Token(Token = "0x6000CCE")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, FixedList128Bytes<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CEC")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, NativeParallelHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CF2")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, UnsafeParallelHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000D16")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, UnsafeHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CF5")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81B930", Offset = "0x81AD30", Length = "0x292")]
	[Extension]
	[Token(Token = "0x6000CF8")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, NativeList<T> other) { }

	[Address(RVA = "0x81B010", Offset = "0x81A410", Length = "0x205")]
	[Extension]
	[Token(Token = "0x6000CFB")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, UnsafeList<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x6000D13")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81B6A0", Offset = "0x81AAA0", Length = "0x28E")]
	[Extension]
	[Token(Token = "0x6000CFE")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, FixedList128Bytes<T> other) { }

	[Address(RVA = "0x81BDE0", Offset = "0x81B1E0", Length = "0x22B")]
	[Extension]
	[Token(Token = "0x6000D01")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, FixedList32Bytes<T> other) { }

	[Address(RVA = "0x81C010", Offset = "0x81B410", Length = "0x25E")]
	[Extension]
	[Token(Token = "0x6000D04")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x6000D10")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, NativeHashSet<T> other) { }

	[Address(RVA = "0x81B430", Offset = "0x81A830", Length = "0x26E")]
	[Extension]
	[Token(Token = "0x6000D07")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, FixedList512Bytes<T> other) { }

	[Address(RVA = "0x81A6E0", Offset = "0x819AE0", Length = "0x23E")]
	[Extension]
	[Token(Token = "0x6000D0A")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, FixedList64Bytes<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CEF")]
	public static void ExceptWith(ref UnsafeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81AB40", Offset = "0x819F40", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000D22")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, UnsafeParallelHashSet<T> other) { }

	[Address(RVA = "0x81AD60", Offset = "0x81A160", Length = "0x2A7")]
	[Extension]
	[Token(Token = "0x6000D0D")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, NativeArray<T> other) { }

	[Address(RVA = "0x81B010", Offset = "0x81A410", Length = "0x205")]
	[Extension]
	[Token(Token = "0x6000CCB")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, UnsafeList<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CBF")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, UnsafeHashSet<T> other) { }

	[Address(RVA = "0x81B010", Offset = "0x81A410", Length = "0x205")]
	[Extension]
	[Token(Token = "0x6000CBC")]
	public static void ExceptWith(ref NativeHashSet<T>& container, UnsafeList<T> other) { }

	[Address(RVA = "0x81B930", Offset = "0x81AD30", Length = "0x292")]
	[Extension]
	[Token(Token = "0x6000D28")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, NativeList<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CC2")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CB9")]
	public static void ExceptWith(ref NativeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000D25")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CB6")]
	public static void ExceptWith(ref NativeHashSet<T>& container, UnsafeParallelHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CC5")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, UnsafeParallelHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CB3")]
	public static void ExceptWith(ref NativeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81B010", Offset = "0x81A410", Length = "0x205")]
	[Extension]
	[Token(Token = "0x6000D2B")]
	public static void ExceptWith(ref UnsafeParallelHashSet<T>& container, UnsafeList<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CC8")]
	public static void ExceptWith(ref NativeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000CF0")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000D17")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, UnsafeHashSet<T> other) { }

	[Address(RVA = "0x81E690", Offset = "0x81DA90", Length = "0x339")]
	[Extension]
	[Token(Token = "0x6000D0B")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, FixedList64Bytes<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000CB1")]
	public static void IntersectWith(ref NativeHashSet<T>& container, UnsafeHashSet<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000CF3")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, UnsafeParallelHashSet<T> other) { }

	[Address(RVA = "0x81C270", Offset = "0x81B670", Length = "0x369")]
	[Extension]
	[Token(Token = "0x6000D08")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, FixedList512Bytes<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000CBA")]
	public static void IntersectWith(ref NativeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000CF6")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81C940", Offset = "0x81BD40", Length = "0x306")]
	[Extension]
	[Token(Token = "0x6000D11")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, NativeHashSet<T> other) { }

	[Address(RVA = "0x81C940", Offset = "0x81BD40", Length = "0x306")]
	[Extension]
	[Token(Token = "0x6000D14")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81C5E0", Offset = "0x81B9E0", Length = "0x359")]
	[Extension]
	[Token(Token = "0x6000D05")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x81D300", Offset = "0x81C700", Length = "0x396")]
	[Extension]
	[Token(Token = "0x6000D29")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, NativeList<T> other) { }

	[Address(RVA = "0x81DD70", Offset = "0x81D170", Length = "0x2FC")]
	[Extension]
	[Token(Token = "0x6000CBD")]
	public static void IntersectWith(ref NativeHashSet<T>& container, UnsafeList<T> other) { }

	[Address(RVA = "0x81DD70", Offset = "0x81D170", Length = "0x2FC")]
	[Extension]
	[Token(Token = "0x6000CFC")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, UnsafeList<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000CB7")]
	public static void IntersectWith(ref NativeHashSet<T>& container, UnsafeParallelHashSet<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000CB4")]
	public static void IntersectWith(ref NativeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81CF70", Offset = "0x81C370", Length = "0x389")]
	[Extension]
	[Token(Token = "0x6000CFF")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, FixedList128Bytes<T> other) { }

	[Address(RVA = "0x81DA40", Offset = "0x81CE40", Length = "0x329")]
	[Extension]
	[Token(Token = "0x6000D02")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, FixedList32Bytes<T> other) { }

	[Address(RVA = "0x81D300", Offset = "0x81C700", Length = "0x396")]
	[Extension]
	[Token(Token = "0x6000CF9")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, NativeList<T> other) { }

	[Address(RVA = "0x81DD70", Offset = "0x81D170", Length = "0x2FC")]
	[Extension]
	[Token(Token = "0x6000D2C")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, UnsafeList<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000CED")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, NativeParallelHashSet<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000CC6")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, UnsafeParallelHashSet<T> other) { }

	[Address(RVA = "0x81CF70", Offset = "0x81C370", Length = "0x389")]
	[Extension]
	[Token(Token = "0x6000CCF")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, FixedList128Bytes<T> other) { }

	[Address(RVA = "0x81E070", Offset = "0x81D470", Length = "0x30C")]
	[Extension]
	[Token(Token = "0x6000D23")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, UnsafeParallelHashSet<T> other) { }

	[Address(RVA = "0x81DA40", Offset = "0x81CE40", Length = "0x329")]
	[Extension]
	[Token(Token = "0x6000CD2")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, FixedList32Bytes<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000D20")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000CC9")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81C5E0", Offset = "0x81B9E0", Length = "0x359")]
	[Extension]
	[Token(Token = "0x6000CD5")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x81C270", Offset = "0x81B670", Length = "0x369")]
	[Extension]
	[Token(Token = "0x6000CD8")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, FixedList512Bytes<T> other) { }

	[Address(RVA = "0x81DD70", Offset = "0x81D170", Length = "0x2FC")]
	[Extension]
	[Token(Token = "0x6000CCC")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, UnsafeList<T> other) { }

	[Address(RVA = "0x81E690", Offset = "0x81DA90", Length = "0x339")]
	[Extension]
	[Token(Token = "0x6000CDB")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, FixedList64Bytes<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000D1D")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, NativeParallelHashSet<T> other) { }

	[Address(RVA = "0x81D6A0", Offset = "0x81CAA0", Length = "0x39C")]
	[Extension]
	[Token(Token = "0x6000D0E")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, NativeArray<T> other) { }

	[Address(RVA = "0x81D6A0", Offset = "0x81CAA0", Length = "0x39C")]
	[Extension]
	[Token(Token = "0x6000CDE")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, NativeArray<T> other) { }

	[Address(RVA = "0x81C940", Offset = "0x81BD40", Length = "0x306")]
	[Extension]
	[Token(Token = "0x6000CE1")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, NativeHashSet<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000CEA")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000CC0")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, UnsafeHashSet<T> other) { }

	[Address(RVA = "0x81E070", Offset = "0x81D470", Length = "0x30C")]
	[Extension]
	[Token(Token = "0x6000CE7")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, UnsafeHashSet<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000D26")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000CC3")]
	public static void IntersectWith(ref NativeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81CC50", Offset = "0x81C050", Length = "0x312")]
	[Extension]
	[Token(Token = "0x6000D1A")]
	public static void IntersectWith(ref UnsafeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81C940", Offset = "0x81BD40", Length = "0x306")]
	[Extension]
	[Token(Token = "0x6000CE4")]
	public static void IntersectWith(ref UnsafeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81AB40", Offset = "0x819F40", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000D24")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, UnsafeParallelHashSet<T> other) { }

	[Address(RVA = "0x81B930", Offset = "0x81AD30", Length = "0x292")]
	[Extension]
	[Token(Token = "0x6000D2A")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, NativeList<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x6000D12")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, NativeHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000D1E")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, NativeParallelHashSet<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x6000D15")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000D1B")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81AD60", Offset = "0x81A160", Length = "0x2A7")]
	[Extension]
	[Token(Token = "0x6000D0F")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, NativeArray<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000D21")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000D18")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, UnsafeHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000D27")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CEE")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, NativeParallelHashSet<T> other) { }

	[Address(RVA = "0x81B430", Offset = "0x81A830", Length = "0x26E")]
	[Extension]
	[Token(Token = "0x6000D09")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, FixedList512Bytes<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CB2")]
	public static void UnionWith(ref NativeHashSet<T>& container, UnsafeHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CB5")]
	public static void UnionWith(ref NativeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CB8")]
	public static void UnionWith(ref NativeHashSet<T>& container, UnsafeParallelHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CBB")]
	public static void UnionWith(ref NativeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81B010", Offset = "0x81A410", Length = "0x205")]
	[Extension]
	[Token(Token = "0x6000CBE")]
	public static void UnionWith(ref NativeHashSet<T>& container, UnsafeList<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CC1")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, UnsafeHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CC4")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CC7")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, UnsafeParallelHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CCA")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81B010", Offset = "0x81A410", Length = "0x205")]
	[Extension]
	[Token(Token = "0x6000CCD")]
	public static void UnionWith(ref NativeParallelHashSet<T>& container, UnsafeList<T> other) { }

	[Address(RVA = "0x81B6A0", Offset = "0x81AAA0", Length = "0x28E")]
	[Extension]
	[Token(Token = "0x6000CD0")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, FixedList128Bytes<T> other) { }

	[Address(RVA = "0x81BDE0", Offset = "0x81B1E0", Length = "0x22B")]
	[Extension]
	[Token(Token = "0x6000CD3")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, FixedList32Bytes<T> other) { }

	[Address(RVA = "0x81C010", Offset = "0x81B410", Length = "0x25E")]
	[Extension]
	[Token(Token = "0x6000CD6")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x81A6E0", Offset = "0x819AE0", Length = "0x23E")]
	[Extension]
	[Token(Token = "0x6000D0C")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, FixedList64Bytes<T> other) { }

	[Address(RVA = "0x81B430", Offset = "0x81A830", Length = "0x26E")]
	[Extension]
	[Token(Token = "0x6000CD9")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, FixedList512Bytes<T> other) { }

	[Address(RVA = "0x81AD60", Offset = "0x81A160", Length = "0x2A7")]
	[Extension]
	[Token(Token = "0x6000CDF")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, NativeArray<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x6000CE2")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, NativeHashSet<T> other) { }

	[Address(RVA = "0x81B220", Offset = "0x81A620", Length = "0x20B")]
	[Extension]
	[Token(Token = "0x6000CE5")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81AB40", Offset = "0x819F40", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CE8")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, UnsafeHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CEB")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CF1")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CF4")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, UnsafeParallelHashSet<T> other) { }

	[Address(RVA = "0x81A920", Offset = "0x819D20", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000CF7")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, ReadOnly<T> other) { }

	[Address(RVA = "0x81B930", Offset = "0x81AD30", Length = "0x292")]
	[Extension]
	[Token(Token = "0x6000CFA")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, NativeList<T> other) { }

	[Address(RVA = "0x81B010", Offset = "0x81A410", Length = "0x205")]
	[Extension]
	[Token(Token = "0x6000CFD")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, UnsafeList<T> other) { }

	[Address(RVA = "0x81B6A0", Offset = "0x81AAA0", Length = "0x28E")]
	[Extension]
	[Token(Token = "0x6000D00")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, FixedList128Bytes<T> other) { }

	[Address(RVA = "0x81BDE0", Offset = "0x81B1E0", Length = "0x22B")]
	[Extension]
	[Token(Token = "0x6000D03")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, FixedList32Bytes<T> other) { }

	[Address(RVA = "0x81C010", Offset = "0x81B410", Length = "0x25E")]
	[Extension]
	[Token(Token = "0x6000D06")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, FixedList4096Bytes<T> other) { }

	[Address(RVA = "0x81A6E0", Offset = "0x819AE0", Length = "0x23E")]
	[Extension]
	[Token(Token = "0x6000CDC")]
	public static void UnionWith(ref UnsafeHashSet<T>& container, FixedList64Bytes<T> other) { }

	[Address(RVA = "0x81B010", Offset = "0x81A410", Length = "0x205")]
	[Extension]
	[Token(Token = "0x6000D2D")]
	public static void UnionWith(ref UnsafeParallelHashSet<T>& container, UnsafeList<T> other) { }

}

