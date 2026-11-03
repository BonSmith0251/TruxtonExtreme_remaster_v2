namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000250")]
public class XPackageWriteStats
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400065B")]
	internal XPackageWriteStats interop; //Field offset: 0x10

	[Token(Token = "0x1700025F")]
	public ulong Budget
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000BFD")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x6000BFE")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000261")]
	public ulong BytesWritten
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000C01")]
		 get { } //Length: 5
		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[Token(Token = "0x6000C02")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000260")]
	public ulong Elapsed
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000BFF")]
		 get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[Token(Token = "0x6000C00")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700025E")]
	public ulong Interval
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000BFB")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x6000BFC")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x11DF780", Offset = "0x11DEB80", Length = "0x31")]
	[Token(Token = "0x6000BF9")]
	internal XPackageWriteStats(XPackageWriteStats interop) { }

	[Address(RVA = "0x2B82130", Offset = "0x2B81530", Length = "0x21")]
	[Token(Token = "0x6000BFA")]
	public XPackageWriteStats() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000BFD")]
	public ulong get_Budget() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000C01")]
	public ulong get_BytesWritten() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000BFF")]
	public ulong get_Elapsed() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000BFB")]
	public ulong get_Interval() { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x6000BFE")]
	public void set_Budget(ulong value) { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[Token(Token = "0x6000C02")]
	public void set_BytesWritten(ulong value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[Token(Token = "0x6000C00")]
	public void set_Elapsed(ulong value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x6000BFC")]
	public void set_Interval(ulong value) { }

}

