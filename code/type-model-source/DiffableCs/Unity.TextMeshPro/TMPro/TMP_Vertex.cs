namespace TMPro;

[Token(Token = "0x200002D")]
public struct TMP_Vertex
{
	[Token(Token = "0x400013A")]
	private static readonly TMP_Vertex k_Zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000136")]
	public Vector3 position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000137")]
	public Vector4 uv; //Field offset: 0xC
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000138")]
	public Vector2 uv2; //Field offset: 0x1C
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000139")]
	public Color32 color; //Field offset: 0x24

	[Token(Token = "0x17000039")]
	public static TMP_Vertex zero
	{
		[Address(RVA = "0x2EC3CB0", Offset = "0x2EC30B0", Length = "0x6C")]
		[Token(Token = "0x6000158")]
		 get { } //Length: 108
	}

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000159")]
	private static TMP_Vertex() { }

	[Address(RVA = "0x2EC3CB0", Offset = "0x2EC30B0", Length = "0x6C")]
	[Token(Token = "0x6000158")]
	public static TMP_Vertex get_zero() { }

}

