namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x200063B")]
internal static class StyleSelectorHelper
{
	[Token(Token = "0x200063C")]
	private struct SelectorWorkItem
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400176B")]
		public OrderedSelectorType type; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400176C")]
		public string input; //Field offset: 0x8

		[Address(RVA = "0xAEE390", Offset = "0xAED790", Length = "0x12")]
		[Token(Token = "0x6002C6B")]
		public SelectorWorkItem(OrderedSelectorType type, string input) { }

	}


	[Address(RVA = "0x335C2B0", Offset = "0x335B6B0", Length = "0x3B2")]
	[Token(Token = "0x6002C69")]
	private static void FastLookup(IDictionary<String, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record) { }

	[Address(RVA = "0x335C670", Offset = "0x335BA70", Length = "0x7ED")]
	[Token(Token = "0x6002C6A")]
	public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex) { }

	[Address(RVA = "0x335D050", Offset = "0x335C450", Length = "0x2F0")]
	[Token(Token = "0x6002C66")]
	public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector) { }

	[Address(RVA = "0x335CE60", Offset = "0x335C260", Length = "0x1E5")]
	[Token(Token = "0x6002C67")]
	public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult) { }

	[Address(RVA = "0x335D360", Offset = "0x335C760", Length = "0xF7")]
	[Token(Token = "0x6002C68")]
	private static void TestSelectorLinkedList(StyleComplexSelector currentComplexSelector, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, ref SelectorMatchRecord record) { }

}

