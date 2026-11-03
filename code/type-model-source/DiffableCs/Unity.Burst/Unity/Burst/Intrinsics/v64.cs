namespace Unity.Burst.Intrinsics;

[DebuggerTypeProxy(typeof(V64DebugView))]
[Token(Token = "0x200003B")]
public struct v64
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400024E")]
	public byte Byte0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400026C")]
	public float Float0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400026B")]
	public long SLong0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400026A")]
	public ulong ULong0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000268")]
	public int SInt0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000266")]
	public uint UInt0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000262")]
	public short SShort0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000256")]
	public sbyte SByte0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400025E")]
	public ushort UShort0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400026E")]
	public double Double0; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x400024F")]
	public byte Byte1; //Field offset: 0x1
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000257")]
	public sbyte SByte1; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000258")]
	public sbyte SByte2; //Field offset: 0x2
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000250")]
	public byte Byte2; //Field offset: 0x2
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x400025F")]
	public ushort UShort1; //Field offset: 0x2
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000263")]
	public short SShort1; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000251")]
	public byte Byte3; //Field offset: 0x3
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000259")]
	public sbyte SByte3; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400025A")]
	public sbyte SByte4; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000269")]
	public int SInt1; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000252")]
	public byte Byte4; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000267")]
	public uint UInt1; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000264")]
	public short SShort2; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000260")]
	public ushort UShort2; //Field offset: 0x4
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400026D")]
	public float Float1; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x4000253")]
	public byte Byte5; //Field offset: 0x5
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x400025B")]
	public sbyte SByte5; //Field offset: 0x5
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000265")]
	public short SShort3; //Field offset: 0x6
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000261")]
	public ushort UShort3; //Field offset: 0x6
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x400025C")]
	public sbyte SByte6; //Field offset: 0x6
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000254")]
	public byte Byte6; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x400025D")]
	public sbyte SByte7; //Field offset: 0x7
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x4000255")]
	public byte Byte7; //Field offset: 0x7

	[Address(RVA = "0x27F6E50", Offset = "0x27F6250", Length = "0x18")]
	[Token(Token = "0x6000AA9")]
	public v64(byte b) { }

	[Address(RVA = "0x27F6E70", Offset = "0x27F6270", Length = "0x5")]
	[Token(Token = "0x6000AB7")]
	public v64(double a) { }

	[Address(RVA = "0x12F1450", Offset = "0x12F0850", Length = "0xA")]
	[Token(Token = "0x6000AB6")]
	public v64(float a, float b) { }

	[Address(RVA = "0x27F6E30", Offset = "0x27F6230", Length = "0xA")]
	[Token(Token = "0x6000AB5")]
	public v64(float f) { }

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x6000AB4")]
	public v64(uint a, uint b) { }

	[Address(RVA = "0x27F6E40", Offset = "0x27F6240", Length = "0x6")]
	[Token(Token = "0x6000AB3")]
	public v64(uint v) { }

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x6000AB2")]
	public v64(int a, int b) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000AB8")]
	public v64(long a) { }

	[Address(RVA = "0x27F6E40", Offset = "0x27F6240", Length = "0x6")]
	[Token(Token = "0x6000AB1")]
	public v64(int v) { }

	[Address(RVA = "0x27F6EA0", Offset = "0x27F62A0", Length = "0x10")]
	[Token(Token = "0x6000AAF")]
	public v64(ushort v) { }

	[Address(RVA = "0x27F6E80", Offset = "0x27F6280", Length = "0x17")]
	[Token(Token = "0x6000AAE")]
	public v64(short a, short b, short c, short d) { }

	[Address(RVA = "0x27F6EA0", Offset = "0x27F62A0", Length = "0x10")]
	[Token(Token = "0x6000AAD")]
	public v64(short v) { }

	[Address(RVA = "0x27F6EB0", Offset = "0x27F62B0", Length = "0x33")]
	[Token(Token = "0x6000AAC")]
	public v64(sbyte a, sbyte b, sbyte c, sbyte d, sbyte e, sbyte f, sbyte g, sbyte h) { }

	[Address(RVA = "0x27F6E50", Offset = "0x27F6250", Length = "0x18")]
	[Token(Token = "0x6000AAB")]
	public v64(sbyte b) { }

	[Address(RVA = "0x27F6EB0", Offset = "0x27F62B0", Length = "0x33")]
	[Token(Token = "0x6000AAA")]
	public v64(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h) { }

	[Address(RVA = "0x27F6E80", Offset = "0x27F6280", Length = "0x17")]
	[Token(Token = "0x6000AB0")]
	public v64(ushort a, ushort b, ushort c, ushort d) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000AB9")]
	public v64(ulong a) { }

}

