namespace UnityEngine.Rendering.Universal.UTess;

[Token(Token = "0x20000B4")]
internal struct TessLink
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000304")]
	internal NativeArray<Int32> roots; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000305")]
	internal NativeArray<Int32> ranks; //Field offset: 0x10

	[Address(RVA = "0x2D52DC0", Offset = "0x2D521C0", Length = "0xDD")]
	[Token(Token = "0x60003BC")]
	internal static TessLink CreateLink(int count, Allocator allocator) { }

	[Address(RVA = "0x2D52EA0", Offset = "0x2D522A0", Length = "0x4A")]
	[Token(Token = "0x60003BD")]
	internal static void DestroyLink(TessLink link) { }

	[Address(RVA = "0x2D52EF0", Offset = "0x2D522F0", Length = "0x5D")]
	[Token(Token = "0x60003BE")]
	internal int Find(int x) { }

	[Address(RVA = "0x2D52F50", Offset = "0x2D52350", Length = "0x112")]
	[Token(Token = "0x60003BF")]
	internal void Link(int x, int y) { }

}

