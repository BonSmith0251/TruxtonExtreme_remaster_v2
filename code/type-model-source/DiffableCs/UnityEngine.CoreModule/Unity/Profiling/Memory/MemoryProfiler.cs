namespace Unity.Profiling.Memory;

[NativeHeader("Runtime/Profiler/Runtime/MemorySnapshotManager.h")]
[Token(Token = "0x2000039")]
public static class MemoryProfiler
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400009A")]
	private static Action<String, Boolean> m_SnapshotFinished; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400009B")]
	private static Action<String, Boolean, DebugScreenCapture> m_SaveScreenshotToDisk; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400009C")]
	private static Action<MemorySnapshotMetadata> CreatingMetadata; //Field offset: 0x10

	[Token(Token = "0x14000001")]
	public static event Action<MemorySnapshotMetadata> CreatingMetadata
	{
		[Address(RVA = "0x2FE3A00", Offset = "0x2FE2E00", Length = "0xDF")]
		[CompilerGenerated]
		[Token(Token = "0x60000AF")]
		 add { } //Length: 223
		[Address(RVA = "0x2FE3AE0", Offset = "0x2FE2EE0", Length = "0xDF")]
		[CompilerGenerated]
		[Token(Token = "0x60000B0")]
		 remove { } //Length: 223
	}

	[Address(RVA = "0x2FE3A00", Offset = "0x2FE2E00", Length = "0xDF")]
	[CompilerGenerated]
	[Token(Token = "0x60000AF")]
	public static void add_CreatingMetadata(Action<MemorySnapshotMetadata> value) { }

	[Address(RVA = "0x2FE3400", Offset = "0x2FE2800", Length = "0x89")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B4")]
	private static void FinalizeSnapshot(string path, bool result) { }

	[Address(RVA = "0x2FE3490", Offset = "0x2FE2890", Length = "0x315")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B1")]
	private static Byte[] PrepareMetadata() { }

	[Address(RVA = "0x2FE3AE0", Offset = "0x2FE2EE0", Length = "0xDF")]
	[CompilerGenerated]
	[Token(Token = "0x60000B0")]
	public static void remove_CreatingMetadata(Action<MemorySnapshotMetadata> value) { }

	[Address(RVA = "0x2FE37B0", Offset = "0x2FE2BB0", Length = "0x12F")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B5")]
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

	[Address(RVA = "0x2FE38E0", Offset = "0x2FE2CE0", Length = "0x73")]
	[Token(Token = "0x60000B2")]
	internal static int WriteIntToByteArray(Byte[] array, int offset, int value) { }

	[Address(RVA = "0x2FE3960", Offset = "0x2FE2D60", Length = "0x90")]
	[Token(Token = "0x60000B3")]
	internal static int WriteStringToByteArray(Byte[] array, int offset, string value) { }

}

