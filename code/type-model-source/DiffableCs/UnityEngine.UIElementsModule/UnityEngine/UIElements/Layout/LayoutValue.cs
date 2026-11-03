namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x2000622")]
internal struct LayoutValue
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001686")]
	private float value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4001687")]
	private LayoutUnit unit; //Field offset: 0x4

	[Token(Token = "0x17000AF2")]
	public LayoutUnit Unit
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x6002B7E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000AF3")]
	public float Value
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x6002B7F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3323ED0", Offset = "0x33232D0", Length = "0x16")]
	[Token(Token = "0x6002B85")]
	public static LayoutValue Auto() { }

	[Address(RVA = "0x3323FE0", Offset = "0x33233E0", Length = "0x58")]
	[Token(Token = "0x6002B81")]
	public bool Equals(LayoutValue other) { }

	[Address(RVA = "0x3323EF0", Offset = "0x33232F0", Length = "0xE3")]
	[Token(Token = "0x6002B82")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x6002B7E")]
	public LayoutUnit get_Unit() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x6002B7F")]
	public float get_Value() { }

	[Address(RVA = "0x3324040", Offset = "0x3323440", Length = "0x2E")]
	[Token(Token = "0x6002B83")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x33240A0", Offset = "0x33234A0", Length = "0x23")]
	[Token(Token = "0x6002B87")]
	public static LayoutValue op_Implicit(float value) { }

	[Address(RVA = "0x3324070", Offset = "0x3323470", Length = "0x28")]
	[Token(Token = "0x6002B86")]
	public static LayoutValue Percent(float value) { }

	[Address(RVA = "0x33240A0", Offset = "0x33234A0", Length = "0x23")]
	[Token(Token = "0x6002B80")]
	public static LayoutValue Point(float value) { }

	[Address(RVA = "0x33240D0", Offset = "0x33234D0", Length = "0xF")]
	[Token(Token = "0x6002B84")]
	public static LayoutValue Undefined() { }

}

