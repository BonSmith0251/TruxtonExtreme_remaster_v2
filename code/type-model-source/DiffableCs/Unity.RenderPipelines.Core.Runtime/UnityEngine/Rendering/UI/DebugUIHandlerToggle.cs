namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002ED")]
public class DebugUIHandlerToggle : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D7C")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D7D")]
	public Toggle valueToggle; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D7E")]
	public Image checkmarkImage; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D7F")]
	protected private BoolField m_Field; //Field offset: 0x78

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x600149C")]
	public DebugUIHandlerToggle() { }

	[Address(RVA = "0x2CB5F40", Offset = "0x2CB5340", Length = "0x7D")]
	[Token(Token = "0x600149A")]
	public virtual void OnAction() { }

	[Address(RVA = "0x2CB2450", Offset = "0x2CB1850", Length = "0x68")]
	[Token(Token = "0x6001499")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CB24C0", Offset = "0x2CB18C0", Length = "0x6A")]
	[Token(Token = "0x6001498")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB5FC0", Offset = "0x2CB53C0", Length = "0x2A")]
	[Token(Token = "0x6001497")]
	private void OnToggleValueChanged(bool value) { }

	[Address(RVA = "0x2CB5FF0", Offset = "0x2CB53F0", Length = "0x12A")]
	[Token(Token = "0x6001496")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB6120", Offset = "0x2CB5520", Length = "0x9B")]
	[Token(Token = "0x600149B")]
	protected private override void UpdateValueLabel() { }

}

