namespace System.Text;

[Token(Token = "0x20002A9")]
public abstract class EncoderFallbackBuffer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B8C")]
	internal Char* charStart; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B8D")]
	internal Char* charEnd; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B8E")]
	internal EncoderNLS encoder; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B8F")]
	internal bool setEncoder; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000B90")]
	internal bool bUsedEncoder; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000B91")]
	internal bool bFallingBack; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000B92")]
	internal int iRecursionCount; //Field offset: 0x2C

	[Token(Token = "0x1700021D")]
	public abstract int Remaining
	{
		[Token(Token = "0x60015C8")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60015CF")]
	protected EncoderFallbackBuffer() { }

	[Token(Token = "0x60015C4")]
	public abstract bool Fallback(char charUnknown, int index) { }

	[Token(Token = "0x60015C5")]
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	[Token(Token = "0x60015C8")]
	public abstract int get_Remaining() { }

	[Token(Token = "0x60015C6")]
	public abstract char GetNextChar() { }

	[Address(RVA = "0x1E8B520", Offset = "0x1E8A920", Length = "0x193")]
	[Token(Token = "0x60015CD")]
	internal override bool InternalFallback(char ch, ref Char* chars) { }

	[Address(RVA = "0x1E8B6C0", Offset = "0x1E8AAC0", Length = "0x37")]
	[Token(Token = "0x60015CC")]
	internal char InternalGetNextChar() { }

	[Address(RVA = "0x1E8B700", Offset = "0x1E8AB00", Length = "0x3C")]
	[Token(Token = "0x60015CB")]
	internal void InternalInitialize(Char* charStart, Char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	[Address(RVA = "0x1E8B740", Offset = "0x1E8AB40", Length = "0x20")]
	[Token(Token = "0x60015CA")]
	internal void InternalReset() { }

	[Token(Token = "0x60015C7")]
	public abstract bool MovePrevious() { }

	[Address(RVA = "0x1E8B760", Offset = "0x1E8AB60", Length = "0x31")]
	[Token(Token = "0x60015C9")]
	public override void Reset() { }

	[Address(RVA = "0x1E8B7A0", Offset = "0x1E8ABA0", Length = "0x8A")]
	[Token(Token = "0x60015CE")]
	internal void ThrowLastCharRecursive(int charRecursive) { }

}

