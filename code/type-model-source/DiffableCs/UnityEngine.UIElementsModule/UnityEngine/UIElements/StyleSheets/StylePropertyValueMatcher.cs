namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x2000645")]
internal class StylePropertyValueMatcher : BaseStyleMatcher
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001785")]
	private List<StylePropertyValue> m_Values; //Field offset: 0x20

	[Token(Token = "0x17000B5B")]
	private StylePropertyValue current
	{
		[Address(RVA = "0x336CDC0", Offset = "0x336C1C0", Length = "0x97")]
		[Token(Token = "0x6002C99")]
		private get { } //Length: 151
	}

	[Token(Token = "0x17000B5E")]
	public virtual bool isCurrentComma
	{
		[Address(RVA = "0x336CE60", Offset = "0x336C260", Length = "0xAC")]
		[Token(Token = "0x6002C9C")]
		 get { } //Length: 172
	}

	[Token(Token = "0x17000B5D")]
	public virtual bool isCurrentVariable
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002C9B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000B5C")]
	public virtual int valueCount
	{
		[Address(RVA = "0x336CF10", Offset = "0x336C310", Length = "0x3C")]
		[Token(Token = "0x6002C9A")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x336CD10", Offset = "0x336C110", Length = "0xA8")]
	[Token(Token = "0x6002CAB")]
	public StylePropertyValueMatcher() { }

	[Address(RVA = "0x336CDC0", Offset = "0x336C1C0", Length = "0x97")]
	[Token(Token = "0x6002C99")]
	private StylePropertyValue get_current() { }

	[Address(RVA = "0x336CE60", Offset = "0x336C260", Length = "0xAC")]
	[Token(Token = "0x6002C9C")]
	public virtual bool get_isCurrentComma() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002C9B")]
	public virtual bool get_isCurrentVariable() { }

	[Address(RVA = "0x336CF10", Offset = "0x336C310", Length = "0x3C")]
	[Token(Token = "0x6002C9A")]
	public virtual int get_valueCount() { }

	[Address(RVA = "0x336CA40", Offset = "0x336BE40", Length = "0x2C0")]
	[Token(Token = "0x6002C9D")]
	public MatchResult Match(Expression exp, List<StylePropertyValue> values) { }

	[Address(RVA = "0x336BDA0", Offset = "0x336B1A0", Length = "0x110")]
	[Token(Token = "0x6002CAA")]
	protected virtual bool MatchAngle() { }

	[Address(RVA = "0x336BEC0", Offset = "0x336B2C0", Length = "0x188")]
	[Token(Token = "0x6002CA3")]
	protected virtual bool MatchColor() { }

	[Address(RVA = "0x336C050", Offset = "0x336B450", Length = "0x146")]
	[Token(Token = "0x6002CA9")]
	protected virtual bool MatchCustomIdent() { }

	[Address(RVA = "0x336C1A0", Offset = "0x336B5A0", Length = "0x160")]
	[Token(Token = "0x6002CA7")]
	protected virtual bool MatchFilterFunction() { }

	[Address(RVA = "0x336C310", Offset = "0x336B710", Length = "0x9E")]
	[Token(Token = "0x6002CA0")]
	protected virtual bool MatchInteger() { }

	[Address(RVA = "0x336C3B0", Offset = "0x336B7B0", Length = "0x10C")]
	[Token(Token = "0x6002C9E")]
	protected virtual bool MatchKeyword(string keyword) { }

	[Address(RVA = "0x336C4C0", Offset = "0x336B8C0", Length = "0x10C")]
	[Token(Token = "0x6002CA1")]
	protected virtual bool MatchLength() { }

	[Address(RVA = "0x336C1A0", Offset = "0x336B5A0", Length = "0x160")]
	[Token(Token = "0x6002CA8")]
	protected virtual bool MatchMaterialPropertyValue() { }

	[Address(RVA = "0x336C5D0", Offset = "0x336B9D0", Length = "0x102")]
	[Token(Token = "0x6002C9F")]
	protected virtual bool MatchNumber(Expression exp) { }

	[Address(RVA = "0x336C6E0", Offset = "0x336BAE0", Length = "0x10C")]
	[Token(Token = "0x6002CA2")]
	protected virtual bool MatchPercentage() { }

	[Address(RVA = "0x336C7F0", Offset = "0x336BBF0", Length = "0x9E")]
	[Token(Token = "0x6002CA4")]
	protected virtual bool MatchResource() { }

	[Address(RVA = "0x336C890", Offset = "0x336BC90", Length = "0xE9")]
	[Token(Token = "0x6002CA6")]
	protected virtual bool MatchTime() { }

	[Address(RVA = "0x336C980", Offset = "0x336BD80", Length = "0xB5")]
	[Token(Token = "0x6002CA5")]
	protected virtual bool MatchUrl() { }

}

