namespace UnityEngine.TerrainUtils;

[Token(Token = "0x200000A")]
internal enum TerrainMapStatusCode : int
{
	OK = 0,
	Overlapping = 1,
	SizeMismatch = 4,
	EdgeAlignmentMismatch = 8,
}

