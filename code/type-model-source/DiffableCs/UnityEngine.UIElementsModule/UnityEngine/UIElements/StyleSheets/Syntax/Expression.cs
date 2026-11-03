namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x2000646")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class Expression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001786")]
	public ExpressionType type; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001787")]
	public ExpressionMultiplier multiplier; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001788")]
	public DataType dataType; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001789")]
	public ExpressionCombinator combinator; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400178A")]
	public Expression[] subExpressions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400178B")]
	public float min; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400178C")]
	public float max; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400178D")]
	public string keyword; //Field offset: 0x38

	[Address(RVA = "0x3362500", Offset = "0x3361900", Length = "0x64")]
	[Token(Token = "0x6002CAC")]
	public Expression(ExpressionType type) { }

}

