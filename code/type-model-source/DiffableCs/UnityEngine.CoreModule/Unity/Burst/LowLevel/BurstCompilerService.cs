namespace Unity.Burst.LowLevel;

[NativeHeader("Runtime/Burst/Burst.h")]
[NativeHeader("Runtime/Burst/BurstDelegateCache.h")]
[StaticAccessor("BurstCompilerService::Get()", StaticAccessorType::Arrow (1))]
[Token(Token = "0x200007C")]
internal static class BurstCompilerService
{
	[Token(Token = "0x200007D")]
	internal enum BurstLogType : int
	{
		Info = 0,
		Warning = 1,
		Error = 2,
	}


	[Address(RVA = "0x2FCF860", Offset = "0x2FCEC60", Length = "0x19B")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x600018A")]
	public static int CompileAsyncDelegateMethod(object delegateMethod, string compilerOptions) { }

	[Address(RVA = "0x2FCF810", Offset = "0x2FCEC10", Length = "0x42")]
	[Token(Token = "0x6000193")]
	private static int CompileAsyncDelegateMethod_Injected(object delegateMethod, ref ManagedSpanWrapper compilerOptions) { }

	[Address(RVA = "0x2FCFA00", Offset = "0x2FCEE00", Length = "0x31")]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x600018B")]
	public static Void* GetAsyncCompiledAsyncDelegateMethod(int userID) { }

	[Address(RVA = "0x2FCFA40", Offset = "0x2FCEE40", Length = "0x2A")]
	[ThreadSafe]
	[Token(Token = "0x600018E")]
	public static uint GetCurrentExecutionMode() { }

	[Address(RVA = "0x2FCFAD0", Offset = "0x2FCEED0", Length = "0x1E6")]
	[ThreadSafe]
	[Token(Token = "0x6000189")]
	public static string GetDisassembly(MethodInfo m, string compilerOptions) { }

	[Address(RVA = "0x2FCFA70", Offset = "0x2FCEE70", Length = "0x52")]
	[Token(Token = "0x6000192")]
	private static void GetDisassembly_Injected(MethodInfo m, ref ManagedSpanWrapper compilerOptions, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FCFCC0", Offset = "0x2FCF0C0", Length = "0x50")]
	[ThreadSafe]
	[Token(Token = "0x600018C")]
	public static Void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment) { }

	[Address(RVA = "0x2FCFD50", Offset = "0x2FCF150", Length = "0x18D")]
	[Token(Token = "0x6000191")]
	public static bool LoadBurstLibrary(string fullPathToLibBurstGenerated) { }

	[Address(RVA = "0x2FCFD10", Offset = "0x2FCF110", Length = "0x33")]
	[Token(Token = "0x6000194")]
	private static bool LoadBurstLibrary_Injected(ref ManagedSpanWrapper fullPathToLibBurstGenerated) { }

	[Address(RVA = "0x2FCFEE0", Offset = "0x2FCF2E0", Length = "0x60")]
	[FreeFunction("DefaultBurstLogCallback", True)]
	[Token(Token = "0x600018F")]
	public static void Log(Void* userData, BurstLogType logType, Byte* message, Byte* filename, int lineNumber) { }

	[Address(RVA = "0x2FCFF40", Offset = "0x2FCF340", Length = "0x60")]
	[FreeFunction("DefaultBurstRuntimeLogCallback", True)]
	[Token(Token = "0x6000190")]
	public static void RuntimeLog(Void* userData, BurstLogType logType, Byte* message, Byte* filename, int lineNumber) { }

	[Address(RVA = "0x2FCFFA0", Offset = "0x2FCF3A0", Length = "0x31")]
	[ThreadSafe]
	[Token(Token = "0x600018D")]
	public static void SetCurrentExecutionMode(uint environment) { }

}

