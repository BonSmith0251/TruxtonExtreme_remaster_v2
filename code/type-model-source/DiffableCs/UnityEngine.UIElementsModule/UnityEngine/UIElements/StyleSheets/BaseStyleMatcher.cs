namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x2000643")]
internal abstract class BaseStyleMatcher
{
	[Token(Token = "0x2000644")]
	private struct MatchContext
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001783")]
		public int valueIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4001784")]
		public int matchedVariableCount; //Field offset: 0x4

	}

	[Token(Token = "0x4001780")]
	protected static readonly Regex s_CustomIdentRegex; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001781")]
	private Stack<MatchContext> m_ContextStack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001782")]
	private MatchContext m_CurrentContext; //Field offset: 0x18

	[Token(Token = "0x17000B59")]
	public int currentIndex
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6002C82")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6002C83")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000B58")]
	public bool hasCurrent
	{
		[Address(RVA = "0x335EB20", Offset = "0x335DF20", Length = "0x27")]
		[Token(Token = "0x6002C81")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000B57")]
	public abstract bool isCurrentComma
	{
		[Token(Token = "0x6002C80")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000B56")]
	public abstract bool isCurrentVariable
	{
		[Token(Token = "0x6002C7F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000B5A")]
	public int matchedVariableCount
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6002C84")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x6002C85")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000B55")]
	public abstract int valueCount
	{
		[Token(Token = "0x6002C7E")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x335EA10", Offset = "0x335DE10", Length = "0x8D")]
	[Token(Token = "0x6002C98")]
	private static BaseStyleMatcher() { }

	[Address(RVA = "0x335EAA0", Offset = "0x335DEA0", Length = "0x77")]
	[Token(Token = "0x6002C97")]
	protected BaseStyleMatcher() { }

	[Address(RVA = "0x335D9E0", Offset = "0x335CDE0", Length = "0x44")]
	[Token(Token = "0x6002C8A")]
	public void DropContext() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6002C82")]
	public int get_currentIndex() { }

	[Address(RVA = "0x335EB20", Offset = "0x335DF20", Length = "0x27")]
	[Token(Token = "0x6002C81")]
	public bool get_hasCurrent() { }

	[Token(Token = "0x6002C80")]
	public abstract bool get_isCurrentComma() { }

	[Token(Token = "0x6002C7F")]
	public abstract bool get_isCurrentVariable() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6002C84")]
	public int get_matchedVariableCount() { }

	[Token(Token = "0x6002C7E")]
	public abstract int get_valueCount() { }

	[Address(RVA = "0x335DA30", Offset = "0x335CE30", Length = "0x4A")]
	[Token(Token = "0x6002C86")]
	protected void Initialize() { }

	[Address(RVA = "0x335E7A0", Offset = "0x335DBA0", Length = "0x18F")]
	[Token(Token = "0x6002C8B")]
	protected bool Match(Expression exp) { }

	[Address(RVA = "0x335DA80", Offset = "0x335CE80", Length = "0x30")]
	[Token(Token = "0x6002C92")]
	private bool MatchAndAnd(Expression exp) { }

	[Token(Token = "0x6002C7C")]
	protected abstract bool MatchAngle() { }

	[Token(Token = "0x6002C76")]
	protected abstract bool MatchColor() { }

	[Address(RVA = "0x335DAC0", Offset = "0x335CEC0", Length = "0x338")]
	[Token(Token = "0x6002C8F")]
	private bool MatchCombinator(Expression exp) { }

	[Token(Token = "0x6002C7D")]
	protected abstract bool MatchCustomIdent() { }

	[Address(RVA = "0x335DE10", Offset = "0x335D210", Length = "0x180")]
	[Token(Token = "0x6002C96")]
	private bool MatchDataType(Expression exp) { }

	[Address(RVA = "0x335E0E0", Offset = "0x335D4E0", Length = "0x102")]
	[Token(Token = "0x6002C8C")]
	private bool MatchExpression(Expression exp) { }

	[Address(RVA = "0x335DFC0", Offset = "0x335D3C0", Length = "0x113")]
	[Token(Token = "0x6002C8D")]
	private bool MatchExpressionWithMultiplier(Expression exp) { }

	[Token(Token = "0x6002C7A")]
	protected abstract bool MatchFilterFunction() { }

	[Address(RVA = "0x335E1F0", Offset = "0x335D5F0", Length = "0xAE")]
	[Token(Token = "0x6002C8E")]
	private bool MatchGroup(Expression exp) { }

	[Token(Token = "0x6002C73")]
	protected abstract bool MatchInteger() { }

	[Address(RVA = "0x335E2A0", Offset = "0x335D6A0", Length = "0x79")]
	[Token(Token = "0x6002C95")]
	private bool MatchJuxtaposition(Expression exp) { }

	[Token(Token = "0x6002C71")]
	protected abstract bool MatchKeyword(string keyword) { }

	[Token(Token = "0x6002C74")]
	protected abstract bool MatchLength() { }

	[Address(RVA = "0x335E490", Offset = "0x335D890", Length = "0x1B8")]
	[Token(Token = "0x6002C93")]
	private int MatchMany(Expression exp) { }

	[Address(RVA = "0x335E320", Offset = "0x335D720", Length = "0x166")]
	[Token(Token = "0x6002C94")]
	private int MatchManyByOrder(Expression exp, Int32* matchOrder) { }

	[Token(Token = "0x6002C7B")]
	protected abstract bool MatchMaterialPropertyValue() { }

	[Token(Token = "0x6002C72")]
	protected abstract bool MatchNumber(Expression exp) { }

	[Address(RVA = "0x335E670", Offset = "0x335DA70", Length = "0x121")]
	[Token(Token = "0x6002C90")]
	private bool MatchOr(Expression exp) { }

	[Address(RVA = "0x335E650", Offset = "0x335DA50", Length = "0x16")]
	[Token(Token = "0x6002C91")]
	private bool MatchOrOr(Expression exp) { }

	[Token(Token = "0x6002C75")]
	protected abstract bool MatchPercentage() { }

	[Token(Token = "0x6002C77")]
	protected abstract bool MatchResource() { }

	[Token(Token = "0x6002C79")]
	protected abstract bool MatchTime() { }

	[Token(Token = "0x6002C78")]
	protected abstract bool MatchUrl() { }

	[Address(RVA = "0x335E930", Offset = "0x335DD30", Length = "0x38")]
	[Token(Token = "0x6002C87")]
	public void MoveNext() { }

	[Address(RVA = "0x335E970", Offset = "0x335DD70", Length = "0x49")]
	[Token(Token = "0x6002C89")]
	public void RestoreContext() { }

	[Address(RVA = "0x335E9C0", Offset = "0x335DDC0", Length = "0x48")]
	[Token(Token = "0x6002C88")]
	public void SaveContext() { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6002C83")]
	public void set_currentIndex(int value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x6002C85")]
	public void set_matchedVariableCount(int value) { }

}

