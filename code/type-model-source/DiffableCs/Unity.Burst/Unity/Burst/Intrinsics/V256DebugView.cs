namespace Unity.Burst.Intrinsics;

[Token(Token = "0x2000038")]
internal class V256DebugView
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000183")]
	private v256 m_Value; //Field offset: 0x10

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000036")]
	public Byte[] Byte
	{
		[Address(RVA = "0x27F57F0", Offset = "0x27F4BF0", Length = "0x24C")]
		[Token(Token = "0x6000A75")]
		 get { } //Length: 588
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x1700003F")]
	public Double[] Double
	{
		[Address(RVA = "0x27F5A40", Offset = "0x27F4E40", Length = "0x8C")]
		[Token(Token = "0x6000A7E")]
		 get { } //Length: 140
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x1700003C")]
	public Single[] Float
	{
		[Address(RVA = "0x27F5AD0", Offset = "0x27F4ED0", Length = "0xD4")]
		[Token(Token = "0x6000A7B")]
		 get { } //Length: 212
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000037")]
	public SByte[] SByte
	{
		[Address(RVA = "0x27F5BB0", Offset = "0x27F4FB0", Length = "0x24C")]
		[Token(Token = "0x6000A76")]
		 get { } //Length: 588
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x1700003B")]
	public Int32[] SInt
	{
		[Address(RVA = "0x27F5E00", Offset = "0x27F5200", Length = "0xAC")]
		[Token(Token = "0x6000A7A")]
		 get { } //Length: 172
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x1700003D")]
	public Int64[] SLong
	{
		[Address(RVA = "0x27F5EB0", Offset = "0x27F52B0", Length = "0x84")]
		[Token(Token = "0x6000A7C")]
		 get { } //Length: 132
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000039")]
	public Int16[] SShort
	{
		[Address(RVA = "0x27F5F40", Offset = "0x27F5340", Length = "0x150")]
		[Token(Token = "0x6000A78")]
		 get { } //Length: 336
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x1700003A")]
	public UInt32[] UInt
	{
		[Address(RVA = "0x27F60A0", Offset = "0x27F54A0", Length = "0xAC")]
		[Token(Token = "0x6000A79")]
		 get { } //Length: 172
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x1700003E")]
	public UInt64[] ULong
	{
		[Address(RVA = "0x27F6150", Offset = "0x27F5550", Length = "0x84")]
		[Token(Token = "0x6000A7D")]
		 get { } //Length: 132
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000038")]
	public UInt16[] UShort
	{
		[Address(RVA = "0x27F61E0", Offset = "0x27F55E0", Length = "0x150")]
		[Token(Token = "0x6000A77")]
		 get { } //Length: 336
	}

	[Address(RVA = "0x11DF780", Offset = "0x11DEB80", Length = "0x31")]
	[Token(Token = "0x6000A74")]
	public V256DebugView(v256 value) { }

	[Address(RVA = "0x27F57F0", Offset = "0x27F4BF0", Length = "0x24C")]
	[Token(Token = "0x6000A75")]
	public Byte[] get_Byte() { }

	[Address(RVA = "0x27F5A40", Offset = "0x27F4E40", Length = "0x8C")]
	[Token(Token = "0x6000A7E")]
	public Double[] get_Double() { }

	[Address(RVA = "0x27F5AD0", Offset = "0x27F4ED0", Length = "0xD4")]
	[Token(Token = "0x6000A7B")]
	public Single[] get_Float() { }

	[Address(RVA = "0x27F5BB0", Offset = "0x27F4FB0", Length = "0x24C")]
	[Token(Token = "0x6000A76")]
	public SByte[] get_SByte() { }

	[Address(RVA = "0x27F5E00", Offset = "0x27F5200", Length = "0xAC")]
	[Token(Token = "0x6000A7A")]
	public Int32[] get_SInt() { }

	[Address(RVA = "0x27F5EB0", Offset = "0x27F52B0", Length = "0x84")]
	[Token(Token = "0x6000A7C")]
	public Int64[] get_SLong() { }

	[Address(RVA = "0x27F5F40", Offset = "0x27F5340", Length = "0x150")]
	[Token(Token = "0x6000A78")]
	public Int16[] get_SShort() { }

	[Address(RVA = "0x27F60A0", Offset = "0x27F54A0", Length = "0xAC")]
	[Token(Token = "0x6000A79")]
	public UInt32[] get_UInt() { }

	[Address(RVA = "0x27F6150", Offset = "0x27F5550", Length = "0x84")]
	[Token(Token = "0x6000A7D")]
	public UInt64[] get_ULong() { }

	[Address(RVA = "0x27F61E0", Offset = "0x27F55E0", Length = "0x150")]
	[Token(Token = "0x6000A77")]
	public UInt16[] get_UShort() { }

}

