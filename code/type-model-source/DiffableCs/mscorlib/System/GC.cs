namespace System;

[Token(Token = "0x200018F")]
public static class GC
{
	[Token(Token = "0x40005C1")]
	internal static readonly object EPHEMERON_TOMBSTONE; //Field offset: 0x0

	[Token(Token = "0x17000127")]
	public static int MaxGeneration
	{
		[Address(RVA = "0x206A450", Offset = "0x2069850", Length = "0x3E")]
		[Token(Token = "0x6000E54")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x206A3E0", Offset = "0x20697E0", Length = "0x5")]
	[Token(Token = "0x6000E57")]
	private static void _ReRegisterForFinalize(object o) { }

	[Address(RVA = "0x206A3F0", Offset = "0x20697F0", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000E55")]
	private static void _SuppressFinalize(object o) { }

	[Address(RVA = "0x206A400", Offset = "0x2069800", Length = "0x50")]
	[Token(Token = "0x6000E59")]
	private static GC() { }

	[Address(RVA = "0x2069E90", Offset = "0x2069290", Length = "0x138")]
	[Token(Token = "0x6000E4F")]
	public static void AddMemoryPressure(long bytesAllocated) { }

	[Address(RVA = "0x2069FD0", Offset = "0x20693D0", Length = "0x76")]
	[Token(Token = "0x6000E51")]
	public static void Collect() { }

	[Address(RVA = "0x206A050", Offset = "0x2069450", Length = "0xB7")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000E52")]
	public static int CollectionCount(int generation) { }

	[Address(RVA = "0x206A490", Offset = "0x2069890", Length = "0x5")]
	[Token(Token = "0x6000E4D")]
	private static object get_ephemeron_tombstone() { }

	[Address(RVA = "0x206A450", Offset = "0x2069850", Length = "0x3E")]
	[Token(Token = "0x6000E54")]
	public static int get_MaxGeneration() { }

	[Address(RVA = "0x206A110", Offset = "0x2069510", Length = "0x5")]
	[Token(Token = "0x6000E48")]
	private static int GetCollectionCount(int generation) { }

	[Address(RVA = "0x206A120", Offset = "0x2069520", Length = "0x5")]
	[Token(Token = "0x6000E49")]
	private static int GetMaxGeneration() { }

	[Address(RVA = "0x206A130", Offset = "0x2069530", Length = "0x1C")]
	[Token(Token = "0x6000E4E")]
	internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation) { }

	[Address(RVA = "0x206A150", Offset = "0x2069550", Length = "0x5")]
	[Token(Token = "0x6000E4A")]
	private static void InternalCollect(int generation) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000E53")]
	public static void KeepAlive(object obj) { }

	[Address(RVA = "0x1ECCFE0", Offset = "0x1ECC3E0", Length = "0x5")]
	[Token(Token = "0x6000E4B")]
	private static void RecordPressure(long bytesAllocated) { }

	[Address(RVA = "0x206A4A0", Offset = "0x20698A0", Length = "0x5")]
	[Token(Token = "0x6000E4C")]
	internal static void register_ephemeron_array(Ephemeron[] array) { }

	[Address(RVA = "0x206A200", Offset = "0x2069600", Length = "0x13B")]
	[Token(Token = "0x6000E50")]
	public static void RemoveMemoryPressure(long bytesAllocated) { }

	[Address(RVA = "0x206A160", Offset = "0x2069560", Length = "0x94")]
	[Token(Token = "0x6000E58")]
	public static void ReRegisterForFinalize(object obj) { }

	[Address(RVA = "0x206A340", Offset = "0x2069740", Length = "0x94")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000E56")]
	public static void SuppressFinalize(object obj) { }

}

