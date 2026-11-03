namespace UnityEngine.TerrainUtils;

[IsReadOnly]
[Token(Token = "0x200000B")]
public struct TerrainTileCoord
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000025")]
	public readonly int tileX; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000026")]
	public readonly int tileZ; //Field offset: 0x4

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x6000035")]
	public TerrainTileCoord(int tileX, int tileZ) { }

}

