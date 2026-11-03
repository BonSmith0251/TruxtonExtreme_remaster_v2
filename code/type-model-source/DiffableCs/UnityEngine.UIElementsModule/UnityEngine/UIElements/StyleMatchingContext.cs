namespace UnityEngine.UIElements;

[Token(Token = "0x2000563")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleMatchingContext
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011E0")]
	private List<StyleSheet> m_StyleSheetStack; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40011E1")]
	public StyleVariableContext variableContext; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40011E2")]
	public VisualElement currentElement; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40011E3")]
	public Action<VisualElement, MatchResultInfo> processResult; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011E4")]
	public AncestorFilter ancestorFilter; //Field offset: 0x30

	[Token(Token = "0x17000A21")]
	public int styleSheetCount
	{
		[Address(RVA = "0x32DEB90", Offset = "0x32DDF90", Length = "0x3C")]
		[Token(Token = "0x6002742")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x32DEA70", Offset = "0x32DDE70", Length = "0x11E")]
	[Token(Token = "0x6002743")]
	public StyleMatchingContext(Action<VisualElement, MatchResultInfo> processResult) { }

	[Address(RVA = "0x32DE8C0", Offset = "0x32DDCC0", Length = "0xDC")]
	[Token(Token = "0x6002744")]
	public void AddStyleSheet(StyleSheet sheet) { }

	[Address(RVA = "0x32DEB90", Offset = "0x32DDF90", Length = "0x3C")]
	[Token(Token = "0x6002742")]
	public int get_styleSheetCount() { }

	[Address(RVA = "0x32DE9A0", Offset = "0x32DDDA0", Length = "0x51")]
	[Token(Token = "0x6002746")]
	public StyleSheet GetStyleSheetAt(int index) { }

	[Address(RVA = "0x32DEA00", Offset = "0x32DDE00", Length = "0x61")]
	[Token(Token = "0x6002745")]
	public void RemoveStyleSheetRange(int index, int count) { }

}

