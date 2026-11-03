namespace Unity.Hierarchy;

[NativeAsStruct]
[NativeHeader("Modules/HierarchyCore/Public/HierarchySearch.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000027")]
public sealed class HierarchySearchQueryDescriptor
{
	[CompilerGenerated]
	[Token(Token = "0x2000028")]
	private sealed class <>c
	{
		[Token(Token = "0x4000074")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000075")]
		public static Func<HierarchySearchFilter, Boolean> <>9__36_0; //Field offset: 0x8
		[Token(Token = "0x4000076")]
		public static Func<HierarchySearchFilter, Boolean> <>9__36_1; //Field offset: 0x10

		[Address(RVA = "0x30DC190", Offset = "0x30DB590", Length = "0x67")]
		[Token(Token = "0x60000EC")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000ED")]
		public <>c() { }

		[Address(RVA = "0x30DC030", Offset = "0x30DB430", Length = "0xA8")]
		[Token(Token = "0x60000EE")]
		internal bool <.ctor>b__36_0(HierarchySearchFilter f) { }

		[Address(RVA = "0x30DC0E0", Offset = "0x30DB4E0", Length = "0xA5")]
		[Token(Token = "0x60000EF")]
		internal bool <.ctor>b__36_1(HierarchySearchFilter f) { }

	}

	[NoAutoStaticsCleanup]
	[Token(Token = "0x400006B")]
	private static readonly HashSet<String> s_SystemFilters; //Field offset: 0x0
	[NoAutoStaticsCleanup]
	[Token(Token = "0x400006C")]
	private static readonly HierarchySearchQueryDescriptor s_Empty; //Field offset: 0x8
	[NoAutoStaticsCleanup]
	[Token(Token = "0x400006D")]
	private static readonly HierarchySearchQueryDescriptor s_InvalidQuery; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400006E")]
	private string m_Query; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400006F")]
	private HierarchySearchFilter[] <SystemFilters>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000070")]
	private HierarchySearchFilter[] <Filters>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000071")]
	private String[] <TextValues>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000072")]
	private bool <Strict>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000073")]
	private bool <Invalid>k__BackingField; //Field offset: 0x31

	[Token(Token = "0x17000027")]
	public private HierarchySearchFilter[] Filters
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000DD")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60000DE")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700002A")]
	public bool Invalid
	{
		[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000E2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002B")]
	public string Query
	{
		[Address(RVA = "0x30D8C10", Offset = "0x30D8010", Length = "0xA8")]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 168
	}

	[Token(Token = "0x17000029")]
	public bool Strict
	{
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000E1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000026")]
	public private HierarchySearchFilter[] SystemFilters
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000DB")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60000DC")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000028")]
	public private String[] TextValues
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000DF")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60000E0")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x30D8CC0", Offset = "0x30D80C0", Length = "0x1B8")]
	[Token(Token = "0x60000EB")]
	private static HierarchySearchQueryDescriptor() { }

	[Address(RVA = "0x30D8E80", Offset = "0x30D8280", Length = "0x431")]
	[Token(Token = "0x60000E4")]
	public HierarchySearchQueryDescriptor(HierarchySearchFilter[] filters = null, String[] textValues = null) { }

	[Address(RVA = "0x30D8680", Offset = "0x30D7A80", Length = "0x4D")]
	[Token(Token = "0x60000E6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.HierarchyModule"})]
	internal string BuildFilterQuery() { }

	[Address(RVA = "0x30D86D0", Offset = "0x30D7AD0", Length = "0x326")]
	[Token(Token = "0x60000E9")]
	internal string BuildQuery() { }

	[Address(RVA = "0x30D8A00", Offset = "0x30D7E00", Length = "0x4D")]
	[Token(Token = "0x60000E7")]
	internal string BuildSystemFilterQuery() { }

	[Address(RVA = "0x30D8A50", Offset = "0x30D7E50", Length = "0x1B2")]
	[Token(Token = "0x60000E8")]
	internal string BuildTextQuery() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000DD")]
	public HierarchySearchFilter[] get_Filters() { }

	[Address(RVA = "0x30D8C10", Offset = "0x30D8010", Length = "0xA8")]
	[Token(Token = "0x60000E3")]
	public string get_Query() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000DB")]
	public HierarchySearchFilter[] get_SystemFilters() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000DF")]
	public String[] get_TextValues() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60000DE")]
	private void set_Filters(HierarchySearchFilter[] value) { }

	[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000E2")]
	public void set_Invalid(bool value) { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000E1")]
	public void set_Strict(bool value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60000DC")]
	private void set_SystemFilters(HierarchySearchFilter[] value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60000E0")]
	private void set_TextValues(String[] value) { }

	[Address(RVA = "0x30D8C10", Offset = "0x30D8010", Length = "0xA8")]
	[Token(Token = "0x60000E5")]
	public virtual string ToString() { }

	[Address(RVA = "0x81EC10", Offset = "0x81E010", Length = "0x50F")]
	[Token(Token = "0x60000EA")]
	private static T[] Where(IEnumerable<T> src, Func<T, Boolean> pred) { }

}

