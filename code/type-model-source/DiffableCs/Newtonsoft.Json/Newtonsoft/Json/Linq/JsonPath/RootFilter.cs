namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001A6")]
internal class RootFilter : PathFilter
{
	[Token(Token = "0x40007D8")]
	public static readonly RootFilter Instance; //Field offset: 0x0

	[Address(RVA = "0x21A4600", Offset = "0x21A3A00", Length = "0x67")]
	[Token(Token = "0x6000E7D")]
	private static RootFilter() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000E7B")]
	private RootFilter() { }

	[Address(RVA = "0x21A4560", Offset = "0x21A3960", Length = "0x9A")]
	[Token(Token = "0x6000E7C")]
	public virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

}

