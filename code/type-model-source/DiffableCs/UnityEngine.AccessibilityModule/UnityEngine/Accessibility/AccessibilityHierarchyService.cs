namespace UnityEngine.Accessibility;

[Token(Token = "0x2000012")]
internal static class AccessibilityHierarchyService
{
	[Token(Token = "0x400004E")]
	private static AccessibilityHierarchy s_ActiveHierarchy; //Field offset: 0x0

	[Token(Token = "0x1700001C")]
	internal static AccessibilityHierarchy activeHierarchy
	{
		[Address(RVA = "0x2F82510", Offset = "0x2F81910", Length = "0x36")]
		[Token(Token = "0x6000064")]
		internal get { } //Length: 54
		[Address(RVA = "0x2F82550", Offset = "0x2F81950", Length = "0x124")]
		[Token(Token = "0x6000065")]
		internal set { } //Length: 292
	}

	[Address(RVA = "0x2F82510", Offset = "0x2F81910", Length = "0x36")]
	[Token(Token = "0x6000064")]
	internal static AccessibilityHierarchy get_activeHierarchy() { }

	[Address(RVA = "0x2F82300", Offset = "0x2F81700", Length = "0x46")]
	[Token(Token = "0x6000066")]
	internal static IReadOnlyList<AccessibilityNode> GetRootNodes() { }

	[Address(RVA = "0x2F82550", Offset = "0x2F81950", Length = "0x124")]
	[Token(Token = "0x6000065")]
	internal static void set_activeHierarchy(AccessibilityHierarchy value) { }

	[Address(RVA = "0x2F823F0", Offset = "0x2F817F0", Length = "0x115")]
	[Token(Token = "0x6000067")]
	internal static bool TryGetNode(int id, out AccessibilityNode node) { }

	[Address(RVA = "0x2F82350", Offset = "0x2F81750", Length = "0xA0")]
	[Token(Token = "0x6000068")]
	internal static bool TryGetNodeAt(float x, float y, out AccessibilityNode node) { }

}

