namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000005")]
internal static class AdaptivePerformanceInitializer
{
	[Token(Token = "0x4000001")]
	private static AdaptivePerformanceManagerSpawner s_Spawner; //Field offset: 0x0

	[Address(RVA = "0x2F8B230", Offset = "0x2F8A630", Length = "0x14B")]
	[RequiredByNativeCode(False)]
	[Token(Token = "0x6000005")]
	public static void AutoInitializeAdaptivePerformanceManaged() { }

	[Address(RVA = "0x2F8B380", Offset = "0x2F8A780", Length = "0x154")]
	[Token(Token = "0x6000006")]
	private static void InitializeSpawner(bool isAuto) { }

}

