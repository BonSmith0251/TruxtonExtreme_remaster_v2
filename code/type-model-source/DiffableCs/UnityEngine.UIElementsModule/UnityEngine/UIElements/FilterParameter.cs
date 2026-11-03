namespace UnityEngine.UIElements;

[Token(Token = "0x2000304")]
public struct FilterParameter : IEquatable<FilterParameter>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000C54")]
	private FilterParameterType m_Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000C55")]
	private float m_FloatValue; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000C56")]
	private Color m_ColorValue; //Field offset: 0x8

	[Token(Token = "0x1700046C")]
	public Color colorValue
	{
		[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
		[Token(Token = "0x6001581")]
		 get { } //Length: 11
		[Address(RVA = "0x1FF58F0", Offset = "0x1FF4CF0", Length = "0x8")]
		[Token(Token = "0x6001582")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700046B")]
	public float floatValue
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[Token(Token = "0x600157F")]
		 get { } //Length: 388
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[Token(Token = "0x6001580")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700046A")]
	public FilterParameterType type
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x600157D")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x600157E")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x3236920", Offset = "0x3235D20", Length = "0x130")]
	[Token(Token = "0x6001585")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3236A60", Offset = "0x3235E60", Length = "0xB2")]
	[Token(Token = "0x6001586")]
	public override bool Equals(FilterParameter other) { }

	[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
	[Token(Token = "0x6001581")]
	public Color get_colorValue() { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[Token(Token = "0x600157F")]
	public float get_floatValue() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x600157D")]
	public FilterParameterType get_type() { }

	[Address(RVA = "0x3236B20", Offset = "0x3235F20", Length = "0x9D")]
	[Token(Token = "0x6001587")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3236C50", Offset = "0x3236050", Length = "0x88")]
	[Token(Token = "0x6001583")]
	public static bool op_Equality(FilterParameter a, FilterParameter b) { }

	[Address(RVA = "0x3236CE0", Offset = "0x32360E0", Length = "0xBC")]
	[Token(Token = "0x6001584")]
	public static bool op_Inequality(FilterParameter a, FilterParameter b) { }

	[Address(RVA = "0x1FF58F0", Offset = "0x1FF4CF0", Length = "0x8")]
	[Token(Token = "0x6001582")]
	public void set_colorValue(Color value) { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[Token(Token = "0x6001580")]
	public void set_floatValue(float value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x600157E")]
	public void set_type(FilterParameterType value) { }

	[Address(RVA = "0x3236BC0", Offset = "0x3235FC0", Length = "0x90")]
	[Token(Token = "0x6001588")]
	public virtual string ToString() { }

}

