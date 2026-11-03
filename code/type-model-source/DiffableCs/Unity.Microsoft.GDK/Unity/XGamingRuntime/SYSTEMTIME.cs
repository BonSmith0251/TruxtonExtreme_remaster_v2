namespace Unity.XGamingRuntime;

[Token(Token = "0x20000FF")]
public class SYSTEMTIME
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D0")]
	internal SYSTEMTIME interop; //Field offset: 0x10

	[Token(Token = "0x1700005A")]
	public ushort WDay
	{
		[Address(RVA = "0x29EA640", Offset = "0x29E9A40", Length = "0x5")]
		[Token(Token = "0x6000623")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6E8E0", Offset = "0x2B6DCE0", Length = "0x5")]
		[Token(Token = "0x6000624")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000059")]
	public ushort WDayOfWeek
	{
		[Address(RVA = "0x1963870", Offset = "0x1962C70", Length = "0x5")]
		[Token(Token = "0x6000621")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6E8D0", Offset = "0x2B6DCD0", Length = "0x5")]
		[Token(Token = "0x6000622")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700005B")]
	public ushort WHour
	{
		[Address(RVA = "0x10A5BC0", Offset = "0x10A4FC0", Length = "0x5")]
		[Token(Token = "0x6000625")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6E8F0", Offset = "0x2B6DCF0", Length = "0x5")]
		[Token(Token = "0x6000626")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700005E")]
	public ushort WMilliseconds
	{
		[Address(RVA = "0x2B6E890", Offset = "0x2B6DC90", Length = "0x5")]
		[Token(Token = "0x600062B")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6E900", Offset = "0x2B6DD00", Length = "0x5")]
		[Token(Token = "0x600062C")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700005C")]
	public ushort WMinute
	{
		[Address(RVA = "0x2B6E8A0", Offset = "0x2B6DCA0", Length = "0x5")]
		[Token(Token = "0x6000627")]
		 get { } //Length: 5
		[Address(RVA = "0x24FCE90", Offset = "0x24FC290", Length = "0x5")]
		[Token(Token = "0x6000628")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000058")]
	public ushort WMonth
	{
		[Address(RVA = "0x2B6E8B0", Offset = "0x2B6DCB0", Length = "0x5")]
		[Token(Token = "0x600061F")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6E910", Offset = "0x2B6DD10", Length = "0x5")]
		[Token(Token = "0x6000620")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700005D")]
	public ushort WSecond
	{
		[Address(RVA = "0x2B6E8C0", Offset = "0x2B6DCC0", Length = "0x5")]
		[Token(Token = "0x6000629")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6E920", Offset = "0x2B6DD20", Length = "0x5")]
		[Token(Token = "0x600062A")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000057")]
	public ushort WYear
	{
		[Address(RVA = "0x111BFC0", Offset = "0x111B3C0", Length = "0x5")]
		[Token(Token = "0x600061D")]
		 get { } //Length: 5
		[Address(RVA = "0x1E51EE0", Offset = "0x1E512E0", Length = "0x5")]
		[Token(Token = "0x600061E")]
		 set { } //Length: 5
	}

	[Address(RVA = "0xB49C20", Offset = "0xB49020", Length = "0x29")]
	[Token(Token = "0x600061B")]
	internal SYSTEMTIME(SYSTEMTIME interop) { }

	[Address(RVA = "0x2B6E870", Offset = "0x2B6DC70", Length = "0x1D")]
	[Token(Token = "0x600061C")]
	public SYSTEMTIME() { }

	[Address(RVA = "0x29EA640", Offset = "0x29E9A40", Length = "0x5")]
	[Token(Token = "0x6000623")]
	public ushort get_WDay() { }

	[Address(RVA = "0x1963870", Offset = "0x1962C70", Length = "0x5")]
	[Token(Token = "0x6000621")]
	public ushort get_WDayOfWeek() { }

	[Address(RVA = "0x10A5BC0", Offset = "0x10A4FC0", Length = "0x5")]
	[Token(Token = "0x6000625")]
	public ushort get_WHour() { }

	[Address(RVA = "0x2B6E890", Offset = "0x2B6DC90", Length = "0x5")]
	[Token(Token = "0x600062B")]
	public ushort get_WMilliseconds() { }

	[Address(RVA = "0x2B6E8A0", Offset = "0x2B6DCA0", Length = "0x5")]
	[Token(Token = "0x6000627")]
	public ushort get_WMinute() { }

	[Address(RVA = "0x2B6E8B0", Offset = "0x2B6DCB0", Length = "0x5")]
	[Token(Token = "0x600061F")]
	public ushort get_WMonth() { }

	[Address(RVA = "0x2B6E8C0", Offset = "0x2B6DCC0", Length = "0x5")]
	[Token(Token = "0x6000629")]
	public ushort get_WSecond() { }

	[Address(RVA = "0x111BFC0", Offset = "0x111B3C0", Length = "0x5")]
	[Token(Token = "0x600061D")]
	public ushort get_WYear() { }

	[Address(RVA = "0x2B6E8E0", Offset = "0x2B6DCE0", Length = "0x5")]
	[Token(Token = "0x6000624")]
	public void set_WDay(ushort value) { }

	[Address(RVA = "0x2B6E8D0", Offset = "0x2B6DCD0", Length = "0x5")]
	[Token(Token = "0x6000622")]
	public void set_WDayOfWeek(ushort value) { }

	[Address(RVA = "0x2B6E8F0", Offset = "0x2B6DCF0", Length = "0x5")]
	[Token(Token = "0x6000626")]
	public void set_WHour(ushort value) { }

	[Address(RVA = "0x2B6E900", Offset = "0x2B6DD00", Length = "0x5")]
	[Token(Token = "0x600062C")]
	public void set_WMilliseconds(ushort value) { }

	[Address(RVA = "0x24FCE90", Offset = "0x24FC290", Length = "0x5")]
	[Token(Token = "0x6000628")]
	public void set_WMinute(ushort value) { }

	[Address(RVA = "0x2B6E910", Offset = "0x2B6DD10", Length = "0x5")]
	[Token(Token = "0x6000620")]
	public void set_WMonth(ushort value) { }

	[Address(RVA = "0x2B6E920", Offset = "0x2B6DD20", Length = "0x5")]
	[Token(Token = "0x600062A")]
	public void set_WSecond(ushort value) { }

	[Address(RVA = "0x1E51EE0", Offset = "0x1E512E0", Length = "0x5")]
	[Token(Token = "0x600061E")]
	public void set_WYear(ushort value) { }

}

