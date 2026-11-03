namespace System.Text.RegularExpressions;

[Token(Token = "0x20000ED")]
public class RegexMatchTimeoutException : TimeoutException, ISerializable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40003FE")]
	private readonly string <Input>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40003FF")]
	private readonly string <Pattern>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000400")]
	private readonly TimeSpan <MatchTimeout>k__BackingField; //Field offset: 0xA0

	[Token(Token = "0x170000DF")]
	public string Input
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000581")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000E1")]
	public TimeSpan MatchTimeout
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000583")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000E0")]
	public string Pattern
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000582")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2631280", Offset = "0x2630680", Length = "0x114")]
	[Token(Token = "0x600057D")]
	public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	[Address(RVA = "0x2631510", Offset = "0x2630910", Length = "0xA6")]
	[Token(Token = "0x600057E")]
	public RegexMatchTimeoutException() { }

	[Address(RVA = "0x26313A0", Offset = "0x26307A0", Length = "0x168")]
	[Token(Token = "0x600057F")]
	protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000581")]
	public string get_Input() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000583")]
	public TimeSpan get_MatchTimeout() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000582")]
	public string get_Pattern() { }

	[Address(RVA = "0x2631190", Offset = "0x2630590", Length = "0xEF")]
	[Token(Token = "0x6000580")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

