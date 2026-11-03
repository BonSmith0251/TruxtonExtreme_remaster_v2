namespace Unity.Cinemachine;

[Token(Token = "0x200016D")]
internal struct RectD
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000617")]
	public double left; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000618")]
	public double top; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000619")]
	public double right; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400061A")]
	public double bottom; //Field offset: 0x18

	[Token(Token = "0x1700014D")]
	public double Height
	{
		[Address(RVA = "0x289D120", Offset = "0x289C520", Length = "0xB")]
		[Token(Token = "0x600070C")]
		 get { } //Length: 11
		[Address(RVA = "0x289D140", Offset = "0x289C540", Length = "0xB")]
		[Token(Token = "0x600070D")]
		 set { } //Length: 11
	}

	[Token(Token = "0x1700014C")]
	public double Width
	{
		[Address(RVA = "0x289D130", Offset = "0x289C530", Length = "0xA")]
		[Token(Token = "0x600070A")]
		 get { } //Length: 10
		[Address(RVA = "0x289D150", Offset = "0x289C550", Length = "0xA")]
		[Token(Token = "0x600070B")]
		 set { } //Length: 10
	}

	[Address(RVA = "0x27F6C30", Offset = "0x27F6030", Length = "0x1A")]
	[Token(Token = "0x6000708")]
	public RectD(double l, double t, double r, double b) { }

	[Address(RVA = "0x289D030", Offset = "0x289C430", Length = "0x1F")]
	[Token(Token = "0x6000709")]
	public RectD(RectD rec) { }

	[Address(RVA = "0x289D120", Offset = "0x289C520", Length = "0xB")]
	[Token(Token = "0x600070C")]
	public double get_Height() { }

	[Address(RVA = "0x289D130", Offset = "0x289C530", Length = "0xA")]
	[Token(Token = "0x600070A")]
	public double get_Width() { }

	[Address(RVA = "0x289D090", Offset = "0x289C490", Length = "0x1C")]
	[Token(Token = "0x600070E")]
	public bool IsEmpty() { }

	[Address(RVA = "0x289D0B0", Offset = "0x289C4B0", Length = "0x30")]
	[Token(Token = "0x600070F")]
	public PointD MidPoint() { }

	[Address(RVA = "0x289D0E0", Offset = "0x289C4E0", Length = "0x32")]
	[Token(Token = "0x6000710")]
	public bool PtIsInside(PointD pt) { }

	[Address(RVA = "0x289D140", Offset = "0x289C540", Length = "0xB")]
	[Token(Token = "0x600070D")]
	public void set_Height(double value) { }

	[Address(RVA = "0x289D150", Offset = "0x289C550", Length = "0xA")]
	[Token(Token = "0x600070B")]
	public void set_Width(double value) { }

}

