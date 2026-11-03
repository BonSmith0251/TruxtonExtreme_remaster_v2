namespace UnityEngine.UIElements;

[Token(Token = "0x200019B")]
public struct StartDragArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007A7")]
	private readonly string <title>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007A8")]
	private readonly DragVisualMode <visualMode>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40007A9")]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007AA")]
	private Hashtable <genericData>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007AB")]
	private IReadOnlyList<EntityId> <entityIds>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007AC")]
	private String[] <assetPaths>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000228")]
	internal String[] assetPaths
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C05")]
		internal get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000C06")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000227")]
	internal IReadOnlyList<EntityId> entityIds
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C03")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000C04")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000226")]
	internal Hashtable genericData
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000C01")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000C02")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000225")]
	internal EventModifiers modifiers
	{
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C00")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000223")]
	public string title
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000BFE")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000224")]
	public DragVisualMode visualMode
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000BFF")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x33B3AF0", Offset = "0x33B2EF0", Length = "0x58")]
	[Token(Token = "0x6000BFC")]
	public StartDragArgs(string title, DragVisualMode visualMode) { }

	[Address(RVA = "0x33B3B50", Offset = "0x33B2F50", Length = "0x65")]
	[Token(Token = "0x6000BFD")]
	internal StartDragArgs(string title, DragVisualMode visualMode, EventModifiers modifiers) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C05")]
	internal String[] get_assetPaths() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C03")]
	internal IReadOnlyList<EntityId> get_entityIds() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000C01")]
	internal Hashtable get_genericData() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000BFE")]
	public string get_title() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000BFF")]
	public DragVisualMode get_visualMode() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000C06")]
	private void set_assetPaths(String[] value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000C04")]
	private void set_entityIds(IReadOnlyList<EntityId> value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000C02")]
	private void set_genericData(Hashtable value) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C00")]
	internal void set_modifiers(EventModifiers value) { }

	[Address(RVA = "0x33B3A40", Offset = "0x33B2E40", Length = "0xA5")]
	[Token(Token = "0x6000C07")]
	public void SetGenericData(string key, object data) { }

}

