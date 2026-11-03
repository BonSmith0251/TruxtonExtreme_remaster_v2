namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200019C")]
internal class JPath
{
	[Token(Token = "0x40007A8")]
	private static readonly Char[] FloatCharacters; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007A9")]
	private readonly string _expression; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007AA")]
	private readonly List<PathFilter> <Filters>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007AB")]
	private int _currentIndex; //Field offset: 0x20

	[Token(Token = "0x17000242")]
	public List<PathFilter> Filters
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000E3A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x21996E0", Offset = "0x2198AE0", Length = "0x8C")]
	[Token(Token = "0x6000E50")]
	private static JPath() { }

	[Address(RVA = "0x2199770", Offset = "0x2198B70", Length = "0xB2")]
	[Token(Token = "0x6000E3B")]
	public JPath(string expression) { }

	[Address(RVA = "0x21962D0", Offset = "0x21956D0", Length = "0x7A")]
	[Token(Token = "0x6000E3E")]
	private static PathFilter CreatePathFilter(string member, bool scan) { }

	[Address(RVA = "0x2196350", Offset = "0x2195750", Length = "0xBC")]
	[Token(Token = "0x6000E44")]
	private JsonException CreateUnexpectedCharacterException() { }

	[Address(RVA = "0x2196410", Offset = "0x2195810", Length = "0x50")]
	[Token(Token = "0x6000E41")]
	private void EatWhitespace() { }

	[Address(RVA = "0x2196470", Offset = "0x2195870", Length = "0x6B")]
	[Token(Token = "0x6000E4D")]
	private void EnsureLength(string message) { }

	[Address(RVA = "0x21966D0", Offset = "0x2195AD0", Length = "0x83")]
	[Token(Token = "0x6000E4E")]
	internal IEnumerable<JToken> Evaluate(JToken root, JToken t, JsonSelectSettings settings) { }

	[Address(RVA = "0x21964E0", Offset = "0x21958E0", Length = "0x1E6")]
	[Token(Token = "0x6000E4F")]
	internal static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken root, JToken t, JsonSelectSettings settings) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000E3A")]
	public List<PathFilter> get_Filters() { }

	[Address(RVA = "0x2196760", Offset = "0x2195B60", Length = "0x97")]
	[Token(Token = "0x6000E4A")]
	private bool Match(string s) { }

	[Address(RVA = "0x2196800", Offset = "0x2195C00", Length = "0x92F")]
	[Token(Token = "0x6000E40")]
	private PathFilter ParseArrayIndexer(char indexerCloseChar) { }

	[Address(RVA = "0x2197130", Offset = "0x2196530", Length = "0x3BB")]
	[Token(Token = "0x6000E46")]
	private QueryExpression ParseExpression() { }

	[Address(RVA = "0x21974F0", Offset = "0x21968F0", Length = "0x16D")]
	[Token(Token = "0x6000E3F")]
	private PathFilter ParseIndexer(char indexerOpenChar, bool scan) { }

	[Address(RVA = "0x2197660", Offset = "0x2196A60", Length = "0x1DE")]
	[Token(Token = "0x6000E3C")]
	private void ParseMain() { }

	[Address(RVA = "0x2197840", Offset = "0x2196C40", Length = "0x5AD")]
	[Token(Token = "0x6000E4B")]
	private QueryOperator ParseOperator() { }

	[Address(RVA = "0x2197DF0", Offset = "0x21971F0", Length = "0x504")]
	[Token(Token = "0x6000E3D")]
	private bool ParsePath(List<PathFilter> filters, int currentPartStartIndex, bool query) { }

	[Address(RVA = "0x2198300", Offset = "0x2197700", Length = "0x2E1")]
	[Token(Token = "0x6000E42")]
	private PathFilter ParseQuery(char indexerCloseChar, bool scan) { }

	[Address(RVA = "0x21985F0", Offset = "0x21979F0", Length = "0x37C")]
	[Token(Token = "0x6000E4C")]
	private PathFilter ParseQuotedField(char indexerCloseChar, bool scan) { }

	[Address(RVA = "0x2198970", Offset = "0x2197D70", Length = "0x3F5")]
	[Token(Token = "0x6000E45")]
	private object ParseSide() { }

	[Address(RVA = "0x2198D70", Offset = "0x2198170", Length = "0x2AE")]
	[Token(Token = "0x6000E48")]
	private string ReadQuotedString() { }

	[Address(RVA = "0x2199020", Offset = "0x2198420", Length = "0x171")]
	[Token(Token = "0x6000E49")]
	private string ReadRegexString() { }

	[Address(RVA = "0x21991A0", Offset = "0x21985A0", Length = "0x1C6")]
	[Token(Token = "0x6000E43")]
	private bool TryParseExpression(out List<PathFilter>& expressionPath) { }

	[Address(RVA = "0x2199370", Offset = "0x2198770", Length = "0x369")]
	[NullableContext(2)]
	[Token(Token = "0x6000E47")]
	private bool TryParseValue(out object value) { }

}

