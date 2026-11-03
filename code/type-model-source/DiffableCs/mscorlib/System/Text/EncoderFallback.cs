namespace System.Text;

[Token(Token = "0x20002A8")]
public abstract class EncoderFallback
{
	[Token(Token = "0x4000B8A")]
	private static EncoderFallback s_replacementFallback; //Field offset: 0x0
	[Token(Token = "0x4000B8B")]
	private static EncoderFallback s_exceptionFallback; //Field offset: 0x8

	[Token(Token = "0x1700021B")]
	public static EncoderFallback ExceptionFallback
	{
		[Address(RVA = "0x1E8BAC0", Offset = "0x1E8AEC0", Length = "0x98")]
		[Token(Token = "0x60015C0")]
		 get { } //Length: 152
	}

	[Token(Token = "0x1700021C")]
	public abstract int MaxCharCount
	{
		[Token(Token = "0x60015C2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700021A")]
	public static EncoderFallback ReplacementFallback
	{
		[Address(RVA = "0x1E8BB60", Offset = "0x1E8AF60", Length = "0xB6")]
		[Token(Token = "0x60015BF")]
		 get { } //Length: 182
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60015C3")]
	protected EncoderFallback() { }

	[Token(Token = "0x60015C1")]
	public abstract EncoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x1E8BAC0", Offset = "0x1E8AEC0", Length = "0x98")]
	[Token(Token = "0x60015C0")]
	public static EncoderFallback get_ExceptionFallback() { }

	[Token(Token = "0x60015C2")]
	public abstract int get_MaxCharCount() { }

	[Address(RVA = "0x1E8BB60", Offset = "0x1E8AF60", Length = "0xB6")]
	[Token(Token = "0x60015BF")]
	public static EncoderFallback get_ReplacementFallback() { }

}

