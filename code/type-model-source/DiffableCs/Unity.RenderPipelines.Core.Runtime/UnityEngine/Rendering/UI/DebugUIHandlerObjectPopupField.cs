namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002E5")]
public class DebugUIHandlerObjectPopupField : DebugUIHandlerField<ObjectPopupField>
{
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000D61")]
	private int m_Index; //Field offset: 0x88

	[Address(RVA = "0x2CB2FB0", Offset = "0x2CB23B0", Length = "0x39")]
	[Token(Token = "0x6001469")]
	public DebugUIHandlerObjectPopupField() { }

	[Address(RVA = "0x2CB2D60", Offset = "0x2CB2160", Length = "0xFB")]
	[Token(Token = "0x6001465")]
	private void ChangeSelectedObject() { }

	[Address(RVA = "0x2CB2E60", Offset = "0x2CB2260", Length = "0xD")]
	[Token(Token = "0x6001467")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CB2E70", Offset = "0x2CB2270", Length = "0xD")]
	[Token(Token = "0x6001466")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CB2E80", Offset = "0x2CB2280", Length = "0x53")]
	[Token(Token = "0x6001464")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB2EE0", Offset = "0x2CB22E0", Length = "0xC8")]
	[Token(Token = "0x6001468")]
	public virtual void UpdateValueLabel() { }

}

