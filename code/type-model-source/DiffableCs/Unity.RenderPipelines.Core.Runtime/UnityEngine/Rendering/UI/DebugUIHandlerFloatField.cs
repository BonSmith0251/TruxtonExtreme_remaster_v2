namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002DB")]
public class DebugUIHandlerFloatField : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D3A")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D3B")]
	public Text valueLabel; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D3C")]
	private FloatField m_Field; //Field offset: 0x70

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x600142D")]
	public DebugUIHandlerFloatField() { }

	[Address(RVA = "0x2CB1130", Offset = "0x2CB0530", Length = "0xAB")]
	[Token(Token = "0x600142B")]
	private void ChangeValue(bool fast, float multiplier) { }

	[Address(RVA = "0x2CB11E0", Offset = "0x2CB05E0", Length = "0x10")]
	[Token(Token = "0x600142A")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CB11F0", Offset = "0x2CB05F0", Length = "0x68")]
	[Token(Token = "0x6001428")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CB1260", Offset = "0x2CB0660", Length = "0x10")]
	[Token(Token = "0x6001429")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CB1270", Offset = "0x2CB0670", Length = "0x6A")]
	[Token(Token = "0x6001427")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB12E0", Offset = "0x2CB06E0", Length = "0x9D")]
	[Token(Token = "0x6001426")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB1380", Offset = "0x2CB0780", Length = "0xC1")]
	[Token(Token = "0x600142C")]
	private void UpdateValueLabel() { }

}

