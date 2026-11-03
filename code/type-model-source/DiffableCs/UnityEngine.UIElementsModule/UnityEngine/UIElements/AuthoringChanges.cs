namespace UnityEngine.UIElements;

[Token(Token = "0x200000C")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule"})]
internal class AuthoringChanges
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000019")]
	private readonly HashSet<VisualElement> <addedOrMovedElements>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001A")]
	private readonly HashSet<VisualElement> <removedFromPanel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001B")]
	private readonly HashSet<VisualElement> <styleChanged>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400001C")]
	private readonly HashSet<VisualElement> <stylingContextChanged>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400001D")]
	private readonly HashSet<VisualElement> <bindingContextChanged>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x17000008")]
	public HashSet<VisualElement> addedOrMovedElements
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600002F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000C")]
	public HashSet<VisualElement> bindingContextChanged
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000033")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000009")]
	public HashSet<VisualElement> removedFromPanel
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000030")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000A")]
	public HashSet<VisualElement> styleChanged
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000031")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000B")]
	public HashSet<VisualElement> stylingContextChanged
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000032")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x31ED920", Offset = "0x31ECD20", Length = "0x12F")]
	[Token(Token = "0x6000036")]
	public AuthoringChanges() { }

	[Address(RVA = "0x31ED7F0", Offset = "0x31ECBF0", Length = "0x98")]
	[Token(Token = "0x6000035")]
	public void Clear() { }

	[Address(RVA = "0x31ED890", Offset = "0x31ECC90", Length = "0x88")]
	[Token(Token = "0x6000034")]
	public bool ContainsChanges() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600002F")]
	public HashSet<VisualElement> get_addedOrMovedElements() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000033")]
	public HashSet<VisualElement> get_bindingContextChanged() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000030")]
	public HashSet<VisualElement> get_removedFromPanel() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000031")]
	public HashSet<VisualElement> get_styleChanged() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000032")]
	public HashSet<VisualElement> get_stylingContextChanged() { }

}

