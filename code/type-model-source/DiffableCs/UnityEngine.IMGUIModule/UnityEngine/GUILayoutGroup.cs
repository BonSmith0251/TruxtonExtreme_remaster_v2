namespace UnityEngine;

[Token(Token = "0x2000025")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.CoreModule"})]
internal class GUILayoutGroup : GUILayoutEntry
{
	[Token(Token = "0x40000F1")]
	private static readonly GUILayoutEntry none; //Field offset: 0x0
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000DD")]
	public List<GUILayoutEntry> entries; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000DE")]
	public bool isVertical; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x40000DF")]
	public bool resetCoords; //Field offset: 0x51
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40000E0")]
	public float spacing; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000E1")]
	public bool sameSize; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x40000E2")]
	public bool isWindow; //Field offset: 0x59
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40000E3")]
	public int windowID; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000E4")]
	private int m_Cursor; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40000E5")]
	protected int m_StretchableCountX; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000E6")]
	protected int m_StretchableCountY; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40000E7")]
	protected bool m_UserSpecifiedWidth; //Field offset: 0x6C
	[FieldOffset(Offset = "0x6D")]
	[Token(Token = "0x40000E8")]
	protected bool m_UserSpecifiedHeight; //Field offset: 0x6D
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000E9")]
	protected float m_ChildMinWidth; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40000EA")]
	protected float m_ChildMaxWidth; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000EB")]
	protected float m_ChildMinHeight; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40000EC")]
	protected float m_ChildMaxHeight; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000ED")]
	protected int m_MarginLeft; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40000EE")]
	protected int m_MarginRight; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40000EF")]
	protected int m_MarginTop; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40000F0")]
	protected int m_MarginBottom; //Field offset: 0x8C

	[Token(Token = "0x1700007A")]
	public virtual int marginBottom
	{
		[Address(RVA = "0xD11AE0", Offset = "0xD10EE0", Length = "0x7")]
		[Token(Token = "0x60001DE")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000077")]
	public virtual int marginLeft
	{
		[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
		[Token(Token = "0x60001DB")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000078")]
	public virtual int marginRight
	{
		[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
		[Token(Token = "0x60001DC")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000079")]
	public virtual int marginTop
	{
		[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
		[Token(Token = "0x60001DD")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x30E3F10", Offset = "0x30E3310", Length = "0xDC")]
	[Token(Token = "0x60001EA")]
	private static GUILayoutGroup() { }

	[Address(RVA = "0x30E3FF0", Offset = "0x30E33F0", Length = "0x130")]
	[Token(Token = "0x60001DF")]
	public GUILayoutGroup() { }

	[Address(RVA = "0x30E1630", Offset = "0x30E0A30", Length = "0xA9")]
	[Token(Token = "0x60001E4")]
	public void Add(GUILayoutEntry e) { }

	[Address(RVA = "0x30E16E0", Offset = "0x30E0AE0", Length = "0xFC")]
	[Token(Token = "0x60001E0")]
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	[Address(RVA = "0x30E1800", Offset = "0x30E0C00", Length = "0x7F")]
	[Token(Token = "0x60001E1")]
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	[Address(RVA = "0x30E1880", Offset = "0x30E0C80", Length = "0x7B8")]
	[Token(Token = "0x60001E7")]
	public virtual void CalcHeight() { }

	[Address(RVA = "0x30E2040", Offset = "0x30E1440", Length = "0x817")]
	[Token(Token = "0x60001E5")]
	public virtual void CalcWidth() { }

	[Address(RVA = "0xD11AE0", Offset = "0xD10EE0", Length = "0x7")]
	[Token(Token = "0x60001DE")]
	public virtual int get_marginBottom() { }

	[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
	[Token(Token = "0x60001DB")]
	public virtual int get_marginLeft() { }

	[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
	[Token(Token = "0x60001DC")]
	public virtual int get_marginRight() { }

	[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
	[Token(Token = "0x60001DD")]
	public virtual int get_marginTop() { }

	[Address(RVA = "0x30E2860", Offset = "0x30E1C60", Length = "0x308")]
	[Token(Token = "0x60001E3")]
	public GUILayoutEntry GetNext() { }

	[Address(RVA = "0x30E2B70", Offset = "0x30E1F70", Length = "0x8")]
	[Token(Token = "0x60001E2")]
	public void ResetCursor() { }

	[Address(RVA = "0x30E2B80", Offset = "0x30E1F80", Length = "0x806")]
	[Token(Token = "0x60001E6")]
	public virtual void SetHorizontal(float x, float width) { }

	[Address(RVA = "0x30E3390", Offset = "0x30E2790", Length = "0x80D")]
	[Token(Token = "0x60001E8")]
	public virtual void SetVertical(float y, float height) { }

	[Address(RVA = "0x30E3BA0", Offset = "0x30E2FA0", Length = "0x361")]
	[Token(Token = "0x60001E9")]
	public virtual string ToString() { }

}

