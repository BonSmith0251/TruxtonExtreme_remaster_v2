namespace UnityEngine;

[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
[Token(Token = "0x200000D")]
public static class SubsystemManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000005")]
	private static Action beforeReloadSubsystems; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000006")]
	private static Action afterReloadSubsystems; //Field offset: 0x8
	[Token(Token = "0x4000007")]
	private static List<IntegratedSubsystem> s_IntegratedSubsystems; //Field offset: 0x10
	[Token(Token = "0x4000008")]
	private static List<SubsystemWithProvider> s_StandaloneSubsystems; //Field offset: 0x18
	[Token(Token = "0x4000009")]
	private static List<Subsystem> s_DeprecatedSubsystems; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400000A")]
	private static Action reloadSubsytemsStarted; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400000B")]
	private static Action reloadSubsytemsCompleted; //Field offset: 0x30

	[Address(RVA = "0x31676C0", Offset = "0x3166AC0", Length = "0x16F")]
	[Token(Token = "0x6000019")]
	private static SubsystemManager() { }

	[Address(RVA = "0x91DC50", Offset = "0x91D050", Length = "0x1AC")]
	[Token(Token = "0x600001C")]
	private static void AddSubsystemSubset(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo) { }

	[Address(RVA = "0x3166F70", Offset = "0x3166370", Length = "0x223")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000017")]
	private static void ClearSubsystems() { }

	[Address(RVA = "0x31671A0", Offset = "0x31665A0", Length = "0x168")]
	[Token(Token = "0x600001D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"})]
	internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr) { }

	[Address(RVA = "0x91E850", Offset = "0x91DC50", Length = "0x124")]
	[Token(Token = "0x600001A")]
	public static void GetSubsystemDescriptors(List<T> descriptors) { }

	[Address(RVA = "0x91EA60", Offset = "0x91DE60", Length = "0xE6")]
	[Token(Token = "0x600001B")]
	public static void GetSubsystems(List<T> subsystems) { }

	[Address(RVA = "0x3167310", Offset = "0x3166710", Length = "0x11E")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000016")]
	private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem) { }

	[Address(RVA = "0x3167430", Offset = "0x3166830", Length = "0xE9")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000015")]
	private static void ReloadSubsystemsCompleted() { }

	[Address(RVA = "0x3167520", Offset = "0x3166920", Length = "0xE7")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000014")]
	private static void ReloadSubsystemsStarted() { }

	[Address(RVA = "0x3167610", Offset = "0x3166A10", Length = "0x79")]
	[Token(Token = "0x600001E")]
	internal static bool RemoveStandaloneSubsystem(SubsystemWithProvider subsystem) { }

	[Address(RVA = "0x3167690", Offset = "0x3166A90", Length = "0x2A")]
	[Token(Token = "0x6000018")]
	private static void StaticConstructScriptingClassMap() { }

}

