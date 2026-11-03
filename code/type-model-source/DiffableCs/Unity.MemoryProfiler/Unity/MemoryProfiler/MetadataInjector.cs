namespace Unity.MemoryProfiler;

[Token(Token = "0x2000004")]
internal static class MetadataInjector
{
	[Token(Token = "0x4000006")]
	public static DefaultMetadataCollect DefaultCollector; //Field offset: 0x0
	[Token(Token = "0x4000007")]
	public static long CollectorCount; //Field offset: 0x8
	[Token(Token = "0x4000008")]
	public static byte DefaultCollectorInjected; //Field offset: 0x10

	[Address(RVA = "0x2B330E0", Offset = "0x2B324E0", Length = "0x1AE")]
	[Token(Token = "0x6000004")]
	private static void InitializeMetadataCollection() { }

	[Address(RVA = "0x2B33290", Offset = "0x2B32690", Length = "0x37A")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSplashScreen (3))]
	[Token(Token = "0x6000003")]
	private static void PlayerInitMetadata() { }

}

