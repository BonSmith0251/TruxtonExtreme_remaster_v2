namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200003B")]
internal static class TerrainToMesh
{

	[Address(RVA = "0x2F60D00", Offset = "0x2F60100", Length = "0x1FE")]
	[Token(Token = "0x60000C1")]
	public static Mesh Convert(Terrain terrain) { }

	[Address(RVA = "0x2F60C00", Offset = "0x2F60000", Length = "0xFF")]
	[Token(Token = "0x60000C2")]
	public static Mesh Convert(int heightmapWidth, int heightmapHeight, Int16[] heightmapData, Vector3 heightmapScale, int holeWidth, int holeHeight, Byte[] holedata) { }

	[Address(RVA = "0x2F60A40", Offset = "0x2F5FE40", Length = "0x1BF")]
	[Token(Token = "0x60000BF")]
	public static AsyncTerrainToMeshRequest ConvertAsync(Terrain terrain) { }

	[Address(RVA = "0x2F606F0", Offset = "0x2F5FAF0", Length = "0x34C")]
	[Token(Token = "0x60000C0")]
	public static AsyncTerrainToMeshRequest ConvertAsync(int heightmapWidth, int heightmapHeight, Int16[] heightmapData, Vector3 heightmapScale, int holeWidth, int holeHeight, Byte[] holedata) { }

	[Address(RVA = "0x2F60F00", Offset = "0x2F60300", Length = "0x484")]
	[Token(Token = "0x60000BE")]
	private static AsyncTerrainToMeshRequest MakeAsyncTerrainToMeshRequest(int width, int height, Vector3 heightmapScale, Single[2] heightmap, Boolean[2] holes) { }

}

