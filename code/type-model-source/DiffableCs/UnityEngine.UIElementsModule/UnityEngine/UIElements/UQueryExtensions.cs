namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x20004DD")]
public static class UQueryExtensions
{
	[Token(Token = "0x4001062")]
	private static UQueryState<VisualElement> SingleElementEmptyQuery; //Field offset: 0x0
	[Token(Token = "0x4001063")]
	private static UQueryState<VisualElement> SingleElementNameQuery; //Field offset: 0x10
	[Token(Token = "0x4001064")]
	private static UQueryState<VisualElement> SingleElementClassQuery; //Field offset: 0x20
	[Token(Token = "0x4001065")]
	private static UQueryState<VisualElement> SingleElementNameAndClassQuery; //Field offset: 0x30
	[Token(Token = "0x4001066")]
	private static UQueryState<VisualElement> SingleElementTypeQuery; //Field offset: 0x40
	[Token(Token = "0x4001067")]
	private static UQueryState<VisualElement> SingleElementTypeAndNameQuery; //Field offset: 0x50
	[Token(Token = "0x4001068")]
	private static UQueryState<VisualElement> SingleElementTypeAndClassQuery; //Field offset: 0x60
	[Token(Token = "0x4001069")]
	private static UQueryState<VisualElement> SingleElementTypeAndNameAndClassQuery; //Field offset: 0x70

	[Address(RVA = "0x32C0B90", Offset = "0x32BFF90", Length = "0x7B7")]
	[Token(Token = "0x6002506")]
	private static UQueryExtensions() { }

	[Address(RVA = "0x32C0A50", Offset = "0x32BFE50", Length = "0x138")]
	[Extension]
	[Token(Token = "0x6002501")]
	public static VisualElement Q(VisualElement e, string name = null, String[] classes) { }

	[Address(RVA = "0x9A8490", Offset = "0x9A7890", Length = "0x8E1")]
	[Extension]
	[Token(Token = "0x6002502")]
	public static T Q(VisualElement e, string name = null, string className = null) { }

	[Address(RVA = "0x32C0590", Offset = "0x32BF990", Length = "0x4BF")]
	[Extension]
	[Token(Token = "0x6002503")]
	public static VisualElement Q(VisualElement e, string name = null, string className = null) { }

	[Address(RVA = "0x9A8EF0", Offset = "0x9A82F0", Length = "0x167")]
	[Extension]
	[Token(Token = "0x6002504")]
	public static UQueryBuilder<T> Query(VisualElement e, string name = null, String[] classes) { }

	[Address(RVA = "0x9A8D80", Offset = "0x9A8180", Length = "0x167")]
	[Extension]
	[Token(Token = "0x6002505")]
	public static UQueryBuilder<T> Query(VisualElement e, string name = null, string className = null) { }

}

