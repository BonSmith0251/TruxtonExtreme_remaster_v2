namespace Newtonsoft.Json.Linq;

[Token(Token = "0x200017F")]
public class JsonSelectSettings
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000702")]
	private Nullable<TimeSpan> <RegexMatchTimeout>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000703")]
	private bool <ErrorWhenNoMatch>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000212")]
	public bool ErrorWhenNoMatch
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CA6")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000CA7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000211")]
	public Nullable<TimeSpan> RegexMatchTimeout
	{
		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000CA4")]
		 get { } //Length: 11
		[Address(RVA = "0x6622B0", Offset = "0x6616B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000CA5")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000CA8")]
	public JsonSelectSettings() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CA6")]
	public bool get_ErrorWhenNoMatch() { }

	[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000CA4")]
	public Nullable<TimeSpan> get_RegexMatchTimeout() { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000CA7")]
	public void set_ErrorWhenNoMatch(bool value) { }

	[Address(RVA = "0x6622B0", Offset = "0x6616B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000CA5")]
	public void set_RegexMatchTimeout(Nullable<TimeSpan> value) { }

}

