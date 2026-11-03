namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000189")]
public class JTokenReader : JsonReader, IJsonLineInfo
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400073E")]
	private readonly JToken _root; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Nullable(2)]
	[Token(Token = "0x400073F")]
	private string _initialPath; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Nullable(2)]
	[Token(Token = "0x4000740")]
	private JToken _parent; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Nullable(2)]
	[Token(Token = "0x4000741")]
	private JToken _current; //Field offset: 0x90

	[Nullable(2)]
	[Token(Token = "0x1700022B")]
	public JToken CurrentToken
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[NullableContext(2)]
		[Token(Token = "0x6000D78")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700022C")]
	private override int Newtonsoft.Json.IJsonLineInfo.LineNumber
	{
		[Address(RVA = "0x2199A90", Offset = "0x2198E90", Length = "0x55")]
		[Token(Token = "0x6000D84")]
		private get { } //Length: 85
	}

	[Token(Token = "0x1700022D")]
	private override int Newtonsoft.Json.IJsonLineInfo.LinePosition
	{
		[Address(RVA = "0x2199AF0", Offset = "0x2198EF0", Length = "0x55")]
		[Token(Token = "0x6000D85")]
		private get { } //Length: 85
	}

	[Token(Token = "0x1700022E")]
	public virtual string Path
	{
		[Address(RVA = "0x219B050", Offset = "0x219A450", Length = "0xF4")]
		[Token(Token = "0x6000D86")]
		 get { } //Length: 244
	}

	[Address(RVA = "0x219AF50", Offset = "0x219A350", Length = "0x62")]
	[Token(Token = "0x6000D79")]
	public JTokenReader(JToken token) { }

	[Address(RVA = "0x219AFC0", Offset = "0x219A3C0", Length = "0x85")]
	[Token(Token = "0x6000D7A")]
	public JTokenReader(JToken token, string initialPath) { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[NullableContext(2)]
	[Token(Token = "0x6000D78")]
	public JToken get_CurrentToken() { }

	[Address(RVA = "0x219B050", Offset = "0x219A450", Length = "0xF4")]
	[Token(Token = "0x6000D86")]
	public virtual string get_Path() { }

	[Address(RVA = "0x21998C0", Offset = "0x2198CC0", Length = "0x16D")]
	[Token(Token = "0x6000D7E")]
	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	[Address(RVA = "0x2199A90", Offset = "0x2198E90", Length = "0x55")]
	[Token(Token = "0x6000D84")]
	private override int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	[Address(RVA = "0x2199AF0", Offset = "0x2198EF0", Length = "0x55")]
	[Token(Token = "0x6000D85")]
	private override int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	[Address(RVA = "0x2199A30", Offset = "0x2198E30", Length = "0x52")]
	[Token(Token = "0x6000D83")]
	private override bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	[Address(RVA = "0x219A440", Offset = "0x2199840", Length = "0x161")]
	[Token(Token = "0x6000D7B")]
	public virtual bool Read() { }

	[Address(RVA = "0x2199B50", Offset = "0x2198F50", Length = "0xA4")]
	[Token(Token = "0x6000D7F")]
	private bool ReadInto(JContainer c) { }

	[Address(RVA = "0x2199C00", Offset = "0x2199000", Length = "0x7B4")]
	[Token(Token = "0x6000D7C")]
	private bool ReadOver(JToken t) { }

	[Address(RVA = "0x219A400", Offset = "0x2199800", Length = "0x37")]
	[Token(Token = "0x6000D7D")]
	private bool ReadToEnd() { }

	[Address(RVA = "0x219A5B0", Offset = "0x21999B0", Length = "0x22")]
	[NullableContext(2)]
	[Token(Token = "0x6000D82")]
	private string SafeToString(object value) { }

	[Address(RVA = "0x219A5E0", Offset = "0x21999E0", Length = "0x1A3")]
	[Token(Token = "0x6000D80")]
	private bool SetEnd(JContainer c) { }

	[Address(RVA = "0x219A790", Offset = "0x2199B90", Length = "0x778")]
	[Token(Token = "0x6000D81")]
	private void SetToken(JToken token) { }

}

