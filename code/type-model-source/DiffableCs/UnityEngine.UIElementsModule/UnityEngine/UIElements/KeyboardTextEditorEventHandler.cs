namespace UnityEngine.UIElements;

[Token(Token = "0x20000EE")]
internal class KeyboardTextEditorEventHandler : TextEditorEventHandler
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400048A")]
	internal bool m_Changed; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x400048B")]
	internal bool m_ShouldInvokeUpdateValue; //Field offset: 0x21

	[Address(RVA = "0x3385ED0", Offset = "0x33852D0", Length = "0xA0")]
	[Token(Token = "0x6000735")]
	public KeyboardTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities) { }

	[Address(RVA = "0x3384C30", Offset = "0x3384030", Length = "0x77")]
	[Token(Token = "0x600073B")]
	private void ApplyTextIfNeeded() { }

	[Address(RVA = "0x3384CB0", Offset = "0x33840B0", Length = "0x3C0")]
	[Token(Token = "0x6000736")]
	public virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x3385080", Offset = "0x3384480", Length = "0x42")]
	[Token(Token = "0x6000738")]
	private void OnBlur(BlurEvent _) { }

	[Address(RVA = "0x33850D0", Offset = "0x33844D0", Length = "0x1EF")]
	[Token(Token = "0x600073E")]
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	[Address(RVA = "0x33852C0", Offset = "0x33846C0", Length = "0x85")]
	[Token(Token = "0x6000737")]
	private void OnFocus(FocusEvent _) { }

	[Address(RVA = "0x3385350", Offset = "0x3384750", Length = "0x54")]
	[Token(Token = "0x6000739")]
	private void OnIMEInput(IMEEvent _) { }

	[Address(RVA = "0x33853B0", Offset = "0x33847B0", Length = "0x6F2")]
	[Token(Token = "0x600073A")]
	private void OnKeyDown(KeyDownEvent evt) { }

	[Address(RVA = "0x850750", Offset = "0x84FB50", Length = "0x79")]
	[Token(Token = "0x600073F")]
	private void OnNavigationEvent(NavigationEventBase<TEvent> evt) { }

	[Address(RVA = "0x3385AB0", Offset = "0x3384EB0", Length = "0x1B1")]
	[Token(Token = "0x600073D")]
	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	[Address(RVA = "0x3385C70", Offset = "0x3385070", Length = "0x25F")]
	[Token(Token = "0x600073C")]
	private void UpdateLabel(bool generatePreview) { }

}

