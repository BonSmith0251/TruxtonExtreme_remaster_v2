namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
[Token(Token = "0x2000014")]
public sealed class GUISettings
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000079")]
	private bool m_DoubleClickSelectsWord; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[SerializeField]
	[Token(Token = "0x400007A")]
	private bool m_TripleClickSelectsLine; //Field offset: 0x11
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x400007B")]
	private Color m_CursorColor; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400007C")]
	private float m_CursorFlashSpeed; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400007D")]
	private Color m_SelectionColor; //Field offset: 0x28

	[Address(RVA = "0x30E7EA0", Offset = "0x30E72A0", Length = "0x2C")]
	[Token(Token = "0x60000CE")]
	public GUISettings() { }

}

