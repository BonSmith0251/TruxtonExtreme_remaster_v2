namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002E1")]
public class DebugUIHandlerIntField : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D55")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D56")]
	public Text valueLabel; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D57")]
	private IntField m_Field; //Field offset: 0x70

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x6001455")]
	public DebugUIHandlerIntField() { }

	[Address(RVA = "0x2CB2610", Offset = "0x2CB1A10", Length = "0xA8")]
	[Token(Token = "0x6001453")]
	private void ChangeValue(bool fast, int multiplier) { }

	[Address(RVA = "0x2CB26C0", Offset = "0x2CB1AC0", Length = "0xE")]
	[Token(Token = "0x6001452")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CB11F0", Offset = "0x2CB05F0", Length = "0x68")]
	[Token(Token = "0x6001450")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CB26D0", Offset = "0x2CB1AD0", Length = "0xE")]
	[Token(Token = "0x6001451")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CB1270", Offset = "0x2CB0670", Length = "0x6A")]
	[Token(Token = "0x600144F")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB26E0", Offset = "0x2CB1AE0", Length = "0x9D")]
	[Token(Token = "0x600144E")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB2780", Offset = "0x2CB1B80", Length = "0xD3")]
	[Token(Token = "0x6001454")]
	private void UpdateValueLabel() { }

}

