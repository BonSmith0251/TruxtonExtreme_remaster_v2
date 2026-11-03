namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x200003D")]
public static class CollectionHelper
{
	[BurstCompile]
	[Token(Token = "0x200003F")]
	internal struct DummyJob : IJob
	{

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600015A")]
		public override void Execute() { }

	}

	[Token(Token = "0x200003E")]
	public struct LongDoubleUnion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000087")]
		internal long longValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000088")]
		internal double doubleValue; //Field offset: 0x0

	}

	[Token(Token = "0x4000086")]
	public const int CacheLineSize = 64; //Field offset: 0x0

	[Address(RVA = "0x28ABC80", Offset = "0x28AB080", Length = "0x11")]
	[Token(Token = "0x600013E")]
	public static int Align(int size, int alignmentPowerOfTwo) { }

	[Address(RVA = "0x28ABCA0", Offset = "0x28AB0A0", Length = "0x17")]
	[Token(Token = "0x600013F")]
	public static ulong Align(ulong size, ulong alignmentPowerOfTwo) { }

	[Address(RVA = "0x28ABC60", Offset = "0x28AB060", Length = "0x19")]
	[Token(Token = "0x6000140")]
	internal static Void* AlignPointer(Void* ptr, int alignmentPowerOfTwo) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000147")]
	internal static int AssumePositive(int value) { }

	[Address(RVA = "0x28ABCC0", Offset = "0x28AB0C0", Length = "0xA8")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600013B")]
	internal static void CheckAllocator(AllocatorHandle allocator) { }

	[Address(RVA = "0x28ABD70", Offset = "0x28AB170", Length = "0x121")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600014C")]
	internal static void CheckCapacityInRange(int capacity, int length) { }

	[Address(RVA = "0x79F7B0", Offset = "0x79EBB0", Length = "0x12F")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000154")]
	private static void CheckConvertArguments(int length) { }

	[Address(RVA = "0x28ABEA0", Offset = "0x28AB2A0", Length = "0xA6")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600014B")]
	internal static void CheckIndexInRange(int index, int length) { }

	[Address(RVA = "0x28ABF50", Offset = "0x28AB350", Length = "0x99")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000149")]
	internal static void CheckIntPositivePowerOfTwo(int value) { }

	[Address(RVA = "0x79F8E0", Offset = "0x79ECE0", Length = "0xB6")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)})]
	[Token(Token = "0x6000148")]
	internal static void CheckIsUnmanaged() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(DummyJob)})]
	[Token(Token = "0x6000158")]
	public static void CheckReflectionDataCorrect(IntPtr reflectionData) { }

	[Address(RVA = "0x79F9A0", Offset = "0x79EDA0", Length = "0xB3")]
	[BurstDiscard]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000159")]
	private static void CheckReflectionDataCorrectInternal(IntPtr reflectionData, ref bool burstCompiled) { }

	[Address(RVA = "0x28ABFF0", Offset = "0x28AB3F0", Length = "0x9D")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600014A")]
	internal static void CheckUlongPositivePowerOfTwo(ulong value) { }

	[Address(RVA = "0x79FA60", Offset = "0x79EE60", Length = "0x53")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000155")]
	public static NativeArray<T> ConvertExistingDataToNativeArray(Void* dataPointer, int length, AllocatorHandle allocator, bool setTempMemoryHandle = false) { }

	[Address(RVA = "0x79FAC0", Offset = "0x79EEC0", Length = "0x97")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000156")]
	public static NativeArray<T> ConvertExistingNativeListToNativeArray(ref NativeList<T>& nativeList, int length, AllocatorHandle allocator) { }

	[Address(RVA = "0x7A05E0", Offset = "0x79F9E0", Length = "0x1CF")]
	[ExcludeFromBurstCompatTesting("Managed array")]
	[Token(Token = "0x6000151")]
	public static NativeArray<T> CreateNativeArray(T[] array, ref U allocator) { }

	[Address(RVA = "0x7A0970", Offset = "0x79FD70", Length = "0x131")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x600014F")]
	public static NativeArray<T> CreateNativeArray(NativeArray<T> array, AllocatorHandle allocator) { }

	[Address(RVA = "0x79FC40", Offset = "0x79F040", Length = "0xDA")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x600014E")]
	public static NativeArray<T> CreateNativeArray(int length, AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	[Address(RVA = "0x7A0B80", Offset = "0x79FF80", Length = "0xF3")]
	[ExcludeFromBurstCompatTesting("Managed array")]
	[Token(Token = "0x6000150")]
	public static NativeArray<T> CreateNativeArray(T[] array, AllocatorHandle allocator) { }

	[Address(RVA = "0x7A07B0", Offset = "0x79FBB0", Length = "0x1BD")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(AllocatorHandle)})]
	[Token(Token = "0x600014D")]
	public static NativeArray<T> CreateNativeArray(int length, ref U allocator, NativeArrayOptions options = 1) { }

	[Address(RVA = "0x7A17E0", Offset = "0x7A0BE0", Length = "0x61")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int), typeof(AllocatorHandle)})]
	[Token(Token = "0x6000157")]
	public static NativeParallelMultiHashMap<TKey, TValue> CreateNativeParallelMultiHashMap(int length, ref U allocator) { }

	[Address(RVA = "0x6E0E20", Offset = "0x6E0220", Length = "0x3A")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000153")]
	public static void Dispose(NativeArray<T> nativeArray) { }

	[Address(RVA = "0x7A1850", Offset = "0x7A0C50", Length = "0x3A")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000152")]
	public static void DisposeNativeArray(NativeArray<T> nativeArray, AllocatorHandle allocator) { }

	[Address(RVA = "0x28AC090", Offset = "0x28AB490", Length = "0x2D")]
	[Token(Token = "0x6000144")]
	public static uint Hash(Void* ptr, int bytes) { }

	[Address(RVA = "0x28AC0C0", Offset = "0x28AB4C0", Length = "0xD")]
	[Token(Token = "0x6000141")]
	public static bool IsAligned(Void* p, int alignmentPowerOfTwo) { }

	[Address(RVA = "0x28AC0C0", Offset = "0x28AB4C0", Length = "0xD")]
	[Token(Token = "0x6000142")]
	public static bool IsAligned(ulong offset, int alignmentPowerOfTwo) { }

	[Address(RVA = "0x28AC0D0", Offset = "0x28AB4D0", Length = "0x9")]
	[Token(Token = "0x6000143")]
	public static bool IsPowerOfTwo(int value) { }

	[Address(RVA = "0x28AC0E0", Offset = "0x28AB4E0", Length = "0x3F")]
	[Token(Token = "0x600013D")]
	public static int Log2Ceil(int value) { }

	[Address(RVA = "0x28AC120", Offset = "0x28AB520", Length = "0x41")]
	[Token(Token = "0x600013C")]
	public static int Log2Floor(int value) { }

	[Address(RVA = "0x28AC170", Offset = "0x28AB570", Length = "0x14")]
	[Token(Token = "0x6000146")]
	internal static bool ShouldDeallocate(AllocatorHandle allocator) { }

	[Address(RVA = "0x28AC190", Offset = "0x28AB590", Length = "0x258")]
	[ExcludeFromBurstCompatTesting("Used only for debugging, and uses managed strings")]
	[Token(Token = "0x6000145")]
	internal static void WriteLayout(Type type) { }

}

