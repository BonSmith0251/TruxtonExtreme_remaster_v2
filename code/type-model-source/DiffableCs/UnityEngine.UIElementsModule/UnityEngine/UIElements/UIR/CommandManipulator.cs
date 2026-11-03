namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200057C")]
internal static class CommandManipulator
{

	[Address(RVA = "0x32D8C10", Offset = "0x32D8010", Length = "0xBD1")]
	[Token(Token = "0x60027EB")]
	public static void DisableElementRendering(RenderTreeManager renderTreeManager, VisualElement ve, bool renderingDisabled) { }

	[Address(RVA = "0x32D97F0", Offset = "0x32D8BF0", Length = "0x12A")]
	[Token(Token = "0x60027E6")]
	private static void FindHeadCommandInsertionPoint(RenderData renderData, out RenderChainCommand prev, out RenderChainCommand next) { }

	[Address(RVA = "0x32D9920", Offset = "0x32D8D20", Length = "0x75")]
	[Token(Token = "0x60027E5")]
	private static RenderChainCommand FindPrevCommand(RenderData candidate, bool searchFromHead) { }

	[Address(RVA = "0x32D99A0", Offset = "0x32D8DA0", Length = "0x10A")]
	[Token(Token = "0x60027E7")]
	private static void FindTailCommandInsertionPoint(RenderData renderData, out RenderChainCommand prev, out RenderChainCommand next) { }

	[Address(RVA = "0x32D9AB0", Offset = "0x32D8EB0", Length = "0x151")]
	[Token(Token = "0x60027EA")]
	private static void InjectCommandInBetween(RenderChainCommand cmd, bool isHeadCommand, RenderChainCommand prev, RenderChainCommand next) { }

	[Address(RVA = "0x32D9C10", Offset = "0x32D9010", Length = "0x118")]
	[Token(Token = "0x60027E8")]
	private static void RemoveChain(RenderTree renderTree, RenderChainCommand first, RenderChainCommand last) { }

	[Address(RVA = "0x32D9D30", Offset = "0x32D9130", Length = "0x3F8")]
	[Token(Token = "0x60027EC")]
	private static void RemoveSingleCommand(RenderTreeManager renderTreeManager, RenderData renderData, RenderChainCommand cmd) { }

	[Address(RVA = "0x32DA130", Offset = "0x32D9530", Length = "0x289")]
	[Token(Token = "0x60027E3")]
	public static void ReplaceHeadCommands(RenderTreeManager renderTreeManager, RenderData renderData, EntryProcessor processor) { }

	[Address(RVA = "0x32DA3C0", Offset = "0x32D97C0", Length = "0x371")]
	[Token(Token = "0x60027E4")]
	public static void ReplaceTailCommands(RenderTreeManager renderTreeManager, RenderData renderData, EntryProcessor processor) { }

	[Address(RVA = "0x32DA740", Offset = "0x32D9B40", Length = "0x32A")]
	[Token(Token = "0x60027E9")]
	public static void ResetCommands(RenderTreeManager renderTreeManager, RenderData renderData) { }

}

