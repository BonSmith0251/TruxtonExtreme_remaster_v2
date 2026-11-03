namespace UnityEngine.UIElements.Layout;

[IsReadOnly]
[RequiredByNativeCode]
[Token(Token = "0x2000609")]
internal struct LayoutDataAccess
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001610")]
	private readonly int m_Manager; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001611")]
	private readonly LayoutDataStore m_Nodes; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001612")]
	private readonly LayoutDataStore m_Configs; //Field offset: 0x20

	[Address(RVA = "0x331CEE0", Offset = "0x331C2E0", Length = "0x29")]
	[Token(Token = "0x6002B46")]
	internal LayoutDataAccess(int manager, LayoutDataStore nodes, LayoutDataStore configs) { }

	[Address(RVA = "0x331CA10", Offset = "0x331BE10", Length = "0x6E")]
	[Token(Token = "0x6002B52")]
	public LayoutBaselineFunction GetBaselineFunction(LayoutHandle handle) { }

	[Address(RVA = "0x331CA80", Offset = "0x331BE80", Length = "0x7F")]
	[Token(Token = "0x6002B4C")]
	public LayoutCacheData GetCacheData(LayoutHandle handle) { }

	[Address(RVA = "0x331CB00", Offset = "0x331BF00", Length = "0x73")]
	[Token(Token = "0x6002B4B")]
	public LayoutComputedData GetComputedData(LayoutHandle handle) { }

	[Address(RVA = "0x331CB80", Offset = "0x331BF80", Length = "0x73")]
	[Token(Token = "0x6002B4D")]
	public LayoutConfigData GetConfigData(LayoutHandle handle) { }

	[Address(RVA = "0x331CC00", Offset = "0x331C000", Length = "0x6E")]
	[Token(Token = "0x6002B4E")]
	public LayoutMeasureFunction GetMeasureFunction(LayoutHandle handle) { }

	[Address(RVA = "0x331CC70", Offset = "0x331C070", Length = "0x73")]
	[Token(Token = "0x6002B49")]
	public LayoutNodeData GetNodeData(LayoutHandle handle) { }

	[Address(RVA = "0x331CCF0", Offset = "0x331C0F0", Length = "0x6E")]
	[Token(Token = "0x6002B50")]
	public VisualElement GetOwner(LayoutHandle handle) { }

	[Address(RVA = "0x331CD60", Offset = "0x331C160", Length = "0x73")]
	[Token(Token = "0x6002B4A")]
	public LayoutStyleData GetStyleData(LayoutHandle handle) { }

	[Address(RVA = "0x851790", Offset = "0x850B90", Length = "0x2D")]
	[Token(Token = "0x6002B48")]
	private T GetTypedConfigDataRef(LayoutHandle handle, LayoutConfigDataType type) { }

	[Address(RVA = "0x8517C0", Offset = "0x850BC0", Length = "0x2D")]
	[Token(Token = "0x6002B47")]
	private T GetTypedNodeDataRef(LayoutHandle handle, LayoutNodeDataType type) { }

	[Address(RVA = "0x331CDE0", Offset = "0x331C1E0", Length = "0x7E")]
	[Token(Token = "0x6002B4F")]
	public void SetMeasureFunction(LayoutHandle handle, LayoutMeasureFunction value) { }

	[Address(RVA = "0x331CE60", Offset = "0x331C260", Length = "0x7E")]
	[Token(Token = "0x6002B51")]
	public void SetOwner(LayoutHandle handle, VisualElement value) { }

}

