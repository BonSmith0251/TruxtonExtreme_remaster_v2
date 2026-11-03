namespace System.Text;

[Token(Token = "0x20002A4")]
internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
{
	[Token(Token = "0x4000B85")]
	private static object s_InternalSyncObject; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B81")]
	private char _cBestFit; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B82")]
	private InternalEncoderBestFitFallback _oFallback; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B83")]
	private int _iCount; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000B84")]
	private int _iSize; //Field offset: 0x44

	[Token(Token = "0x17000216")]
	private static object InternalSyncObject
	{
		[Address(RVA = "0x1E8F130", Offset = "0x1E8E530", Length = "0x92")]
		[Token(Token = "0x60015A7")]
		private get { } //Length: 146
	}

	[Token(Token = "0x17000217")]
	public virtual int Remaining
	{
		[Address(RVA = "0x1E8F1D0", Offset = "0x1E8E5D0", Length = "0xD")]
		[Token(Token = "0x60015AD")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x1E8EF70", Offset = "0x1E8E370", Length = "0x1B4")]
	[Token(Token = "0x60015A8")]
	public InternalEncoderBestFitFallbackBuffer(InternalEncoderBestFitFallback fallback) { }

	[Address(RVA = "0x1E8EAE0", Offset = "0x1E8DEE0", Length = "0x126")]
	[Token(Token = "0x60015A9")]
	public virtual bool Fallback(char charUnknown, int index) { }

	[Address(RVA = "0x1E8EC10", Offset = "0x1E8E010", Length = "0x1D0")]
	[Token(Token = "0x60015AA")]
	public virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	[Address(RVA = "0x1E8F130", Offset = "0x1E8E530", Length = "0x92")]
	[Token(Token = "0x60015A7")]
	private static object get_InternalSyncObject() { }

	[Address(RVA = "0x1E8F1D0", Offset = "0x1E8E5D0", Length = "0xD")]
	[Token(Token = "0x60015AD")]
	public virtual int get_Remaining() { }

	[Address(RVA = "0x1E8EDF0", Offset = "0x1E8E1F0", Length = "0x21")]
	[Token(Token = "0x60015AB")]
	public virtual char GetNextChar() { }

	[Address(RVA = "0x1E8EE20", Offset = "0x1E8E220", Length = "0x1C")]
	[Token(Token = "0x60015AC")]
	public virtual bool MovePrevious() { }

	[Address(RVA = "0x1E8EE40", Offset = "0x1E8E240", Length = "0x14")]
	[Token(Token = "0x60015AE")]
	public virtual void Reset() { }

	[Address(RVA = "0x1E8EE60", Offset = "0x1E8E260", Length = "0x108")]
	[Token(Token = "0x60015AF")]
	private char TryBestFit(char cUnknown) { }

}

