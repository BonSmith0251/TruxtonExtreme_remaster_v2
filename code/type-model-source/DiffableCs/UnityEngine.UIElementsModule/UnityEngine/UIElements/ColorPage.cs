namespace UnityEngine.UIElements;

[Token(Token = "0x20002D5")]
internal struct ColorPage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B82")]
	public bool isValid; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000B83")]
	public Color32 pageAndID; //Field offset: 0x4

	[Address(RVA = "0x33FD420", Offset = "0x33FC820", Length = "0x8D")]
	[Token(Token = "0x60013AB")]
	public static ColorPage Init(RenderTreeManager renderTreeManager, BMPAlloc alloc) { }

	[Address(RVA = "0x33FD4B0", Offset = "0x33FC8B0", Length = "0x1A")]
	[Token(Token = "0x60013AC")]
	public NativeColorPage ToNativeColorPage() { }

}

