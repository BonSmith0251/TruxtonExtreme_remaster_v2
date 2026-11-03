namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200002F")]
public class JsonReaderException : JsonException
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000099")]
	private readonly int <LineNumber>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400009A")]
	private readonly int <LinePosition>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Nullable(2)]
	[Token(Token = "0x400009B")]
	private readonly string <Path>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x1700003C")]
	public int LineNumber
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000133")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700003D")]
	public int LinePosition
	{
		[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000134")]
		 get { } //Length: 7
	}

	[Nullable(2)]
	[Token(Token = "0x1700003E")]
	public string Path
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x6000135")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x20CCFD0", Offset = "0x20CC3D0", Length = "0x49")]
	[Token(Token = "0x6000136")]
	public JsonReaderException() { }

	[Address(RVA = "0x20CD020", Offset = "0x20CC420", Length = "0x59")]
	[Token(Token = "0x6000137")]
	public JsonReaderException(string message) { }

	[Address(RVA = "0x20CD080", Offset = "0x20CC480", Length = "0x69")]
	[Token(Token = "0x6000138")]
	public JsonReaderException(string message, Exception innerException) { }

	[Address(RVA = "0x20CD0F0", Offset = "0x20CC4F0", Length = "0x74")]
	[Token(Token = "0x6000139")]
	public JsonReaderException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x20CE810", Offset = "0x20CDC10", Length = "0x9F")]
	[Token(Token = "0x600013A")]
	public JsonReaderException(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	[Address(RVA = "0x20CE800", Offset = "0x20CDC00", Length = "0xB")]
	[Token(Token = "0x600013B")]
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	[Address(RVA = "0x20CE650", Offset = "0x20CDA50", Length = "0x1AD")]
	[Token(Token = "0x600013C")]
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	[Address(RVA = "0x20CE4F0", Offset = "0x20CD8F0", Length = "0x15C")]
	[Token(Token = "0x600013D")]
	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000133")]
	public int get_LineNumber() { }

	[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000134")]
	public int get_LinePosition() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x6000135")]
	public string get_Path() { }

}

