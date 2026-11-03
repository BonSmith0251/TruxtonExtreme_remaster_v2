namespace UnityEngine.UIElements;

[Token(Token = "0x2000256")]
public struct FilterPassContext
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400090E")]
	private FilterFunction <filterFunction>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400090F")]
	private int <filterPassIndex>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000910")]
	private bool <readsGamma>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x75")]
	[Token(Token = "0x4000911")]
	private bool <writesGamma>k__BackingField; //Field offset: 0x75

	[Token(Token = "0x170002F2")]
	public internal FilterFunction filterFunction
	{
		[Address(RVA = "0x33D09F0", Offset = "0x33CFDF0", Length = "0x3A")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001006")]
		 get { } //Length: 58
		[Address(RVA = "0x33D0A30", Offset = "0x33CFE30", Length = "0x41")]
		[CompilerGenerated]
		[Token(Token = "0x6001007")]
		internal set { } //Length: 65
	}

	[Token(Token = "0x170002F3")]
	internal int filterPassIndex
	{
		[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001008")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002F4")]
	public internal bool readsGamma
	{
		[Address(RVA = "0x1D48530", Offset = "0x1D47930", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001009")]
		 get { } //Length: 5
		[Address(RVA = "0x28937D0", Offset = "0x2892BD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600100A")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002F5")]
	internal bool writesGamma
	{
		[Address(RVA = "0x24702A0", Offset = "0x246F6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600100B")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x33D09F0", Offset = "0x33CFDF0", Length = "0x3A")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001006")]
	public FilterFunction get_filterFunction() { }

	[Address(RVA = "0x1D48530", Offset = "0x1D47930", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001009")]
	public bool get_readsGamma() { }

	[Address(RVA = "0x33D0A30", Offset = "0x33CFE30", Length = "0x41")]
	[CompilerGenerated]
	[Token(Token = "0x6001007")]
	internal void set_filterFunction(FilterFunction value) { }

	[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001008")]
	internal void set_filterPassIndex(int value) { }

	[Address(RVA = "0x28937D0", Offset = "0x2892BD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600100A")]
	internal void set_readsGamma(bool value) { }

	[Address(RVA = "0x24702A0", Offset = "0x246F6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600100B")]
	internal void set_writesGamma(bool value) { }

}

