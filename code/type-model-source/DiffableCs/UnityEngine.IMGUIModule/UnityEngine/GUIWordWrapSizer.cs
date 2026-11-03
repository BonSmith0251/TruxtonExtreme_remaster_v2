namespace UnityEngine;

[Token(Token = "0x2000024")]
internal sealed class GUIWordWrapSizer : GUILayoutEntry
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000DA")]
	private readonly GUIContent m_Content; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000DB")]
	private readonly float m_ForcedMinHeight; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40000DC")]
	private readonly float m_ForcedMaxHeight; //Field offset: 0x54

	[Address(RVA = "0x30F1810", Offset = "0x30F0C10", Length = "0x1C7")]
	[Token(Token = "0x60001D8")]
	public GUIWordWrapSizer(GUIStyle style, GUIContent content, GUILayoutOption[] options) { }

	[Address(RVA = "0x30F1590", Offset = "0x30F0990", Length = "0x149")]
	[Token(Token = "0x60001DA")]
	public virtual void CalcHeight() { }

	[Address(RVA = "0x30F16E0", Offset = "0x30F0AE0", Length = "0x12C")]
	[Token(Token = "0x60001D9")]
	public virtual void CalcWidth() { }

}

