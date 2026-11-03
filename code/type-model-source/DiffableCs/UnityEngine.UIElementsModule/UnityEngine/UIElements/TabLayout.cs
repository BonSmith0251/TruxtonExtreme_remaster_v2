namespace UnityEngine.UIElements;

[Token(Token = "0x2000158")]
internal class TabLayout
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006D0")]
	private TabView m_TabView; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006D1")]
	private List<VisualElement> m_TabHeaders; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006D2")]
	private bool m_IsVertical; //Field offset: 0x20

	[Address(RVA = "0x33B6870", Offset = "0x33B5C70", Length = "0x62")]
	[Token(Token = "0x6000A69")]
	public TabLayout(TabView tabView, bool isVertical) { }

	[Address(RVA = "0x33B64B0", Offset = "0x33B58B0", Length = "0x6E")]
	[Token(Token = "0x6000A6A")]
	public static float GetHeight(VisualElement t) { }

	[Address(RVA = "0x33B6520", Offset = "0x33B5920", Length = "0x1A7")]
	[Token(Token = "0x6000A6C")]
	public float GetTabOffset(VisualElement tab) { }

	[Address(RVA = "0x33B66D0", Offset = "0x33B5AD0", Length = "0x6E")]
	[Token(Token = "0x6000A6B")]
	public static float GetWidth(VisualElement t) { }

	[Address(RVA = "0x33B6740", Offset = "0x33B5B40", Length = "0x76")]
	[Token(Token = "0x6000A6D")]
	private void InitOrderTabs() { }

	[Address(RVA = "0x33B67C0", Offset = "0x33B5BC0", Length = "0xA8")]
	[Token(Token = "0x6000A6E")]
	public void ReorderDisplay(int from, int to) { }

}

