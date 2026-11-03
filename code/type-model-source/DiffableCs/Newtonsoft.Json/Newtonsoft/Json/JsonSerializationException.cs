namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000031")]
public class JsonSerializationException : JsonException
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400009C")]
	private readonly int <LineNumber>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400009D")]
	private readonly int <LinePosition>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Nullable(2)]
	[Token(Token = "0x400009E")]
	private readonly string <Path>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x1700003F")]
	public int LineNumber
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600013F")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000040")]
	public int LinePosition
	{
		[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000140")]
		 get { } //Length: 7
	}

	[Nullable(2)]
	[Token(Token = "0x17000041")]
	public string Path
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x6000141")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x20CCFD0", Offset = "0x20CC3D0", Length = "0x49")]
	[Token(Token = "0x6000142")]
	public JsonSerializationException() { }

	[Address(RVA = "0x20CD020", Offset = "0x20CC420", Length = "0x59")]
	[Token(Token = "0x6000143")]
	public JsonSerializationException(string message) { }

	[Address(RVA = "0x20CD080", Offset = "0x20CC480", Length = "0x69")]
	[Token(Token = "0x6000144")]
	public JsonSerializationException(string message, Exception innerException) { }

	[Address(RVA = "0x20CD0F0", Offset = "0x20CC4F0", Length = "0x74")]
	[Token(Token = "0x6000145")]
	public JsonSerializationException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x20CE810", Offset = "0x20CDC10", Length = "0x9F")]
	[Token(Token = "0x6000146")]
	public JsonSerializationException(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	[Address(RVA = "0x20D3FF0", Offset = "0x20D33F0", Length = "0x1AD")]
	[Token(Token = "0x6000147")]
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	[Address(RVA = "0x20D41A0", Offset = "0x20D35A0", Length = "0x1AD")]
	[Token(Token = "0x6000148")]
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	[Address(RVA = "0x20D4350", Offset = "0x20D3750", Length = "0x15C")]
	[Token(Token = "0x6000149")]
	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600013F")]
	public int get_LineNumber() { }

	[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000140")]
	public int get_LinePosition() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x6000141")]
	public string get_Path() { }

}

