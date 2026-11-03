namespace UnityEngine.Rendering;

[Token(Token = "0x20001EE")]
public static class TileLayoutUtils
{

	[Address(RVA = "0x2C67A00", Offset = "0x2C66E00", Length = "0xD3")]
	[Token(Token = "0x6000EB6")]
	public static bool TryLayoutByCol(RectInt src, uint tileSize, out RectInt main, out RectInt other) { }

	[Address(RVA = "0x2C67AE0", Offset = "0x2C66EE0", Length = "0xD4")]
	[Token(Token = "0x6000EB5")]
	public static bool TryLayoutByRow(RectInt src, uint tileSize, out RectInt main, out RectInt other) { }

	[Address(RVA = "0x2C67BC0", Offset = "0x2C66FC0", Length = "0x168")]
	[Token(Token = "0x6000EB4")]
	public static bool TryLayoutByTiles(RectInt src, uint tileSize, out RectInt main, out RectInt topRow, out RectInt rightCol, out RectInt topRight) { }

}

