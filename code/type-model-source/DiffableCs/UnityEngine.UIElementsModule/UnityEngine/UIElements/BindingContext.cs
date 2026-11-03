namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000022")]
public struct BindingContext
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004C")]
	private readonly VisualElement m_TargetElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400004D")]
	private readonly BindingId m_BindingId; //Field offset: 0x8
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400004E")]
	private readonly PropertyPath m_DataSourcePath; //Field offset: 0xA0
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400004F")]
	private readonly object m_DataSource; //Field offset: 0x130

	[Token(Token = "0x17000025")]
	public BindingId bindingId
	{
		[Address(RVA = "0xAEF540", Offset = "0xAEE940", Length = "0x61")]
		[Token(Token = "0x60000A1")]
		 get { } //Length: 97
	}

	[Token(Token = "0x17000027")]
	public object dataSource
	{
		[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
		[Token(Token = "0x60000A3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000026")]
	public PropertyPath dataSourcePath
	{
		[Address(RVA = "0x31EEA80", Offset = "0x31EDE80", Length = "0x69")]
		[Token(Token = "0x60000A2")]
		 get { } //Length: 105
	}

	[Token(Token = "0x17000024")]
	public VisualElement targetElement
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60000A0")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x31EE920", Offset = "0x31EDD20", Length = "0x157")]
	[Token(Token = "0x60000A4")]
	internal BindingContext(VisualElement targetElement, in BindingId bindingId, in PropertyPath resolvedDataSourcePath, object resolvedDataSource) { }

	[Address(RVA = "0xAEF540", Offset = "0xAEE940", Length = "0x61")]
	[Token(Token = "0x60000A1")]
	public BindingId get_bindingId() { }

	[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
	[Token(Token = "0x60000A3")]
	public object get_dataSource() { }

	[Address(RVA = "0x31EEA80", Offset = "0x31EDE80", Length = "0x69")]
	[Token(Token = "0x60000A2")]
	public PropertyPath get_dataSourcePath() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60000A0")]
	public VisualElement get_targetElement() { }

}

