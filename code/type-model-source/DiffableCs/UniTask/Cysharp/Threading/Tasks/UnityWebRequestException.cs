namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000168")]
public class UnityWebRequestException : Exception
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400057C")]
	private readonly UnityWebRequest <UnityWebRequest>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400057D")]
	private readonly Result <Result>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400057E")]
	private readonly string <Error>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400057F")]
	private readonly string <Text>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000580")]
	private readonly long <ResponseCode>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000581")]
	private readonly Dictionary<String, String> <ResponseHeaders>k__BackingField; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000582")]
	private string msg; //Field offset: 0xC0

	[Token(Token = "0x17000062")]
	public string Error
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000897")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000066")]
	public virtual string Message
	{
		[Address(RVA = "0x2793E90", Offset = "0x2793290", Length = "0x97")]
		[Token(Token = "0x600089C")]
		 get { } //Length: 151
	}

	[Token(Token = "0x17000064")]
	public long ResponseCode
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000899")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000065")]
	public Dictionary<String, String> ResponseHeaders
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600089A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000061")]
	public Result Result
	{
		[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000896")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000063")]
	public string Text
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000898")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000060")]
	public UnityWebRequest UnityWebRequest
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000895")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2793D50", Offset = "0x2793150", Length = "0x13F")]
	[Token(Token = "0x600089B")]
	public UnityWebRequestException(UnityWebRequest unityWebRequest) { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000897")]
	public string get_Error() { }

	[Address(RVA = "0x2793E90", Offset = "0x2793290", Length = "0x97")]
	[Token(Token = "0x600089C")]
	public virtual string get_Message() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000899")]
	public long get_ResponseCode() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600089A")]
	public Dictionary<String, String> get_ResponseHeaders() { }

	[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000896")]
	public Result get_Result() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000898")]
	public string get_Text() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000895")]
	public UnityWebRequest get_UnityWebRequest() { }

}

