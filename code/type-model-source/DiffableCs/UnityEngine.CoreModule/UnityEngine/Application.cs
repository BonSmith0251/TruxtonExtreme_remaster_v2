namespace UnityEngine;

[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
[NativeHeader("Runtime/Application/ApplicationInfo.h")]
[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
[NativeHeader("Runtime/Network/NetworkUtility.h")]
[NativeHeader("Runtime/Utilities/URLUtility.h")]
[NativeHeader("Runtime/Utilities/Argv.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
[NativeHeader("Runtime/Misc/Player.h")]
[NativeHeader("Runtime/Application/AdsIdHandler.h")]
[NativeHeader("Runtime/Misc/BuildSettings.h")]
[NativeHeader("NativeKernel/Logging/LogSystem.h")]
[NativeHeader("Runtime/Input/TargetFrameRate.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[Token(Token = "0x2000094")]
public class Application
{
	[Token(Token = "0x2000097")]
	internal sealed class LogCallback : MulticastDelegate
	{

		[Address(RVA = "0x2FE30C0", Offset = "0x2FE24C0", Length = "0xB5")]
		[Token(Token = "0x60002AE")]
		public LogCallback(object object, IntPtr method) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x60002AF")]
		public override void Invoke(string condition, string stackTrace, LogType type) { }

	}

	[Token(Token = "0x2000095")]
	internal sealed class LowMemoryCallback : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x60002AA")]
		public LowMemoryCallback(object object, IntPtr method) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x60002AB")]
		public override void Invoke() { }

	}

	[Token(Token = "0x2000096")]
	internal sealed class MemoryUsageChangedCallback : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x60002AC")]
		public MemoryUsageChangedCallback(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x60002AD")]
		public override void Invoke(in ApplicationMemoryUsageChange usage) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000152")]
	private static LowMemoryCallback lowMemory; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000153")]
	private static MemoryUsageChangedCallback memoryUsageChanged; //Field offset: 0x8
	[Token(Token = "0x4000154")]
	private static LogCallback s_LogCallbackHandler; //Field offset: 0x10
	[Token(Token = "0x4000155")]
	private static LogCallback s_LogCallbackHandlerThreaded; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000156")]
	private static Action<Boolean> focusChanged; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000157")]
	private static Action<String> deepLinkActivated; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000158")]
	private static Func<Boolean> wantsToQuit; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000159")]
	private static Action quitting; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400015A")]
	private static Action unloading; //Field offset: 0x40
	[Token(Token = "0x400015B")]
	private static CancellationTokenSource s_currentCancellationTokenSource; //Field offset: 0x48

	[Token(Token = "0x14000002")]
	public static event Action<Boolean> focusChanged
	{
		[Address(RVA = "0x2FCD760", Offset = "0x2FCCB60", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6000295")]
		 add { } //Length: 261
		[Address(RVA = "0x2FCE280", Offset = "0x2FCD680", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6000296")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x14000003")]
	public static event Action quitting
	{
		[Address(RVA = "0x2FCD870", Offset = "0x2FCCC70", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x6000297")]
		 add { } //Length: 242
		[Address(RVA = "0x2FCE390", Offset = "0x2FCD790", Length = "0xF2")]
		[CompilerGenerated]
		[Token(Token = "0x6000298")]
		 remove { } //Length: 242
	}

	[Token(Token = "0x17000059")]
	public static string dataPath
	{
		[Address(RVA = "0x2FCD9B0", Offset = "0x2FCCDB0", Length = "0xDE")]
		[FreeFunction("GetAppDataPath", IsThreadSafe = True)]
		[Token(Token = "0x6000284")]
		 get { } //Length: 222
	}

	[Token(Token = "0x17000058")]
	public static bool isBatchMode
	{
		[Address(RVA = "0x2FCDA90", Offset = "0x2FCCE90", Length = "0x2A")]
		[FreeFunction("::IsBatchmode")]
		[Token(Token = "0x6000283")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000065")]
	public static bool isEditor
	{
		[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
		[Token(Token = "0x60002A1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000056")]
	public static bool isFocused
	{
		[Address(RVA = "0x2FCDAC0", Offset = "0x2FCCEC0", Length = "0x2A")]
		[FreeFunction("IsPlayerFocused")]
		[Token(Token = "0x6000281")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000063")]
	public static bool isMobilePlatform
	{
		[Address(RVA = "0x2FCDAF0", Offset = "0x2FCCEF0", Length = "0x92")]
		[Token(Token = "0x6000290")]
		 get { } //Length: 146
	}

	[Token(Token = "0x17000055")]
	public static bool isPlaying
	{
		[Address(RVA = "0x2FCDB90", Offset = "0x2FCCF90", Length = "0x2A")]
		[FreeFunction("IsWorldPlaying")]
		[Token(Token = "0x6000280")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700005B")]
	public static string persistentDataPath
	{
		[Address(RVA = "0x2FCDC00", Offset = "0x2FCD000", Length = "0xDE")]
		[FreeFunction("GetPersistentDataPathApplicationSpecific")]
		[Token(Token = "0x6000286")]
		 get { } //Length: 222
	}

	[Token(Token = "0x17000062")]
	public static RuntimePlatform platform
	{
		[Address(RVA = "0x2FCDCE0", Offset = "0x2FCD0E0", Length = "0x2A")]
		[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
		[Token(Token = "0x600028F")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000060")]
	public static string productName
	{
		[Address(RVA = "0x2FCDD50", Offset = "0x2FCD150", Length = "0xDE")]
		[FreeFunction("GetPlayerSettings().GetProductName")]
		[Token(Token = "0x600028B")]
		 get { } //Length: 222
	}

	[Token(Token = "0x17000057")]
	public static bool runInBackground
	{
		[Address(RVA = "0x2FCDE30", Offset = "0x2FCD230", Length = "0x2A")]
		[FreeFunction("GetPlayerSettingsRunInBackground")]
		[Token(Token = "0x6000282")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700005A")]
	public static string streamingAssetsPath
	{
		[Address(RVA = "0x2FCDEA0", Offset = "0x2FCD2A0", Length = "0xDE")]
		[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
		[Token(Token = "0x6000285")]
		 get { } //Length: 222
	}

	[Token(Token = "0x17000064")]
	public static SystemLanguage systemLanguage
	{
		[Address(RVA = "0x2FCDF80", Offset = "0x2FCD380", Length = "0x2A")]
		[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
		[Token(Token = "0x6000291")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000061")]
	public static int targetFrameRate
	{
		[Address(RVA = "0x2FCDFB0", Offset = "0x2FCD3B0", Length = "0x2A")]
		[FreeFunction("GetTargetFrameRate")]
		[Token(Token = "0x600028D")]
		 get { } //Length: 42
		[Address(RVA = "0x2FCE490", Offset = "0x2FCD890", Length = "0x31")]
		[FreeFunction("SetTargetFrameRate")]
		[Token(Token = "0x600028E")]
		 set { } //Length: 49
	}

	[Token(Token = "0x1700005C")]
	public static string unityVersion
	{
		[Address(RVA = "0x2FCE080", Offset = "0x2FCD480", Length = "0xDE")]
		[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = True)]
		[Token(Token = "0x6000287")]
		 get { } //Length: 222
	}

	[Token(Token = "0x1700005E")]
	internal static int unityVersionMaj
	{
		[Address(RVA = "0x2FCDFE0", Offset = "0x2FCD3E0", Length = "0x2A")]
		[FreeFunction("Application_Bindings::GetUnityVersionMaj", IsThreadSafe = True)]
		[Token(Token = "0x6000289")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 42
	}

	[Token(Token = "0x1700005D")]
	internal static int unityVersionVer
	{
		[Address(RVA = "0x2FCE010", Offset = "0x2FCD410", Length = "0x2A")]
		[FreeFunction("Application_Bindings::GetUnityVersionVer", IsThreadSafe = True)]
		[Token(Token = "0x6000288")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 42
	}

	[Token(Token = "0x1700005F")]
	public static string version
	{
		[Address(RVA = "0x2FCE1A0", Offset = "0x2FCD5A0", Length = "0xDE")]
		[FreeFunction("GetApplicationInfo().GetVersion")]
		[Token(Token = "0x600028A")]
		 get { } //Length: 222
	}

	[Address(RVA = "0x2FCD6E0", Offset = "0x2FCCAE0", Length = "0x78")]
	[Token(Token = "0x60002A2")]
	private static Application() { }

	[Address(RVA = "0x2FCD760", Offset = "0x2FCCB60", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6000295")]
	public static void add_focusChanged(Action<Boolean> value) { }

	[Address(RVA = "0x2FCD870", Offset = "0x2FCCC70", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x6000297")]
	public static void add_quitting(Action value) { }

	[Address(RVA = "0x2FCCC10", Offset = "0x2FCC010", Length = "0xE8")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000294")]
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[Address(RVA = "0x2FCCD00", Offset = "0x2FCC100", Length = "0x13B")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000292")]
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	[Address(RVA = "0x2FCD9B0", Offset = "0x2FCCDB0", Length = "0xDE")]
	[FreeFunction("GetAppDataPath", IsThreadSafe = True)]
	[Token(Token = "0x6000284")]
	public static string get_dataPath() { }

	[Address(RVA = "0x2FCD970", Offset = "0x2FCCD70", Length = "0x33")]
	[Token(Token = "0x60002A3")]
	private static void get_dataPath_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FCDA90", Offset = "0x2FCCE90", Length = "0x2A")]
	[FreeFunction("::IsBatchmode")]
	[Token(Token = "0x6000283")]
	public static bool get_isBatchMode() { }

	[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
	[Token(Token = "0x60002A1")]
	public static bool get_isEditor() { }

	[Address(RVA = "0x2FCDAC0", Offset = "0x2FCCEC0", Length = "0x2A")]
	[FreeFunction("IsPlayerFocused")]
	[Token(Token = "0x6000281")]
	public static bool get_isFocused() { }

	[Address(RVA = "0x2FCDAF0", Offset = "0x2FCCEF0", Length = "0x92")]
	[Token(Token = "0x6000290")]
	public static bool get_isMobilePlatform() { }

	[Address(RVA = "0x2FCDB90", Offset = "0x2FCCF90", Length = "0x2A")]
	[FreeFunction("IsWorldPlaying")]
	[Token(Token = "0x6000280")]
	public static bool get_isPlaying() { }

	[Address(RVA = "0x2FCDC00", Offset = "0x2FCD000", Length = "0xDE")]
	[FreeFunction("GetPersistentDataPathApplicationSpecific")]
	[Token(Token = "0x6000286")]
	public static string get_persistentDataPath() { }

	[Address(RVA = "0x2FCDBC0", Offset = "0x2FCCFC0", Length = "0x33")]
	[Token(Token = "0x60002A5")]
	private static void get_persistentDataPath_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FCDCE0", Offset = "0x2FCD0E0", Length = "0x2A")]
	[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
	[Token(Token = "0x600028F")]
	public static RuntimePlatform get_platform() { }

	[Address(RVA = "0x2FCDD50", Offset = "0x2FCD150", Length = "0xDE")]
	[FreeFunction("GetPlayerSettings().GetProductName")]
	[Token(Token = "0x600028B")]
	public static string get_productName() { }

	[Address(RVA = "0x2FCDD10", Offset = "0x2FCD110", Length = "0x33")]
	[Token(Token = "0x60002A8")]
	private static void get_productName_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FCDE30", Offset = "0x2FCD230", Length = "0x2A")]
	[FreeFunction("GetPlayerSettingsRunInBackground")]
	[Token(Token = "0x6000282")]
	public static bool get_runInBackground() { }

	[Address(RVA = "0x2FCDEA0", Offset = "0x2FCD2A0", Length = "0xDE")]
	[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
	[Token(Token = "0x6000285")]
	public static string get_streamingAssetsPath() { }

	[Address(RVA = "0x2FCDE60", Offset = "0x2FCD260", Length = "0x33")]
	[Token(Token = "0x60002A4")]
	private static void get_streamingAssetsPath_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FCDF80", Offset = "0x2FCD380", Length = "0x2A")]
	[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
	[Token(Token = "0x6000291")]
	public static SystemLanguage get_systemLanguage() { }

	[Address(RVA = "0x2FCDFB0", Offset = "0x2FCD3B0", Length = "0x2A")]
	[FreeFunction("GetTargetFrameRate")]
	[Token(Token = "0x600028D")]
	public static int get_targetFrameRate() { }

	[Address(RVA = "0x2FCE080", Offset = "0x2FCD480", Length = "0xDE")]
	[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = True)]
	[Token(Token = "0x6000287")]
	public static string get_unityVersion() { }

	[Address(RVA = "0x2FCE040", Offset = "0x2FCD440", Length = "0x33")]
	[Token(Token = "0x60002A6")]
	private static void get_unityVersion_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FCDFE0", Offset = "0x2FCD3E0", Length = "0x2A")]
	[FreeFunction("Application_Bindings::GetUnityVersionMaj", IsThreadSafe = True)]
	[Token(Token = "0x6000289")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static int get_unityVersionMaj() { }

	[Address(RVA = "0x2FCE010", Offset = "0x2FCD410", Length = "0x2A")]
	[FreeFunction("Application_Bindings::GetUnityVersionVer", IsThreadSafe = True)]
	[Token(Token = "0x6000288")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static int get_unityVersionVer() { }

	[Address(RVA = "0x2FCE1A0", Offset = "0x2FCD5A0", Length = "0xDE")]
	[FreeFunction("GetApplicationInfo().GetVersion")]
	[Token(Token = "0x600028A")]
	public static string get_version() { }

	[Address(RVA = "0x2FCE160", Offset = "0x2FCD560", Length = "0x33")]
	[Token(Token = "0x60002A7")]
	private static void get_version_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FCCE40", Offset = "0x2FCC240", Length = "0x7E")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000293")]
	internal static bool HasLogCallback() { }

	[Address(RVA = "0x2FCCEC0", Offset = "0x2FCC2C0", Length = "0x8C")]
	[RequiredByNativeCode]
	[Token(Token = "0x600029C")]
	private static void Internal_ApplicationQuit() { }

	[Address(RVA = "0x2FCCF50", Offset = "0x2FCC350", Length = "0x8C")]
	[RequiredByNativeCode]
	[Token(Token = "0x600029D")]
	private static void Internal_ApplicationUnload() { }

	[Address(RVA = "0x2FCCFE0", Offset = "0x2FCC3E0", Length = "0x197")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000299")]
	private static bool Internal_ApplicationWantsToQuit() { }

	[Address(RVA = "0x2FCD180", Offset = "0x2FCC580", Length = "0xFD")]
	[RequiredByNativeCode]
	[Token(Token = "0x600029A")]
	private static void Internal_InitializeExitCancellationToken() { }

	[Address(RVA = "0x2FCD280", Offset = "0x2FCC680", Length = "0x5F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600029B")]
	private static void Internal_RaiseExitCancellationToken() { }

	[Address(RVA = "0x2FCD2E0", Offset = "0x2FCC6E0", Length = "0x96")]
	[RequiredByNativeCode]
	[Token(Token = "0x60002A0")]
	internal static void InvokeDeepLinkActivated(string url) { }

	[Address(RVA = "0x2FCD380", Offset = "0x2FCC780", Length = "0x96")]
	[RequiredByNativeCode]
	[Token(Token = "0x600029F")]
	internal static void InvokeFocusChanged(bool focus) { }

	[Address(RVA = "0x2FCD420", Offset = "0x2FCC820", Length = "0x40")]
	[RequiredByNativeCode]
	[Token(Token = "0x600029E")]
	internal static void InvokeOnBeforeRender() { }

	[Address(RVA = "0x2FCD4A0", Offset = "0x2FCC8A0", Length = "0x199")]
	[FreeFunction("OpenURL")]
	[Token(Token = "0x600028C")]
	public static void OpenURL(string url) { }

	[Address(RVA = "0x2FCD460", Offset = "0x2FCC860", Length = "0x33")]
	[Token(Token = "0x60002A9")]
	private static void OpenURL_Injected(ref ManagedSpanWrapper url) { }

	[Address(RVA = "0x2FCD680", Offset = "0x2FCCA80", Length = "0x5D")]
	[Token(Token = "0x600027F")]
	public static void Quit() { }

	[Address(RVA = "0x2FCD640", Offset = "0x2FCCA40", Length = "0x31")]
	[FreeFunction("GetInputManager().QuitApplication")]
	[Token(Token = "0x600027E")]
	public static void Quit(int exitCode) { }

	[Address(RVA = "0x2FCE280", Offset = "0x2FCD680", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6000296")]
	public static void remove_focusChanged(Action<Boolean> value) { }

	[Address(RVA = "0x2FCE390", Offset = "0x2FCD790", Length = "0xF2")]
	[CompilerGenerated]
	[Token(Token = "0x6000298")]
	public static void remove_quitting(Action value) { }

	[Address(RVA = "0x2FCE490", Offset = "0x2FCD890", Length = "0x31")]
	[FreeFunction("SetTargetFrameRate")]
	[Token(Token = "0x600028E")]
	public static void set_targetFrameRate(int value) { }

}

