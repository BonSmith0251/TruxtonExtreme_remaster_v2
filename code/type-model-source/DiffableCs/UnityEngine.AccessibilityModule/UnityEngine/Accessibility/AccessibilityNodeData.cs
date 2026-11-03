namespace UnityEngine.Accessibility;

[NativeHeader("Modules/Accessibility/Bindings/AccessibilityNodeData.bindings.h")]
[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeData.h")]
[NativeType(CodegenOptions::Custom (1), "MonoAccessibilityNodeData")]
[RequiredByNativeCode]
[Token(Token = "0x200000A")]
internal struct AccessibilityNodeData
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000032")]
	private Int32[] <childIds>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000033")]
	private string <label>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000034")]
	private string <value>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000035")]
	private string <hint>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000036")]
	private Rect <frame>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000037")]
	private int <nodeId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000038")]
	private int <parentId>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000039")]
	private AccessibilityRole <role>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x400003A")]
	private AccessibilityState <state>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x400003B")]
	private bool <isActive>k__BackingField; //Field offset: 0x3A
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x400003C")]
	private bool <allowsDirectInteraction>k__BackingField; //Field offset: 0x3B
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400003D")]
	private bool <implementsInvoked>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x400003E")]
	private bool <implementsScrolled>k__BackingField; //Field offset: 0x3D
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3E")]
	[Token(Token = "0x400003F")]
	private bool <implementsDismissed>k__BackingField; //Field offset: 0x3E

	[Token(Token = "0x17000013")]
	public bool allowsDirectInteraction
	{
		[Address(RVA = "0x1D42E70", Offset = "0x1D42270", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600003B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000009")]
	public Int32[] childIds
	{
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000030")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700000D")]
	public Rect frame
	{
		[Address(RVA = "0x1E523A0", Offset = "0x1E517A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000034")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700000C")]
	public string hint
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000033")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000016")]
	public bool implementsDismissed
	{
		[Address(RVA = "0x2F84DD0", Offset = "0x2F841D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600003E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000014")]
	public bool implementsInvoked
	{
		[Address(RVA = "0x101DB80", Offset = "0x101CF80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600003C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000015")]
	public bool implementsScrolled
	{
		[Address(RVA = "0x2F84DE0", Offset = "0x2F841E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600003D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000012")]
	public bool isActive
	{
		[Address(RVA = "0x1EF8790", Offset = "0x1EF7B90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600003A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000A")]
	public string label
	{
		[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000031")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000E")]
	public int nodeId
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000035")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000036")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000F")]
	public int parentId
	{
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000037")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000010")]
	public AccessibilityRole role
	{
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000038")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000011")]
	public AccessibilityState state
	{
		[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000039")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000B")]
	public string value
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000032")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2F84D30", Offset = "0x2F84130", Length = "0xA0")]
	[Token(Token = "0x600002F")]
	public AccessibilityNodeData() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000035")]
	public int get_nodeId() { }

	[Address(RVA = "0x1D42E70", Offset = "0x1D42270", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600003B")]
	public void set_allowsDirectInteraction(bool value) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000030")]
	public void set_childIds(Int32[] value) { }

	[Address(RVA = "0x1E523A0", Offset = "0x1E517A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000034")]
	public void set_frame(Rect value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000033")]
	public void set_hint(string value) { }

	[Address(RVA = "0x2F84DD0", Offset = "0x2F841D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600003E")]
	public void set_implementsDismissed(bool value) { }

	[Address(RVA = "0x101DB80", Offset = "0x101CF80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600003C")]
	public void set_implementsInvoked(bool value) { }

	[Address(RVA = "0x2F84DE0", Offset = "0x2F841E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600003D")]
	public void set_implementsScrolled(bool value) { }

	[Address(RVA = "0x1EF8790", Offset = "0x1EF7B90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600003A")]
	public void set_isActive(bool value) { }

	[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000031")]
	public void set_label(string value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000036")]
	public void set_nodeId(int value) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000037")]
	public void set_parentId(int value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000038")]
	public void set_role(AccessibilityRole value) { }

	[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000039")]
	public void set_state(AccessibilityState value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000032")]
	public void set_value(string value) { }

}

