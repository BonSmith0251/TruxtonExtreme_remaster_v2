namespace System.Resources;

[Token(Token = "0x20004C0")]
internal class ManifestBasedResourceGroveler : IResourceGroveler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012BE")]
	private ResourceManagerMediator _mediator; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60021BE")]
	public ManifestBasedResourceGroveler(ResourceManagerMediator mediator) { }

	[Address(RVA = "0x1F36840", Offset = "0x1F35C40", Length = "0x2F2")]
	[Token(Token = "0x60021BF")]
	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation) { }

	[Address(RVA = "0x1F367B0", Offset = "0x1F35BB0", Length = "0x83")]
	[Token(Token = "0x60021C0")]
	private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation) { }

}

