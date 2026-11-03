namespace Mono.Net.Security;

[Token(Token = "0x2000060")]
internal static class MonoTlsProviderFactory
{
	[Token(Token = "0x4000114")]
	private static object locker; //Field offset: 0x0
	[Token(Token = "0x4000115")]
	private static bool initialized; //Field offset: 0x8
	[Token(Token = "0x4000116")]
	private static MobileTlsProvider defaultProvider; //Field offset: 0x10
	[Token(Token = "0x4000117")]
	private static Dictionary<String, Tuple`2<Guid, String>> providerRegistration; //Field offset: 0x18
	[Token(Token = "0x4000118")]
	private static Dictionary<Guid, MobileTlsProvider> providerCache; //Field offset: 0x20
	[Token(Token = "0x4000119")]
	internal static readonly Guid UnityTlsId; //Field offset: 0x28
	[Token(Token = "0x400011A")]
	internal static readonly Guid AppleTlsId; //Field offset: 0x38
	[Token(Token = "0x400011B")]
	internal static readonly Guid BtlsId; //Field offset: 0x48

	[Address(RVA = "0x22C9730", Offset = "0x22C8B30", Length = "0x131")]
	[Token(Token = "0x6000164")]
	private static MonoTlsProviderFactory() { }

	[Address(RVA = "0x22C8350", Offset = "0x22C7750", Length = "0x24B")]
	[Token(Token = "0x6000162")]
	private static MobileTlsProvider CreateDefaultProviderImpl() { }

	[Address(RVA = "0x22C86B0", Offset = "0x22C7AB0", Length = "0x40")]
	[Token(Token = "0x6000163")]
	internal static MobileTlsProvider GetProvider() { }

	[Address(RVA = "0x22C85A0", Offset = "0x22C79A0", Length = "0x106")]
	[Token(Token = "0x600015B")]
	internal static MobileTlsProvider GetProviderInternal() { }

	[Address(RVA = "0x22C86F0", Offset = "0x22C7AF0", Length = "0x3AB")]
	[Token(Token = "0x600015C")]
	internal static void InitializeInternal() { }

	[Address(RVA = "0x22C8AA0", Offset = "0x22C7EA0", Length = "0x396")]
	[Token(Token = "0x600015E")]
	private static void InitializeProviderRegistration() { }

	[Address(RVA = "0x1E5F020", Offset = "0x1E5E420", Length = "0x5")]
	[Token(Token = "0x6000161")]
	internal static bool IsBtlsSupported() { }

	[Address(RVA = "0x22C8E40", Offset = "0x22C8240", Length = "0x598")]
	[Token(Token = "0x600015D")]
	private static MobileTlsProvider LookupProvider(string name, bool throwOnError) { }

	[Address(RVA = "0x22C93E0", Offset = "0x22C87E0", Length = "0x205")]
	[Token(Token = "0x6000160")]
	private static void PopulateProviders() { }

	[Address(RVA = "0x22C95F0", Offset = "0x22C89F0", Length = "0x132")]
	[Token(Token = "0x600015F")]
	private static void PopulateUnityProviders() { }

}

