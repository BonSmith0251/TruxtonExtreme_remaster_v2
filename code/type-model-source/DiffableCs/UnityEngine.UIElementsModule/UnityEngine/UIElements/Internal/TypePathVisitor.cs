namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000668")]
internal class TypePathVisitor : ITypeVisitor, IPropertyBagVisitor, IPropertyVisitor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017FA")]
	private PropertyPath <Path>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40017FB")]
	private Type <resolvedType>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40017FC")]
	private VisitReturnCode <ReturnCode>k__BackingField; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40017FD")]
	private Type m_LastType; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40017FE")]
	private int m_PathIndex; //Field offset: 0xB8

	[Token(Token = "0x17000B97")]
	public PropertyPath Path
	{
		[Address(RVA = "0x198B0B0", Offset = "0x198A4B0", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x6002D81")]
		 get { } //Length: 84
		[Address(RVA = "0x3372FE0", Offset = "0x33723E0", Length = "0x5B")]
		[CompilerGenerated]
		[Token(Token = "0x6002D82")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000B98")]
	private Type resolvedType
	{
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002D83")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000B99")]
	public internal VisitReturnCode ReturnCode
	{
		[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6002D84")]
		 get { } //Length: 7
		[Address(RVA = "0x2C9FC60", Offset = "0x2C9F060", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6002D85")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002D8C")]
	public TypePathVisitor() { }

	[Address(RVA = "0x198B0B0", Offset = "0x198A4B0", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x6002D81")]
	public PropertyPath get_Path() { }

	[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6002D84")]
	public VisitReturnCode get_ReturnCode() { }

	[Address(RVA = "0x3372CF0", Offset = "0x33720F0", Length = "0x1BC")]
	[Token(Token = "0x6002D8B")]
	private static Type GetElementType(Type type) { }

	[Address(RVA = "0x3372EB0", Offset = "0x33722B0", Length = "0x92")]
	[Token(Token = "0x6002D8A")]
	private bool IsLastPartReached() { }

	[Address(RVA = "0x3372F50", Offset = "0x3372350", Length = "0x88")]
	[Token(Token = "0x6002D86")]
	public void Reset() { }

	[Address(RVA = "0x3372FE0", Offset = "0x33723E0", Length = "0x5B")]
	[CompilerGenerated]
	[Token(Token = "0x6002D82")]
	public void set_Path(PropertyPath value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002D83")]
	private void set_resolvedType(Type value) { }

	[Address(RVA = "0x2C9FC60", Offset = "0x2C9F060", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6002D85")]
	internal void set_ReturnCode(VisitReturnCode value) { }

	[Address(RVA = "0x9712E0", Offset = "0x9706E0", Length = "0x6E8")]
	[Token(Token = "0x6002D87")]
	private override void Unity.Properties.IPropertyBagVisitor.Visit(IPropertyBag<TContainer> properties, ref TContainer container) { }

	[Address(RVA = "0x97FB80", Offset = "0x97EF80", Length = "0x1CC")]
	[Token(Token = "0x6002D88")]
	private override void Unity.Properties.IPropertyVisitor.Visit(Property<TContainer, TValue> property, ref TContainer container) { }

	[Address(RVA = "0x995180", Offset = "0x994580", Length = "0x6CD")]
	[Token(Token = "0x6002D89")]
	private override void Unity.Properties.ITypeVisitor.Visit() { }

}

