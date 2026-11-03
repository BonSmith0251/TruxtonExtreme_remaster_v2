namespace Unity.Burst;

[Token(Token = "0x2000015")]
public sealed class BurstCompilerOptions
{
	[Token(Token = "0x4000033")]
	private const string DisableCompilationArg = "--burst-disable-compilation"; //Field offset: 0x0
	[Token(Token = "0x4000085")]
	internal const string OptionSaveExtraContext = "save-extra-context"; //Field offset: 0x0
	[Token(Token = "0x4000084")]
	internal const string OptionDiscardAssemblies = "discard-assemblies="; //Field offset: 0x0
	[Token(Token = "0x4000083")]
	internal const string OptionTargetFramework = "target-framework="; //Field offset: 0x0
	[Token(Token = "0x4000082")]
	internal const string OptionCompilationId = "compilation-id="; //Field offset: 0x0
	[Token(Token = "0x4000081")]
	internal const string OptionLibraryOutputMode = "library-output-mode="; //Field offset: 0x0
	[Token(Token = "0x4000080")]
	internal const string OptionSafetyChecks = "safety-checks"; //Field offset: 0x0
	[Token(Token = "0x400007F")]
	internal const string OptionAotPdbSearchPaths = "pdb-search-paths="; //Field offset: 0x0
	[Token(Token = "0x400007E")]
	internal const string OptionAlwaysCreateOutput = "always-create-output="; //Field offset: 0x0
	[Token(Token = "0x400007D")]
	internal const string OptionOutputMode = "output-mode="; //Field offset: 0x0
	[Token(Token = "0x400007C")]
	internal const string OptionPrintLogOnMissingPInvokeCallbackAttribute = "print-monopinvokecallbackmissing-message"; //Field offset: 0x0
	[Token(Token = "0x400007B")]
	internal const string OptionChunkSize = "chunk-size="; //Field offset: 0x0
	[Token(Token = "0x4000086")]
	internal const string CompilerCommandShutdown = "$shutdown"; //Field offset: 0x0
	[Token(Token = "0x400007A")]
	internal const string OptionCompilerThreads = "threads="; //Field offset: 0x0
	[Token(Token = "0x4000078")]
	internal const string OptionVerbose = "verbose"; //Field offset: 0x0
	[Token(Token = "0x4000077")]
	internal const string OptionAotDecodeFolder = "decode-folder="; //Field offset: 0x0
	[Token(Token = "0x4000076")]
	internal const string OptionAotKeyFolder = "key-folder="; //Field offset: 0x0
	[Token(Token = "0x4000075")]
	internal const string OptionAotEmitLlvmObjects = "emit-llvm-objects"; //Field offset: 0x0
	[Token(Token = "0x4000074")]
	internal const string OptionAotNoNativeToolchain = "no-native-toolchain"; //Field offset: 0x0
	[Token(Token = "0x4000073")]
	internal const string OptionMethodPrefix = "method-prefix="; //Field offset: 0x0
	[Token(Token = "0x4000072")]
	internal const string OptionAotOnlyStaticMethods = "only-static-methods"; //Field offset: 0x0
	[Token(Token = "0x4000071")]
	internal const string OptionAotNoLink = "nolink"; //Field offset: 0x0
	[Token(Token = "0x4000070")]
	internal const string OptionAotKeepIntermediateFiles = "keep-intermediate-files"; //Field offset: 0x0
	[Token(Token = "0x400006E")]
	internal const string OptionAotAssembly = "assembly="; //Field offset: 0x0
	[Token(Token = "0x400006D")]
	internal const string OptionAotType = "type="; //Field offset: 0x0
	[Token(Token = "0x4000079")]
	internal const string OptionValidateExternalToolChain = "validate-external-tool-chain"; //Field offset: 0x0
	[Token(Token = "0x400006C")]
	internal const string OptionAotMethod = "method="; //Field offset: 0x0
	[Token(Token = "0x4000087")]
	internal const string CompilerCommandCancel = "$cancel"; //Field offset: 0x0
	[Token(Token = "0x4000089")]
	internal const string CompilerCommandDisableCompiler = "$disable_compiler"; //Field offset: 0x0
	[Token(Token = "0x40000A1")]
	internal static readonly bool ForceDisableBurstCompilation; //Field offset: 0x0
	[Token(Token = "0x40000A0")]
	internal const string CompilerCommandSetProtocolVersionBurst = "$set_protocol_version_burst"; //Field offset: 0x0
	[Token(Token = "0x400009F")]
	internal const string CompilerCommandRequestSetProtocolVersionEditor = "$request_set_protocol_version_editor"; //Field offset: 0x0
	[Token(Token = "0x400009E")]
	internal const string CompilerCommandInitialiseDebuggerCommmand = "$load_debugger_interface"; //Field offset: 0x0
	[Token(Token = "0x400009D")]
	internal const string CompilerCommandRequestInitialiseDebuggerCommmand = "$request_debug_command"; //Field offset: 0x0
	[Token(Token = "0x400009C")]
	internal const string CompilerCommandAotCompilation = "$aot_compilation"; //Field offset: 0x0
	[Token(Token = "0x400009B")]
	internal const string CompilerCommandDirtyAllAssemblies = "$dirty_all_assemblies"; //Field offset: 0x0
	[Token(Token = "0x400009A")]
	internal const string CompilerCommandNotifyCompilationFinished = "$notify_compilation_finished"; //Field offset: 0x0
	[Token(Token = "0x4000099")]
	internal const string CompilerCommandNotifyCompilationStarted = "$notify_compilation_started"; //Field offset: 0x0
	[Token(Token = "0x4000098")]
	internal const string CompilerCommandNotifyAssemblyCompilationFinished = "$notify_assembly_compilation_finished"; //Field offset: 0x0
	[Token(Token = "0x4000097")]
	internal const string CompilerCommandNotifyAssemblyCompilationNotRequired = "$notify_assembly_compilation_not_required"; //Field offset: 0x0
	[Token(Token = "0x4000088")]
	internal const string CompilerCommandEnableCompiler = "$enable_compiler"; //Field offset: 0x0
	[Token(Token = "0x4000096")]
	internal const string CompilerCommandIsArmTestEnv = "$is_arm_test_env"; //Field offset: 0x0
	[Token(Token = "0x4000094")]
	internal const string CompilerCommandIsNativeApiAvailable = "$is_native_api_available"; //Field offset: 0x0
	[Token(Token = "0x4000093")]
	internal const string CompilerCommandUnloadBurstNatives = "$unload_burst_natives"; //Field offset: 0x0
	[Token(Token = "0x4000092")]
	internal const string CompilerCommandSetProfileCallbacks = "$set_profile_callbacks"; //Field offset: 0x0
	[Token(Token = "0x4000091")]
	internal const string CompilerCommandGetTargetCpuFromHost = "$get_target_cpu_from_host"; //Field offset: 0x0
	[Token(Token = "0x4000090")]
	internal const string CompilerCommandVersionNotification = "$version"; //Field offset: 0x0
	[Token(Token = "0x400008F")]
	internal const string CompilerCommandDomainReload = "$domain_reload"; //Field offset: 0x0
	[Token(Token = "0x400008E")]
	internal const string CompilerCommandInitialize = "$initialize"; //Field offset: 0x0
	[Token(Token = "0x400008D")]
	internal const string CompilerCommandTriggerRecompilation = "$trigger_recompilation"; //Field offset: 0x0
	[Token(Token = "0x400008C")]
	internal const string CompilerCommandIsCurrentCompilationDone = "$is_current_compilation_done"; //Field offset: 0x0
	[Token(Token = "0x400008B")]
	internal const string CompilerCommandTriggerSetupRecompilation = "$trigger_setup_recompilation"; //Field offset: 0x0
	[Token(Token = "0x400008A")]
	internal const string CompilerCommandSetDefaultOptions = "$set_default_options"; //Field offset: 0x0
	[Token(Token = "0x4000095")]
	internal const string CompilerCommandILPPCompilation = "$ilpp_compilation"; //Field offset: 0x0
	[Token(Token = "0x400006B")]
	internal const string OptionIncludeRootAssemblyReferences = "include-root-assembly-references="; //Field offset: 0x0
	[Token(Token = "0x400006F")]
	internal const string OptionAotOutputPath = "output="; //Field offset: 0x0
	[Token(Token = "0x4000069")]
	internal const string OptionAotAssemblyFolder = "assembly-folder="; //Field offset: 0x0
	[Token(Token = "0x400004C")]
	internal const string OptionFormat = "format="; //Field offset: 0x0
	[Token(Token = "0x400004B")]
	internal const string OptionDump = "dump="; //Field offset: 0x0
	[Token(Token = "0x400006A")]
	internal const string OptionRootAssembly = "root-assembly="; //Field offset: 0x0
	[Token(Token = "0x4000049")]
	internal const string OptionDisableWarnings = "disable-warnings="; //Field offset: 0x0
	[Token(Token = "0x4000048")]
	internal const string OptionBranchProtection = "branch-protection="; //Field offset: 0x0
	[Token(Token = "0x4000047")]
	internal const string OptionFloatMode = "float-mode="; //Field offset: 0x0
	[Token(Token = "0x4000046")]
	internal const string OptionFloatPrecision = "float-precision="; //Field offset: 0x0
	[Token(Token = "0x4000045")]
	internal const string OptionOptForSize = "opt-for-size"; //Field offset: 0x0
	[Token(Token = "0x4000044")]
	internal const string OptionLogTimings = "log-timings"; //Field offset: 0x0
	[Token(Token = "0x4000043")]
	internal const string OptionOptLevel = "opt-level="; //Field offset: 0x0
	[Token(Token = "0x4000042")]
	internal const string OptionTarget = "target="; //Field offset: 0x0
	[Token(Token = "0x4000041")]
	internal const string OptionFastMath = "fastmath"; //Field offset: 0x0
	[Token(Token = "0x4000040")]
	internal const string OptionDisableOpt = "disable-opt"; //Field offset: 0x0
	[Token(Token = "0x400003F")]
	internal const string OptionDisableSafetyChecks = "disable-safety-checks"; //Field offset: 0x0
	[Token(Token = "0x400003E")]
	internal const string OptionGlobalSafetyChecksSetting = "global-safety-checks-setting="; //Field offset: 0x0
	[Token(Token = "0x400003D")]
	internal const string OptionBackend = "backend="; //Field offset: 0x0
	[Token(Token = "0x400003C")]
	internal const string OptionMinimumOSVersion = "minimum-os-version="; //Field offset: 0x0
	[Token(Token = "0x400003B")]
	internal const string OptionPlatform = "platform="; //Field offset: 0x0
	[Token(Token = "0x400003A")]
	internal const string OptionGroup = "group"; //Field offset: 0x0
	[Token(Token = "0x4000039")]
	internal const string OptionBurstcSwitch = "+burstc"; //Field offset: 0x0
	[Token(Token = "0x4000038")]
	internal const string BurstInitializeStaticsName = "burst.initialize.statics"; //Field offset: 0x0
	[Token(Token = "0x4000037")]
	internal const string BurstInitializeExternalsName = "burst.initialize.externals"; //Field offset: 0x0
	[Token(Token = "0x4000036")]
	internal const string BurstInitializeName = "burst.initialize"; //Field offset: 0x0
	[Token(Token = "0x4000035")]
	internal const string DefaultLibraryName = "lib_burst_generated"; //Field offset: 0x0
	[Token(Token = "0x4000034")]
	private const string ForceSynchronousCompilationArg = "--burst-force-sync-compilation"; //Field offset: 0x0
	[Token(Token = "0x400004D")]
	internal const string OptionDebugTrap = "debugtrap"; //Field offset: 0x0
	[Token(Token = "0x400004E")]
	internal const string OptionDisableVectors = "disable-vectors"; //Field offset: 0x0
	[Token(Token = "0x400004A")]
	internal const string OptionAssemblyDefines = "assembly-defines="; //Field offset: 0x0
	[Token(Token = "0x4000050")]
	internal const string OptionDebugMode = "debugMode"; //Field offset: 0x0
	[Token(Token = "0x4000068")]
	internal const string OptionEnableInterpreter = "enable-interpreter"; //Field offset: 0x0
	[Token(Token = "0x4000067")]
	internal const string OptionJitManagedDelegateHandle = "managed-delegate-handle="; //Field offset: 0x0
	[Token(Token = "0x4000066")]
	internal const string OptionJitManagedFunctionPointer = "managed-function-pointer="; //Field offset: 0x0
	[Token(Token = "0x4000065")]
	internal const string OptionJitIsForFunctionPointer = "is-for-function-pointer"; //Field offset: 0x0
	[Token(Token = "0x4000064")]
	internal const string OptionJitCompilationPriority = "compilation-priority="; //Field offset: 0x0
	[Token(Token = "0x4000063")]
	internal const string OptionJitEnableSynchronousCompilation = "enable-synchronous-compilation"; //Field offset: 0x0
	[Token(Token = "0x4000062")]
	internal const string OptionJitEnableAssemblyCachingLogs = "enable-assembly-caching-logs"; //Field offset: 0x0
	[Token(Token = "0x400004F")]
	internal const string OptionDebug = "debug="; //Field offset: 0x0
	[Token(Token = "0x4000060")]
	internal const string OptionJitDisableFunctionCaching = "disable-function-caching"; //Field offset: 0x0
	[Token(Token = "0x400005F")]
	internal const string OptionCacheDirectory = "cache-directory="; //Field offset: 0x0
	[Token(Token = "0x400005E")]
	internal const string OptionForceDisableFrameInfoRegistration = "force-disable-frame-info-registration"; //Field offset: 0x0
	[Token(Token = "0x400005D")]
	internal const string OptionStackProtectorBufferSize = "stack-protector-buffer-size="; //Field offset: 0x0
	[Token(Token = "0x4000061")]
	internal const string OptionJitDisableAssemblyCaching = "disable-assembly-caching"; //Field offset: 0x0
	[Token(Token = "0x400005B")]
	internal const string OptionPlatformConfiguration = "platform-configuration="; //Field offset: 0x0
	[Token(Token = "0x4000051")]
	internal const string OptionStaticLinkage = "generate-static-linkage-methods"; //Field offset: 0x0
	[Token(Token = "0x400005C")]
	internal const string OptionStackProtector = "stack-protector="; //Field offset: 0x0
	[Token(Token = "0x4000053")]
	internal const string OptionTempDirectory = "temp-folder="; //Field offset: 0x0
	[Token(Token = "0x4000054")]
	internal const string OptionEnableDirectExternalLinking = "enable-direct-external-linking"; //Field offset: 0x0
	[Token(Token = "0x4000055")]
	internal const string OptionLinkerOptions = "linker-options="; //Field offset: 0x0
	[Token(Token = "0x4000052")]
	internal const string OptionJobMarshalling = "generate-job-marshalling-methods"; //Field offset: 0x0
	[Token(Token = "0x4000057")]
	internal const string OptionEnableFrameInfoRegistration = "enable-frame-info-registration"; //Field offset: 0x0
	[Token(Token = "0x4000058")]
	internal const string OptionGenerateLinkXml = "generate-link-xml="; //Field offset: 0x0
	[Token(Token = "0x4000059")]
	internal const string OptionMetaDataGeneration = "meta-data-generation="; //Field offset: 0x0
	[Token(Token = "0x400005A")]
	internal const string OptionDisableStringInterpolationInExceptionMessages = "disable-string-interpolation-in-exception-messages"; //Field offset: 0x0
	[Token(Token = "0x4000056")]
	internal const string OptionEnableAutoLayoutFallbackCheck = "enable-autolayout-fallback-check"; //Field offset: 0x0
	[Token(Token = "0x40000A2")]
	private static readonly bool ForceBurstCompilationSynchronously; //Field offset: 0x1
	[Token(Token = "0x40000A3")]
	internal static readonly bool IsSecondaryUnityProcess; //Field offset: 0x2
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A4")]
	private bool _enableBurstCompilation; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40000A5")]
	private bool _enableBurstCompileSynchronously; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x40000A6")]
	private bool _enableBurstSafetyChecks; //Field offset: 0x12
	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x40000A7")]
	private bool _enableBurstTimings; //Field offset: 0x13
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000A8")]
	private bool _enableBurstDebug; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x40000A9")]
	private bool _forceEnableBurstSafetyChecks; //Field offset: 0x15
	[CompilerGenerated]
	[FieldOffset(Offset = "0x16")]
	[Token(Token = "0x40000AA")]
	private readonly bool <IsGlobal>k__BackingField; //Field offset: 0x16
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000AB")]
	private Action <OptionsChanged>k__BackingField; //Field offset: 0x18

