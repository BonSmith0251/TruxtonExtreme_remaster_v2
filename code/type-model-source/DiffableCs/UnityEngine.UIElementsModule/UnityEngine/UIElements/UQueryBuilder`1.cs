namespace UnityEngine.UIElements;

[Token(Token = "0x20004DC")]
public struct UQueryBuilder : IEquatable<UQueryBuilder`1<T>>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400105B")]
	private List<StyleSelector> m_StyleSelectors; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400105C")]
	private List<StyleSelectorPart> m_Parts; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400105D")]
	private VisualElement m_Element; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400105E")]
	private List<RuleMatcher> m_Matchers; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400105F")]
	private StyleSelectorRelationship m_Relationship; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001060")]
	private int pseudoStatesMask; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001061")]
	private int negatedPseudoStatesMask; //Field offset: 0x0

	[Token(Token = "0x170009BA")]
	private List<StyleSelectorPart> parts
	{
		[Address(RVA = "0x1118450", Offset = "0x1117850", Length = "0x7B")]
		[Token(Token = "0x60024EB")]
		private get { } //Length: 123
	}

	[Token(Token = "0x170009B9")]
	private List<StyleSelector> styleSelectors
	{
		[Address(RVA = "0x11184D0", Offset = "0x11178D0", Length = "0x78")]
		[Token(Token = "0x60024EA")]
		private get { } //Length: 120
	}

	[Address(RVA = "0x1118380", Offset = "0x1117780", Length = "0xC3")]
	[Token(Token = "0x60024EC")]
	public UQueryBuilder`1(VisualElement visualElement) { }

	[Address(RVA = "0x1116A90", Offset = "0x1115E90", Length = "0x12B")]
	[Token(Token = "0x60024F2")]
	private void AddClass(string c) { }

	[Address(RVA = "0x1116BC0", Offset = "0x1115FC0", Length = "0x1A0")]
	[Token(Token = "0x60024F3")]
	private void AddClasses(String[] classes) { }

	[Address(RVA = "0x1116D70", Offset = "0x1116170", Length = "0x12B")]
	[Token(Token = "0x60024F4")]
	private void AddName(string id) { }

	[Address(RVA = "0x1116EA0", Offset = "0x11162A0", Length = "0x13E")]
	[Token(Token = "0x60024F7")]
	private void AddPseudoStatesRuleIfNecessasy() { }

	[Address(RVA = "0x6A6FE0", Offset = "0x6A63E0", Length = "0xE7")]
	[Token(Token = "0x60024F6")]
	private UQueryBuilder<T2> AddRelationship(StyleSelectorRelationship relationship) { }

	[Address(RVA = "0x6A70D0", Offset = "0x6A64D0", Length = "0x1C8")]
	[Token(Token = "0x60024F5")]
	private void AddType() { }

	[Address(RVA = "0x1116FE0", Offset = "0x11163E0", Length = "0x215")]
	[Token(Token = "0x60024FB")]
	public UQueryState<T> Build() { }

	[Address(RVA = "0x1117200", Offset = "0x1116600", Length = "0x16F")]
	[Token(Token = "0x60024ED")]
	public UQueryBuilder<T> Class(string classname) { }

	[Address(RVA = "0x1117370", Offset = "0x1116770", Length = "0x90")]
	[Token(Token = "0x60024F9")]
	private bool CurrentSelectorEmpty() { }

	[Address(RVA = "0x1117530", Offset = "0x1116930", Length = "0x287")]
	[Token(Token = "0x60024FE")]
	public override bool Equals(UQueryBuilder<T> other) { }

	[Address(RVA = "0x1117410", Offset = "0x1116810", Length = "0x11B")]
	[Token(Token = "0x60024FF")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11177C0", Offset = "0x1116BC0", Length = "0x1E9")]
	[Token(Token = "0x60024FA")]
	private void FinishCurrentSelector() { }

	[Address(RVA = "0x11179B0", Offset = "0x1116DB0", Length = "0x272")]
	[Token(Token = "0x60024F8")]
	private void FinishSelector() { }

	[Address(RVA = "0x1117C30", Offset = "0x1117030", Length = "0xD5")]
	[Token(Token = "0x60024FD")]
	public void ForEach(Action<T> funcCall) { }

	[Address(RVA = "0x1118450", Offset = "0x1117850", Length = "0x7B")]
	[Token(Token = "0x60024EB")]
	private List<StyleSelectorPart> get_parts() { }

	[Address(RVA = "0x11184D0", Offset = "0x11178D0", Length = "0x78")]
	[Token(Token = "0x60024EA")]
	private List<StyleSelector> get_styleSelectors() { }

	[Address(RVA = "0x1117D10", Offset = "0x1117110", Length = "0x259")]
	[Token(Token = "0x6002500")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1117F70", Offset = "0x1117370", Length = "0x16F")]
	[Token(Token = "0x60024EE")]
	public UQueryBuilder<T> Name(string id) { }

	[Address(RVA = "0x6A72A0", Offset = "0x6A66A0", Length = "0x173")]
	[Token(Token = "0x60024F0")]
	public UQueryBuilder<T2> OfType(string name = null, string className = null) { }

	[Address(RVA = "0x6A7420", Offset = "0x6A6820", Length = "0x173")]
	[Token(Token = "0x60024EF")]
	public UQueryBuilder<T2> OfType(string name = null, String[] classes) { }

	[Address(RVA = "0x11180E0", Offset = "0x11174E0", Length = "0x1C1")]
	[Token(Token = "0x60024F1")]
	internal UQueryBuilder<T> SingleBaseType() { }

	[Address(RVA = "0x11182B0", Offset = "0x11176B0", Length = "0xC5")]
	[Token(Token = "0x60024FC")]
	public List<T> ToList() { }

}

