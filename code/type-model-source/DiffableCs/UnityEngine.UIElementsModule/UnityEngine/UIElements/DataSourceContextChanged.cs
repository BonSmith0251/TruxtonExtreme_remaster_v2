namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000045")]
public struct DataSourceContextChanged
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000153")]
	private readonly VisualElement m_TargetElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000154")]
	private readonly BindingId m_BindingId; //Field offset: 0x8
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000155")]
	private readonly DataSourceContext m_PreviousContext; //Field offset: 0xA0
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000156")]
	private readonly DataSourceContext m_NewContext; //Field offset: 0x138

	[Address(RVA = "0x32237E0", Offset = "0x3222BE0", Length = "0x1DD")]
	[Token(Token = "0x6000214")]
	internal DataSourceContextChanged(VisualElement element, in BindingId bindingId, in DataSourceContext previousContext, in DataSourceContext newContext) { }

}

