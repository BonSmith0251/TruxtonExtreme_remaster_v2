namespace UnityEngine.SubsystemsImplementation;

[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
[Token(Token = "0x200000E")]
public static class SubsystemDescriptorStore
{
	[Token(Token = "0x400000C")]
	private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors; //Field offset: 0x0
	[Token(Token = "0x400000D")]
	private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors; //Field offset: 0x8
	[Token(Token = "0x400000E")]
	private static List<SubsystemDescriptor> s_DeprecatedDescriptors; //Field offset: 0x10

	[Address(RVA = "0x3166E20", Offset = "0x3166220", Length = "0x148")]
	[Token(Token = "0x6000027")]
	private static SubsystemDescriptorStore() { }

	[Address(RVA = "0x91DC50", Offset = "0x91D050", Length = "0x1AC")]
	[Token(Token = "0x6000024")]
	private static void AddDescriptorSubset(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo) { }

	[Address(RVA = "0x31668B0", Offset = "0x3165CB0", Length = "0x19E")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000020")]
	internal static void ClearManagedDescriptors() { }

	[Address(RVA = "0x91DEE0", Offset = "0x91D2E0", Length = "0xE5")]
	[Token(Token = "0x6000023")]
	internal static void GetSubsystemDescriptors(List<T> descriptors) { }

	[Address(RVA = "0x3166A50", Offset = "0x3165E50", Length = "0xE7")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001F")]
	internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc) { }

	[Address(RVA = "0x3166B40", Offset = "0x3165F40", Length = "0x6F")]
	[Token(Token = "0x6000026")]
	internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor) { }

	[Address(RVA = "0x3166BB0", Offset = "0x3165FB0", Length = "0x8F")]
	[Token(Token = "0x6000022")]
	public static void RegisterDescriptor(SubsystemDescriptorWithProvider descriptor) { }

	[Address(RVA = "0x91E5B0", Offset = "0x91D9B0", Length = "0x22D")]
	[Token(Token = "0x6000025")]
	internal static void RegisterDescriptor(TDescriptor descriptor, List<TBaseTypeInList> storeInList) { }

	[Address(RVA = "0x3166C80", Offset = "0x3166080", Length = "0x199")]
	[Token(Token = "0x6000021")]
	private static void ReportSingleSubsystemAnalytics(string id) { }

	[Address(RVA = "0x3166C40", Offset = "0x3166040", Length = "0x33")]
	[Token(Token = "0x6000028")]
	private static void ReportSingleSubsystemAnalytics_Injected(ref ManagedSpanWrapper id) { }

}

