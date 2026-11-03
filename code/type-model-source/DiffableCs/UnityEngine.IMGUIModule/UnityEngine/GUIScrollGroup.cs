namespace UnityEngine;

[Token(Token = "0x2000026")]
internal sealed class GUIScrollGroup : GUILayoutGroup
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000F2")]
	public float calcMinWidth; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40000F3")]
	public float calcMaxWidth; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000F4")]
	public float calcMinHeight; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40000F5")]
	public float calcMaxHeight; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000F6")]
	public float clientWidth; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40000F7")]
	public float clientHeight; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000F8")]
	public bool allowHorizontalScroll; //Field offset: 0xA8
	[FieldOffset(Offset = "0xA9")]
	[Token(Token = "0x40000F9")]
	public bool allowVerticalScroll; //Field offset: 0xA9
	[FieldOffset(Offset = "0xAA")]
	[Token(Token = "0x40000FA")]
	public bool needsHorizontalScrollbar; //Field offset: 0xAA
	[FieldOffset(Offset = "0xAB")]
	[Token(Token = "0x40000FB")]
	public bool needsVerticalScrollbar; //Field offset: 0xAB
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40000FC")]
	public GUIStyle horizontalScrollbar; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40000FD")]
	public GUIStyle verticalScrollbar; //Field offset: 0xB8

	[Address(RVA = "0x30E7E40", Offset = "0x30E7240", Length = "0x52")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001EB")]
	public GUIScrollGroup() { }

	[Address(RVA = "0x30E7670", Offset = "0x30E6A70", Length = "0x192")]
	[Token(Token = "0x60001EE")]
	public virtual void CalcHeight() { }

	[Address(RVA = "0x30E7810", Offset = "0x30E6C10", Length = "0x97")]
	[Token(Token = "0x60001EC")]
	public virtual void CalcWidth() { }

	[Address(RVA = "0x30E78B0", Offset = "0x30E6CB0", Length = "0x217")]
	[Token(Token = "0x60001ED")]
	public virtual void SetHorizontal(float x, float width) { }

	[Address(RVA = "0x30E7AD0", Offset = "0x30E6ED0", Length = "0x36F")]
	[Token(Token = "0x60001EF")]
	public virtual void SetVertical(float y, float height) { }

}

