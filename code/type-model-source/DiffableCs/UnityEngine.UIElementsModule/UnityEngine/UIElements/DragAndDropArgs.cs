namespace UnityEngine.UIElements;

[Token(Token = "0x2000194")]
internal struct DragAndDropArgs : IListDragAndDropArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400078E")]
	private object <target>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400078F")]
	private int <insertAtIndex>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000790")]
	private int <parentId>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000791")]
	private int <childIndex>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000792")]
	private DragAndDropPosition <dragAndDropPosition>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000793")]
	private DragAndDropData <dragAndDropData>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000794")]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700021F")]
	public override int childIndex
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000BEB")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000BEC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000221")]
	public override DragAndDropData dragAndDropData
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000BEF")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000BF0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000220")]
	public override DragAndDropPosition dragAndDropPosition
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000BED")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000BEE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700021D")]
	public override int insertAtIndex
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000BE7")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000BE8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000222")]
	internal EventModifiers modifiers
	{
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000BF1")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700021E")]
	public override int parentId
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000BE9")]
		 get { } //Length: 4
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000BEA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700021C")]
	public object target
	{
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000BE6")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000BEB")]
	public override int get_childIndex() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000BEF")]
	public override DragAndDropData get_dragAndDropData() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000BED")]
	public override DragAndDropPosition get_dragAndDropPosition() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000BE7")]
	public override int get_insertAtIndex() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000BE9")]
	public override int get_parentId() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000BEC")]
	public void set_childIndex(int value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000BF0")]
	public void set_dragAndDropData(DragAndDropData value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000BEE")]
	public void set_dragAndDropPosition(DragAndDropPosition value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000BE8")]
	public void set_insertAtIndex(int value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000BF1")]
	internal void set_modifiers(EventModifiers value) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000BEA")]
	public void set_parentId(int value) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000BE6")]
	public void set_target(object value) { }

}

