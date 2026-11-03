namespace System.IO;

[ComVisible(True)]
[Token(Token = "0x2000674")]
public class BinaryWriter : IDisposable
{
	[Token(Token = "0x40019F6")]
	public static readonly BinaryWriter Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40019F7")]
	protected Stream OutStream; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40019F8")]
	private Byte[] _buffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019F9")]
	private Encoding _encoding; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40019FA")]
	private Encoder _encoder; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[OptionalField]
	[Token(Token = "0x40019FB")]
	private bool _leaveOpen; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40019FC")]
	private Byte[] _largeByteBuffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019FD")]
	private int _maxChars; //Field offset: 0x40

	[Address(RVA = "0x1FEFD40", Offset = "0x1FEF140", Length = "0x15B")]
	[Token(Token = "0x6003060")]
	private static BinaryWriter() { }

	[Address(RVA = "0x1FEFFD0", Offset = "0x1FEF3D0", Length = "0x1EE")]
	[Token(Token = "0x600304A")]
	public BinaryWriter(Stream output, Encoding encoding, bool leaveOpen) { }

	[Address(RVA = "0x1FEFEC0", Offset = "0x1FEF2C0", Length = "0x10C")]
	[Token(Token = "0x6003047")]
	protected BinaryWriter() { }

	[Address(RVA = "0x1FF01C0", Offset = "0x1FEF5C0", Length = "0x7A")]
	[Token(Token = "0x6003048")]
	public BinaryWriter(Stream output) { }

	[Address(RVA = "0x1FEFEA0", Offset = "0x1FEF2A0", Length = "0x1A")]
	[Token(Token = "0x6003049")]
	public BinaryWriter(Stream output, Encoding encoding) { }

	[Address(RVA = "0x1F3F9C0", Offset = "0x1F3EDC0", Length = "0x16")]
	[Token(Token = "0x600304B")]
	public override void Close() { }

	[Address(RVA = "0x1FEEFF0", Offset = "0x1FEE3F0", Length = "0x59")]
	[Token(Token = "0x600304C")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1F3F9C0", Offset = "0x1F3EDC0", Length = "0x16")]
	[Token(Token = "0x600304D")]
	public override void Dispose() { }

	[Address(RVA = "0x1FEF050", Offset = "0x1FEE450", Length = "0x2A")]
	[Token(Token = "0x600304E")]
	public override void Flush() { }

	[Address(RVA = "0x1FEF0F0", Offset = "0x1FEE4F0", Length = "0x38E")]
	[Token(Token = "0x600305E")]
	public override void Write(string value) { }

	[Address(RVA = "0x1FEF7C0", Offset = "0x1FEEBC0", Length = "0x4C")]
	[Token(Token = "0x600305D")]
	public override void Write(float value) { }

	[Address(RVA = "0x1FEF4F0", Offset = "0x1FEE8F0", Length = "0x138")]
	[CLSCompliant(False)]
	[Token(Token = "0x600305C")]
	public override void Write(ulong value) { }

	[Address(RVA = "0x1FEF870", Offset = "0x1FEEC70", Length = "0x138")]
	[Token(Token = "0x600305B")]
	public override void Write(long value) { }

	[Address(RVA = "0x1FEFC90", Offset = "0x1FEF090", Length = "0xA7")]
	[CLSCompliant(False)]
	[Token(Token = "0x600305A")]
	public override void Write(uint value) { }

	[Address(RVA = "0x1FEFA70", Offset = "0x1FEEE70", Length = "0xA7")]
	[Token(Token = "0x6003059")]
	public override void Write(int value) { }

	[Address(RVA = "0x1FEF9B0", Offset = "0x1FEEDB0", Length = "0x6E")]
	[CLSCompliant(False)]
	[Token(Token = "0x6003058")]
	public override void Write(ushort value) { }

	[Address(RVA = "0x1FEF6F0", Offset = "0x1FEEAF0", Length = "0xC0")]
	[Token(Token = "0x6003055")]
	public override void Write(Char[] chars) { }

	[Address(RVA = "0x1FEFA20", Offset = "0x1FEEE20", Length = "0x4C")]
	[Token(Token = "0x6003056")]
	public override void Write(double value) { }

	[Address(RVA = "0x1FEFB20", Offset = "0x1FEEF20", Length = "0x13F")]
	[Token(Token = "0x6003054")]
	public override void Write(char ch) { }

	[Address(RVA = "0x1FEF660", Offset = "0x1FEEA60", Length = "0x8E")]
	[Token(Token = "0x6003052")]
	public override void Write(Byte[] buffer) { }

	[Address(RVA = "0x1FEF630", Offset = "0x1FEEA30", Length = "0x2A")]
	[CLSCompliant(False)]
	[Token(Token = "0x6003051")]
	public override void Write(sbyte value) { }

	[Address(RVA = "0x1FEF630", Offset = "0x1FEEA30", Length = "0x2A")]
	[Token(Token = "0x6003050")]
	public override void Write(byte value) { }

	[Address(RVA = "0x1FEF810", Offset = "0x1FEEC10", Length = "0x5D")]
	[Token(Token = "0x600304F")]
	public override void Write(bool value) { }

	[Address(RVA = "0x1FEF480", Offset = "0x1FEE880", Length = "0x6E")]
	[Token(Token = "0x6003057")]
	public override void Write(short value) { }

	[Address(RVA = "0x1FEFC60", Offset = "0x1FEF060", Length = "0x2F")]
	[Token(Token = "0x6003053")]
	public override void Write(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1FEF080", Offset = "0x1FEE480", Length = "0x6B")]
	[Token(Token = "0x600305F")]
	protected void Write7BitEncodedInt(int value) { }

}

