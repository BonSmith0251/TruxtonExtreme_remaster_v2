namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000021")]
public struct BindingActivationContext
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004A")]
	private readonly VisualElement m_TargetElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400004B")]
	private readonly BindingId m_BindingId; //Field offset: 0x8

	[Address(RVA = "0x31EE860", Offset = "0x31EDC60", Length = "0xBA")]
	[Token(Token = "0x600009F")]
	internal BindingActivationContext(VisualElement element, in BindingId property) { }

}

