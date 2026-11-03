namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000664")]
internal class AutoCompletePathVisitor : ITypeVisitor, IPropertyVisitor, IPropertyBagVisitor, IListPropertyVisitor
{
	[Token(Token = "0x2000666")]
	private struct InspectedTypeScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40017F8")]
		private VisitContext m_VisitContext; //Field offset: 0x0

		[Address(RVA = "0x1CBDC50", Offset = "0x1CBD050", Length = "0xB8")]
		[Token(Token = "0x6002D7C")]
		public InspectedTypeScope`1(VisitContext context) { }

		[Address(RVA = "0x1CBBD60", Offset = "0x1CBB160", Length = "0xA7")]
		[Token(Token = "0x6002D7D")]
		public override void Dispose() { }

	}

	[Token(Token = "0x2000665")]
	private class VisitContext
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017F4")]
		private List<PropertyPathInfo> <propertyPathInfos>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40017F5")]
		private readonly HashSet<Type> <types>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40017F6")]
		private PropertyPath <current>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40017F7")]
		private int <currentDepth>k__BackingField; //Field offset: 0xB0

		[Token(Token = "0x17000B95")]
		public PropertyPath current
		{
			[Address(RVA = "0x33740E0", Offset = "0x33734E0", Length = "0x57")]
			[CompilerGenerated]
			[Token(Token = "0x6002D77")]
			 get { } //Length: 87
			[Address(RVA = "0x3374140", Offset = "0x3373540", Length = "0x5E")]
			[CompilerGenerated]
			[Token(Token = "0x6002D78")]
			 set { } //Length: 94
		}

		[Token(Token = "0x17000B96")]
		public int currentDepth
		{
			[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x6002D79")]
			 get { } //Length: 7
			[Address(RVA = "0x1D58B00", Offset = "0x1D57F00", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x6002D7A")]
			 set { } //Length: 7
		}

		[Token(Token = "0x17000B93")]
		public List<PropertyPathInfo> propertyPathInfos
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002D74")]
			 get { } //Length: 5
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6002D75")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000B94")]
		public HashSet<Type> types
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6002D76")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x3374060", Offset = "0x3373460", Length = "0x77")]
		[Token(Token = "0x6002D7B")]
		public VisitContext() { }

		[Address(RVA = "0x33740E0", Offset = "0x33734E0", Length = "0x57")]
		[CompilerGenerated]
		[Token(Token = "0x6002D77")]
		public PropertyPath get_current() { }

		[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6002D79")]
		public int get_currentDepth() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002D74")]
		public List<PropertyPathInfo> get_propertyPathInfos() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002D76")]
		public HashSet<Type> get_types() { }

		[Address(RVA = "0x3374140", Offset = "0x3373540", Length = "0x5E")]
		[CompilerGenerated]
		[Token(Token = "0x6002D78")]
		public void set_current(PropertyPath value) { }

		[Address(RVA = "0x1D58B00", Offset = "0x1D57F00", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6002D7A")]
		public void set_currentDepth(int value) { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002D75")]
		public void set_propertyPathInfos(List<PropertyPathInfo> value) { }

	}

	[Token(Token = "0x2000667")]
	private struct VisitedPropertyScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40017F9")]
		private VisitContext m_VisitContext; //Field offset: 0x0

		[Address(RVA = "0x3374680", Offset = "0x3373A80", Length = "0x376")]
		[Token(Token = "0x6002D7E")]
		public VisitedPropertyScope(VisitContext context, IProperty property) { }

		[Address(RVA = "0x3374330", Offset = "0x3373730", Length = "0x345")]
		[Token(Token = "0x6002D7F")]
		public VisitedPropertyScope(VisitContext context, int index, Type type) { }

		[Address(RVA = "0x33741A0", Offset = "0x33735A0", Length = "0x18C")]
		[Token(Token = "0x6002D80")]
		public override void Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017F2")]
	private VisitContext m_VisitContext; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017F3")]
	private int <maxDepth>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000B92")]
	public int maxDepth
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002D6B")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x335D910", Offset = "0x335CD10", Length = "0xC6")]
	[Token(Token = "0x6002D73")]
	public AutoCompletePathVisitor() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002D6B")]
	public int get_maxDepth() { }

	[Address(RVA = "0x335D460", Offset = "0x335C860", Length = "0x75")]
	[Token(Token = "0x6002D6C")]
	private bool HasReachedEnd(Type containerType) { }

	[Address(RVA = "0x335D4E0", Offset = "0x335C8E0", Length = "0xC5")]
	[Token(Token = "0x6002D6D")]
	public void Reset() { }

	[Address(RVA = "0x746160", Offset = "0x745560", Length = "0x4F")]
	[Token(Token = "0x6002D71")]
	private override void Unity.Properties.IListPropertyVisitor.Visit(Property<TContainer, TList> property, ref TContainer container, ref TList list) { }

	[Address(RVA = "0x750A00", Offset = "0x74FE00", Length = "0x68E")]
	[Token(Token = "0x6002D6F")]
	private override void Unity.Properties.IPropertyBagVisitor.Visit(IPropertyBag<TContainer> properties, ref TContainer container) { }

	[Address(RVA = "0x77A0E0", Offset = "0x7794E0", Length = "0x250")]
	[Token(Token = "0x6002D70")]
	private override void Unity.Properties.IPropertyVisitor.Visit(Property<TContainer, TValue> property, ref TContainer container) { }

	[Address(RVA = "0x786B50", Offset = "0x785F50", Length = "0x450")]
	[Token(Token = "0x6002D6E")]
	private override void Unity.Properties.ITypeVisitor.Visit() { }

	[Address(RVA = "0x335D5B0", Offset = "0x335C9B0", Length = "0x359")]
	[Token(Token = "0x6002D72")]
	private void VisitPropertyType(Type type) { }

}

