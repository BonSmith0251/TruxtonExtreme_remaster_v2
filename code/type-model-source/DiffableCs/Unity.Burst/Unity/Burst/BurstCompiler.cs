namespace Unity.Burst;

[Token(Token = "0x200000A")]
public static class BurstCompiler
{
	[CompilerGenerated]
	[Token(Token = "0x2000012")]
	private sealed class <>c
	{
		[Token(Token = "0x400002A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400002B")]
		public static Func<Attribute, Boolean> <>9__22_0; //Field offset: 0x8
		[Token(Token = "0x400002C")]
		public static Func<Attribute, Boolean> <>9__29_0; //Field offset: 0x10

		[Address(RVA = "0x27E5B80", Offset = "0x27E4F80", Length = "0x67")]
		[Token(Token = "0x6000058")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000059")]
		public <>c() { }

		[Address(RVA = "0x27E5AA0", Offset = "0x27E4EA0", Length = "0x6C")]
		[Token(Token = "0x600005A")]
		internal bool <Compile>b__22_0(Attribute s) { }

		[Address(RVA = "0x27E5B10", Offset = "0x27E4F10", Length = "0x6C")]
		[Token(Token = "0x600005B")]
		internal bool <TriggerUnsafeStaticMethodRecompilation>b__29_0(Attribute x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000013")]
	private struct <>c__DisplayClass17_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002D")]
		public RuntimeMethodHandle managedMethodHandle; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400002E")]
		public RuntimeTypeHandle delegateTypeHandle; //Field offset: 0x8

	}

	[BurstCompile]
	[Token(Token = "0x200000D")]
	public static class BurstCompilerHelper
	{
		[Token(Token = "0x2000010")]
		public static class IsBurstEnabled_00000145$BurstDirectCall
		{
			[Token(Token = "0x4000028")]
			private static IntPtr Pointer; //Field offset: 0x0

			[Address(RVA = "0x27C4B70", Offset = "0x27C3F70", Length = "0x167")]
			[Token(Token = "0x6000054")]
			private static IntPtr GetFunctionPointer() { }

			[Address(RVA = "0x27C49F0", Offset = "0x27C3DF0", Length = "0x174")]
			[BurstDiscard]
			[Token(Token = "0x6000053")]
			private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

			[Address(RVA = "0x27C4CE0", Offset = "0x27C40E0", Length = "0x287")]
			[Token(Token = "0x6000055")]
			public static bool Invoke() { }

		}

		[Token(Token = "0x200000F")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class IsBurstEnabled_00000145$PostfixBurstDelegate : MulticastDelegate
		{

			[Address(RVA = "0x1C107A0", Offset = "0x1C0FBA0", Length = "0xA5")]
			[Token(Token = "0x600004F")]
			public IsBurstEnabled_00000145$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

			[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
			[Token(Token = "0x6000051")]
			public override IAsyncResult BeginInvoke(AsyncCallback unnamed_param_0, object unnamed_param_1) { }

			[Address(RVA = "0x27C49C0", Offset = "0x27C3DC0", Length = "0x28")]
			[Token(Token = "0x6000052")]
			public override bool EndInvoke(IAsyncResult unnamed_param_0) { }

			[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
			[Token(Token = "0x6000050")]
			public override bool Invoke() { }

		}

		[Token(Token = "0x200000E")]
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		private sealed class IsBurstEnabledDelegate : MulticastDelegate
		{

			[Address(RVA = "0x1C107A0", Offset = "0x1C0FBA0", Length = "0xA5")]
			[Token(Token = "0x600004B")]
			public IsBurstEnabledDelegate(object object, IntPtr method) { }

			[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
			[Token(Token = "0x600004D")]
			public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

			[Address(RVA = "0x27C49C0", Offset = "0x27C3DC0", Length = "0x28")]
			[Token(Token = "0x600004E")]
			public override bool EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
			[Token(Token = "0x600004C")]
			public override bool Invoke() { }

		}

		[Token(Token = "0x4000026")]
		private static readonly IsBurstEnabledDelegate IsBurstEnabledImpl; //Field offset: 0x0
		[Token(Token = "0x4000027")]
		public static readonly bool IsBurstGenerated; //Field offset: 0x8

		[Address(RVA = "0x27BA0A0", Offset = "0x27B94A0", Length = "0x152")]
		[Token(Token = "0x6000049")]
		private static BurstCompilerHelper() { }

		[Address(RVA = "0x665340", Offset = "0x664740", Length = "0x4")]
		[BurstDiscard]
		[Token(Token = "0x6000047")]
		private static void DiscardedMethod(ref bool value) { }

		[Address(RVA = "0x27BA050", Offset = "0x27B9450", Length = "0x7")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(IsBurstEnabledDelegate))]
		[Token(Token = "0x6000046")]
		private static bool IsBurstEnabled() { }

		[Address(RVA = "0x27BA010", Offset = "0x27B9410", Length = "0x3C")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(IsBurstEnabledDelegate))]
		[Token(Token = "0x600004A")]
		internal static bool IsBurstEnabled$BurstManaged() { }

		[Address(RVA = "0x27BA060", Offset = "0x27B9460", Length = "0x31")]
		[Token(Token = "0x6000048")]
		private static bool IsCompiledByBurst(Delegate del) { }

	}

	[Token(Token = "0x200000B")]
	private class CommandBuilder
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000023")]
		private StringBuilder _builder; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000024")]
		private bool _hasArgs; //Field offset: 0x18

		[Address(RVA = "0x27C4580", Offset = "0x27C3980", Length = "0x6B")]
		[Token(Token = "0x600003F")]
		public CommandBuilder() { }

		[Address(RVA = "0x27C4380", Offset = "0x27C3780", Length = "0x28")]
		[Token(Token = "0x6000043")]
		public CommandBuilder And(char sep = |) { }

		[Address(RVA = "0x27C43B0", Offset = "0x27C37B0", Length = "0x4B")]
		[Token(Token = "0x6000040")]
		public CommandBuilder Begin(string cmd) { }

		[Address(RVA = "0x27C4400", Offset = "0x27C3800", Length = "0x6D")]
		[Token(Token = "0x6000044")]
		public string SendToCompiler() { }

		[Address(RVA = "0x27C4520", Offset = "0x27C3920", Length = "0x57")]
		[Token(Token = "0x6000041")]
		public CommandBuilder With(string arg) { }

		[Address(RVA = "0x27C4470", Offset = "0x27C3870", Length = "0xA7")]
		[Token(Token = "0x6000042")]
		public CommandBuilder With(IntPtr arg) { }

	}

	[Token(Token = "0x2000011")]
	private class FakeDelegate
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000029")]
		private readonly MethodInfo <Method>k__BackingField; //Field offset: 0x10

		[Preserve]
		[Token(Token = "0x1700000A")]
		public MethodInfo Method
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000057")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000056")]
		public FakeDelegate(MethodInfo method) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000057")]
		public MethodInfo get_Method() { }

	}

