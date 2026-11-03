namespace UnityEngine.UIElements;

[Token(Token = "0x20000EF")]
internal class TextEditorEventHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400048C")]
	protected TextElement textElement; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400048D")]
	protected TextEditingUtilities editingUtilities; //Field offset: 0x18

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000740")]
	protected TextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000743")]
	public override void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000741")]
	public override void RegisterCallbacksOnTarget(VisualElement target) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000742")]
	public override void UnregisterCallbacksFromTarget(VisualElement target) { }

}

