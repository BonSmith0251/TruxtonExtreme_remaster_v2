namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002DC")]
public class DebugUIHandlerFoldout : DebugUIHandlerWidget
{
	[Token(Token = "0x4000D41")]
	private const float k_FoldoutXOffset = 215; //Field offset: 0x0
	[Token(Token = "0x4000D42")]
	private const float k_XOffset = 230; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D3D")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D3E")]
	public UIFoldout valueToggle; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D3F")]
	private Foldout m_Field; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D40")]
	private DebugUIHandlerContainer m_Container; //Field offset: 0x78

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x6001436")]
	public DebugUIHandlerFoldout() { }

	[Address(RVA = "0x2CB1450", Offset = "0x2CB0850", Length = "0xCC")]
	[Token(Token = "0x6001435")]
	public virtual DebugUIHandlerWidget Next() { }

	[Address(RVA = "0x2CB1520", Offset = "0x2CB0920", Length = "0x69")]
	[Token(Token = "0x6001433")]
	public virtual void OnAction() { }

	[Address(RVA = "0x2CB1590", Offset = "0x2CB0990", Length = "0x56")]
	[Token(Token = "0x6001432")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CAC720", Offset = "0x2CABB20", Length = "0x3B")]
	[Token(Token = "0x6001430")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CB15F0", Offset = "0x2CB09F0", Length = "0x56")]
	[Token(Token = "0x6001431")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CB1650", Offset = "0x2CB0A50", Length = "0x10B")]
	[Token(Token = "0x600142F")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB1760", Offset = "0x2CB0B60", Length = "0x4DE")]
	[Token(Token = "0x600142E")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB1C40", Offset = "0x2CB1040", Length = "0x37")]
	[Token(Token = "0x6001434")]
	private void UpdateValue() { }

}

