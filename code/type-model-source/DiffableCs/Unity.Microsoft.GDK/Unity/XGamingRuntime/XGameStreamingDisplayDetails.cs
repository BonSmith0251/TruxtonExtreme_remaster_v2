namespace Unity.XGamingRuntime;

[Token(Token = "0x2000228")]
public class XGameStreamingDisplayDetails
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F9")]
	internal XGameStreamingDisplayDetails _interop; //Field offset: 0x10
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005FA")]
	internal RECT rect; //Field offset: 0x38

	[Token(Token = "0x1700021C")]
	public XGameStreamingVideoFlags Flags
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6000B47")]
		 get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[Token(Token = "0x6000B48")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000215")]
	internal XGameStreamingDisplayDetails interop
	{
		[Address(RVA = "0x2B81420", Offset = "0x2B80820", Length = "0x3B")]
		[Token(Token = "0x6000B3A")]
		internal get { } //Length: 59
	}

	[Token(Token = "0x1700021B")]
	public uint MaxHeight
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000B45")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x6000B46")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000219")]
	public uint MaxPixels
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000B41")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x6000B42")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700021A")]
	public uint MaxWidth
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6000B43")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[Token(Token = "0x6000B44")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000217")]
	public uint PreferredHeight
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000B3D")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x6000B3E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000216")]
	public uint PreferredWidth
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000B3B")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000B3C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000218")]
	public RECT SafeArea
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000B3F")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6000B40")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B81380", Offset = "0x2B80780", Length = "0x9C")]
	[Token(Token = "0x6000B38")]
	internal XGameStreamingDisplayDetails(XGameStreamingDisplayDetails interop) { }

	[Address(RVA = "0x2B81300", Offset = "0x2B80700", Length = "0x7E")]
	[Token(Token = "0x6000B39")]
	public XGameStreamingDisplayDetails() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6000B47")]
	public XGameStreamingVideoFlags get_Flags() { }

	[Address(RVA = "0x2B81420", Offset = "0x2B80820", Length = "0x3B")]
	[Token(Token = "0x6000B3A")]
	internal XGameStreamingDisplayDetails get_interop() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000B45")]
	public uint get_MaxHeight() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000B41")]
	public uint get_MaxPixels() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000B43")]
	public uint get_MaxWidth() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6000B3D")]
	public uint get_PreferredHeight() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000B3B")]
	public uint get_PreferredWidth() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000B3F")]
	public RECT get_SafeArea() { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[Token(Token = "0x6000B48")]
	public void set_Flags(XGameStreamingVideoFlags value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x6000B46")]
	public void set_MaxHeight(uint value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x6000B42")]
	public void set_MaxPixels(uint value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[Token(Token = "0x6000B44")]
	public void set_MaxWidth(uint value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x6000B3E")]
	public void set_PreferredHeight(uint value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000B3C")]
	public void set_PreferredWidth(uint value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6000B40")]
	public void set_SafeArea(RECT value) { }

}

