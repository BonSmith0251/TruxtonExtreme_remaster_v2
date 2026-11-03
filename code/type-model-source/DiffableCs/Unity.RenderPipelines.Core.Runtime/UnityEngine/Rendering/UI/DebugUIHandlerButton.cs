namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002CF")]
public class DebugUIHandlerButton : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D15")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D16")]
	private Button m_Field; //Field offset: 0x68

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x60013DA")]
	public DebugUIHandlerButton() { }

	[Address(RVA = "0x2CACF50", Offset = "0x2CAC350", Length = "0x35")]
	[Token(Token = "0x60013D9")]
	public virtual void OnAction() { }

	[Address(RVA = "0x2CAC720", Offset = "0x2CABB20", Length = "0x3B")]
	[Token(Token = "0x60013D8")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CACF90", Offset = "0x2CAC390", Length = "0x3D")]
	[Token(Token = "0x60013D7")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CACFD0", Offset = "0x2CAC3D0", Length = "0x94")]
	[Token(Token = "0x60013D6")]
	internal virtual void SetWidget(Widget widget) { }

}

