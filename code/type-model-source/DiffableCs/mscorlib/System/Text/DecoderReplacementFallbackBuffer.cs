namespace System.Text;

[Token(Token = "0x20002A1")]
public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B7A")]
	private string _strDefault; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B7B")]
	private int _fallbackCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000B7C")]
	private int _fallbackIndex; //Field offset: 0x2C

	[Token(Token = "0x17000211")]
	public virtual int Remaining
	{
		[Address(RVA = "0x20AFDB0", Offset = "0x20AF1B0", Length = "0xD")]
		[Token(Token = "0x6001594")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x20AFD60", Offset = "0x20AF160", Length = "0x44")]
	[Token(Token = "0x6001591")]
	public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback) { }

	[Address(RVA = "0x20AFC80", Offset = "0x20AF080", Length = "0x47")]
	[Token(Token = "0x6001592")]
	public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

	[Address(RVA = "0x20AFDB0", Offset = "0x20AF1B0", Length = "0xD")]
	[Token(Token = "0x6001594")]
	public virtual int get_Remaining() { }

	[Address(RVA = "0x20AFCD0", Offset = "0x20AF0D0", Length = "0x4D")]
	[Token(Token = "0x6001593")]
	public virtual char GetNextChar() { }

	[Address(RVA = "0x20AFD20", Offset = "0x20AF120", Length = "0x1A")]
	[Token(Token = "0x6001596")]
	internal virtual int InternalFallback(Byte[] bytes, Byte* pBytes) { }

	[Address(RVA = "0x20AFD40", Offset = "0x20AF140", Length = "0x11")]
	[Token(Token = "0x6001595")]
	public virtual void Reset() { }

}

