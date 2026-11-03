namespace UnityEngine.AdaptivePerformance.Provider;

[Token(Token = "0x2000057")]
internal static class AdaptivePerformanceSubsystemRegistry
{

	[Address(RVA = "0x2F9A3C0", Offset = "0x2F997C0", Length = "0x91")]
	[Token(Token = "0x6000281")]
	public static List<AdaptivePerformanceSubsystemDescriptor> GetRegisteredDescriptors() { }

	[Address(RVA = "0x2F9A460", Offset = "0x2F99860", Length = "0xCE")]
	[Token(Token = "0x6000280")]
	public static AdaptivePerformanceSubsystemDescriptor RegisterDescriptor(Cinfo cinfo) { }

}

