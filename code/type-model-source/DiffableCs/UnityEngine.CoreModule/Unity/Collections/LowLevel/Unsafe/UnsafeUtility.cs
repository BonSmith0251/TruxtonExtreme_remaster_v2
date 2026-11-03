namespace Unity.Collections.LowLevel.Unsafe;

[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
[StaticAccessor("UnsafeUtility", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000077")]
public static class UnsafeUtility
{
	[Token(Token = "0x2000079")]
	private struct AlignOfHelper
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000113")]
		public byte dummy; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000114")]
		public T data; //Field offset: 0x0

	}

	[Token(Token = "0x2000078")]
	public struct TypeFlagsCache
	{
		[Token(Token = "0x4000112")]
		internal static readonly int flags; //Field offset: 0x0

		[Address(RVA = "0x10DF490", Offset = "0x10DE890", Length = "0xC5")]
		[Token(Token = "0x6000185")]
		private static TypeFlagsCache`1() { }

		[Address(RVA = "0x10DF420", Offset = "0x10DE820", Length = "0x63")]
		[BurstDiscard]
		[Token(Token = "0x6000186")]
		private static void Init(ref int flags) { }

	}


	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600017C")]
	public static Void* AddressOf(ref T output) { }

	[Address(RVA = "0x9DC930", Offset = "0x9DBD30", Length = "0x1A")]
	[Token(Token = "0x6000173")]
	public static int AlignOf() { }

	[Address(RVA = "0x9D75F0", Offset = "0x9D69F0", Length = "0x8")]
	[Token(Token = "0x6000181")]
	public static T ArrayElementAsRef(Void* ptr, int index) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600017F")]
	internal static T As(object from) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600017E")]
	public static T As(ref U from) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000180")]
	public static T AsRef(Void* ptr) { }

	[Address(RVA = "0x9E0270", Offset = "0x9DF670", Length = "0x30")]
	[Token(Token = "0x6000174")]
	public static void CopyPtrToStructure(Void* ptr, out T output) { }

	[Address(RVA = "0x9E0230", Offset = "0x9DF630", Length = "0x3D")]
	[Token(Token = "0x6000176")]
	public static void CopyStructureToPtr(ref T input, Void* ptr) { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000184")]
	public static bool EnumEquals(T lhs, T rhs) { }

	[Address(RVA = "0x9E0410", Offset = "0x9DF810", Length = "0x1F")]
	[Token(Token = "0x6000182")]
	public static int EnumToInt(T enumValue) { }

	[Address(RVA = "0x2FF03B0", Offset = "0x2FEF7B0", Length = "0x40")]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x6000160")]
	public static void Free(Void* memory, Allocator allocator) { }

	[Address(RVA = "0x2FF0360", Offset = "0x2FEF760", Length = "0x41")]
	[Token(Token = "0x6000161")]
	public static void Free(Void* memory, MemoryLabel label) { }

	[Address(RVA = "0x2FF0320", Offset = "0x2FEF720", Length = "0x40")]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x600015C")]
	public static void FreeTracked(Void* memory, Allocator allocator) { }

	[Address(RVA = "0x2FF03F0", Offset = "0x2FEF7F0", Length = "0x65")]
	[Token(Token = "0x6000170")]
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	[Address(RVA = "0x9E0430", Offset = "0x9DF830", Length = "0x72")]
	[Token(Token = "0x6000171")]
	internal static string GetReasonForGenericListNonBlittable() { }

	[Address(RVA = "0x2FF0460", Offset = "0x2FEF860", Length = "0x207")]
	[Token(Token = "0x600016D")]
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	[Address(RVA = "0x2FF0670", Offset = "0x2FEFA70", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x600016B")]
	internal static int GetScriptingTypeFlags(Type type) { }

	[Address(RVA = "0x9E0580", Offset = "0x9DF980", Length = "0x7")]
	[Token(Token = "0x6000175")]
	private static void InternalCopyPtrToStructure(Void* ptr, out T output) { }

	[Address(RVA = "0x9E0570", Offset = "0x9DF970", Length = "0x5")]
	[Token(Token = "0x6000177")]
	private static void InternalCopyStructureToPtr(ref T input, Void* ptr) { }

	[Address(RVA = "0x9E0570", Offset = "0x9DF970", Length = "0x5")]
	[Token(Token = "0x6000183")]
	private static void InternalEnumToInt(ref T enumValue, ref int intValue) { }

	[Address(RVA = "0x2FF06B0", Offset = "0x2FEFAB0", Length = "0x88")]
	[Token(Token = "0x600016E")]
	internal static bool IsArrayBlittable(Array arr) { }

	[Address(RVA = "0x9E0590", Offset = "0x9DF990", Length = "0x4A")]
	[Token(Token = "0x6000157")]
	public static bool IsBlittable() { }

	[Address(RVA = "0x2FF07A0", Offset = "0x2FEFBA0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x600016A")]
	public static bool IsBlittable(Type type) { }

	[Address(RVA = "0x2FF0740", Offset = "0x2FEFB40", Length = "0x5D")]
	[Token(Token = "0x600016C")]
	private static bool IsBlittableValueType(Type t) { }

	[Address(RVA = "0x7A5B90", Offset = "0x7A4F90", Length = "0x2A")]
	[Token(Token = "0x600016F")]
	internal static bool IsGenericListBlittable() { }

	[Address(RVA = "0x9E05E0", Offset = "0x9DF9E0", Length = "0x6C")]
	[Token(Token = "0x6000172")]
	public static bool IsUnmanaged() { }

	[Address(RVA = "0x2FF07E0", Offset = "0x2FEFBE0", Length = "0x40")]
	[BurstAuthorizedExternalMethod]
	[ThreadSafe(ThrowsException = False)]
	[Token(Token = "0x6000159")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.AIModule"})]
	internal static int LeakErase(IntPtr handle, LeakCategory category) { }

	[Address(RVA = "0x2FF0820", Offset = "0x2FEFC20", Length = "0x50")]
	[BurstAuthorizedExternalMethod]
	[ThreadSafe(ThrowsException = False)]
	[Token(Token = "0x6000158")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.AIModule"})]
	internal static int LeakRecord(IntPtr handle, LeakCategory category, int callstacksToSkip) { }

	[Address(RVA = "0x2FF0A10", Offset = "0x2FEFE10", Length = "0x53")]
	[Token(Token = "0x600015D")]
	public static Void* Malloc(long size, int alignment, Allocator allocator) { }

	[Address(RVA = "0x2FF09A0", Offset = "0x2FEFDA0", Length = "0x61")]
	[Token(Token = "0x600015E")]
	public static Void* Malloc(long size, int alignment, MemoryLabel label) { }

	[Address(RVA = "0x2FF0940", Offset = "0x2FEFD40", Length = "0x60")]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x600015F")]
	private static Void* Malloc(long size, int alignment, Allocator allocator, IntPtr label) { }

	[Address(RVA = "0x2FF0870", Offset = "0x2FEFC70", Length = "0x6A")]
	[Token(Token = "0x600015A")]
	public static Void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip) { }

	[Address(RVA = "0x2FF08E0", Offset = "0x2FEFCE0", Length = "0x60")]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x600015B")]
	internal static Void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip, IntPtr label) { }

	[Address(RVA = "0x2FF0A70", Offset = "0x2FEFE70", Length = "0x44")]
	[Token(Token = "0x6000167")]
	public static void MemClear(Void* destination, long size) { }

	[Address(RVA = "0x2FF0AC0", Offset = "0x2FEFEC0", Length = "0x52")]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x6000168")]
	public static int MemCmp(Void* ptr1, Void* ptr2, long size) { }

	[Address(RVA = "0x2FF0BF0", Offset = "0x2FEFFF0", Length = "0x52")]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x6000162")]
	public static void MemCpy(Void* destination, Void* source, long size) { }

	[Address(RVA = "0x2FF0B20", Offset = "0x2FEFF20", Length = "0x62")]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x6000163")]
	public static void MemCpyReplicate(Void* destination, Void* source, int size, int count) { }

	[Address(RVA = "0x2FF0B90", Offset = "0x2FEFF90", Length = "0x60")]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x6000164")]
	public static void MemCpyStride(Void* destination, int destinationStride, Void* source, int sourceStride, int elementSize, int count) { }

	[Address(RVA = "0x2FF0C50", Offset = "0x2FF0050", Length = "0x52")]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x6000165")]
	public static void MemMove(Void* destination, Void* source, long size) { }

	[Address(RVA = "0x2FF0CB0", Offset = "0x2FF00B0", Length = "0x53")]
	[ThreadSafe(ThrowsException = True)]
	[Token(Token = "0x6000166")]
	public static void MemSet(Void* destination, byte value, long size) { }

	[Address(RVA = "0x9E0B20", Offset = "0x9DFF20", Length = "0x7")]
	[Token(Token = "0x6000178")]
	public static T ReadArrayElement(Void* source, int index) { }

	[Address(RVA = "0x9E0680", Offset = "0x9DFA80", Length = "0x87")]
	[Token(Token = "0x6000179")]
	public static T ReadArrayElementWithStride(Void* source, int index, int stride) { }

	[Address(RVA = "0x9DCDF0", Offset = "0x9DC1F0", Length = "0x6")]
	[Token(Token = "0x600017D")]
	public static int SizeOf() { }

	[Address(RVA = "0x2FF0D10", Offset = "0x2FF0110", Length = "0x9D7")]
	[ThreadSafe]
	[Token(Token = "0x6000169")]
	public static int SizeOf(Type type) { }

	[Address(RVA = "0x9E1EC0", Offset = "0x9E12C0", Length = "0x8")]
	[Token(Token = "0x600017A")]
	public static void WriteArrayElement(Void* destination, int index, T value) { }

	[Address(RVA = "0x9E1A00", Offset = "0x9E0E00", Length = "0x8F")]
	[Token(Token = "0x600017B")]
	public static void WriteArrayElementWithStride(Void* destination, int index, int stride, T value) { }

}

