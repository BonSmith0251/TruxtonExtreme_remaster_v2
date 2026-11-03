namespace UnityEngine.UIElements;

[Token(Token = "0x2000031")]
[UxmlObject]
public class DataBinding : Binding, IDataSourceProvider
{
	[Token(Token = "0x4000107")]
	private static MethodInfo s_UpdateUIMethodInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000108")]
	private BindingMode m_BindingMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000109")]
	private ConverterGroup m_SourceToUiConverters; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400010A")]
	private ConverterGroup m_UiToSourceConverters; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400010B")]
	private object <dataSource>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400010C")]
	private Type <dataSourceType>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400010D")]
	private PropertyPath <dataSourcePath>k__BackingField; //Field offset: 0x48

	[CreateProperty]
	[Token(Token = "0x17000036")]
	public BindingMode bindingMode
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000190")]
		 get { } //Length: 4
		[Address(RVA = "0x320A800", Offset = "0x3209C00", Length = "0xD")]
		[Token(Token = "0x6000191")]
		 set { } //Length: 13
	}

	[CreateProperty]
	[Token(Token = "0x17000033")]
	public override object dataSource
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600018A")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600018B")]
		 set { } //Length: 13
	}

	[CreateProperty]
	[Token(Token = "0x17000035")]
	public override PropertyPath dataSourcePath
	{
		[Address(RVA = "0x320A450", Offset = "0x3209850", Length = "0x5D")]
		[CompilerGenerated]
		[Token(Token = "0x600018E")]
		 get { } //Length: 93
		[Address(RVA = "0x320A810", Offset = "0x3209C10", Length = "0x64")]
		[CompilerGenerated]
		[Token(Token = "0x600018F")]
		 set { } //Length: 100
	}

	[Token(Token = "0x17000034")]
	public Type dataSourceType
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600018C")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600018D")]
		 set { } //Length: 13
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000037")]
	public ConverterGroup sourceToUiConverters
	{
		[Address(RVA = "0x320A4B0", Offset = "0x32098B0", Length = "0x95")]
		[Token(Token = "0x6000192")]
		 get { } //Length: 149
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000038")]
	public ConverterGroup uiToSourceConverters
	{
		[Address(RVA = "0x320A550", Offset = "0x3209950", Length = "0x95")]
		[Token(Token = "0x6000193")]
		 get { } //Length: 149
	}

	[Token(Token = "0x17000032")]
	internal static MethodInfo updateUIMethod
	{
		[Address(RVA = "0x320A5F0", Offset = "0x32099F0", Length = "0x20F")]
		[Token(Token = "0x6000188")]
		internal get { } //Length: 527
	}

	[Address(RVA = "0x320A090", Offset = "0x3209490", Length = "0xFB")]
	[Token(Token = "0x6000194")]
	public void ApplyConverterGroupToSource(ConverterGroup group) { }

	[Address(RVA = "0x320A190", Offset = "0x3209590", Length = "0xFB")]
	[Token(Token = "0x6000195")]
	public void ApplyConverterGroupToUI(ConverterGroup group) { }

	[Address(RVA = "0x320A290", Offset = "0x3209690", Length = "0x1B8")]
	[Token(Token = "0x6000189")]
	private static MethodInfo CacheReflectionInfo() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000190")]
	public BindingMode get_bindingMode() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600018A")]
	public override object get_dataSource() { }

	[Address(RVA = "0x320A450", Offset = "0x3209850", Length = "0x5D")]
	[CompilerGenerated]
	[Token(Token = "0x600018E")]
	public override PropertyPath get_dataSourcePath() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600018C")]
	public Type get_dataSourceType() { }

	[Address(RVA = "0x320A4B0", Offset = "0x32098B0", Length = "0x95")]
	[Token(Token = "0x6000192")]
	public ConverterGroup get_sourceToUiConverters() { }

	[Address(RVA = "0x320A550", Offset = "0x3209950", Length = "0x95")]
	[Token(Token = "0x6000193")]
	public ConverterGroup get_uiToSourceConverters() { }

	[Address(RVA = "0x320A5F0", Offset = "0x32099F0", Length = "0x20F")]
	[Token(Token = "0x6000188")]
	internal static MethodInfo get_updateUIMethod() { }

	[Address(RVA = "0x7BC610", Offset = "0x7BBA10", Length = "0x6BC")]
	[Token(Token = "0x6000198")]
	internal static string GetSetValueErrorString(VisitReturnCode returnCode, object source, in PropertyPath sourcePath, object target, in BindingId targetPath, TValue extractedValueFromSource) { }

	[Address(RVA = "0x320A800", Offset = "0x3209C00", Length = "0xD")]
	[Token(Token = "0x6000191")]
	public void set_bindingMode(BindingMode value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600018B")]
	public void set_dataSource(object value) { }

	[Address(RVA = "0x320A810", Offset = "0x3209C10", Length = "0x64")]
	[CompilerGenerated]
	[Token(Token = "0x600018F")]
	public void set_dataSourcePath(PropertyPath value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600018D")]
	public void set_dataSourceType(Type value) { }

	[Address(RVA = "0x7C0090", Offset = "0x7BF490", Length = "0x5B6")]
	[Token(Token = "0x6000197")]
	protected private override BindingResult UpdateSource(in BindingContext context, ref TValue value) { }

	[Address(RVA = "0x7C0650", Offset = "0x7BFA50", Length = "0xAE8")]
	[Token(Token = "0x6000196")]
	protected private override BindingResult UpdateUI(in BindingContext context, ref TValue value) { }

}

