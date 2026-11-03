namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200019F")]
internal abstract class QueryExpression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007BA")]
	internal QueryOperator Operator; //Field offset: 0x10

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x6000E55")]
	public QueryExpression(QueryOperator operator) { }

	[Address(RVA = "0x21A3750", Offset = "0x21A2B50", Length = "0x25")]
	[Token(Token = "0x6000E56")]
	public bool IsMatch(JToken root, JToken t) { }

	[Token(Token = "0x6000E57")]
	public abstract bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }

}

