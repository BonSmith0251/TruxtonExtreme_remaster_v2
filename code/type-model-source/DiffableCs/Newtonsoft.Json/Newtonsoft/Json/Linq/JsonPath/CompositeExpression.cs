namespace Newtonsoft.Json.Linq.JsonPath;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001A0")]
internal class CompositeExpression : QueryExpression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007BB")]
	private List<QueryExpression> <Expressions>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000243")]
	public List<QueryExpression> Expressions
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000E58")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000E59")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2191440", Offset = "0x2190840", Length = "0x7C")]
	[Token(Token = "0x6000E5A")]
	public CompositeExpression(QueryOperator operator) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000E58")]
	public List<QueryExpression> get_Expressions() { }

	[Address(RVA = "0x2191190", Offset = "0x2190590", Length = "0x2AD")]
	[Token(Token = "0x6000E5B")]
	public virtual bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000E59")]
	public void set_Expressions(List<QueryExpression> value) { }

}

