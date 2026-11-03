namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/ShadingRateInfo.h")]
[Token(Token = "0x2000391")]
public static class ShadingRateInfo
{

	[Token(Token = "0x170003EB")]
	public static ShadingRateFragmentSize[] availableFragmentSizes
	{
		[Address(RVA = "0x30B7440", Offset = "0x30B6840", Length = "0x7")]
		[Token(Token = "0x6001CBC")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170003EA")]
	public static Vector2Int imageTileSize
	{
		[Address(RVA = "0x30B7360", Offset = "0x30B6760", Length = "0x3D")]
		[Token(Token = "0x6001CBB")]
		 get { } //Length: 61
	}

	[Token(Token = "0x170003E9")]
	public static bool supportsPerDrawCall
	{
		[Address(RVA = "0x30B73E0", Offset = "0x30B67E0", Length = "0x2A")]
		[Token(Token = "0x6001CBA")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003E8")]
	public static bool supportsPerImageTile
	{
		[Address(RVA = "0x30B7410", Offset = "0x30B6810", Length = "0x2A")]
		[Token(Token = "0x6001CB9")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x30B7440", Offset = "0x30B6840", Length = "0x7")]
	[Token(Token = "0x6001CBC")]
	public static ShadingRateFragmentSize[] get_availableFragmentSizes() { }

	[Address(RVA = "0x30B7360", Offset = "0x30B6760", Length = "0x3D")]
	[Token(Token = "0x6001CBB")]
	public static Vector2Int get_imageTileSize() { }

	[Address(RVA = "0x30B73E0", Offset = "0x30B67E0", Length = "0x2A")]
	[Token(Token = "0x6001CBA")]
	public static bool get_supportsPerDrawCall() { }

	[Address(RVA = "0x30B7410", Offset = "0x30B6810", Length = "0x2A")]
	[Token(Token = "0x6001CB9")]
	public static bool get_supportsPerImageTile() { }

	[Address(RVA = "0x30B7260", Offset = "0x30B6660", Length = "0xB3")]
	[FreeFunction("ShadingRateInfo::GetAvailableFragmentSizes")]
	[Token(Token = "0x6001CC1")]
	private static ShadingRateFragmentSize[] GetAvailableFragmentSizes() { }

	[Address(RVA = "0x30B7220", Offset = "0x30B6620", Length = "0x33")]
	[Token(Token = "0x6001CC3")]
	private static void GetAvailableFragmentSizes_Injected(out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x30B7360", Offset = "0x30B6760", Length = "0x3D")]
	[FreeFunction("ShadingRateInfo::GetImageTileSize")]
	[Token(Token = "0x6001CC0")]
	private static Vector2Int GetImageTileSize() { }

	[Address(RVA = "0x30B7320", Offset = "0x30B6720", Length = "0x33")]
	[Token(Token = "0x6001CC2")]
	private static void GetImageTileSize_Injected(out Vector2Int ret) { }

	[Address(RVA = "0x30B73A0", Offset = "0x30B67A0", Length = "0x31")]
	[FreeFunction("ShadingRateInfo::QueryNativeValue")]
	[Token(Token = "0x6001CBD")]
	public static byte QueryNativeValue(ShadingRateFragmentSize fragmentSize) { }

	[Address(RVA = "0x30B73E0", Offset = "0x30B67E0", Length = "0x2A")]
	[FreeFunction("ShadingRateInfo::SupportsPerDrawCall")]
	[Token(Token = "0x6001CBF")]
	private static bool SupportsPerDrawCall() { }

	[Address(RVA = "0x30B7410", Offset = "0x30B6810", Length = "0x2A")]
	[FreeFunction("ShadingRateInfo::SupportsPerImageTile")]
	[Token(Token = "0x6001CBE")]
	private static bool SupportsPerImageTile() { }

}

