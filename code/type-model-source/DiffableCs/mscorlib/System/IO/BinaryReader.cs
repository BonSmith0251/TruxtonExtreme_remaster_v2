namespace System.IO;

[ComVisible(True)]
[Token(Token = "0x2000673")]
public class BinaryReader : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40019EC")]
	private Stream m_stream; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40019ED")]
	private Byte[] m_buffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019EE")]
	private Decoder m_decoder; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40019EF")]
	private Byte[] m_charBytes; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40019F0")]
	private Char[] m_singleChar; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40019F1")]
	private Char[] m_charBuffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019F2")]
	private int m_maxCharsSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40019F3")]
	private bool m_2BytesPerChar; //Field offset: 0x44
	[FieldOffset(Offset = "0x45")]
	[Token(Token = "0x40019F4")]
	private bool m_isMemoryStream; //Field offset: 0x45
	[FieldOffset(Offset = "0x46")]
	[Token(Token = "0x40019F5")]
	private bool m_leaveOpen; //Field offset: 0x46

	[Token(Token = "0x17000791")]
	public override Stream BaseStream
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600302D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1FEEF50", Offset = "0x1FEE350", Length = "0x74")]
	[Token(Token = "0x600302A")]
	public BinaryReader(Stream input) { }

	[Address(RVA = "0x1FEEFD0", Offset = "0x1FEE3D0", Length = "0x1A")]
	[Token(Token = "0x600302B")]
	public BinaryReader(Stream input, Encoding encoding) { }

	[Address(RVA = "0x1FEEC90", Offset = "0x1FEE090", Length = "0x2BB")]
	[Token(Token = "0x600302C")]
	public BinaryReader(Stream input, Encoding encoding, bool leaveOpen) { }

	[Address(RVA = "0x1FED4C0", Offset = "0x1FEC8C0", Length = "0x16")]
	[Token(Token = "0x600302E")]
	public override void Close() { }

	[Address(RVA = "0x1FED4E0", Offset = "0x1FEC8E0", Length = "0xB5")]
	[Token(Token = "0x600302F")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1FED4C0", Offset = "0x1FEC8C0", Length = "0x16")]
	[Token(Token = "0x6003030")]
	public override void Dispose() { }

	[Address(RVA = "0x1FED5A0", Offset = "0x1FEC9A0", Length = "0x164")]
	[Token(Token = "0x6003045")]
	protected override void FillBuffer(int numBytes) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600302D")]
	public override Stream get_BaseStream() { }

	[Address(RVA = "0x1FED710", Offset = "0x1FECB10", Length = "0x383")]
	[Token(Token = "0x6003040")]
	private int InternalReadChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1FEDAA0", Offset = "0x1FECEA0", Length = "0x2A1")]
	[Token(Token = "0x6003041")]
	private int InternalReadOneChar() { }

	[Address(RVA = "0x1FEEA80", Offset = "0x1FEDE80", Length = "0x1D")]
	[Token(Token = "0x6003031")]
	public override int Read() { }

	[Address(RVA = "0x1FEEAA0", Offset = "0x1FEDEA0", Length = "0x1ED")]
	[Token(Token = "0x6003043")]
	public override int Read(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1FEDD50", Offset = "0x1FED150", Length = "0xAB")]
	[Token(Token = "0x6003046")]
	protected private int Read7BitEncodedInt() { }

	[Address(RVA = "0x1FEDE00", Offset = "0x1FED200", Length = "0x48")]
	[Token(Token = "0x6003032")]
	public override bool ReadBoolean() { }

	[Address(RVA = "0x1FEDE50", Offset = "0x1FED250", Length = "0x3B")]
	[Token(Token = "0x6003033")]
	public override byte ReadByte() { }

	[Address(RVA = "0x1FEDE90", Offset = "0x1FED290", Length = "0x1AD")]
	[Token(Token = "0x6003044")]
	public override Byte[] ReadBytes(int count) { }

	[Address(RVA = "0x1FEE040", Offset = "0x1FED440", Length = "0x28")]
	[Token(Token = "0x6003035")]
	public override char ReadChar() { }

	[Address(RVA = "0x1FEE070", Offset = "0x1FED470", Length = "0x170")]
	[Token(Token = "0x6003042")]
	public override Char[] ReadChars(int count) { }

	[Address(RVA = "0x1FEE1F0", Offset = "0x1FED5F0", Length = "0x133")]
	[Token(Token = "0x600303E")]
	public override decimal ReadDecimal() { }

	[Address(RVA = "0x1FEE330", Offset = "0x1FED730", Length = "0x34")]
	[Token(Token = "0x600303D")]
	public override double ReadDouble() { }

	[Address(RVA = "0x1FEE370", Offset = "0x1FED770", Length = "0x56")]
	[Token(Token = "0x6003036")]
	public override short ReadInt16() { }

	[Address(RVA = "0x1FEE3D0", Offset = "0x1FED7D0", Length = "0x12A")]
	[Token(Token = "0x6003038")]
	public override int ReadInt32() { }

	[Address(RVA = "0x1FEE500", Offset = "0x1FED900", Length = "0x110")]
	[Token(Token = "0x600303A")]
	public override long ReadInt64() { }

	[Address(RVA = "0x1FEE620", Offset = "0x1FEDA20", Length = "0x45")]
	[CLSCompliant(False)]
	[Token(Token = "0x6003034")]
	public override sbyte ReadSByte() { }

	[Address(RVA = "0x1FEE670", Offset = "0x1FEDA70", Length = "0x34")]
	[Token(Token = "0x600303C")]
	public override float ReadSingle() { }

	[Address(RVA = "0x1FEE6B0", Offset = "0x1FEDAB0", Length = "0x34C")]
	[Token(Token = "0x600303F")]
	public override string ReadString() { }

	[Address(RVA = "0x1FEE370", Offset = "0x1FED770", Length = "0x56")]
	[CLSCompliant(False)]
	[Token(Token = "0x6003037")]
	public override ushort ReadUInt16() { }

	[Address(RVA = "0x1FEEA00", Offset = "0x1FEDE00", Length = "0x7E")]
	[CLSCompliant(False)]
	[Token(Token = "0x6003039")]
	public override uint ReadUInt32() { }

	[Address(RVA = "0x1FEE500", Offset = "0x1FED900", Length = "0x110")]
	[CLSCompliant(False)]
	[Token(Token = "0x600303B")]
	public override ulong ReadUInt64() { }

}

