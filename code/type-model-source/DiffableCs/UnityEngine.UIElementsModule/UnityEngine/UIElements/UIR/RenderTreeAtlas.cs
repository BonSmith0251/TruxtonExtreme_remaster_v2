namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005C7")]
internal static class RenderTreeAtlas
{
	[Token(Token = "0x20005C8")]
	internal struct AtlasBlock
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40014B6")]
		public int width; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40014B7")]
		public int height; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40014B8")]
		public RectInt rect; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40014B9")]
		public Rect uvRect; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40014BA")]
		public RenderTexture texture; //Field offset: 0x28

		[Address(RVA = "0x3302F20", Offset = "0x3302320", Length = "0x2D")]
		[Token(Token = "0x6002983")]
		public AtlasBlock(int w, int h, RectInt r, Rect uv) { }

	}


	[Address(RVA = "0x330A860", Offset = "0x3309C60", Length = "0x2B4")]
	[Token(Token = "0x6002982")]
	public static bool CreateTextureForAtlasBlock(ref AtlasBlock block, bool forceGammaRendering, out bool allocatedNewTexture) { }

	[Address(RVA = "0x330AB20", Offset = "0x3309F20", Length = "0x16D")]
	[Token(Token = "0x6002981")]
	public static bool ReserveSize(int width, int height, out AtlasBlock block) { }

}

