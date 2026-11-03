namespace Unity.Properties;

[Token(Token = "0x2000041")]
public abstract class PropertyBag : IPropertyBag<TContainer>, IPropertyBag, IPropertyBagRegister, IConstructor<TContainer>, IConstructor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005F")]
	private readonly InstantiationKind <InstantiationKind>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000032")]
	protected override InstantiationKind InstantiationKind
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000101")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000031")]
	private override InstantiationKind Unity.Properties.IConstructor.InstantiationKind
	{
		[Address(RVA = "0xE37F60", Offset = "0xE37360", Length = "0x14")]
		[Token(Token = "0x60000FD")]
		private get { } //Length: 20
	}

	[Address(RVA = "0xE3A150", Offset = "0xE39550", Length = "0xEE")]
	[Token(Token = "0x60000F6")]
	private static PropertyBag`1() { }

	[Address(RVA = "0xE3A240", Offset = "0xE39640", Length = "0xE")]
	[Token(Token = "0x6000103")]
	protected PropertyBag`1() { }

	[Address(RVA = "0xE37CA0", Offset = "0xE370A0", Length = "0x6D")]
	[Token(Token = "0x60000F8")]
	public override void Accept(ITypeVisitor visitor) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000101")]
	protected override InstantiationKind get_InstantiationKind() { }

	[Token(Token = "0x60000FF")]
	public abstract PropertyCollection<TContainer> GetProperties() { }

	[Token(Token = "0x6000100")]
	public abstract PropertyCollection<TContainer> GetProperties(ref TContainer container) { }

	[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
	[Token(Token = "0x6000102")]
	protected override TContainer Instantiate() { }

	[Address(RVA = "0xE37F60", Offset = "0xE37360", Length = "0x14")]
	[Token(Token = "0x60000FD")]
	private override InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }

	[Address(RVA = "0xE37DF0", Offset = "0xE371F0", Length = "0x14")]
	[Token(Token = "0x60000FE")]
	private override TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }

	[Address(RVA = "0xE39F20", Offset = "0xE39320", Length = "0x62")]
	[Token(Token = "0x60000F7")]
	private override void Unity.Properties.Internal.IPropertyBagRegister.Register() { }

	[Address(RVA = "0xE38B50", Offset = "0xE37F50", Length = "0x1E8")]
	[Token(Token = "0x60000F9")]
	private override void Unity.Properties.IPropertyBag.Accept(IPropertyBagVisitor visitor, ref object container) { }

	[Address(RVA = "0xE37F80", Offset = "0xE37380", Length = "0xD8")]
	[Token(Token = "0x60000FA")]
	private override void Unity.Properties.IPropertyBag<TContainer>.Accept(IPropertyBagVisitor visitor, ref TContainer container) { }

	[Address(RVA = "0xE38110", Offset = "0xE37510", Length = "0x52")]
	[Token(Token = "0x60000FB")]
	private override PropertyCollection<TContainer> Unity.Properties.IPropertyBag<TContainer>.GetProperties() { }

	[Address(RVA = "0xE382E0", Offset = "0xE376E0", Length = "0x52")]
	[Token(Token = "0x60000FC")]
	private override PropertyCollection<TContainer> Unity.Properties.IPropertyBag<TContainer>.GetProperties(ref TContainer container) { }

}

