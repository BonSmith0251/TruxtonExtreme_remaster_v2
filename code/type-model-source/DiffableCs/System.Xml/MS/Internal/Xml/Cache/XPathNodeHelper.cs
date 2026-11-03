namespace MS.Internal.Xml.Cache;

[Token(Token = "0x2000286")]
internal abstract class XPathNodeHelper
{

	[Address(RVA = "0x24DA320", Offset = "0x24D9720", Length = "0x13A")]
	[Token(Token = "0x6001A03")]
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	[Address(RVA = "0x24DA460", Offset = "0x24D9860", Length = "0x82")]
	[Token(Token = "0x6001A02")]
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	[Address(RVA = "0x24DA4F0", Offset = "0x24D98F0", Length = "0x39")]
	[Token(Token = "0x6001A05")]
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	[Address(RVA = "0x24DA530", Offset = "0x24D9930", Length = "0xF6")]
	[Token(Token = "0x6001A07")]
	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }

	[Address(RVA = "0x24DA630", Offset = "0x24D9A30", Length = "0x9A")]
	[Token(Token = "0x6001A04")]
	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	[Address(RVA = "0x24DA6D0", Offset = "0x24D9AD0", Length = "0x1F2")]
	[Token(Token = "0x6001A06")]
	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

}

