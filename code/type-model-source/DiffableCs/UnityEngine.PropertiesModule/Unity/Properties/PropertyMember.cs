namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x200001F")]
internal struct PropertyMember : IMemberInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000039")]
	internal readonly PropertyInfo m_PropertyInfo; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400003A")]
	private readonly string <Name>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x1700001C")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x315B3A0", Offset = "0x315A7A0", Length = "0x2E")]
		[Token(Token = "0x6000078")]
		 get { } //Length: 46
	}

	[Token(Token = "0x1700001B")]
	public override string Name
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000077")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001D")]
	public override Type ValueType
	{
		[Address(RVA = "0x315B3D0", Offset = "0x315A7D0", Length = "0x29")]
		[Token(Token = "0x6000079")]
		 get { } //Length: 41
	}

	[Address(RVA = "0x31420C0", Offset = "0x31414C0", Length = "0x30")]
	[Token(Token = "0x600007A")]
	public PropertyMember(PropertyInfo propertyInfo) { }

	[Address(RVA = "0x315B3A0", Offset = "0x315A7A0", Length = "0x2E")]
	[Token(Token = "0x6000078")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000077")]
	public override string get_Name() { }

	[Address(RVA = "0x315B3D0", Offset = "0x315A7D0", Length = "0x29")]
	[Token(Token = "0x6000079")]
	public override Type get_ValueType() { }

	[Address(RVA = "0x3142060", Offset = "0x3141460", Length = "0xA")]
	[Token(Token = "0x600007D")]
	public override IEnumerable<Attribute> GetCustomAttributes() { }

	[Address(RVA = "0x315B360", Offset = "0x315A760", Length = "0x1D")]
	[Token(Token = "0x600007B")]
	public override object GetValue(object obj) { }

	[Address(RVA = "0x315B380", Offset = "0x315A780", Length = "0x1D")]
	[Token(Token = "0x600007C")]
	public override void SetValue(object obj, object value) { }

}

