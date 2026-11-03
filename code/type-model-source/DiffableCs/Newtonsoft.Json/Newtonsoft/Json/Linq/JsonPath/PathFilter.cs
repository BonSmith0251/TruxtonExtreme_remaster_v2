namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x200019D")]
internal abstract class PathFilter
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000E54")]
	protected PathFilter() { }

	[NullableContext(1)]
	[Token(Token = "0x6000E51")]
	public abstract IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

	[Address(RVA = "0x21A3320", Offset = "0x21A2720", Length = "0xC1")]
	[Token(Token = "0x6000E53")]
	protected static JToken GetNextScanValue(JToken originalParent, JToken container, JToken value) { }

	[Address(RVA = "0x21A33F0", Offset = "0x21A27F0", Length = "0x355")]
	[Token(Token = "0x6000E52")]
	protected static JToken GetTokenIndex(JToken t, JsonSelectSettings settings, int index) { }

}

