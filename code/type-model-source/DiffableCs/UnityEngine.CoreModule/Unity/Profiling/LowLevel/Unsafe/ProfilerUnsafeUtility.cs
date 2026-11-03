namespace Unity.Profiling.LowLevel.Unsafe;

[IgnoredByDeepProfiler]
[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerUnsafeUtility.bindings.h")]
[Token(Token = "0x2000037")]
[UsedByNativeCode]
public static class ProfilerUnsafeUtility
{

	[Address(RVA = "0x2FE4B10", Offset = "0x2FE3F10", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x60000A2")]
	public static void BeginSample(IntPtr markerPtr) { }

	[Address(RVA = "0x2FE4B50", Offset = "0x2FE3F50", Length = "0x52")]
	[ThreadSafe]
	[Token(Token = "0x600009D")]
	internal static ushort CreateCategory__Unmanaged(Byte* name, int nameLen, ProfilerCategoryColor colorIndex) { }

	[Address(RVA = "0x2FE4BB0", Offset = "0x2FE3FB0", Length = "0xA4")]
	[ThreadSafe]
	[Token(Token = "0x60000A4")]
	internal static Void* CreateCounterValue__Unmanaged(out IntPtr counterPtr, Byte* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions) { }

	[Address(RVA = "0x2FE4D40", Offset = "0x2FE4140", Length = "0x1AD")]
	[ThreadSafe]
	[Token(Token = "0x600009F")]
	public static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[Address(RVA = "0x2FE4CD0", Offset = "0x2FE40D0", Length = "0x64")]
	[ThreadSafe]
	[Token(Token = "0x60000A0")]
	internal static IntPtr CreateMarker__Unmanaged(Byte* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[Address(RVA = "0x2FE4C60", Offset = "0x2FE4060", Length = "0x64")]
	[Token(Token = "0x60000A9")]
	private static IntPtr CreateMarker_Injected(ref ManagedSpanWrapper name, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[Address(RVA = "0x2FE4EF0", Offset = "0x2FE42F0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x60000A3")]
	public static void EndSample(IntPtr markerPtr) { }

	[Address(RVA = "0x2FE4F80", Offset = "0x2FE4380", Length = "0x51")]
	[ThreadSafe]
	[Token(Token = "0x600009E")]
	public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId) { }

	[Address(RVA = "0x2FE4F30", Offset = "0x2FE4330", Length = "0x42")]
	[Token(Token = "0x60000A8")]
	private static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret) { }

	[Address(RVA = "0x2FE5090", Offset = "0x2FE4490", Length = "0x2AA")]
	[NativeConditional("ENABLE_MEM_PROFILER")]
	[ThreadSafe(ThrowsException = False)]
	[Token(Token = "0x60000A6")]
	internal static IntPtr GetOrCreateMemLabel(string areaName, string objectName) { }

	[Address(RVA = "0x2FE5030", Offset = "0x2FE4430", Length = "0x60")]
	[NativeConditional("ENABLE_MEM_PROFILER")]
	[ThreadSafe(ThrowsException = False)]
	[Token(Token = "0x60000A7")]
	internal static IntPtr GetOrCreateMemLabel__Unmanaged(Byte* areaName, int areaNameLen, Byte* objectName, int objectNameLen) { }

	[Address(RVA = "0x2FE4FE0", Offset = "0x2FE43E0", Length = "0x42")]
	[Token(Token = "0x60000AA")]
	private static IntPtr GetOrCreateMemLabel_Injected(ref ManagedSpanWrapper areaName, ref ManagedSpanWrapper objectName) { }

	[Address(RVA = "0x2FE5340", Offset = "0x2FE4740", Length = "0x74")]
	[ThreadSafe]
	[Token(Token = "0x60000A1")]
	internal static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, Byte* name, int nameLen, byte type, byte unit) { }

	[Address(RVA = "0x2FE53C0", Offset = "0x2FE47C0", Length = "0xE8")]
	[Token(Token = "0x60000A5")]
	internal static string Utf8ToString(Byte* chars, int charsLen) { }

}

