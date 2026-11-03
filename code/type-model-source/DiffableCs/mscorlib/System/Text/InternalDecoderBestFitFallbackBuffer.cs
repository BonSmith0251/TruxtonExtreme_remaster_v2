namespace System.Text;

[Token(Token = "0x2000299")]
internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
{
	[Token(Token = "0x4000B6E")]
	private static object s_InternalSyncObject; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B6A")]
	private char _cBestFit; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000B6B")]
	private int _iCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B6C")]
	private int _iSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B6D")]
	private InternalDecoderBestFitFallback _oFallback; //Field offset: 0x30

	[Token(Token = "0x17000205")]
	private static object InternalSyncObject
	{
		[Address(RVA = "0x20B2440", Offset = "0x20B1840", Length = "0x92")]
		[Token(Token = "0x6001557")]
		private get { } //Length: 146
	}

	[Token(Token = "0x17000206")]
	public virtual int Remaining
	{
		[Address(RVA = "0x1E8B030", Offset = "0x1E8A430", Length = "0xD")]
		[Token(Token = "0x600155B")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x20B2280", Offset = "0x20B1680", Length = "0x1B4")]
	[Token(Token = "0x6001558")]
	public InternalDecoderBestFitFallbackBuffer(InternalDecoderBestFitFallback fallback) { }

	[Address(RVA = "0x20B2050", Offset = "0x20B1450", Length = "0x46")]
	[Token(Token = "0x6001559")]
	public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

	[Address(RVA = "0x20B2440", Offset = "0x20B1840", Length = "0x92")]
	[Token(Token = "0x6001557")]
	private static object get_InternalSyncObject() { }

	[Address(RVA = "0x1E8B030", Offset = "0x1E8A430", Length = "0xD")]
	[Token(Token = "0x600155B")]
	public virtual int get_Remaining() { }

	[Address(RVA = "0x20B20A0", Offset = "0x20B14A0", Length = "0x21")]
	[Token(Token = "0x600155A")]
	public virtual char GetNextChar() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600155D")]
	internal virtual int InternalFallback(Byte[] bytes, Byte* pBytes) { }

	[Address(RVA = "0x1E8B010", Offset = "0x1E8A410", Length = "0x10")]
	[Token(Token = "0x600155C")]
	public virtual void Reset() { }

	[Address(RVA = "0x20B20D0", Offset = "0x20B14D0", Length = "0x1A5")]
	[Token(Token = "0x600155E")]
	private char TryBestFit(Byte[] bytesCheck) { }

}

