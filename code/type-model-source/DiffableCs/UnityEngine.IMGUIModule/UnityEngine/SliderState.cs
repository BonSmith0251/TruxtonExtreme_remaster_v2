namespace UnityEngine;

[Token(Token = "0x200002B")]
internal class SliderState
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000101")]
	public float dragStartPos; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000102")]
	public float dragStartValue; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000103")]
	public bool isDragging; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001FC")]
	public SliderState() { }

}

