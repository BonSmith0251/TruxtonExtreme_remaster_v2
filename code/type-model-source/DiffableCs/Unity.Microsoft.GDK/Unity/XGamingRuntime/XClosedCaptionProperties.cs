namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20000F1")]
public class XClosedCaptionProperties
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001B5")]
	internal XClosedCaptionProperties _interop; //Field offset: 0x10
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001B6")]
	internal XColor _backgroundColor; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001B7")]
	internal XColor _fontColor; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001B8")]
	internal XColor _windowColor; //Field offset: 0x40

	[Token(Token = "0x17000013")]
	public XColor BackgroundColor
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000588")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000589")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000019")]
	public bool Enabled
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000594")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x6000595")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000014")]
	public XColor FontColor
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600058A")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x600058B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000016")]
	public XClosedCaptionFontEdgeAttribute FontEdgeAttribute
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x600058E")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x600058F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000018")]
	public float FontScale
	{
		[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
		[Token(Token = "0x6000592")]
		 get { } //Length: 6
		[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
		[Token(Token = "0x6000593")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000017")]
	public XClosedCaptionFontStyle FontStyle
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000590")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000591")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000012")]
	internal XClosedCaptionProperties interop
	{
		[Address(RVA = "0x2B7CB60", Offset = "0x2B7BF60", Length = "0x80")]
		[Token(Token = "0x6000587")]
		internal get { } //Length: 128
	}

	[Token(Token = "0x17000015")]
	public XColor WindowColor
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600058C")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x600058D")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B7CA20", Offset = "0x2B7BE20", Length = "0x10B")]
	[Token(Token = "0x6000585")]
	internal XClosedCaptionProperties(XClosedCaptionProperties interop) { }

	[Address(RVA = "0x2B7CB30", Offset = "0x2B7BF30", Length = "0x26")]
	[Token(Token = "0x6000586")]
	public XClosedCaptionProperties() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000588")]
	public XColor get_BackgroundColor() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000594")]
	public bool get_Enabled() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600058A")]
	public XColor get_FontColor() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x600058E")]
	public XClosedCaptionFontEdgeAttribute get_FontEdgeAttribute() { }

	[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
	[Token(Token = "0x6000592")]
	public float get_FontScale() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000590")]
	public XClosedCaptionFontStyle get_FontStyle() { }

	[Address(RVA = "0x2B7CB60", Offset = "0x2B7BF60", Length = "0x80")]
	[Token(Token = "0x6000587")]
	internal XClosedCaptionProperties get_interop() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600058C")]
	public XColor get_WindowColor() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000589")]
	public void set_BackgroundColor(XColor value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x6000595")]
	public void set_Enabled(bool value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x600058B")]
	public void set_FontColor(XColor value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x600058F")]
	public void set_FontEdgeAttribute(XClosedCaptionFontEdgeAttribute value) { }

	[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
	[Token(Token = "0x6000593")]
	public void set_FontScale(float value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000591")]
	public void set_FontStyle(XClosedCaptionFontStyle value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x600058D")]
	public void set_WindowColor(XColor value) { }

}

