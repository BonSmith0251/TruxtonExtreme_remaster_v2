namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001A1")]
internal class BooleanQueryExpression : QueryExpression
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007BC")]
	public readonly object Left; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Nullable(2)]
	[Token(Token = "0x40007BD")]
	public readonly object Right; //Field offset: 0x20

	[Address(RVA = "0x19529A0", Offset = "0x1951DA0", Length = "0x5D")]
	[Token(Token = "0x6000E5C")]
	public BooleanQueryExpression(QueryOperator operator, object left, object right) { }

	[Address(RVA = "0x218FCF0", Offset = "0x218F0F0", Length = "0x157")]
	[Token(Token = "0x6000E62")]
	internal static bool EqualsWithStrictMatch(JValue value, JValue queryValue) { }

	[Address(RVA = "0x218FE50", Offset = "0x218F250", Length = "0x228")]
	[Token(Token = "0x6000E61")]
	internal static bool EqualsWithStringCoercion(JValue value, JValue queryValue) { }

	[Address(RVA = "0x21903A0", Offset = "0x218F7A0", Length = "0x1EE")]
	[Token(Token = "0x6000E5D")]
	private IEnumerable<JToken> GetResult(JToken root, JToken t, object o) { }

	[Address(RVA = "0x2190590", Offset = "0x218F990", Length = "0x4AC")]
	[Token(Token = "0x6000E5E")]
	public virtual bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }

	[Address(RVA = "0x2190A40", Offset = "0x218FE40", Length = "0x238")]
	[Token(Token = "0x6000E5F")]
	private bool MatchTokens(JToken leftResult, JToken rightResult, JsonSelectSettings settings) { }

	[Address(RVA = "0x2190CB0", Offset = "0x21900B0", Length = "0x1DB")]
	[Token(Token = "0x6000E60")]
	private static bool RegexEquals(JValue input, JValue pattern, JsonSelectSettings settings) { }

}

