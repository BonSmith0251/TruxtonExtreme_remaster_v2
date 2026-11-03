namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000044")]
public struct DataSourceContext
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000151")]
	private readonly object <dataSource>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000152")]
	private readonly PropertyPath <dataSourcePath>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000044")]
	public object dataSource
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000211")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000045")]
	public PropertyPath dataSourcePath
	{
		[Address(RVA = "0x3223A60", Offset = "0x3222E60", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x6000212")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x32239C0", Offset = "0x3222DC0", Length = "0x9C")]
	[Token(Token = "0x6000213")]
	public DataSourceContext(object dataSource, in PropertyPath dataSourcePath) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000211")]
	public object get_dataSource() { }

	[Address(RVA = "0x3223A60", Offset = "0x3222E60", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x6000212")]
	public PropertyPath get_dataSourcePath() { }

}

