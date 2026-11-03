namespace Unity.Burst.Intrinsics;

[Token(Token = "0x2000036")]
internal class V64DebugView
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000181")]
	private v64 m_Value; //Field offset: 0x10

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000022")]
	public Byte[] Byte
	{
		[Address(RVA = "0x27F6340", Offset = "0x27F5740", Length = "0xB4")]
		[Token(Token = "0x6000A5F")]
		 get { } //Length: 180
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x1700002B")]
	public Double[] Double
	{
		[Address(RVA = "0x27F6400", Offset = "0x27F5800", Length = "0x5C")]
		[Token(Token = "0x6000A68")]
		 get { } //Length: 92
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000028")]
	public Single[] Float
	{
		[Address(RVA = "0x27F6460", Offset = "0x27F5860", Length = "0x6C")]
		[Token(Token = "0x6000A65")]
		 get { } //Length: 108
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000023")]
	public SByte[] SByte
	{
		[Address(RVA = "0x27F64D0", Offset = "0x27F58D0", Length = "0xB4")]
		[Token(Token = "0x6000A60")]
		 get { } //Length: 180
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000027")]
	public Int32[] SInt
	{
		[Address(RVA = "0x27F6590", Offset = "0x27F5990", Length = "0x64")]
		[Token(Token = "0x6000A64")]
		 get { } //Length: 100
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000029")]
	public Int64[] SLong
	{
		[Address(RVA = "0x27F6600", Offset = "0x27F5A00", Length = "0x5A")]
		[Token(Token = "0x6000A66")]
		 get { } //Length: 90
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000025")]
	public Int16[] SShort
	{
		[Address(RVA = "0x27F6660", Offset = "0x27F5A60", Length = "0x84")]
		[Token(Token = "0x6000A62")]
		 get { } //Length: 132
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000026")]
	public UInt32[] UInt
	{
		[Address(RVA = "0x27F66F0", Offset = "0x27F5AF0", Length = "0x64")]
		[Token(Token = "0x6000A63")]
		 get { } //Length: 100
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x1700002A")]
	public UInt64[] ULong
	{
		[Address(RVA = "0x27F6760", Offset = "0x27F5B60", Length = "0x5A")]
		[Token(Token = "0x6000A67")]
		 get { } //Length: 90
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	[Token(Token = "0x17000024")]
	public UInt16[] UShort
	{
		[Address(RVA = "0x27F67C0", Offset = "0x27F5BC0", Length = "0x84")]
		[Token(Token = "0x6000A61")]
		 get { } //Length: 132
	}

	[Address(RVA = "0xD69A70", Offset = "0xD68E70", Length = "0x26")]
	[Token(Token = "0x6000A5E")]
	public V64DebugView(v64 value) { }

	[Address(RVA = "0x27F6340", Offset = "0x27F5740", Length = "0xB4")]
	[Token(Token = "0x6000A5F")]
	public Byte[] get_Byte() { }

	[Address(RVA = "0x27F6400", Offset = "0x27F5800", Length = "0x5C")]
	[Token(Token = "0x6000A68")]
	public Double[] get_Double() { }

	[Address(RVA = "0x27F6460", Offset = "0x27F5860", Length = "0x6C")]
	[Token(Token = "0x6000A65")]
	public Single[] get_Float() { }

	[Address(RVA = "0x27F64D0", Offset = "0x27F58D0", Length = "0xB4")]
	[Token(Token = "0x6000A60")]
	public SByte[] get_SByte() { }

	[Address(RVA = "0x27F6590", Offset = "0x27F5990", Length = "0x64")]
	[Token(Token = "0x6000A64")]
	public Int32[] get_SInt() { }

	[Address(RVA = "0x27F6600", Offset = "0x27F5A00", Length = "0x5A")]
	[Token(Token = "0x6000A66")]
	public Int64[] get_SLong() { }

	[Address(RVA = "0x27F6660", Offset = "0x27F5A60", Length = "0x84")]
	[Token(Token = "0x6000A62")]
	public Int16[] get_SShort() { }

	[Address(RVA = "0x27F66F0", Offset = "0x27F5AF0", Length = "0x64")]
	[Token(Token = "0x6000A63")]
	public UInt32[] get_UInt() { }

	[Address(RVA = "0x27F6760", Offset = "0x27F5B60", Length = "0x5A")]
	[Token(Token = "0x6000A67")]
	public UInt64[] get_ULong() { }

	[Address(RVA = "0x27F67C0", Offset = "0x27F5BC0", Length = "0x84")]
	[Token(Token = "0x6000A61")]
	public UInt16[] get_UShort() { }

}

