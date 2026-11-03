namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x200060F")]
internal struct LayoutNodeData
{
	[Flags]
	[Token(Token = "0x2000610")]
	public enum FlexStatus : int
	{
		IsDirty = 1,
		HasNewLayout = 4,
		DependsOnParentSize = 64,
		UsesMeasure = 128,
		UsesBaseline = 256,
		Fixed = 8,
		MinViolation = 16,
		MaxViolation = 32,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001622")]
	public FixedBuffer2<LayoutValue> ResolvedDimensions; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001623")]
	private float TargetSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001624")]
	public int ManagedOwnerIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001625")]
	public int LineIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001626")]
	public LayoutHandle Config; //Field offset: 0x1C
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001627")]
	public LayoutHandle Parent; //Field offset: 0x24
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001628")]
	public LayoutHandle NextChild; //Field offset: 0x2C
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001629")]
	public LayoutList<LayoutHandle> Children; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400162A")]
	private FlexStatus Status; //Field offset: 0x40

	[Token(Token = "0x17000AE8")]
	public bool HasNewLayout
	{
		[Address(RVA = "0x3320B70", Offset = "0x331FF70", Length = "0x9")]
		[Token(Token = "0x6002B65")]
		 get { } //Length: 9
		[Address(RVA = "0x3320BA0", Offset = "0x331FFA0", Length = "0x19")]
		[Token(Token = "0x6002B66")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000AE9")]
	public bool IsDirty
	{
		[Address(RVA = "0x3320B80", Offset = "0x331FF80", Length = "0x7")]
		[Token(Token = "0x6002B67")]
		 get { } //Length: 7
		[Address(RVA = "0x3320BC0", Offset = "0x331FFC0", Length = "0x19")]
		[Token(Token = "0x6002B68")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000AEB")]
	public bool UsesBaseline
	{
		[Address(RVA = "0x3320BE0", Offset = "0x331FFE0", Length = "0x1B")]
		[Token(Token = "0x6002B6B")]
		 set { } //Length: 27
	}

	[Token(Token = "0x17000AEA")]
	public bool UsesMeasure
	{
		[Address(RVA = "0x3320B90", Offset = "0x331FF90", Length = "0x9")]
		[Token(Token = "0x6002B69")]
		 get { } //Length: 9
		[Address(RVA = "0x3320C00", Offset = "0x3320000", Length = "0x1B")]
		[Token(Token = "0x6002B6A")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x3320B70", Offset = "0x331FF70", Length = "0x9")]
	[Token(Token = "0x6002B65")]
	public bool get_HasNewLayout() { }

	[Address(RVA = "0x3320B80", Offset = "0x331FF80", Length = "0x7")]
	[Token(Token = "0x6002B67")]
	public bool get_IsDirty() { }

	[Address(RVA = "0x3320B90", Offset = "0x331FF90", Length = "0x9")]
	[Token(Token = "0x6002B69")]
	public bool get_UsesMeasure() { }

	[Address(RVA = "0x3320BA0", Offset = "0x331FFA0", Length = "0x19")]
	[Token(Token = "0x6002B66")]
	public void set_HasNewLayout(bool value) { }

	[Address(RVA = "0x3320BC0", Offset = "0x331FFC0", Length = "0x19")]
	[Token(Token = "0x6002B68")]
	public void set_IsDirty(bool value) { }

	[Address(RVA = "0x3320BE0", Offset = "0x331FFE0", Length = "0x1B")]
	[Token(Token = "0x6002B6B")]
	public void set_UsesBaseline(bool value) { }

	[Address(RVA = "0x3320C00", Offset = "0x3320000", Length = "0x1B")]
	[Token(Token = "0x6002B6A")]
	public void set_UsesMeasure(bool value) { }

}

