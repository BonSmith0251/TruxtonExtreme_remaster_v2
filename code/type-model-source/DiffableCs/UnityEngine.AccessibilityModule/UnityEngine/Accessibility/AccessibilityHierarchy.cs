namespace UnityEngine.Accessibility;

[Token(Token = "0x2000011")]
public class AccessibilityHierarchy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004C")]
	private readonly IDictionary<Int32, AccessibilityNode> m_Nodes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004D")]
	private List<AccessibilityNode> m_RootNodes; //Field offset: 0x18

	[Token(Token = "0x1700001B")]
	public IReadOnlyList<AccessibilityNode> rootNodes
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600005D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2F82D60", Offset = "0x2F82160", Length = "0x12E")]
	[CompilerGenerated]
	[Token(Token = "0x6000063")]
	internal static AccessibilityNode <TryGetNodeAt>g__FindNodeContainingPoint|16_0(IList<AccessibilityNode> nodes, Vector2 pos) { }

	[Address(RVA = "0x2F82680", Offset = "0x2F81A80", Length = "0x10B")]
	[Token(Token = "0x6000061")]
	internal void AllocateNative() { }

	[Address(RVA = "0x2F82790", Offset = "0x2F81B90", Length = "0x10E")]
	[Token(Token = "0x6000062")]
	internal void FreeNative() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600005D")]
	public IReadOnlyList<AccessibilityNode> get_rootNodes() { }

	[Address(RVA = "0x2F828A0", Offset = "0x2F81CA0", Length = "0x3A4")]
	[Token(Token = "0x6000060")]
	public void RefreshNodeFrames() { }

	[Address(RVA = "0x2F82C90", Offset = "0x2F82090", Length = "0xCA")]
	[Token(Token = "0x600005E")]
	public bool TryGetNode(int id, out AccessibilityNode node) { }

	[Address(RVA = "0x2F82C50", Offset = "0x2F82050", Length = "0x38")]
	[Token(Token = "0x600005F")]
	public bool TryGetNodeAt(float horizontalPosition, float verticalPosition, out AccessibilityNode node) { }

}

