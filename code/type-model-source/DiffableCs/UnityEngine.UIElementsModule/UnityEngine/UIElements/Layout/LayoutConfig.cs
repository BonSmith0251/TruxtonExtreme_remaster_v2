namespace UnityEngine.UIElements.Layout;

[IsReadOnly]
[Token(Token = "0x20005EF")]
internal struct LayoutConfig
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015C0")]
	private readonly LayoutDataAccess m_Access; //Field offset: 0x0
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40015C1")]
	private readonly LayoutHandle m_Handle; //Field offset: 0x38

	[Token(Token = "0x17000A9A")]
	public LayoutBaselineFunction Baseline
	{
		[Address(RVA = "0x331C8E0", Offset = "0x331BCE0", Length = "0x6F")]
		[Token(Token = "0x6002AA0")]
		 get { } //Length: 111
	}

	[Token(Token = "0x17000A97")]
	public LayoutHandle Handle
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6002A9C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000A99")]
	public LayoutMeasureFunction Measure
	{
		[Address(RVA = "0x331C950", Offset = "0x331BD50", Length = "0x6F")]
		[Token(Token = "0x6002A9E")]
		 get { } //Length: 111
		[Address(RVA = "0x331CA00", Offset = "0x331BE00", Length = "0xF")]
		[Token(Token = "0x6002A9F")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000A98")]
	public float PointScaleFactor
	{
		[Address(RVA = "0x331C9C0", Offset = "0x331BDC0", Length = "0xC")]
		[Token(Token = "0x6002A9D")]
		 get { } //Length: 12
	}

	[Token(Token = "0x17000A96")]
	public static LayoutConfig Undefined
	{
		[Address(RVA = "0x331C9D0", Offset = "0x331BDD0", Length = "0x30")]
		[Token(Token = "0x6002A9A")]
		 get { } //Length: 48
	}

	[Address(RVA = "0x331C8B0", Offset = "0x331BCB0", Length = "0x25")]
	[Token(Token = "0x6002A9B")]
	internal LayoutConfig(LayoutDataAccess access, LayoutHandle handle) { }

	[Address(RVA = "0x331C8E0", Offset = "0x331BCE0", Length = "0x6F")]
	[Token(Token = "0x6002AA0")]
	public LayoutBaselineFunction get_Baseline() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6002A9C")]
	public LayoutHandle get_Handle() { }

	[Address(RVA = "0x331C950", Offset = "0x331BD50", Length = "0x6F")]
	[Token(Token = "0x6002A9E")]
	public LayoutMeasureFunction get_Measure() { }

	[Address(RVA = "0x331C9C0", Offset = "0x331BDC0", Length = "0xC")]
	[Token(Token = "0x6002A9D")]
	public float get_PointScaleFactor() { }

	[Address(RVA = "0x331C9D0", Offset = "0x331BDD0", Length = "0x30")]
	[Token(Token = "0x6002A9A")]
	public static LayoutConfig get_Undefined() { }

	[Address(RVA = "0x331CA00", Offset = "0x331BE00", Length = "0xF")]
	[Token(Token = "0x6002A9F")]
	public void set_Measure(LayoutMeasureFunction value) { }

}

