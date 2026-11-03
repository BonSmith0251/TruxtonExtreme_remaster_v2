namespace System.Text;

[Token(Token = "0x200029D")]
public abstract class DecoderFallback
{
	[Token(Token = "0x4000B71")]
	private static DecoderFallback s_replacementFallback; //Field offset: 0x0
	[Token(Token = "0x4000B72")]
	private static DecoderFallback s_exceptionFallback; //Field offset: 0x8

	[Token(Token = "0x1700020A")]
	public static DecoderFallback ExceptionFallback
	{
		[Address(RVA = "0x20AED90", Offset = "0x20AE190", Length = "0x9F")]
		[Token(Token = "0x600156D")]
		 get { } //Length: 159
	}

	[Token(Token = "0x1700020B")]
	public abstract int MaxCharCount
	{
		[Token(Token = "0x600156F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000209")]
	public static DecoderFallback ReplacementFallback
	{
		[Address(RVA = "0x20AEE30", Offset = "0x20AE230", Length = "0x99")]
		[Token(Token = "0x600156C")]
		 get { } //Length: 153
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001570")]
	protected DecoderFallback() { }

	[Token(Token = "0x600156E")]
	public abstract DecoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x20AED90", Offset = "0x20AE190", Length = "0x9F")]
	[Token(Token = "0x600156D")]
	public static DecoderFallback get_ExceptionFallback() { }

	[Token(Token = "0x600156F")]
	public abstract int get_MaxCharCount() { }

	[Address(RVA = "0x20AEE30", Offset = "0x20AE230", Length = "0x99")]
	[Token(Token = "0x600156C")]
	public static DecoderFallback get_ReplacementFallback() { }

}

