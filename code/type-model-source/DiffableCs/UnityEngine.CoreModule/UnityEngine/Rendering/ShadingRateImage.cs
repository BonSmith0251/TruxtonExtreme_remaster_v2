namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/ShadingRateImage.h")]
[Token(Token = "0x2000390")]
public static class ShadingRateImage
{

	[Address(RVA = "0x30B70E0", Offset = "0x30B64E0", Length = "0x5E")]
	[FreeFunction("ShadingRateImage::GetAllocSizeInternal")]
	[Token(Token = "0x6001CB6")]
	internal static void GetAllocSizeInternal(int pixelWidth, int pixelHeight, out int tileWidth, out int tileHeight) { }

	[Address(RVA = "0x30B7140", Offset = "0x30B6540", Length = "0x6D")]
	[Token(Token = "0x6001CB7")]
	public static Vector2Int GetAllocTileSize(Vector2Int pixelSize) { }

	[Address(RVA = "0x30B71B0", Offset = "0x30B65B0", Length = "0x67")]
	[Token(Token = "0x6001CB8")]
	public static Vector2Int GetAllocTileSize(int pixelWidth, int pixelHeight) { }

}

