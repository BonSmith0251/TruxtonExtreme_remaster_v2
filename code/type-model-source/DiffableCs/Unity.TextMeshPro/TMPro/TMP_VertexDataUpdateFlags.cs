namespace TMPro;

[Token(Token = "0x2000020")]
public enum TMP_VertexDataUpdateFlags : int
{
	None = 0,
	Vertices = 1,
	Uv0 = 2,
	Uv2 = 4,
	Uv4 = 8,
	Colors32 = 16,
	All = 255,
}

