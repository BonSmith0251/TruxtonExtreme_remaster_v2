namespace Unity.Hierarchy;

[NativeHeader("Modules/HierarchyCore/Public/HierarchySearch.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000026")]
public struct HierarchySearchFilter
{
	[Token(Token = "0x4000065")]
	private static readonly Char[] s_WhiteSpaces; //Field offset: 0x0
	[NoAutoStaticsCleanup]
	[Token(Token = "0x4000066")]
	private static readonly HierarchySearchFilter s_Invalid; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000067")]
	private string <Name>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000068")]
	private string <Value>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000069")]
	private float <NumValue>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400006A")]
	private HierarchySearchFilterOperator <Op>k__BackingField; //Field offset: 0x14

	[IsReadOnly]
	[Token(Token = "0x17000020")]
	public static HierarchySearchFilter Invalid
	{
		[Address(RVA = "0x30D85E0", Offset = "0x30D79E0", Length = "0x4F")]
		[Token(Token = "0x60000D1")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000021")]
	public bool IsValid
	{
		[Address(RVA = "0x30D8630", Offset = "0x30D7A30", Length = "0x4C")]
		[Token(Token = "0x60000D2")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000022")]
	public string Name
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60000D3")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000024")]
	public float NumValue
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60000D5")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000025")]
	public HierarchySearchFilterOperator Op
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60000D6")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000023")]
	public string Value
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60000D4")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x30D8550", Offset = "0x30D7950", Length = "0x8C")]
	[Token(Token = "0x60000DA")]
	private static HierarchySearchFilter() { }

	[Address(RVA = "0x30D85E0", Offset = "0x30D79E0", Length = "0x4F")]
	[Token(Token = "0x60000D1")]
	public static HierarchySearchFilter get_Invalid() { }

	[Address(RVA = "0x30D8630", Offset = "0x30D7A30", Length = "0x4C")]
	[Token(Token = "0x60000D2")]
	public bool get_IsValid() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60000D3")]
	public string get_Name() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60000D5")]
	public float get_NumValue() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60000D6")]
	public HierarchySearchFilterOperator get_Op() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60000D4")]
	public string get_Value() { }

	[Address(RVA = "0x30D80A0", Offset = "0x30D74A0", Length = "0xAE")]
	[Token(Token = "0x60000D9")]
	internal static string QuoteStringIfNeeded(string s) { }

	[Address(RVA = "0x30D8150", Offset = "0x30D7550", Length = "0x88")]
	[Token(Token = "0x60000D7")]
	public static string ToString(HierarchySearchFilterOperator op) { }

	[Address(RVA = "0x30D82F0", Offset = "0x30D76F0", Length = "0x238")]
	[Token(Token = "0x60000D8")]
	public virtual string ToString() { }

}

