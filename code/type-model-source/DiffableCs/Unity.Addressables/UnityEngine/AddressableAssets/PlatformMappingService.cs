namespace UnityEngine.AddressableAssets;

[Token(Token = "0x2000040")]
public class PlatformMappingService
{
	[Token(Token = "0x40000D6")]
	internal static readonly Dictionary<RuntimePlatform, AddressablesPlatform> s_RuntimeTargetMapping; //Field offset: 0x0

	[Address(RVA = "0x27AFC50", Offset = "0x27AF050", Length = "0x21E")]
	[Token(Token = "0x60001B2")]
	private static PlatformMappingService() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001B1")]
	public PlatformMappingService() { }

	[Address(RVA = "0x27AF8C0", Offset = "0x27AECC0", Length = "0xCA")]
	[Token(Token = "0x60001AE")]
	internal static AddressablesPlatform GetAddressablesPlatformInternal(RuntimePlatform platform) { }

	[Address(RVA = "0x27AF990", Offset = "0x27AED90", Length = "0x135")]
	[Token(Token = "0x60001AF")]
	internal static string GetAddressablesPlatformPathInternal(RuntimePlatform platform) { }

	[Address(RVA = "0x27AFAD0", Offset = "0x27AEED0", Length = "0x172")]
	[Token(Token = "0x60001B0")]
	public static string GetPlatformPathSubFolder() { }

}

