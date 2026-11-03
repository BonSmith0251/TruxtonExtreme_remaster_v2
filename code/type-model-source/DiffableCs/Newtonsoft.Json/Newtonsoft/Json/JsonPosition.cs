namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000026")]
internal struct JsonPosition
{
	[Token(Token = "0x400004C")]
	private static readonly Char[] SpecialCharacters; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004D")]
	internal JsonContainerType Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400004E")]
	internal int Position; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Nullable(2)]
	[Token(Token = "0x400004F")]
	internal string PropertyName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000050")]
	internal bool HasIndex; //Field offset: 0x10

	[Address(RVA = "0x20CDCC0", Offset = "0x20CD0C0", Length = "0x8C")]
	[Token(Token = "0x60000B3")]
	private static JsonPosition() { }

	[Address(RVA = "0x20CDD50", Offset = "0x20CD150", Length = "0x78")]
	[Token(Token = "0x60000AD")]
	public JsonPosition(JsonContainerType type) { }

	[Address(RVA = "0x20CD3A0", Offset = "0x20CC7A0", Length = "0x43C")]
	[Token(Token = "0x60000B1")]
	internal static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition) { }

	[Address(RVA = "0x20CD7E0", Offset = "0x20CCBE0", Length = "0x91")]
	[Token(Token = "0x60000AE")]
	internal int CalculateLength() { }

	[Address(RVA = "0x20CD880", Offset = "0x20CCC80", Length = "0x21B")]
	[Token(Token = "0x60000B2")]
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	[Address(RVA = "0x20CDAA0", Offset = "0x20CCEA0", Length = "0xF")]
	[Token(Token = "0x60000B0")]
	internal static bool TypeHasIndex(JsonContainerType type) { }

	[Address(RVA = "0x20CDAB0", Offset = "0x20CCEB0", Length = "0x205")]
	[NullableContext(2)]
	[Token(Token = "0x60000AF")]
	internal void WriteTo(StringBuilder sb, ref StringWriter writer, ref Char[] buffer) { }

}