	[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
	[Token(Token = "0x200000C")]
	public class StaticTypeReinitAttribute : Attribute
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000025")]
		public readonly Type reinitType; //Field offset: 0x10

		[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
		[Token(Token = "0x6000045")]
		public StaticTypeReinitAttribute(Type toReinit) { }

	}

	[ThreadStatic]
	[Token(Token = "0x400001E")]
	private static CommandBuilder _cmdBuilder; //Field offset: 0x80000000
	[Token(Token = "0x400001F")]
	internal static bool _IsEnabled; //Field offset: 0x0
	[Token(Token = "0x4000020")]
	public static readonly BurstCompilerOptions Options; //Field offset: 0x8
	[Token(Token = "0x4000021")]
	internal static Action OnCompileILPPMethod2; //Field offset: 0x10
	[Token(Token = "0x4000022")]
	private static readonly MethodInfo DummyMethodInfo; //Field offset: 0x18

	[Token(Token = "0x17000009")]
	public static bool IsEnabled
	{
		[Address(RVA = "0x27BEB00", Offset = "0x27BDF00", Length = "0x8D")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x27BE8F0", Offset = "0x27BDCF0", Length = "0x20D")]
	[Token(Token = "0x600003D")]
	private static BurstCompiler() { }

	[Address(RVA = "0x27BE720", Offset = "0x27BDB20", Length = "0xE1")]
	[CompilerGenerated]
	[Token(Token = "0x600003E")]
	internal static void <GetILPPMethodFunctionPointer2>g__GetManagedFallbackDelegate|17_0(out Delegate managedFallbackDelegate, out GCHandle gcHandle, ref <>c__DisplayClass17_0 unnamed_param_2) { }

	[Address(RVA = "0x27BCE30", Offset = "0x27BC230", Length = "0x2C")]
	[Token(Token = "0x6000038")]
	internal static string AotCompilation(String[] assemblyFolders, String[] assemblyRoots, string options) { }

	[Address(RVA = "0x27BCE60", Offset = "0x27BC260", Length = "0x16B")]
	[Token(Token = "0x6000019")]
	private static CommandBuilder BeginCompilerCommand(string cmd) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000029")]
	internal static void Cancel() { }

	[Address(RVA = "0x27BD1F0", Offset = "0x27BC5F0", Length = "0x81D")]
	[Token(Token = "0x6000027")]
	private static Void* Compile(object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing, bool deterministicCompilation = false) { }

	[Address(RVA = "0x27BDA10", Offset = "0x27BCE10", Length = "0x165")]
	[Token(Token = "0x6000026")]
	private static Void* Compile(object delegateObj, bool isFunctionPointer, bool deterministicCompilation = false) { }

	[Address(RVA = "0x79B010", Offset = "0x79A410", Length = "0x106")]
	[Token(Token = "0x600001D")]
	internal static T CompileDelegate(T delegateMethod, bool deterministicCompilation = false) { }

	[Address(RVA = "0x79B120", Offset = "0x79A520", Length = "0x61")]
	[Token(Token = "0x6000025")]
	public static FunctionPointer<T> CompileFunctionPointer(T delegateMethod) { }

	[Address(RVA = "0x27BD170", Offset = "0x27BC570", Length = "0x3E")]
	[Obsolete("This method will be removed in a future version of Burst")]
	[Token(Token = "0x6000020")]
	public static IntPtr CompileILPPMethod(RuntimeMethodHandle burstMethodHandle, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle) { }

	[Address(RVA = "0x27BCFD0", Offset = "0x27BC3D0", Length = "0x190")]
	[Token(Token = "0x6000021")]
	public static IntPtr CompileILPPMethod2(RuntimeMethodHandle burstMethodHandle) { }

	[Address(RVA = "0x27BD1B0", Offset = "0x27BC5B0", Length = "0x3E")]
	[Obsolete("This method will be removed in a future version of Burst")]
	[Token(Token = "0x6000024")]
	public static Void* CompileUnsafeStaticMethod(RuntimeMethodHandle handle) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600002C")]
	internal static void Disable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600003C")]
	private static void DummyMethod() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600002B")]
	internal static void Enable() { }

	[Address(RVA = "0x27BEB00", Offset = "0x27BDF00", Length = "0x8D")]
	[Token(Token = "0x600001A")]
	public static bool get_IsEnabled() { }

	[Address(RVA = "0x27BDB80", Offset = "0x27BCF80", Length = "0x7")]
	[Token(Token = "0x600001C")]
	public static BurstExecutionEnvironment GetExecutionMode() { }

	[Address(RVA = "0x27BDDA0", Offset = "0x27BD1A0", Length = "0x3E")]
	[Obsolete("This method will be removed in a future version of Burst")]
	[Token(Token = "0x6000022")]
	public static Void* GetILPPMethodFunctionPointer(IntPtr ilppMethod) { }

	[Address(RVA = "0x27BDB90", Offset = "0x27BCF90", Length = "0x20B")]
	[Token(Token = "0x6000023")]
	public static Void* GetILPPMethodFunctionPointer2(IntPtr ilppMethod, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000033")]
	internal static void Initialize(String[] assemblyFolders, String[] ignoreAssemblies) { }

	[Address(RVA = "0x27BDDE0", Offset = "0x27BD1E0", Length = "0x7B")]
	[Token(Token = "0x6000031")]
	internal static bool IsApiAvailable(string apiName) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600002A")]
	internal static bool IsCurrentCompilationDone() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600002D")]
	internal static bool IsHostEditorArm() { }

	[Address(RVA = "0x27BDE60", Offset = "0x27BD260", Length = "0x53")]
	[Token(Token = "0x6000018")]
	public static bool IsLoadAdditionalLibrarySupported() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000036")]
	internal static void NotifyAssemblyCompilationFinished(string assemblyName, String[] defines) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000035")]
	internal static void NotifyAssemblyCompilationNotRequired(string assemblyName) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000037")]
	internal static void NotifyCompilationFinished() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000034")]
	internal static void NotifyCompilationStarted(String[] assemblyFolders, String[] ignoreAssemblies) { }

	[Address(RVA = "0x27BDEC0", Offset = "0x27BD2C0", Length = "0x131")]
	[Token(Token = "0x6000032")]
	internal static int RequestSetProtocolVersion(int version) { }

	[Address(RVA = "0x27BE000", Offset = "0x27BD400", Length = "0x2BB")]
	[Token(Token = "0x600003B")]
	private static string SendCommandToCompiler(string commandName, string commandArgs = null) { }

	[Address(RVA = "0x27BE2C0", Offset = "0x27BD6C0", Length = "0xA0")]
	[Token(Token = "0x600003A")]
	private static string SendRawCommandToCompiler(string command) { }

	[Address(RVA = "0x27BE370", Offset = "0x27BD770", Length = "0x7")]
	[Token(Token = "0x600001B")]
	public static void SetExecutionMode(BurstExecutionEnvironment mode) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000039")]
	internal static void SetProfilerCallbacks() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000028")]
	internal static void Shutdown() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600002F")]
	internal static void TriggerRecompilation() { }

	[Address(RVA = "0x27BE380", Offset = "0x27BD780", Length = "0x39B")]
	[Token(Token = "0x600002E")]
	internal static void TriggerUnsafeStaticMethodRecompilation() { }

	[Address(RVA = "0x27BE810", Offset = "0x27BDC10", Length = "0xD7")]
	[Token(Token = "0x6000030")]
	internal static void UnloadAdditionalLibraries() { }

	[Address(RVA = "0x79B190", Offset = "0x79A590", Length = "0xE7")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x600001F")]
	private static void VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute(T delegateMethod) { }

	[Address(RVA = "0x79B280", Offset = "0x79A680", Length = "0x10A")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x600001E")]
	private static void VerifyDelegateIsNotMulticast(T delegateMethod) { }

}

