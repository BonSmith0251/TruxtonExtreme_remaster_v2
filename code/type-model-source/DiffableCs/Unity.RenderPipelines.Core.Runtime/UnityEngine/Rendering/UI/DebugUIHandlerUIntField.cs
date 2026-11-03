namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002F0")]
public class DebugUIHandlerUIntField : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D85")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D86")]
	public Text valueLabel; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D87")]
	private UIntField m_Field; //Field offset: 0x70

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x60014AE")]
	public DebugUIHandlerUIntField() { }

	[Address(RVA = "0x2CB61C0", Offset = "0x2CB55C0", Length = "0xA9")]
	[Token(Token = "0x60014AC")]
	private void ChangeValue(bool fast, int multiplier) { }

	[Address(RVA = "0x2CB6270", Offset = "0x2CB5670", Length = "0x9C")]
	[Token(Token = "0x60014AB")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CB11F0", Offset = "0x2CB05F0", Length = "0x68")]
	[Token(Token = "0x60014A9")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CB6310", Offset = "0x2CB5710", Length = "0x8F")]
	[Token(Token = "0x60014AA")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CB1270", Offset = "0x2CB0670", Length = "0x6A")]
	[Token(Token = "0x60014A8")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB63A0", Offset = "0x2CB57A0", Length = "0x9D")]
	[Token(Token = "0x60014A7")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB6440", Offset = "0x2CB5840", Length = "0xD3")]
	[Token(Token = "0x60014AD")]
	private void UpdateValueLabel() { }

}

