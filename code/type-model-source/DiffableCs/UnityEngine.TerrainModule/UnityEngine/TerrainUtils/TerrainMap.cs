namespace UnityEngine.TerrainUtils;

[Token(Token = "0x200000C")]
public class TerrainMap
{
	[CompilerGenerated]
	[Token(Token = "0x200000D")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002A")]
		public int groupID; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600003F")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x316BC30", Offset = "0x316B030", Length = "0xD8")]
		[Token(Token = "0x6000040")]
		internal bool <CreateFromPlacement>b__0(Terrain x) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000027")]
	private Vector3 m_patchSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000028")]
	private TerrainMapStatusCode m_errorCode; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000029")]
	private Dictionary<TerrainTileCoord, Terrain> m_terrainTiles; //Field offset: 0x20

	[Token(Token = "0x17000012")]
	public Dictionary<TerrainTileCoord, Terrain> terrainTiles
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000039")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x316A820", Offset = "0x3169C20", Length = "0x7E")]
	[Token(Token = "0x600003A")]
	public TerrainMap() { }

	[Address(RVA = "0x31690C0", Offset = "0x31684C0", Length = "0x33C")]
	[Token(Token = "0x600003B")]
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	[Address(RVA = "0x31697E0", Offset = "0x3168BE0", Length = "0x515")]
	[Token(Token = "0x6000037")]
	public static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter = null, bool fullValidation = true) { }

	[Address(RVA = "0x3169400", Offset = "0x3168800", Length = "0x3D7")]
	[Token(Token = "0x6000038")]
	public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter = null, bool fullValidation = true) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000039")]
	public Dictionary<TerrainTileCoord, Terrain> get_terrainTiles() { }

	[Address(RVA = "0x3169D00", Offset = "0x3169100", Length = "0x7D")]
	[Token(Token = "0x6000036")]
	public Terrain GetTerrain(int tileX, int tileZ) { }

	[Address(RVA = "0x3169D80", Offset = "0x3169180", Length = "0x10B")]
	[Token(Token = "0x600003C")]
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	[Address(RVA = "0x316A6D0", Offset = "0x3169AD0", Length = "0x149")]
	[Token(Token = "0x600003E")]
	private TerrainMapStatusCode Validate() { }

	[Address(RVA = "0x3169E90", Offset = "0x3169290", Length = "0x83C")]
	[Token(Token = "0x600003D")]
	private void ValidateTerrain(int tileX, int tileZ) { }

}

