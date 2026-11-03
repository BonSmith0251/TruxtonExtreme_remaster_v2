namespace UnityEngine.UIElements;

[Token(Token = "0x2000305")]
public struct FilterFunction : IEquatable<FilterFunction>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000C57")]
	private FilterFunctionType m_Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000C58")]
	private FixedBuffer4<FilterParameter> m_Parameters; //Field offset: 0x4
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x4000C59")]
	private int m_ParameterCount; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000C5A")]
	private FilterFunctionDefinition m_CustomDefinition; //Field offset: 0x68

	[Token(Token = "0x17000470")]
	public FilterFunctionDefinition customDefinition
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x600158D")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x600158E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700046F")]
	public int parameterCount
	{
		[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
		[Token(Token = "0x600158C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700046E")]
	internal FixedBuffer4<FilterParameter> parameters
	{
		[Address(RVA = "0x32366A0", Offset = "0x3235AA0", Length = "0x33")]
		[Token(Token = "0x600158B")]
		internal get { } //Length: 51
	}

	[Token(Token = "0x1700046D")]
	public FilterFunctionType type
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6001589")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x600158A")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x32364E0", Offset = "0x32358E0", Length = "0x1BA")]
	[Token(Token = "0x6001591")]
	internal FilterFunction(FilterFunctionType type, FixedBuffer4<FilterParameter> parameters, int paramCount) { }

	[Address(RVA = "0x3235EB0", Offset = "0x32352B0", Length = "0x62C")]
	[Token(Token = "0x6001592")]
	internal FilterFunction(FilterFunctionDefinition customDefinition, FixedBuffer4<FilterParameter> parameters, int paramCount) { }

	[Address(RVA = "0x3235860", Offset = "0x3234C60", Length = "0xD7")]
	[Token(Token = "0x600158F")]
	public void AddParameter(FilterParameter p) { }

	[Address(RVA = "0x3235940", Offset = "0x3234D40", Length = "0x8")]
	[Token(Token = "0x6001590")]
	public void ClearParameters() { }

	[Address(RVA = "0x3235950", Offset = "0x3234D50", Length = "0x13C")]
	[Token(Token = "0x6001597")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3235A90", Offset = "0x3234E90", Length = "0x9A")]
	[Token(Token = "0x6001596")]
	public override bool Equals(FilterFunction other) { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x600158D")]
	public FilterFunctionDefinition get_customDefinition() { }

	[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
	[Token(Token = "0x600158C")]
	public int get_parameterCount() { }

	[Address(RVA = "0x32366A0", Offset = "0x3235AA0", Length = "0x33")]
	[Token(Token = "0x600158B")]
	internal FixedBuffer4<FilterParameter> get_parameters() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6001589")]
	public FilterFunctionType get_type() { }

	[Address(RVA = "0x3235B30", Offset = "0x3234F30", Length = "0x13")]
	[Token(Token = "0x6001593")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal FilterFunctionDefinition GetDefinition() { }

	[Address(RVA = "0x3235B50", Offset = "0x3234F50", Length = "0x107")]
	[Token(Token = "0x6001598")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x32366E0", Offset = "0x3235AE0", Length = "0x197")]
	[Token(Token = "0x6001594")]
	public static bool op_Equality(FilterFunction lhs, FilterFunction rhs) { }

	[Address(RVA = "0x3236880", Offset = "0x3235C80", Length = "0x9C")]
	[Token(Token = "0x6001595")]
	public static bool op_Inequality(FilterFunction lhs, FilterFunction rhs) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x600158E")]
	public void set_customDefinition(FilterFunctionDefinition value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x600158A")]
	public void set_type(FilterFunctionType value) { }

	[Address(RVA = "0x3235C60", Offset = "0x3235060", Length = "0x241")]
	[Token(Token = "0x6001599")]
	public virtual string ToString() { }

}

