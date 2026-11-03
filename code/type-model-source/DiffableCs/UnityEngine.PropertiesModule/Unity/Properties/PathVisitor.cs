namespace Unity.Properties;

[Token(Token = "0x2000057")]
public abstract class PathVisitor : IPropertyBagVisitor, IPropertyVisitor
{
	[IsReadOnly]
	[Token(Token = "0x2000058")]
	private struct PropertyScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007E")]
		private readonly PathVisitor m_Visitor; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400007F")]
		private readonly IProperty m_Property; //Field offset: 0x8

		[Address(RVA = "0x315FAC0", Offset = "0x315EEC0", Length = "0x61")]
		[Token(Token = "0x6000149")]
		public PropertyScope(PathVisitor visitor, IProperty property) { }

		[Address(RVA = "0x315FA90", Offset = "0x315EE90", Length = "0x2F")]
		[Token(Token = "0x600014A")]
		public override void Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000079")]
	private int m_PathIndex; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007A")]
	private PropertyPath <Path>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400007B")]
	private IProperty <Property>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400007C")]
	private bool <ReadonlyVisit>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x400007D")]
	private VisitReturnCode <ReturnCode>k__BackingField; //Field offset: 0xB4

	[Token(Token = "0x1700003B")]
	public PropertyPath Path
	{
		[Address(RVA = "0x3142AF0", Offset = "0x3141EF0", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x600013C")]
		 get { } //Length: 84
		[Address(RVA = "0x3142B50", Offset = "0x3141F50", Length = "0x5B")]
		[CompilerGenerated]
		[Token(Token = "0x600013D")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700003C")]
	private IProperty Property
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600013F")]
		private get { } //Length: 8
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000140")]
		private set { } //Length: 19
	}

	[Token(Token = "0x1700003D")]
	public bool ReadonlyVisit
	{
		[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000141")]
		 get { } //Length: 8
		[Address(RVA = "0x6617A0", Offset = "0x660BA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000142")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700003E")]
	public VisitReturnCode ReturnCode
	{
		[Address(RVA = "0x1F7B3D0", Offset = "0x1F7A7D0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000143")]
		 get { } //Length: 7
		[Address(RVA = "0x2D68640", Offset = "0x2D67A40", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000144")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000148")]
	protected PathVisitor() { }

	[Address(RVA = "0x3142AF0", Offset = "0x3141EF0", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x600013C")]
	public PropertyPath get_Path() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600013F")]
	private IProperty get_Property() { }

	[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000141")]
	public bool get_ReadonlyVisit() { }

	[Address(RVA = "0x1F7B3D0", Offset = "0x1F7A7D0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000143")]
	public VisitReturnCode get_ReturnCode() { }

	[Address(RVA = "0x3142A90", Offset = "0x3141E90", Length = "0x5F")]
	[Token(Token = "0x600013E")]
	public override void Reset() { }

	[Address(RVA = "0x3142B50", Offset = "0x3141F50", Length = "0x5B")]
	[CompilerGenerated]
	[Token(Token = "0x600013D")]
	public void set_Path(PropertyPath value) { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000140")]
	private void set_Property(IProperty value) { }

	[Address(RVA = "0x6617A0", Offset = "0x660BA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000142")]
	public void set_ReadonlyVisit(bool value) { }

	[Address(RVA = "0x2D68640", Offset = "0x2D67A40", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000144")]
	protected void set_ReturnCode(VisitReturnCode value) { }

	[Address(RVA = "0x89E130", Offset = "0x89D530", Length = "0xA72")]
	[Token(Token = "0x6000145")]
	private override void Unity.Properties.IPropertyBagVisitor.Visit(IPropertyBag<TContainer> properties, ref TContainer container) { }

	[Address(RVA = "0x89F650", Offset = "0x89EA50", Length = "0x260")]
	[Token(Token = "0x6000146")]
	private override void Unity.Properties.IPropertyVisitor.Visit(Property<TContainer, TValue> property, ref TContainer container) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000147")]
	protected override void VisitPath(Property<TContainer, TValue> property, ref TContainer container, ref TValue value) { }

}

