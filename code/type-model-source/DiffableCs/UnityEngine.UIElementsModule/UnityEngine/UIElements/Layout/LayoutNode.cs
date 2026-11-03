namespace UnityEngine.UIElements.Layout;

[DefaultMember("Item")]
[Token(Token = "0x20005F9")]
internal struct LayoutNode : IEquatable<LayoutNode>
{
	[Token(Token = "0x40015E3")]
	private const int k_DefaultChildCapacity = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015E4")]
	private readonly LayoutDataAccess m_Access; //Field offset: 0x0
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40015E5")]
	private readonly LayoutHandle m_Handle; //Field offset: 0x38

	[Token(Token = "0x17000ABA")]
	public LayoutAlign AlignContent
	{
		[Address(RVA = "0x3322D80", Offset = "0x3322180", Length = "0x47")]
		[Token(Token = "0x6002AEA")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000AB8")]
	public LayoutAlign AlignItems
	{
		[Address(RVA = "0x3322DD0", Offset = "0x33221D0", Length = "0x47")]
		[Token(Token = "0x6002AE8")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000AB9")]
	public LayoutAlign AlignSelf
	{
		[Address(RVA = "0x3322E20", Offset = "0x3322220", Length = "0x47")]
		[Token(Token = "0x6002AE9")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000AC6")]
	public float AspectRatio
	{
		[Address(RVA = "0x3322E70", Offset = "0x3322270", Length = "0x55")]
		[Token(Token = "0x6002AF6")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000AD7")]
	public float BorderBottomWidth
	{
		[Address(RVA = "0x3322ED0", Offset = "0x33222D0", Length = "0x58")]
		[Token(Token = "0x6002B07")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000AD4")]
	public float BorderLeftWidth
	{
		[Address(RVA = "0x3322F30", Offset = "0x3322330", Length = "0x58")]
		[Token(Token = "0x6002B04")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000AD6")]
	public float BorderRightWidth
	{
		[Address(RVA = "0x3322F90", Offset = "0x3322390", Length = "0x58")]
		[Token(Token = "0x6002B06")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000AD5")]
	public float BorderTopWidth
	{
		[Address(RVA = "0x3322FF0", Offset = "0x33223F0", Length = "0x58")]
		[Token(Token = "0x6002B05")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000ACB")]
	public LayoutValue Bottom
	{
		[Address(RVA = "0x3323050", Offset = "0x3322450", Length = "0x10")]
		[Token(Token = "0x6002AFB")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000ADD")]
	internal LayoutCacheData Cache
	{
		[Address(RVA = "0x3322670", Offset = "0x3321A70", Length = "0xC")]
		[Token(Token = "0x6002B1A")]
		internal get { } //Length: 12
	}

	[Token(Token = "0x17000AB3")]
	private LayoutList<LayoutHandle> Children
	{
		[Address(RVA = "0x3322680", Offset = "0x3321A80", Length = "0x19")]
		[Token(Token = "0x6002AE0")]
		private get { } //Length: 25
	}

	[Token(Token = "0x17000AB1")]
	public float ComputedFlexBasis
	{
		[Address(RVA = "0x33226A0", Offset = "0x3321AA0", Length = "0x1A")]
		[Token(Token = "0x6002ADC")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000AE1")]
	public LayoutConfig Config
	{
		[Address(RVA = "0x33226C0", Offset = "0x3321AC0", Length = "0x76")]
		[Token(Token = "0x6002B23")]
		 get { } //Length: 118
		[Address(RVA = "0x3323060", Offset = "0x3322460", Length = "0x23")]
		[Token(Token = "0x6002B24")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000AB4")]
	public int Count
	{
		[Address(RVA = "0x3322740", Offset = "0x3321B40", Length = "0xD4")]
		[Token(Token = "0x6002AE1")]
		 get { } //Length: 212
	}

	[Token(Token = "0x17000AB7")]
	public LayoutDisplay Display
	{
		[Address(RVA = "0x3323090", Offset = "0x3322490", Length = "0x47")]
		[Token(Token = "0x6002AE7")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000ABF")]
	public LayoutValue FlexBasis
	{
		[Address(RVA = "0x33230E0", Offset = "0x33224E0", Length = "0x38")]
		[Token(Token = "0x6002AEF")]
		 set { } //Length: 56
	}

	[Token(Token = "0x17000AB5")]
	public LayoutFlexDirection FlexDirection
	{
		[Address(RVA = "0x3323120", Offset = "0x3322520", Length = "0x47")]
		[Token(Token = "0x6002AE5")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000ABD")]
	public float FlexGrow
	{
		[Address(RVA = "0x3323170", Offset = "0x3322570", Length = "0x55")]
		[Token(Token = "0x6002AED")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000ABE")]
	public float FlexShrink
	{
		[Address(RVA = "0x33231D0", Offset = "0x33225D0", Length = "0x55")]
		[Token(Token = "0x6002AEE")]
		 set { } //Length: 85
	}

	[Token(Token = "0x17000ADA")]
	public LayoutHandle Handle
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6002B17")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000ADF")]
	public bool HasNewLayout
	{
		[Address(RVA = "0x3322820", Offset = "0x3321C20", Length = "0x1D")]
		[Token(Token = "0x6002B1D")]
		 get { } //Length: 29
		[Address(RVA = "0x3323230", Offset = "0x3322630", Length = "0x33")]
		[Token(Token = "0x6002B1E")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000AC1")]
	public LayoutValue Height
	{
		[Address(RVA = "0x3323270", Offset = "0x3322670", Length = "0x5A")]
		[Token(Token = "0x6002AF1")]
		 set { } //Length: 90
	}

	[Token(Token = "0x17000ADE")]
	public bool IsDirty
	{
		[Address(RVA = "0x3322840", Offset = "0x3321C40", Length = "0x1B")]
		[Token(Token = "0x6002B1B")]
		 get { } //Length: 27
		[Address(RVA = "0x33232D0", Offset = "0x33226D0", Length = "0x33")]
		[Token(Token = "0x6002B1C")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000AD9")]
	public bool IsUndefined
	{
		[Address(RVA = "0x3322860", Offset = "0x3321C60", Length = "0x10")]
		[Token(Token = "0x6002B16")]
		 get { } //Length: 16
	}

	[Token(Token = "0x17000AB6")]
	public LayoutJustify JustifyContent
	{
		[Address(RVA = "0x3323310", Offset = "0x3322710", Length = "0x47")]
		[Token(Token = "0x6002AE6")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000ADB")]
	public LayoutComputedData Layout
	{
		[Address(RVA = "0x3322BD0", Offset = "0x3321FD0", Length = "0xC")]
		[Token(Token = "0x6002B18")]
		 get { } //Length: 12
	}

	[Token(Token = "0x17000AB0")]
	public float LayoutBorderBottom
	{
		[Address(RVA = "0x3322870", Offset = "0x3321C70", Length = "0x1A")]
		[Token(Token = "0x6002ADB")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000AAD")]
	public float LayoutBorderLeft
	{
		[Address(RVA = "0x3322890", Offset = "0x3321C90", Length = "0x4C")]
		[Token(Token = "0x6002AD8")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000AAF")]
	public float LayoutBorderRight
	{
		[Address(RVA = "0x33228E0", Offset = "0x3321CE0", Length = "0x4C")]
		[Token(Token = "0x6002ADA")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000AAE")]
	public float LayoutBorderTop
	{
		[Address(RVA = "0x3322930", Offset = "0x3321D30", Length = "0x1A")]
		[Token(Token = "0x6002AD9")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000AA2")]
	public float LayoutBottom
	{
		[Address(RVA = "0x3322950", Offset = "0x3321D50", Length = "0x1A")]
		[Token(Token = "0x6002ACD")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000AA4")]
	public float LayoutHeight
	{
		[Address(RVA = "0x3322970", Offset = "0x3321D70", Length = "0x1A")]
		[Token(Token = "0x6002ACF")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000AA8")]
	public float LayoutMarginBottom
	{
		[Address(RVA = "0x3322990", Offset = "0x3321D90", Length = "0x1A")]
		[Token(Token = "0x6002AD3")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000AA5")]
	public float LayoutMarginLeft
	{
		[Address(RVA = "0x33229B0", Offset = "0x3321DB0", Length = "0x4C")]
		[Token(Token = "0x6002AD0")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000AA7")]
	public float LayoutMarginRight
	{
		[Address(RVA = "0x3322A00", Offset = "0x3321E00", Length = "0x4C")]
		[Token(Token = "0x6002AD2")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000AA6")]
	public float LayoutMarginTop
	{
		[Address(RVA = "0x3322A50", Offset = "0x3321E50", Length = "0x1A")]
		[Token(Token = "0x6002AD1")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000AAC")]
	public float LayoutPaddingBottom
	{
		[Address(RVA = "0x3322A70", Offset = "0x3321E70", Length = "0x1A")]
		[Token(Token = "0x6002AD7")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000AA9")]
	public float LayoutPaddingLeft
	{
		[Address(RVA = "0x3322A90", Offset = "0x3321E90", Length = "0x4C")]
		[Token(Token = "0x6002AD4")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000AAB")]
	public float LayoutPaddingRight
	{
		[Address(RVA = "0x3322AE0", Offset = "0x3321EE0", Length = "0x4C")]
		[Token(Token = "0x6002AD6")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000AAA")]
	public float LayoutPaddingTop
	{
		[Address(RVA = "0x3322B30", Offset = "0x3321F30", Length = "0x1A")]
		[Token(Token = "0x6002AD5")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000AA1")]
	public float LayoutRight
	{
		[Address(RVA = "0x3322B50", Offset = "0x3321F50", Length = "0x1A")]
		[Token(Token = "0x6002ACC")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000AA3")]
	public float LayoutWidth
	{
		[Address(RVA = "0x3322B70", Offset = "0x3321F70", Length = "0x1A")]
		[Token(Token = "0x6002ACE")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000A9F")]
	public float LayoutX
	{
		[Address(RVA = "0x3322B90", Offset = "0x3321F90", Length = "0x19")]
		[Token(Token = "0x6002ACA")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000AA0")]
	public float LayoutY
	{
		[Address(RVA = "0x3322BB0", Offset = "0x3321FB0", Length = "0x1A")]
		[Token(Token = "0x6002ACB")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000AC8")]
	public LayoutValue Left
	{
		[Address(RVA = "0x3323360", Offset = "0x3322760", Length = "0xD")]
		[Token(Token = "0x6002AF8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000ACF")]
	public LayoutValue MarginBottom
	{
		[Address(RVA = "0x3323370", Offset = "0x3322770", Length = "0x10")]
		[Token(Token = "0x6002AFF")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000ACC")]
	public LayoutValue MarginLeft
	{
		[Address(RVA = "0x3323380", Offset = "0x3322780", Length = "0xD")]
		[Token(Token = "0x6002AFC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000ACE")]
	public LayoutValue MarginRight
	{
		[Address(RVA = "0x3323390", Offset = "0x3322790", Length = "0x10")]
		[Token(Token = "0x6002AFE")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000ACD")]
	public LayoutValue MarginTop
	{
		[Address(RVA = "0x33233A0", Offset = "0x33227A0", Length = "0x10")]
		[Token(Token = "0x6002AFD")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000AC3")]
	public LayoutValue MaxHeight
	{
		[Address(RVA = "0x33233B0", Offset = "0x33227B0", Length = "0x5A")]
		[Token(Token = "0x6002AF3")]
		 set { } //Length: 90
	}

	[Token(Token = "0x17000AC2")]
	public LayoutValue MaxWidth
	{
		[Address(RVA = "0x3323410", Offset = "0x3322810", Length = "0x5A")]
		[Token(Token = "0x6002AF2")]
		 set { } //Length: 90
	}

	[Token(Token = "0x17000AC5")]
	public LayoutValue MinHeight
	{
		[Address(RVA = "0x3323470", Offset = "0x3322870", Length = "0x5A")]
		[Token(Token = "0x6002AF5")]
		 set { } //Length: 90
	}

	[Token(Token = "0x17000AC4")]
	public LayoutValue MinWidth
	{
		[Address(RVA = "0x33234D0", Offset = "0x33228D0", Length = "0x5A")]
		[Token(Token = "0x6002AF4")]
		 set { } //Length: 90
	}

	[Token(Token = "0x17000AC7")]
	public LayoutOverflow Overflow
	{
		[Address(RVA = "0x3323530", Offset = "0x3322930", Length = "0x47")]
		[Token(Token = "0x6002AF7")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000AD3")]
	public LayoutValue PaddingBottom
	{
		[Address(RVA = "0x3323580", Offset = "0x3322980", Length = "0x10")]
		[Token(Token = "0x6002B03")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000AD0")]
	public LayoutValue PaddingLeft
	{
		[Address(RVA = "0x3323590", Offset = "0x3322990", Length = "0xD")]
		[Token(Token = "0x6002B00")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000AD2")]
	public LayoutValue PaddingRight
	{
		[Address(RVA = "0x33235A0", Offset = "0x33229A0", Length = "0x10")]
		[Token(Token = "0x6002B02")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000AD1")]
	public LayoutValue PaddingTop
	{
		[Address(RVA = "0x33235B0", Offset = "0x33229B0", Length = "0x10")]
		[Token(Token = "0x6002B01")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000AB2")]
	public LayoutNode Parent
	{
		[Address(RVA = "0x3322BE0", Offset = "0x3321FE0", Length = "0x76")]
		[Token(Token = "0x6002ADE")]
		 get { } //Length: 118
		[Address(RVA = "0x33235C0", Offset = "0x33229C0", Length = "0x23")]
		[Token(Token = "0x6002ADF")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000ABB")]
	public LayoutPositionType PositionType
	{
		[Address(RVA = "0x33235F0", Offset = "0x33229F0", Length = "0x47")]
		[Token(Token = "0x6002AEB")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000ACA")]
	public LayoutValue Right
	{
		[Address(RVA = "0x3323640", Offset = "0x3322A40", Length = "0x10")]
		[Token(Token = "0x6002AFA")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000ADC")]
	public LayoutStyleData Style
	{
		[Address(RVA = "0x3322C60", Offset = "0x3322060", Length = "0xC")]
		[Token(Token = "0x6002B19")]
		 get { } //Length: 12
	}

	[Token(Token = "0x17000AC9")]
	public LayoutValue Top
	{
		[Address(RVA = "0x3323650", Offset = "0x3322A50", Length = "0x10")]
		[Token(Token = "0x6002AF9")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000AD8")]
	public static LayoutNode Undefined
	{
		[Address(RVA = "0x331C9D0", Offset = "0x331BDD0", Length = "0x30")]
		[Token(Token = "0x6002B14")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000AE0")]
	public bool UsesMeasure
	{
		[Address(RVA = "0x3322C70", Offset = "0x3322070", Length = "0x1D")]
		[Token(Token = "0x6002B1F")]
		 get { } //Length: 29
		[Address(RVA = "0x3323660", Offset = "0x3322A60", Length = "0x35")]
		[Token(Token = "0x6002B20")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000AC0")]
	public LayoutValue Width
	{
		[Address(RVA = "0x33236A0", Offset = "0x3322AA0", Length = "0x5A")]
		[Token(Token = "0x6002AF0")]
		 set { } //Length: 90
	}

	[Token(Token = "0x17000ABC")]
	public LayoutWrap Wrap
	{
		[Address(RVA = "0x3323700", Offset = "0x3322B00", Length = "0x47")]
		[Token(Token = "0x6002AEC")]
		 set { } //Length: 71
	}

	[Address(RVA = "0x331C8B0", Offset = "0x331BCB0", Length = "0x25")]
	[Token(Token = "0x6002B15")]
	internal LayoutNode(LayoutDataAccess access, LayoutHandle handle) { }

	[Address(RVA = "0x3320C20", Offset = "0x3320020", Length = "0x1B0")]
	[Token(Token = "0x6002B2E")]
	public void CalculateLayout(float width = NaN, float height = NaN) { }

	[Address(RVA = "0x3320DE0", Offset = "0x33201E0", Length = "0xE9")]
	[Token(Token = "0x6002AE4")]
	public void Clear() { }

	[Address(RVA = "0x3320ED0", Offset = "0x33202D0", Length = "0x841")]
	[Token(Token = "0x6002B27")]
	public void CopyFromComputedStyle(ComputedStyle style) { }

	[Address(RVA = "0x3321760", Offset = "0x3320B60", Length = "0x97")]
	[Token(Token = "0x6002B2A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3321720", Offset = "0x3320B20", Length = "0x34")]
	[Token(Token = "0x6002B29")]
	public override bool Equals(LayoutNode other) { }

	[Address(RVA = "0x3322670", Offset = "0x3321A70", Length = "0xC")]
	[Token(Token = "0x6002B1A")]
	internal LayoutCacheData get_Cache() { }

	[Address(RVA = "0x3322680", Offset = "0x3321A80", Length = "0x19")]
	[Token(Token = "0x6002AE0")]
	private LayoutList<LayoutHandle> get_Children() { }

	[Address(RVA = "0x33226A0", Offset = "0x3321AA0", Length = "0x1A")]
	[Token(Token = "0x6002ADC")]
	public float get_ComputedFlexBasis() { }

	[Address(RVA = "0x33226C0", Offset = "0x3321AC0", Length = "0x76")]
	[Token(Token = "0x6002B23")]
	public LayoutConfig get_Config() { }

	[Address(RVA = "0x3322740", Offset = "0x3321B40", Length = "0xD4")]
	[Token(Token = "0x6002AE1")]
	public int get_Count() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6002B17")]
	public LayoutHandle get_Handle() { }

	[Address(RVA = "0x3322820", Offset = "0x3321C20", Length = "0x1D")]
	[Token(Token = "0x6002B1D")]
	public bool get_HasNewLayout() { }

	[Address(RVA = "0x3322840", Offset = "0x3321C40", Length = "0x1B")]
	[Token(Token = "0x6002B1B")]
	public bool get_IsDirty() { }

	[Address(RVA = "0x3322860", Offset = "0x3321C60", Length = "0x10")]
	[Token(Token = "0x6002B16")]
	public bool get_IsUndefined() { }

	[Address(RVA = "0x3322BD0", Offset = "0x3321FD0", Length = "0xC")]
	[Token(Token = "0x6002B18")]
	public LayoutComputedData get_Layout() { }

	[Address(RVA = "0x3322870", Offset = "0x3321C70", Length = "0x1A")]
	[Token(Token = "0x6002ADB")]
	public float get_LayoutBorderBottom() { }

	[Address(RVA = "0x3322890", Offset = "0x3321C90", Length = "0x4C")]
	[Token(Token = "0x6002AD8")]
	public float get_LayoutBorderLeft() { }

	[Address(RVA = "0x33228E0", Offset = "0x3321CE0", Length = "0x4C")]
	[Token(Token = "0x6002ADA")]
	public float get_LayoutBorderRight() { }

	[Address(RVA = "0x3322930", Offset = "0x3321D30", Length = "0x1A")]
	[Token(Token = "0x6002AD9")]
	public float get_LayoutBorderTop() { }

	[Address(RVA = "0x3322950", Offset = "0x3321D50", Length = "0x1A")]
	[Token(Token = "0x6002ACD")]
	public float get_LayoutBottom() { }

	[Address(RVA = "0x3322970", Offset = "0x3321D70", Length = "0x1A")]
	[Token(Token = "0x6002ACF")]
	public float get_LayoutHeight() { }

	[Address(RVA = "0x3322990", Offset = "0x3321D90", Length = "0x1A")]
	[Token(Token = "0x6002AD3")]
	public float get_LayoutMarginBottom() { }

	[Address(RVA = "0x33229B0", Offset = "0x3321DB0", Length = "0x4C")]
	[Token(Token = "0x6002AD0")]
	public float get_LayoutMarginLeft() { }

	[Address(RVA = "0x3322A00", Offset = "0x3321E00", Length = "0x4C")]
	[Token(Token = "0x6002AD2")]
	public float get_LayoutMarginRight() { }

	[Address(RVA = "0x3322A50", Offset = "0x3321E50", Length = "0x1A")]
	[Token(Token = "0x6002AD1")]
	public float get_LayoutMarginTop() { }

	[Address(RVA = "0x3322A70", Offset = "0x3321E70", Length = "0x1A")]
	[Token(Token = "0x6002AD7")]
	public float get_LayoutPaddingBottom() { }

	[Address(RVA = "0x3322A90", Offset = "0x3321E90", Length = "0x4C")]
	[Token(Token = "0x6002AD4")]
	public float get_LayoutPaddingLeft() { }

	[Address(RVA = "0x3322AE0", Offset = "0x3321EE0", Length = "0x4C")]
	[Token(Token = "0x6002AD6")]
	public float get_LayoutPaddingRight() { }

	[Address(RVA = "0x3322B30", Offset = "0x3321F30", Length = "0x1A")]
	[Token(Token = "0x6002AD5")]
	public float get_LayoutPaddingTop() { }

	[Address(RVA = "0x3322B50", Offset = "0x3321F50", Length = "0x1A")]
	[Token(Token = "0x6002ACC")]
	public float get_LayoutRight() { }

	[Address(RVA = "0x3322B70", Offset = "0x3321F70", Length = "0x1A")]
	[Token(Token = "0x6002ACE")]
	public float get_LayoutWidth() { }

	[Address(RVA = "0x3322B90", Offset = "0x3321F90", Length = "0x19")]
	[Token(Token = "0x6002ACA")]
	public float get_LayoutX() { }

	[Address(RVA = "0x3322BB0", Offset = "0x3321FB0", Length = "0x1A")]
	[Token(Token = "0x6002ACB")]
	public float get_LayoutY() { }

	[Address(RVA = "0x3322BE0", Offset = "0x3321FE0", Length = "0x76")]
	[Token(Token = "0x6002ADE")]
	public LayoutNode get_Parent() { }

	[Address(RVA = "0x3322C60", Offset = "0x3322060", Length = "0xC")]
	[Token(Token = "0x6002B19")]
	public LayoutStyleData get_Style() { }

	[Address(RVA = "0x331C9D0", Offset = "0x331BDD0", Length = "0x30")]
	[Token(Token = "0x6002B14")]
	public static LayoutNode get_Undefined() { }

	[Address(RVA = "0x3322C70", Offset = "0x3322070", Length = "0x1D")]
	[Token(Token = "0x6002B1F")]
	public bool get_UsesMeasure() { }

	[Address(RVA = "0x3321800", Offset = "0x3320C00", Length = "0xD")]
	[Token(Token = "0x6002B2B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3316F90", Offset = "0x3316390", Length = "0x72")]
	[Token(Token = "0x6002ADD")]
	private float GetLayoutValue(Single* buffer, LayoutEdge edge) { }

	[Address(RVA = "0x3321810", Offset = "0x3320C10", Length = "0x6F")]
	[Token(Token = "0x6002B22")]
	public VisualElement GetOwner() { }

	[Address(RVA = "0x3321880", Offset = "0x3320C80", Length = "0x12A")]
	[Token(Token = "0x6002AE2")]
	public void Insert(int index, LayoutNode child) { }

	[Address(RVA = "0x33219B0", Offset = "0x3320DB0", Length = "0x1A0")]
	[Token(Token = "0x6002B25")]
	public void MarkDirty() { }

	[Address(RVA = "0x3321B50", Offset = "0x3320F50", Length = "0x19")]
	[Token(Token = "0x6002B26")]
	public void MarkLayoutSeen() { }

	[Address(RVA = "0x3322C90", Offset = "0x3322090", Length = "0x5D")]
	[Token(Token = "0x6002B2C")]
	public static bool op_Equality(LayoutNode lhs, LayoutNode rhs) { }

	[Address(RVA = "0x3322CF0", Offset = "0x33220F0", Length = "0x81")]
	[Token(Token = "0x6002B2D")]
	public static bool op_Inequality(LayoutNode lhs, LayoutNode rhs) { }

	[Address(RVA = "0x3321B70", Offset = "0x3320F70", Length = "0x1C5")]
	[Token(Token = "0x6002AE3")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x3322D80", Offset = "0x3322180", Length = "0x47")]
	[Token(Token = "0x6002AEA")]
	public void set_AlignContent(LayoutAlign value) { }

	[Address(RVA = "0x3322DD0", Offset = "0x33221D0", Length = "0x47")]
	[Token(Token = "0x6002AE8")]
	public void set_AlignItems(LayoutAlign value) { }

	[Address(RVA = "0x3322E20", Offset = "0x3322220", Length = "0x47")]
	[Token(Token = "0x6002AE9")]
	public void set_AlignSelf(LayoutAlign value) { }

	[Address(RVA = "0x3322E70", Offset = "0x3322270", Length = "0x55")]
	[Token(Token = "0x6002AF6")]
	public void set_AspectRatio(float value) { }

	[Address(RVA = "0x3322ED0", Offset = "0x33222D0", Length = "0x58")]
	[Token(Token = "0x6002B07")]
	public void set_BorderBottomWidth(float value) { }

	[Address(RVA = "0x3322F30", Offset = "0x3322330", Length = "0x58")]
	[Token(Token = "0x6002B04")]
	public void set_BorderLeftWidth(float value) { }

	[Address(RVA = "0x3322F90", Offset = "0x3322390", Length = "0x58")]
	[Token(Token = "0x6002B06")]
	public void set_BorderRightWidth(float value) { }

	[Address(RVA = "0x3322FF0", Offset = "0x33223F0", Length = "0x58")]
	[Token(Token = "0x6002B05")]
	public void set_BorderTopWidth(float value) { }

	[Address(RVA = "0x3323050", Offset = "0x3322450", Length = "0x10")]
	[Token(Token = "0x6002AFB")]
	public void set_Bottom(LayoutValue value) { }

	[Address(RVA = "0x3323060", Offset = "0x3322460", Length = "0x23")]
	[Token(Token = "0x6002B24")]
	public void set_Config(LayoutConfig value) { }

	[Address(RVA = "0x3323090", Offset = "0x3322490", Length = "0x47")]
	[Token(Token = "0x6002AE7")]
	public void set_Display(LayoutDisplay value) { }

	[Address(RVA = "0x33230E0", Offset = "0x33224E0", Length = "0x38")]
	[Token(Token = "0x6002AEF")]
	public void set_FlexBasis(LayoutValue value) { }

	[Address(RVA = "0x3323120", Offset = "0x3322520", Length = "0x47")]
	[Token(Token = "0x6002AE5")]
	public void set_FlexDirection(LayoutFlexDirection value) { }

	[Address(RVA = "0x3323170", Offset = "0x3322570", Length = "0x55")]
	[Token(Token = "0x6002AED")]
	public void set_FlexGrow(float value) { }

	[Address(RVA = "0x33231D0", Offset = "0x33225D0", Length = "0x55")]
	[Token(Token = "0x6002AEE")]
	public void set_FlexShrink(float value) { }

	[Address(RVA = "0x3323230", Offset = "0x3322630", Length = "0x33")]
	[Token(Token = "0x6002B1E")]
	public void set_HasNewLayout(bool value) { }

	[Address(RVA = "0x3323270", Offset = "0x3322670", Length = "0x5A")]
	[Token(Token = "0x6002AF1")]
	public void set_Height(LayoutValue value) { }

	[Address(RVA = "0x33232D0", Offset = "0x33226D0", Length = "0x33")]
	[Token(Token = "0x6002B1C")]
	public void set_IsDirty(bool value) { }

	[Address(RVA = "0x3323310", Offset = "0x3322710", Length = "0x47")]
	[Token(Token = "0x6002AE6")]
	public void set_JustifyContent(LayoutJustify value) { }

	[Address(RVA = "0x3323360", Offset = "0x3322760", Length = "0xD")]
	[Token(Token = "0x6002AF8")]
	public void set_Left(LayoutValue value) { }

	[Address(RVA = "0x3323370", Offset = "0x3322770", Length = "0x10")]
	[Token(Token = "0x6002AFF")]
	public void set_MarginBottom(LayoutValue value) { }

	[Address(RVA = "0x3323380", Offset = "0x3322780", Length = "0xD")]
	[Token(Token = "0x6002AFC")]
	public void set_MarginLeft(LayoutValue value) { }

	[Address(RVA = "0x3323390", Offset = "0x3322790", Length = "0x10")]
	[Token(Token = "0x6002AFE")]
	public void set_MarginRight(LayoutValue value) { }

	[Address(RVA = "0x33233A0", Offset = "0x33227A0", Length = "0x10")]
	[Token(Token = "0x6002AFD")]
	public void set_MarginTop(LayoutValue value) { }

	[Address(RVA = "0x33233B0", Offset = "0x33227B0", Length = "0x5A")]
	[Token(Token = "0x6002AF3")]
	public void set_MaxHeight(LayoutValue value) { }

	[Address(RVA = "0x3323410", Offset = "0x3322810", Length = "0x5A")]
	[Token(Token = "0x6002AF2")]
	public void set_MaxWidth(LayoutValue value) { }

	[Address(RVA = "0x3323470", Offset = "0x3322870", Length = "0x5A")]
	[Token(Token = "0x6002AF5")]
	public void set_MinHeight(LayoutValue value) { }

	[Address(RVA = "0x33234D0", Offset = "0x33228D0", Length = "0x5A")]
	[Token(Token = "0x6002AF4")]
	public void set_MinWidth(LayoutValue value) { }

	[Address(RVA = "0x3323530", Offset = "0x3322930", Length = "0x47")]
	[Token(Token = "0x6002AF7")]
	public void set_Overflow(LayoutOverflow value) { }

	[Address(RVA = "0x3323580", Offset = "0x3322980", Length = "0x10")]
	[Token(Token = "0x6002B03")]
	public void set_PaddingBottom(LayoutValue value) { }

	[Address(RVA = "0x3323590", Offset = "0x3322990", Length = "0xD")]
	[Token(Token = "0x6002B00")]
	public void set_PaddingLeft(LayoutValue value) { }

	[Address(RVA = "0x33235A0", Offset = "0x33229A0", Length = "0x10")]
	[Token(Token = "0x6002B02")]
	public void set_PaddingRight(LayoutValue value) { }

	[Address(RVA = "0x33235B0", Offset = "0x33229B0", Length = "0x10")]
	[Token(Token = "0x6002B01")]
	public void set_PaddingTop(LayoutValue value) { }

	[Address(RVA = "0x33235C0", Offset = "0x33229C0", Length = "0x23")]
	[Token(Token = "0x6002ADF")]
	public void set_Parent(LayoutNode value) { }

	[Address(RVA = "0x33235F0", Offset = "0x33229F0", Length = "0x47")]
	[Token(Token = "0x6002AEB")]
	public void set_PositionType(LayoutPositionType value) { }

	[Address(RVA = "0x3323640", Offset = "0x3322A40", Length = "0x10")]
	[Token(Token = "0x6002AFA")]
	public void set_Right(LayoutValue value) { }

	[Address(RVA = "0x3323650", Offset = "0x3322A50", Length = "0x10")]
	[Token(Token = "0x6002AF9")]
	public void set_Top(LayoutValue value) { }

	[Address(RVA = "0x3323660", Offset = "0x3322A60", Length = "0x35")]
	[Token(Token = "0x6002B20")]
	public void set_UsesMeasure(bool value) { }

	[Address(RVA = "0x33236A0", Offset = "0x3322AA0", Length = "0x5A")]
	[Token(Token = "0x6002AF0")]
	public void set_Width(LayoutValue value) { }

	[Address(RVA = "0x3323700", Offset = "0x3322B00", Length = "0x47")]
	[Token(Token = "0x6002AEC")]
	public void set_Wrap(LayoutWrap value) { }

	[Address(RVA = "0x3321D40", Offset = "0x3321140", Length = "0xF")]
	[Token(Token = "0x6002B21")]
	public void SetOwner(VisualElement func) { }

	[Address(RVA = "0x3321D50", Offset = "0x3321150", Length = "0x1A5")]
	[Token(Token = "0x6002B0F")]
	private void SetStyleEdgeMargin(LayoutEdge edge, LayoutValue value) { }

	[Address(RVA = "0x3321F00", Offset = "0x3321300", Length = "0x123")]
	[Token(Token = "0x6002B10")]
	private void SetStyleEdgePadding(LayoutEdge edge, LayoutValue value) { }

	[Address(RVA = "0x3322030", Offset = "0x3321430", Length = "0x123")]
	[Token(Token = "0x6002B0E")]
	private void SetStyleEdgePosition(LayoutEdge edge, LayoutValue value) { }

	[Address(RVA = "0x3322340", Offset = "0x3321740", Length = "0x126")]
	[Token(Token = "0x6002B09")]
	private void SetStyleValue(ref LayoutValue currentValue, LayoutValue newValue) { }

	[Address(RVA = "0x3322160", Offset = "0x3321560", Length = "0x26")]
	[Token(Token = "0x6002B0D")]
	private void SetStyleValueAuto(ref LayoutValue currentValue) { }

	[Address(RVA = "0x3322190", Offset = "0x3321590", Length = "0x65")]
	[Token(Token = "0x6002B0C")]
	private void SetStyleValuePercent(ref LayoutValue currentValue, LayoutValue newValue) { }

	[Address(RVA = "0x3322200", Offset = "0x3321600", Length = "0xA4")]
	[Token(Token = "0x6002B0B")]
	private void SetStyleValuePoint(ref LayoutValue currentValue, LayoutValue newValue) { }

	[Address(RVA = "0x33222B0", Offset = "0x33216B0", Length = "0x8D")]
	[Token(Token = "0x6002B0A")]
	private void SetStyleValueUnit(ref LayoutValue currentValue, LayoutValue newValue) { }

	[Address(RVA = "0x3322470", Offset = "0x3321870", Length = "0x48")]
	[Token(Token = "0x6002B08")]
	private void SetValue(ref float currentValue, float newValue) { }

	[Address(RVA = "0x33224C0", Offset = "0x33218C0", Length = "0x9C")]
	[Token(Token = "0x6002B28")]
	public void SoftReset() { }

	[Address(RVA = "0x3322160", Offset = "0x3321560", Length = "0x26")]
	[Token(Token = "0x6002B12")]
	private void StyleEdgeSetAuto(ref LayoutValue value) { }

	[Address(RVA = "0x3322560", Offset = "0x3321960", Length = "0x74")]
	[Token(Token = "0x6002B11")]
	private void StyleEdgeSetPercent(ref LayoutValue value, float newValue) { }

	[Address(RVA = "0x33225E0", Offset = "0x33219E0", Length = "0x8B")]
	[Token(Token = "0x6002B13")]
	private void StyleEdgeSetPoint(ref LayoutValue value, float newValue) { }

}

