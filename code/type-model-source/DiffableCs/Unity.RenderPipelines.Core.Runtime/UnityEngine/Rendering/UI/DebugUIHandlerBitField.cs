namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002CE")]
public class DebugUIHandlerBitField : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D10")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D11")]
	public UIFoldout valueToggle; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D12")]
	public List<DebugUIHandlerIndirectToggle> toggles; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D13")]
	private BitField m_Field; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D14")]
	private DebugUIHandlerContainer m_Container; //Field offset: 0x80

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x60013D5")]
	public DebugUIHandlerBitField() { }

	[Address(RVA = "0x2CAC530", Offset = "0x2CAB930", Length = "0xA3")]
	[Token(Token = "0x60013CD")]
	private bool GetValue(int index) { }

	[Address(RVA = "0x2CAC5E0", Offset = "0x2CAB9E0", Length = "0xD0")]
	[Token(Token = "0x60013D4")]
	public virtual DebugUIHandlerWidget Next() { }

	[Address(RVA = "0x2CAC6C0", Offset = "0x2CABAC0", Length = "0x2B")]
	[Token(Token = "0x60013D3")]
	public virtual void OnAction() { }

	[Address(RVA = "0x2CAC6F0", Offset = "0x2CABAF0", Length = "0x20")]
	[Token(Token = "0x60013D2")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CAC720", Offset = "0x2CABB20", Length = "0x3B")]
	[Token(Token = "0x60013D0")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CAC760", Offset = "0x2CABB60", Length = "0x20")]
	[Token(Token = "0x60013D1")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CAC790", Offset = "0x2CABB90", Length = "0x111")]
	[Token(Token = "0x60013CF")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CAC8B0", Offset = "0x2CABCB0", Length = "0x2BF")]
	[Token(Token = "0x60013CE")]
	private void SetValue(int index, bool value) { }

	[Address(RVA = "0x2CACB70", Offset = "0x2CABF70", Length = "0x3BF")]
	[Token(Token = "0x60013CC")]
	internal virtual void SetWidget(Widget widget) { }

}