	[Obsolete("This property is no longer used and will be removed in a future major release")]
	[Token(Token = "0x17000012")]
	public bool DisableOptimizations
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600006C")]
		 get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600006D")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700000D")]
	public bool EnableBurstCompilation
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000062")]
		 get { } //Length: 5
		[Address(RVA = "0x27BCC50", Offset = "0x27BC050", Length = "0xE8")]
		[Token(Token = "0x6000063")]
		 set { } //Length: 232
	}

	[Token(Token = "0x1700000E")]
	public bool EnableBurstCompileSynchronously
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[Token(Token = "0x6000064")]
		 get { } //Length: 5
		[Address(RVA = "0x27BCD40", Offset = "0x27BC140", Length = "0x24")]
		[Token(Token = "0x6000065")]
		 set { } //Length: 36
	}

	[Token(Token = "0x17000011")]
	public bool EnableBurstDebug
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x600006A")]
		 get { } //Length: 5
		[Address(RVA = "0x27BCD70", Offset = "0x27BC170", Length = "0x24")]
		[Token(Token = "0x600006B")]
		 set { } //Length: 36
	}

	[Token(Token = "0x1700000F")]
	public bool EnableBurstSafetyChecks
	{
		[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
		[Token(Token = "0x6000066")]
		 get { } //Length: 5
		[Address(RVA = "0x27BCDA0", Offset = "0x27BC1A0", Length = "0x24")]
		[Token(Token = "0x6000067")]
		 set { } //Length: 36
	}

	[Token(Token = "0x17000014")]
	internal bool EnableBurstTimings
	{
		[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
		[Token(Token = "0x6000070")]
		internal get { } //Length: 5
		[Address(RVA = "0x27BCDD0", Offset = "0x27BC1D0", Length = "0x24")]
		[Token(Token = "0x6000071")]
		internal set { } //Length: 36
	}

	[Obsolete("This property is no longer used and will be removed in a future major release. Use the [BurstCompile(FloatMode = FloatMode.Fast)] on the method directly to enable this feature")]
	[Token(Token = "0x17000013")]
	public bool EnableFastMath
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600006E")]
		 get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600006F")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000010")]
	public bool ForceEnableBurstSafetyChecks
	{
		[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
		[Token(Token = "0x6000068")]
		 get { } //Length: 5
		[Address(RVA = "0x27BCE00", Offset = "0x27BC200", Length = "0x24")]
		[Token(Token = "0x6000069")]
		 set { } //Length: 36
	}

	[Token(Token = "0x1700000C")]
	public bool IsEnabled
	{
		[Address(RVA = "0x27BCB60", Offset = "0x27BBF60", Length = "0x65")]
		[Token(Token = "0x6000061")]
		 get { } //Length: 101
	}

	[Token(Token = "0x1700000B")]
	private bool IsGlobal
	{
		[Address(RVA = "0x27BCBD0", Offset = "0x27BBFD0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000060")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000016")]
	internal Action OptionsChanged
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000073")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000074")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000015")]
	internal bool RequiresSynchronousCompilation
	{
		[Address(RVA = "0x27BCBE0", Offset = "0x27BBFE0", Length = "0x63")]
		[Token(Token = "0x6000072")]
		internal get { } //Length: 99
	}

	[Address(RVA = "0x27BC880", Offset = "0x27BBC80", Length = "0x15A")]
	[Token(Token = "0x6000081")]
	private static BurstCompilerOptions() { }

	[Address(RVA = "0x27BC9E0", Offset = "0x27BBDE0", Length = "0x11F")]
	[Token(Token = "0x600005E")]
	private BurstCompilerOptions() { }

	[Address(RVA = "0x27BCB00", Offset = "0x27BBF00", Length = "0x55")]
	[Token(Token = "0x600005F")]
	internal BurstCompilerOptions(bool isGlobal) { }

	[Address(RVA = "0x27BA200", Offset = "0x27B9600", Length = "0x4D")]
	[Token(Token = "0x600007D")]
	private static void AddOption(StringBuilder builder, string option) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000082")]
	private static bool CheckIsSecondaryUnityProcess() { }

	[Address(RVA = "0x27BA250", Offset = "0x27B9650", Length = "0x2F1")]
	[Token(Token = "0x6000075")]
	internal BurstCompilerOptions Clone() { }

	[Address(RVA = "0x27BA550", Offset = "0x27B9950", Length = "0xB6")]
	[Token(Token = "0x600005D")]
	internal static ValueTuple<String[], String[], String> DeserialiseCompilationOptionsSafe(string from) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600006C")]
	public bool get_DisableOptimizations() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000062")]
	public bool get_EnableBurstCompilation() { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[Token(Token = "0x6000064")]
	public bool get_EnableBurstCompileSynchronously() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[Token(Token = "0x600006A")]
	public bool get_EnableBurstDebug() { }

	[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
	[Token(Token = "0x6000066")]
	public bool get_EnableBurstSafetyChecks() { }

	[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
	[Token(Token = "0x6000070")]
	internal bool get_EnableBurstTimings() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600006E")]
	public bool get_EnableFastMath() { }

	[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
	[Token(Token = "0x6000068")]
	public bool get_ForceEnableBurstSafetyChecks() { }

	[Address(RVA = "0x27BCB60", Offset = "0x27BBF60", Length = "0x65")]
	[Token(Token = "0x6000061")]
	public bool get_IsEnabled() { }

	[Address(RVA = "0x27BCBD0", Offset = "0x27BBFD0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000060")]
	private bool get_IsGlobal() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000073")]
	internal Action get_OptionsChanged() { }

	[Address(RVA = "0x27BCBE0", Offset = "0x27BBFE0", Length = "0x63")]
	[Token(Token = "0x6000072")]
	internal bool get_RequiresSynchronousCompilation() { }

	[Address(RVA = "0x27BA610", Offset = "0x27B9A10", Length = "0x2A5")]
	[Token(Token = "0x6000078")]
	private static BurstCompileAttribute GetBurstCompileAttribute(MemberInfo memberInfo) { }

	[Address(RVA = "0x27BA8C0", Offset = "0x27B9CC0", Length = "0xDA")]
	[Token(Token = "0x600007E")]
	internal static string GetOption(string optionName, object value = null) { }

	[Address(RVA = "0x27BA9A0", Offset = "0x27B9DA0", Length = "0x16C2")]
	[Token(Token = "0x600007C")]
	internal string GetOptions(BurstCompileAttribute attr = null, bool isForILPostProcessing = false, bool isForCompilerClient = false, bool deterministicCompilation = false) { }

	[Address(RVA = "0x27BC070", Offset = "0x27BB470", Length = "0x12A")]
	[Token(Token = "0x6000079")]
	internal static bool HasBurstCompileAttribute(MemberInfo member) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000080")]
	private void MaybeTriggerRecompilation() { }

	[Address(RVA = "0x27BC1A0", Offset = "0x27BB5A0", Length = "0x155")]
	[Token(Token = "0x600007A")]
	internal static void MergeAttributes(ref BurstCompileAttribute memberAttribute, in BurstCompileAttribute assemblyAttribute) { }

	[Address(RVA = "0xE106E0", Offset = "0xE0FAE0", Length = "0x19")]
	[Token(Token = "0x600007F")]
	private void OnOptionsChanged() { }

	[Address(RVA = "0x27BC300", Offset = "0x27BB700", Length = "0xD1")]
	[Token(Token = "0x600005C")]
	internal static string SerialiseCompilationOptionsSafe(String[] roots, String[] folders, string options) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600006D")]
	public void set_DisableOptimizations(bool value) { }

	[Address(RVA = "0x27BCC50", Offset = "0x27BC050", Length = "0xE8")]
	[Token(Token = "0x6000063")]
	public void set_EnableBurstCompilation(bool value) { }

	[Address(RVA = "0x27BCD40", Offset = "0x27BC140", Length = "0x24")]
	[Token(Token = "0x6000065")]
	public void set_EnableBurstCompileSynchronously(bool value) { }

	[Address(RVA = "0x27BCD70", Offset = "0x27BC170", Length = "0x24")]
	[Token(Token = "0x600006B")]
	public void set_EnableBurstDebug(bool value) { }

	[Address(RVA = "0x27BCDA0", Offset = "0x27BC1A0", Length = "0x24")]
	[Token(Token = "0x6000067")]
	public void set_EnableBurstSafetyChecks(bool value) { }

	[Address(RVA = "0x27BCDD0", Offset = "0x27BC1D0", Length = "0x24")]
	[Token(Token = "0x6000071")]
	internal void set_EnableBurstTimings(bool value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600006F")]
	public void set_EnableFastMath(bool value) { }

	[Address(RVA = "0x27BCE00", Offset = "0x27BC200", Length = "0x24")]
	[Token(Token = "0x6000069")]
	public void set_ForceEnableBurstSafetyChecks(bool value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000074")]
	internal void set_OptionsChanged(Action value) { }

	[Address(RVA = "0x27BC480", Offset = "0x27BB880", Length = "0x8A")]
	[Token(Token = "0x6000077")]
	private static bool TryGetAttribute(Assembly assembly, out BurstCompileAttribute attribute) { }

	[Address(RVA = "0x27BC3E0", Offset = "0x27BB7E0", Length = "0x9B")]
	[Token(Token = "0x6000076")]
	private static bool TryGetAttribute(MemberInfo member, out BurstCompileAttribute attribute) { }

	[Address(RVA = "0x27BC510", Offset = "0x27BB910", Length = "0x369")]
	[Token(Token = "0x600007B")]
	internal bool TryGetOptions(MemberInfo member, out string flagsOut, bool isForILPostProcessing = false, bool isForCompilerClient = false, bool deterministicCompilation = false) { }

}

