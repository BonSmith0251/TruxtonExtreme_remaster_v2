namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002DA")]
public abstract class DebugUIHandlerField : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D35")]
	public Text nextButtonText; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D36")]
	public Text previousButtonText; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D37")]
	public Text nameLabel; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D38")]
	public Text valueLabel; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D39")]
	protected private T m_Field; //Field offset: 0x0

	[Address(RVA = "0x17D2DD0", Offset = "0x17D21D0", Length = "0x7")]
	[Token(Token = "0x6001425")]
	protected DebugUIHandlerField`1() { }

	[Address(RVA = "0x17D29E0", Offset = "0x17D1DE0", Length = "0x28")]
	[Token(Token = "0x6001422")]
	public virtual void OnAction() { }

	[Address(RVA = "0x17D2A10", Offset = "0x17D1E10", Length = "0x13D")]
	[Token(Token = "0x6001421")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x17D2B50", Offset = "0x17D1F50", Length = "0x13F")]
	[Token(Token = "0x6001420")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x17D2C90", Offset = "0x17D2090", Length = "0x8E")]
	[Token(Token = "0x6001424")]
	protected void SetLabelText(string text) { }

	[Address(RVA = "0x17D2D20", Offset = "0x17D2120", Length = "0xA4")]
	[Token(Token = "0x600141F")]
	internal virtual void SetWidget(Widget widget) { }

	[Token(Token = "0x6001423")]
	public abstract void UpdateValueLabel() { }

}

