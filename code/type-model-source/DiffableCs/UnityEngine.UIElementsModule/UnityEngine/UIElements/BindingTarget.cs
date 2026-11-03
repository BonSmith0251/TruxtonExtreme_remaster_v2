namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000025")]
internal struct BindingTarget
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000056")]
	public readonly VisualElement element; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000057")]
	public readonly BindingId bindingId; //Field offset: 0x8

	[Address(RVA = "0x31EE860", Offset = "0x31EDC60", Length = "0xBA")]
	[Token(Token = "0x60000A8")]
	public BindingTarget(VisualElement element, in BindingId bindingId) { }

}

