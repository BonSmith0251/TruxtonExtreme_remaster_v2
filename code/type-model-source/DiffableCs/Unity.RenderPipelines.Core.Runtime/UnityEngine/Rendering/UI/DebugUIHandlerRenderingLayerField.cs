namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002EB")]
public class DebugUIHandlerRenderingLayerField : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D76")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D77")]
	public UIFoldout valueToggle; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D78")]
	public List<DebugUIHandlerIndirectToggle> toggles; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D79")]
	private RenderingLayerField m_Field; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D7A")]
	private DebugUIHandlerContainer m_Container; //Field offset: 0x80

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x600148F")]
	public DebugUIHandlerRenderingLayerField() { }

	[Address(RVA = "0x2CB43D0", Offset = "0x2CB37D0", Length = "0x8F")]
	[Token(Token = "0x6001487")]
	private bool GetValue(int index) { }

	[Address(RVA = "0x2CB4460", Offset = "0x2CB3860", Length = "0xD0")]
	[Token(Token = "0x600148E")]
	public virtual DebugUIHandlerWidget Next() { }

	[Address(RVA = "0x2CAC6C0", Offset = "0x2CABAC0", Length = "0x2B")]
	[Token(Token = "0x600148D")]
	public virtual void OnAction() { }

	[Address(RVA = "0x2CAC6F0", Offset = "0x2CABAF0", Length = "0x20")]
	[Token(Token = "0x600148C")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CAC720", Offset = "0x2CABB20", Length = "0x3B")]
	[Token(Token = "0x600148A")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CAC760", Offset = "0x2CABB60", Length = "0x20")]
	[Token(Token = "0x600148B")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CB4540", Offset = "0x2CB3940", Length = "0x111")]
	[Token(Token = "0x6001489")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB4660", Offset = "0x2CB3A60", Length = "0xE9")]
	[Token(Token = "0x6001488")]
	private void SetValue(int index, bool value) { }

	[Address(RVA = "0x2CB4750", Offset = "0x2CB3B50", Length = "0x3BB")]
	[Token(Token = "0x6001486")]
	internal virtual void SetWidget(Widget widget) { }

}

