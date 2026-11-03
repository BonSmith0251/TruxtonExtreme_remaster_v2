namespace UnityEngine.Tilemaps;

[RequiredByNativeCode]
[Token(Token = "0x2000002")]
public class ITilemap
{
	[Token(Token = "0x4000001")]
	internal static ITilemap s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000002")]
	internal Tilemap m_Tilemap; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000003")]
	internal bool m_AddToList; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000004")]
	internal int m_RefreshCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000005")]
	internal NativeArray<Vector3Int> m_RefreshPos; //Field offset: 0x20

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000001")]
	internal ITilemap() { }

	[Address(RVA = "0x31CF330", Offset = "0x31CE730", Length = "0x79")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000003")]
	private static ITilemap CreateInstance() { }

	[Address(RVA = "0x31CF3B0", Offset = "0x31CE7B0", Length = "0x3DF")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000004")]
	private static void FindAllRefreshPositions(ITilemap tilemap, int count, IntPtr oldTilesIntPtr, IntPtr newTilesIntPtr, IntPtr positionsIntPtr) { }

	[Address(RVA = "0x31CF790", Offset = "0x31CEB90", Length = "0x272")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000005")]
	private static void GetAllTileData(ITilemap tilemap, int count, IntPtr tilesIntPtr, IntPtr positionsIntPtr, IntPtr outTileDataIntPtr) { }

	[Address(RVA = "0x31CFA10", Offset = "0x31CEE10", Length = "0x1C6")]
	[Token(Token = "0x6000002")]
	public void RefreshTile(Vector3Int position) { }

}

