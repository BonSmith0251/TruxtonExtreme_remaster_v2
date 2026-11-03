namespace Unity.XGamingRuntime;

[Token(Token = "0x2000236")]
public class XGameUiTextEntryExtents
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000621")]
	internal XGameUiTextEntryExtents interop; //Field offset: 0x10

	[Token(Token = "0x1700022F")]
	public float Bottom
	{
		[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
		[Token(Token = "0x6000B7D")]
		 get { } //Length: 6
		[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
		[Token(Token = "0x6000B7E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700022C")]
	public float Left
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x6000B77")]
		 get { } //Length: 6
		[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
		[Token(Token = "0x6000B78")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700022E")]
	public float Right
	{
		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[Token(Token = "0x6000B7B")]
		 get { } //Length: 6
		[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
		[Token(Token = "0x6000B7C")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700022D")]
	public float Top
	{
		[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
		[Token(Token = "0x6000B79")]
		 get { } //Length: 6
		[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
		[Token(Token = "0x6000B7A")]
		 set { } //Length: 6
	}

	[Address(RVA = "0xB49C20", Offset = "0xB49020", Length = "0x29")]
	[Token(Token = "0x6000B75")]
	internal XGameUiTextEntryExtents(XGameUiTextEntryExtents interop) { }

	[Address(RVA = "0x2B6E870", Offset = "0x2B6DC70", Length = "0x1D")]
	[Token(Token = "0x6000B76")]
	public XGameUiTextEntryExtents() { }

	[Address(RVA = "0x1DF2990", Offset = "0x1DF1D90", Length = "0x6")]
	[Token(Token = "0x6000B7D")]
	public float get_Bottom() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x6000B77")]
	public float get_Left() { }

	[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
	[Token(Token = "0x6000B7B")]
	public float get_Right() { }

	[Address(RVA = "0xFBEB10", Offset = "0xFBDF10", Length = "0x6")]
	[Token(Token = "0x6000B79")]
	public float get_Top() { }

	[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
	[Token(Token = "0x6000B7E")]
	public void set_Bottom(float value) { }

	[Address(RVA = "0x661850", Offset = "0x660C50", Length = "0x6")]
	[Token(Token = "0x6000B78")]
	public void set_Left(float value) { }

	[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
	[Token(Token = "0x6000B7C")]
	public void set_Right(float value) { }

	[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
	[Token(Token = "0x6000B7A")]
	public void set_Top(float value) { }

}

