namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Effects/Shadow", 80)]
[Token(Token = "0x2000088")]
public class Shadow : BaseMeshEffect
{
	[Token(Token = "0x4000274")]
	private const float kMaxEffectDistance = 600; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000271")]
	private Color m_EffectColor; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000272")]
	private Vector2 m_EffectDistance; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000273")]
	private bool m_UseGraphicAlpha; //Field offset: 0x40

	[Token(Token = "0x17000156")]
	public Color effectColor
	{
		[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
		[Token(Token = "0x6000544")]
		 get { } //Length: 11
		[Address(RVA = "0x34706B0", Offset = "0x346FAB0", Length = "0x9C")]
		[Token(Token = "0x6000545")]
		 set { } //Length: 156
	}

	[Token(Token = "0x17000157")]
	public Vector2 effectDistance
	{
		[Address(RVA = "0x2E0B600", Offset = "0x2E0AA00", Length = "0x13")]
		[Token(Token = "0x6000546")]
		 get { } //Length: 19
		[Address(RVA = "0x3470750", Offset = "0x346FB50", Length = "0xFD")]
		[Token(Token = "0x6000547")]
		 set { } //Length: 253
	}

	[Token(Token = "0x17000158")]
	public bool useGraphicAlpha
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x6000548")]
		 get { } //Length: 5
		[Address(RVA = "0x3470850", Offset = "0x346FC50", Length = "0x99")]
		[Token(Token = "0x6000549")]
		 set { } //Length: 153
	}

	[Address(RVA = "0x3470680", Offset = "0x346FA80", Length = "0x25")]
	[Token(Token = "0x6000543")]
	protected Shadow() { }

	[Address(RVA = "0x3470530", Offset = "0x346F930", Length = "0xE")]
	[Token(Token = "0x600054B")]
	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	[Address(RVA = "0x34701B0", Offset = "0x346F5B0", Length = "0x379")]
	[Token(Token = "0x600054A")]
	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
	[Token(Token = "0x6000544")]
	public Color get_effectColor() { }

	[Address(RVA = "0x2E0B600", Offset = "0x2E0AA00", Length = "0x13")]
	[Token(Token = "0x6000546")]
	public Vector2 get_effectDistance() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x6000548")]
	public bool get_useGraphicAlpha() { }

	[Address(RVA = "0x3470540", Offset = "0x346F940", Length = "0x13B")]
	[Token(Token = "0x600054C")]
	public virtual void ModifyMesh(VertexHelper vh) { }

	[Address(RVA = "0x34706B0", Offset = "0x346FAB0", Length = "0x9C")]
	[Token(Token = "0x6000545")]
	public void set_effectColor(Color value) { }

	[Address(RVA = "0x3470750", Offset = "0x346FB50", Length = "0xFD")]
	[Token(Token = "0x6000547")]
	public void set_effectDistance(Vector2 value) { }

	[Address(RVA = "0x3470850", Offset = "0x346FC50", Length = "0x99")]
	[Token(Token = "0x6000549")]
	public void set_useGraphicAlpha(bool value) { }

}

