namespace Unity.Burst.Intrinsics;

[Token(Token = "0x2000037")]
internal class V128DebugView
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000182")]
	private v128 m_Value; //Field offset: 0x10

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x1700002C")]
	public Byte[] Byte
	{
		[Address(RVA = "0x27F5110", Offset = "0x27F4510", Length = "0x13C")]
		[Token(Token = "0x6000A6A")]
		 get { } //Length: 316
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000035")]
	public Double[] Double
	{
		[Address(RVA = "0x27F5250", Offset = "0x27F4650", Length = "0x6C")]
		[Token(Token = "0x6000A73")]
		 get { } //Length: 108
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000032")]
	public Single[] Float
	{
		[Address(RVA = "0x27F52C0", Offset = "0x27F46C0", Length = "0x8C")]
		[Token(Token = "0x6000A70")]
		 get { } //Length: 140
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x1700002D")]
	public SByte[] SByte
	{
		[Address(RVA = "0x27F5350", Offset = "0x27F4750", Length = "0x13C")]
		[Token(Token = "0x6000A6B")]
		 get { } //Length: 316
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000031")]
	public Int32[] SInt
	{
		[Address(RVA = "0x27F5490", Offset = "0x27F4890", Length = "0x7C")]
		[Token(Token = "0x6000A6F")]
		 get { } //Length: 124
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000033")]
	public Int64[] SLong
	{
		[Address(RVA = "0x27F5510", Offset = "0x27F4910", Length = "0x68")]
		[Token(Token = "0x6000A71")]
		 get { } //Length: 104
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x1700002F")]
	public Int16[] SShort
	{
		[Address(RVA = "0x27F5580", Offset = "0x27F4980", Length = "0xBC")]
		[Token(Token = "0x6000A6D")]
		 get { } //Length: 188
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000030")]
	public UInt32[] UInt
	{
		[Address(RVA = "0x27F5640", Offset = "0x27F4A40", Length = "0x7C")]
		[Token(Token = "0x6000A6E")]
		 get { } //Length: 124
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000034")]
	public UInt64[] ULong
	{
		[Address(RVA = "0x27F56C0", Offset = "0x27F4AC0", Length = "0x68")]
		[Token(Token = "0x6000A72")]
		 get { } //Length: 104
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x1700002E")]
	public UInt16[] UShort
	{
		[Address(RVA = "0x27F5730", Offset = "0x27F4B30", Length = "0xBC")]
		[Token(Token = "0x6000A6C")]
		 get { } //Length: 188
	}

	[Address(RVA = "0xB49C20", Offset = "0xB49020", Length = "0x29")]
	[Token(Token = "0x6000A69")]
	public V128DebugView(v128 value) { }

	[Address(RVA = "0x27F5110", Offset = "0x27F4510", Length = "0x13C")]
	[Token(Token = "0x6000A6A")]
	public Byte[] get_Byte() { }

	[Address(RVA = "0x27F5250", Offset = "0x27F4650", Length = "0x6C")]
	[Token(Token = "0x6000A73")]
	public Double[] get_Double() { }

	[Address(RVA = "0x27F52C0", Offset = "0x27F46C0", Length = "0x8C")]
	[Token(Token = "0x6000A70")]
	public Single[] get_Float() { }

	[Address(RVA = "0x27F5350", Offset = "0x27F4750", Length = "0x13C")]
	[Token(Token = "0x6000A6B")]
	public SByte[] get_SByte() { }

	[Address(RVA = "0x27F5490", Offset = "0x27F4890", Length = "0x7C")]
	[Token(Token = "0x6000A6F")]
	public Int32[] get_SInt() { }

	[Address(RVA = "0x27F5510", Offset = "0x27F4910", Length = "0x68")]
	[Token(Token = "0x6000A71")]
	public Int64[] get_SLong() { }

	[Address(RVA = "0x27F5580", Offset = "0x27F4980", Length = "0xBC")]
	[Token(Token = "0x6000A6D")]
	public Int16[] get_SShort() { }

	[Address(RVA = "0x27F5640", Offset = "0x27F4A40", Length = "0x7C")]
	[Token(Token = "0x6000A6E")]
	public UInt32[] get_UInt() { }

	[Address(RVA = "0x27F56C0", Offset = "0x27F4AC0", Length = "0x68")]
	[Token(Token = "0x6000A72")]
	public UInt64[] get_ULong() { }

	[Address(RVA = "0x27F5730", Offset = "0x27F4B30", Length = "0xBC")]
	[Token(Token = "0x6000A6C")]
	public UInt16[] get_UShort() { }

}

